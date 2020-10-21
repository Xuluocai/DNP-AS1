using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment.Models
{
    public class Add:PageModel
    {
        private readonly Models.PersonContext _context;

        public Add(Models.PersonContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Person = new Person
            {
                FirstName = "A",
                LastName = "B",
                HairColor = "Black",
                EyeColor = "Blue",
                Height = 190,
                Weight = 70,
                Age=22,
                Sex="Male"


            
            };
            return Page();
        }

        [BindProperty]
        public Person Person{ get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Person.Add(Person);
            await _context.SaveChangesAsync();

            return RedirectToPage("./View");
        }
    }
}

