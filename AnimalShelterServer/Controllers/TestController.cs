
using Microsoft.AspNetCore.Mvc;
using AnimalShelterServer.Models;

namespace AnimalShelterServer.Controllers
{
    public class TestController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult TestPage()
        {
            return View();
        }
    }
}