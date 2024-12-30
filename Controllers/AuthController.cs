using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers;
public class AuthController : Controller
{
    private readonly OrganicContext context;
    private readonly EmailVerificationService emailVerificationService;

    public AuthController(OrganicContext context, EmailVerificationService emailVerificationService)
    {
        this.context = context;
        this.emailVerificationService = emailVerificationService;
    }
    [Authorize]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return Redirect("/auth/login");
    }
    public IActionResult Index()
    {
        ViewBag.Departments = context.Departments.ToList();
        return View();
    }
    public IActionResult Register()
    {
        ViewBag.Departments = context.Departments.ToList();
        return View();
    }
    [HttpPost]
    public IActionResult Register(Member obj)
    {
        ModelState.Remove(nameof(obj.MemberId));

        if (ModelState.IsValid)
        {
            obj.RoleId = 234102922;//member
            obj.MemberId = Guid.NewGuid().ToString().Replace("-", string.Empty);

            obj.Password = obj.Password.HashSha256();

            context.Members.Add(obj);
            int ret = context.SaveChanges();
            if (ret > 0)
            {
                return Redirect("/auth/login");
            }
            ModelState.AddModelError("Error", "Register Failed");
        }
        ViewBag.Departments = context.Departments.ToList();
        return View(obj);
    }
    public IActionResult Login()
    {
        ViewBag.Departments = context.Departments.ToList();
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginModel obj)
    {
        Member? member = context.Members.FirstOrDefault(p => p.Email == obj.Eml && p.Password == obj.Pwd.HashSha256());
        if (member is null)
        {
            ModelState.AddModelError("Error", "Login Failed");
            return View(obj);
        }
        List<Claim> claims = new List<Claim>{
            new Claim(ClaimTypes.NameIdentifier, member.MemberId),
            new Claim(ClaimTypes.Name, member.Name),
            new Claim(ClaimTypes.GivenName, member.GivenName),
            new Claim(ClaimTypes.Surname, member.Surname),
            new Claim(ClaimTypes.Email, member.Email),
        };
        ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        ClaimsPrincipal principal = new ClaimsPrincipal(identity);
        await HttpContext.SignInAsync(principal, new AuthenticationProperties
        {
            IsPersistent = obj.Rem
        });
        return Redirect("/auth");
    }
    // public IActionResult Logout(){
    //     return View();
    // }

    public IActionResult ChangePassword()
    {
        return View();
    }
    public IActionResult ForgotPassword()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ForgotPassword(string email)
    {
        var member = context.Members.FirstOrDefault(m => m.Email == email);
        if (member == null)
        {
            ModelState.AddModelError("Error", "Email không tồn tại.");
            return View();
        }

        // Tạo mã OTP ngẫu nhiên
        Random random = new Random();
        string otp = random.Next(100000, 999999).ToString(); // Sinh mã OTP 6 chữ số
        member.PasswordResetToken = otp; // Lưu mã OTP vào cơ sở dữ liệu
        member.ResetTokenExpiry = DateTime.UtcNow.AddMinutes(10); // Hết hạn sau 10 phút
        context.SaveChanges();

        // Gửi mã OTP qua email
        await emailVerificationService.SendOtpEmailAsync(email, otp);

        TempData["Message"] = "Mã OTP đã được gửi đến email của bạn.";
        return RedirectToAction("VerifyOtp", new { email });
    }
    public IActionResult VerifyOtp(string email)
    {
        ViewBag.Email = email; // Chuyển email đến view để người dùng nhập OTP
        return View();
    }
    [HttpPost]
    public IActionResult VerifyOtp(string email, string otp)
    {
        var member = context.Members.FirstOrDefault(m => m.Email == email);
        if (member == null || member.PasswordResetToken != otp || member.ResetTokenExpiry < DateTime.UtcNow)
        {
            ModelState.AddModelError("Error", "Mã OTP không hợp lệ hoặc đã hết hạn.");
            return View();
        }

        // Nếu mã OTP hợp lệ, bạn có thể yêu cầu người dùng đặt lại mật khẩu ở đây
        return RedirectToAction("ChangePassword", new { email });
    }
    public IActionResult ResetPassword(string token)
    {
        // Kiểm tra token có hợp lệ không
        var member = context.Members.FirstOrDefault(m => m.PasswordResetToken == token && m.ResetTokenExpiry > DateTime.Now);
        if (member == null)
        {
            TempData["Message"] = "Liên kết đặt lại mật khẩu không hợp lệ hoặc đã hết hạn.";
            return RedirectToAction("Login");
        }
        return View(new ResetPasswordViewModel { Token = token });
    }
    [HttpPost]
    public IActionResult ResetPassword(ResetPasswordViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var member = context.Members.FirstOrDefault(m => m.PasswordResetToken == model.Token && m.ResetTokenExpiry > DateTime.Now);
        if (member == null)
        {
            TempData["Message"] = "Liên kết đặt lại mật khẩu không hợp lệ hoặc đã hết hạn.";
            return RedirectToAction("ForgotPassword");
        }

        // Cập nhật mật khẩu mới
        member.Password = model.NewPassword.HashSha256();
        member.PasswordResetToken = null; // Xóa token sau khi đặt lại mật khẩu
        member.ResetTokenExpiry = null;
        context.SaveChanges();

        TempData["Message"] = "Mật khẩu đã được đặt lại thành công. Vui lòng đăng nhập bằng mật khẩu mới.";
        return RedirectToAction("Login");
    }
    [HttpPost]
    public IActionResult ChangePassword(string username, string oldPassword, string newPassword)
    {
        var member = context.Members.FirstOrDefault(m => m.Name == username);
        if (member == null || member.Password != oldPassword.HashSha256())
        {
            ModelState.AddModelError("Error", "Invalid username or password.");
            return View();
        }

        member.Password = newPassword.HashSha256();
        context.SaveChanges();

        TempData["Message"] = "Password changed successfully.";
        return Redirect("/auth/login");
    }
    public IActionResult ManageMembers()
    {
        var members = context.Members.ToList();
        return View(members);
    }

    // Hiển thị form thêm thành viên
    public IActionResult CreateMember()
    {
        return View();
    }

    // Thêm thành viên mới
    [HttpPost]
    public IActionResult CreateMember(Member member)
    {
        if (ModelState.IsValid)
        {
            member.MemberId = Guid.NewGuid().ToString().Replace("-", string.Empty);
            member.Password = member.Password.HashSha256();
            context.Members.Add(member);
            context.SaveChanges();
            return RedirectToAction("ManageMembers");
        }
        return View(member);
    }

    // Hiển thị form sửa thông tin thành viên
    public IActionResult EditMember(string id)
    {
        var member = context.Members.FirstOrDefault(m => m.MemberId == id);
        if (member == null) return NotFound();
        return View(member);
    }

    // Cập nhật thông tin thành viên
    [HttpPost]
    public IActionResult EditMember(Member member)
    {
        if (ModelState.IsValid)
        {
            context.Members.Update(member);
            context.SaveChanges();
            return RedirectToAction("ManageMembers");
        }
        return View(member);
    }

    // Xóa thành viên
    public IActionResult DeleteMember(string id)
    {
        var member = context.Members.FirstOrDefault(m => m.MemberId == id);
        if (member == null) return NotFound();

        context.Members.Remove(member);
        context.SaveChanges();
        return RedirectToAction("ManageMembers");
    }
}