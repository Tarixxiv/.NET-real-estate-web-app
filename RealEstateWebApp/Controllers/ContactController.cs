using Microsoft.AspNetCore.Mvc;
using RealEstateWebApp.Models;
using RealEstateWebApp.Services;

namespace RealEstateWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;

        public ContactController(ILogger<HomeController> logger, IEmailService emailService, IConfiguration configuration)
        {
            _logger = logger;
            _emailService = emailService;
            _configuration = configuration;
        }
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(ClientMessage msg)
        {
            
            if (!ModelState.IsValid) return View();
            
     
            var mergedMessage = $"{msg.Name}\n{msg.Email}\n{msg.TelNum}\n{msg.Content}";
            _emailService.SendEmail(_configuration["EmailDestination"] ?? throw new InvalidOperationException("No email Destination declared")
                ,msg.Subject
                ,mergedMessage);
            return RedirectToAction("SendMessage");
        }

        public IActionResult ReportOffer()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult ReportOffer(ReportedOffer msg)
        {
            if (!ModelState.IsValid) return View();
            
            var mergedMessage = $"{msg.Name}\n" +
                                $"{msg.Email}\n" +
                                $"{msg.TelNum}\n" +
                                $"{msg.TransactionType} {msg.EstateType} w lokalizacji {msg.Localisation}\n" +
                                $"powierzchnia: {msg.Area}\n" +
                                $"cena: {msg.Price}\n" +
                                $"{msg.Description}";
            _emailService.SendEmail(_configuration["EmailDestination"] ?? throw new InvalidOperationException("No email Destination declared")
                ,$"Zgłoszenie oferty {msg.TransactionType} {msg.EstateType} w lokalizacji {msg.Localisation}"
                ,mergedMessage);
            return RedirectToAction("SendMessage");
        }
    }
}
