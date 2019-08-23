using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterServer.Models
{
    public class AnimalShelterServerContext : DbContext
    {
        public AnimalShelterServerContext(DbContextOptions<AnimalShelterServerContext> options)
            : base(options)
        {
        }

        public DbSet<AnimalShelterServer.Models.Animal> Animals { get; set; }
    }
}
