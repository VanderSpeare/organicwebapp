using System.Net;
using Microsoft.Extensions.Options;
using WebApp.Models;

namespace WebApp.Services;
public class VnPaymentService
{
    VnPaymentRequest request;
    public VnPaymentService(IOptions<VnPaymentRequest> options){
        request = options.Value;
    }
    public string ToUrl(Invoice obj, HttpContext context){
        var dict = new Dictionary<string, string>{
            {"vnp_Amount", (obj.Amount * 100).ToString("#.")},
            {"vnp_Command", request.Command},
            {"vnp_CreateDate", obj.InvoiceDate.ToString("yyyyMMddHHmmss")},
            {"vnp_CurrCode", request.CurrCode},
            //{"vnp_IpAddr", "127.0.0.1"},
            {"vnp_IpAddr", context.Connection.RemoteIpAddress!.ToString()},
            {"vnp_Locale", request.Locale},
            {"vnp_OrderInfo", $"Payment for {obj.InvoiceId} with amount {obj.Amount.ToString()}"},
            {"vnp_OrderType", request.OrderType},
            {"vnp_ReturnUrl", request.ReturnUrl},
            {"vnp_TmnCode", request.TmnCode},
            {"vnp_TxnRef", obj.InvoiceId.ToString()},
            {"vnp_Version", request.Version}
        };
        
        var query = string.Join("&", dict.Select(p => $"{p.Key}={WebUtility.UrlEncode(p.Value)}"));
        var hash = query.HashHmacSha512(request.HashSecret);
        return $"{request.BaseUrl}?{query}&vnp_SecureHash={hash}";
    }
}