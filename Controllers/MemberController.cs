using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;
public class MemberController : Controller
{
    public IActionResult Index(){
        return View();
    }
}