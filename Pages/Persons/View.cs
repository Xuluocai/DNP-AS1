using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Models
{
    public class View:PageModel
    {
        private readonly Models.PersonContext _context;

        public View(Models.PersonContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get; set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }

    }
}
