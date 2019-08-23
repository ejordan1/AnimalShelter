
using Microsoft.AspNetCore.Mvc;
using AnimalShelterServer.Models;

namespace AnimalShelterServer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}