using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

[Table("Invoice")]
public class Invoice
{
    
    public int InvoiceId { get; set; }
    public string MemberId { get; set; } = null!;
    public DateTime InvoiceDate { get; set; }
    public string GivenName { get; set; } = null!;
    public string? Surname { get; set; }
    public string Phone { get; set; } = null!;
    public string Address { get; set; } = null!;
    [NotMapped]
    public decimal Amount { get; set; }
    public List<InvoiceDetail>? InvoiceDetails { get; set; }
}