using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class HairColor : HairColorInterface
    {
        String[] Haircolorf = new string[9];
            public HairColor()
        {
            String[] HairColor = { "Blond", "Red", "Brown", "Black", "White", "Grey", "Blue", "Green", "Leverpostej" };
            this.Haircolorf = HairColor;
        }
        public string[] getHairColor()
        {
            return Haircolorf;
        }

        public string RandomHairColor()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, 9);
            Console.WriteLine("Number is"+index);
            Console.WriteLine("Color is" + Haircolorf[index]);
            return Haircolorf[index];
        }

        public string SelectHairColor(int i)
        {
            return Haircolorf[i];
        }
    }
}
