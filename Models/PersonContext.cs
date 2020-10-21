using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class PersonContext:DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options): base(options) { }

        public DbSet<Assignment.Models.Person> Person { get; set; }
    }
}
