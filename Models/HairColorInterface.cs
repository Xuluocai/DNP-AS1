using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    interface HairColorInterface
    {
        public String SelectHairColor(int i);
        public String RandomHairColor();
        public String[] getHairColor();
    }
}
