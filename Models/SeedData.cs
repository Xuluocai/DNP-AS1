using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Assignment.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context=new PersonContext(serviceProvider.GetRequiredService<DbContextOptions<PersonContext>>()))
            {
                if (context.Person.Any())
                {
                    return;
                }

                context.Person.AddRange(
                    new Person
                    {
                        Id = 1,
                        LastName = "Yujie",
                        FirstName = "Chan",
                        Age = 22,
                        Sex = "Male",
                        EyeColor="black",
                        HairColor="black",
                        Height=192,
                        Weight=71

                    });
                context.SaveChanges();

            }
        }
    }
}
