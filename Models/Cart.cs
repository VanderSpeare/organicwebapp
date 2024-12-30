using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;
[Table("Cart")]
public class Cart
{
    public  int CartId { get; set; }
    public  int ProductId { get; set; }
    public Product? Product { get; set; }
    public  string  MemberId { get; set; } = null!;
    public short Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}