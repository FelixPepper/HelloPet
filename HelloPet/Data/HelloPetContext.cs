using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelloPet.Models
{
    public class HelloPetContext : DbContext
    {
        public HelloPetContext (DbContextOptions<HelloPetContext> options)
            : base(options)
        {
        }

        public DbSet<HelloPet.Models.Pet> Pet { get; set; }
    }
}
