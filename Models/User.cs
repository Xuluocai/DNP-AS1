using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class User
    {
      
        public String name { get; set; }
       
   
        public String password { get; set; }
        public String CPassword { get; set; }
        public int ID { get; set; }

        public User(String name,String password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
