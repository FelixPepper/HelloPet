using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloPet.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string PetName { get; set; }
        public string Color { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
    }
}
