using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ResetPasswordViewModel
    {
        public string Token { get; set; } = null!;

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu mới.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; } = null!;

        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu mới.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Mật khẩu xác nhận không khớp.")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
