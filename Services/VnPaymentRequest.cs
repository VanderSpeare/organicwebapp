namespace WebApp.Services;
public class VnPaymentRequest
{
    public string Version { get; set; } = null!;
    public string Command { get; set; } = null!;
    public string TmnCode { get; set; } = null!;
    public string HashSecret { get; set; } = null!;
    public string CurrCode { get; set; } = null!;
    public string Locale { get; set; } = null!;
    public string OrderType { get; set; } = null!;
    public string ReturnUrl { get; set; } = null!;
    public decimal Amount { get; set; }
    public DateTime CreateDate { get; set; }
    public string IpAddr { get; set; } = null!;
    public string OrderInfo { get; set; } = null!;
    public string TxnRef { get; set; } = null!;
    public string SecureHash { get; set; } = null!;
    public string BaseUrl { get; set; } = null!;
}