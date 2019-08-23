using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalShelterServer.Models
{
    [Table("animals")]
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string UserName { get; set; }

        public string AnimalText { get; set; }

        public int AnimalNumber { get; set; }

        public string AnimalNote { get; set; }
    }
}