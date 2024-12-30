using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;
[Table("Member")]
public class Member
{
    public string MemberId { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string GivenName { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public int RoleId { get; set; }
    public string? PasswordResetToken { get; set; }
    public DateTime? ResetTokenExpiry { get; set; }
}