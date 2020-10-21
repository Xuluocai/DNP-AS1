using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class EyeColor : EyeColorInterface
    { String[] eyeColorf;
        public EyeColor() {
            String[] eyeColor = { "Black", "Brown", "Grey", "Green", "Blue", "Amber", "Hazel" };
        this.eyeColorf = eyeColor; }
        public String SelectEyeColor(int index)
        {
            Console.WriteLine("eyecolour selected in class" + eyeColorf[index]);
            return eyeColorf[index];
        }
        public String RandomColor()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, 6);
            Console.WriteLine("rnd in eye Color:" + index);
            Console.WriteLine(eyeColorf[index]);
            return eyeColorf[index];
        }
        public String[] getEyeColor(){
            return eyeColorf;}
    }
}
