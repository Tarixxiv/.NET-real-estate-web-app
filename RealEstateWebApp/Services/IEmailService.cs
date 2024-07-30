namespace RealEstateWebApp.Services;

public interface IEmailService
{
    Task SendEmail(string email, string subject, string message);
}