using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ContactController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReportOffer()
        {
            return View();
        }
    }
}
