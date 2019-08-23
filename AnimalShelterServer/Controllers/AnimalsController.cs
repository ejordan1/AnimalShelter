using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterServer.Models;



namespace AnimalShelterServer.Controllers
{

    // [ApiController]
    //make it ControllerBase again
    public class AnimalsController : Controller
    {

        private readonly AnimalShelterServerContext _db;

        public AnimalsController(AnimalShelterServerContext db)
        {
            _db = db;
        }


        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            return _db.Animals.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}