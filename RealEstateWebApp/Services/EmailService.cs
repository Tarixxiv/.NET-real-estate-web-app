using System.Net;
using System.Net.Mail;

namespace RealEstateWebApp.Services;

public class EmailService(IConfiguration _configuration) : IEmailService
{


    public Task SendEmail(string email, string subject, string message)
    {
        var mail = _configuration["EmailCredentials:mail"];
        var pw = _configuration["EmailCredentials:pw"];;

        var client = new SmtpClient("smtp.office365.com", 587)
        {
            EnableSsl = true,
            Credentials = new NetworkCredential(mail, pw)
        };
        
        return client.SendMailAsync(new MailMessage(from: mail,
            to: email,
            subject,
            message));
    }
}