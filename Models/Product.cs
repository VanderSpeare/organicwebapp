using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

[Table("Product")]
public class Product
{
    public int ProductId { get; set; }
    public short CategoryId { get; set; }
    public Category? Category { get; set; }
    public string ProductName { get; set; } = null!;
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = null!;
    public string Explain { get; set; } = null!;
    public string Availability { get; set; } = null!;
    public string Shipping { get; set; } = null!;
    public decimal Weight { get; set; }
    public string Unit { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Information { get; set; } = null!;
    public string Reviews { get; set; } = null!;

}