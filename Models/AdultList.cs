using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class AdultList
    {
        public List<Adult> Adults;
        public List<String> Lastnames;
        public List<String> Firstnames;
        public List<String> HairColors;
        public List<String> EyeColors;
        public List<int> Ids;
        public List<String> Jobs;


        public AdultList()
        {
            Adults = new List<Adult>();
            Firstnames = new List<string>();
            Lastnames = new List<string>();
            HairColors = new List<string>();
            EyeColors = new List<string>();
            Jobs = new List<string>();
            Ids = new List<int>();

        }
        public void AddAdult(Adult adult)
        {
            int i = Adults.Count + 1;
            adult.Id = i;
            Adults.Add(adult);
            Firstnames.Add(adult.FirstName);
            Lastnames.Add(adult.LastName);
            HairColors.Add(adult.HairColor);
            EyeColors.Add(adult.EyeColor);
            Ids.Add(adult.Id);
            Jobs.Add(adult.Job);
        }

        public String getLastName(int index)
        {
            return Adults[index].LastName;
        }
        public String getFirsttName(int index)
        {
            return Adults[index].FirstName;
        }
        public int getHeight(int index)
        {
            return Adults[index].Height;
        }
        public String getHairColor(int index)
        {
            return Adults[index].HairColor;
        }
        public String getEyeColor(int index)
        {
            return Adults[index].EyeColor;
        }
        public int getId(int index)
        {
            return Adults[index].Id;
        }
        public int getAge(int index)
        {
            return Adults[index].Age;
        }
        public float getweight(int index)
        {
            return Adults[index].Weight;
        }
        public Adult getAdult(int index)
        {
            return Adults[index];
        }

        public List<Adult> getAdultListByName(String name)
        {
            List<Adult> lista = new List<Adult>();

            for (int i = 0; i < Adults.Count; i++)
            {
                if (name.Equals(Adults[i].LastName)){
                    lista.Add(Adults[i]);
                }
                
            }
            return lista;
        }
        public List<Adult> getList()
        {
            return Adults;
        }

        
    }
}

