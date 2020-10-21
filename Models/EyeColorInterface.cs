using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    interface EyeColorInterface
    {
        public String SelectEyeColor(int index);
        public String RandomColor();
        public String[] getEyeColor();
    }
}
