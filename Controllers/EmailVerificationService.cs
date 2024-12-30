using MailKit.Net.Smtp;
using MimeKit;

namespace WebApp.Services
{
    public class EmailVerificationService
    {
        private readonly string smtpServer = "smtp.gmail.com";
        private readonly int port = 587;
        private readonly string email = "kkle47203@gmail.com"; // Thay đổi
        private readonly string password = "xzfz rftu iaul fxsm"; // Thay đổi

        public async Task SendOtpEmailAsync(string recipientEmail, string otp)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Your Name", email)); // Đảm bảo có tên hiển thị và địa chỉ email
            message.To.Add(new MailboxAddress("recipientEmail", recipientEmail)); // Sửa lại dòng này
            message.Subject = "OTP xác thực";

            var bodyBuilder = new BodyBuilder
            {
                TextBody = $"Mã OTP của bạn là: {otp}. Vui lòng không chia sẻ mã này với ai khác."
            };
            message.Body = bodyBuilder.ToMessageBody();
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(smtpServer, port, MailKit.Security.SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(email, password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }

        public async Task<bool> TestSmtpConnectionAsync()
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(smtpServer, port, MailKit.Security.SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(email, password);
                    await client.DisconnectAsync(true);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
