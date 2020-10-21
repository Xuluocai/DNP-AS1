using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;


namespace Assignment.Models
{

    public class Adult : Person
    {
        private Job Jobpool;
        public string Job { get; set; }

        

        public Adult(Person person,string Job)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
            Sex = person.Sex;
            HairColor = person.HairColor;
            EyeColor = person.EyeColor;
            Id = person.Id;
            Height = person.Height;
            Weight = person.Weight;
            this.Job = Job;
        }
        public string getChosenJobTitle(int i)
        {
            Job = Jobpool.selectJob(i);
            return Job;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public void Update(Adult toUpdate)
        {
            Job = toUpdate.Job;
            base.Update(toUpdate);
        }
    }
}