using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace My_Portfolio.Controllers
{
    [AllowAnonymous]
    public class PortfolioController:Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProjectInsights(string projectType)
        {
            ViewBag.ProjectType = projectType;
            return View();
        }



    }
}
