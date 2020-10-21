using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Job
    {
        String[] JobList = new string[12];
        public Job()
        {
            JobList[0] = "hi";
            JobList[1] = "Teacher";
            JobList[2] = "Engineer";
            JobList[3] = "Garbage Collector";
            JobList[4] = "Shepherd";
            JobList[5] = "Pilot";
            JobList[6] = "Police Dffice";
            JobList[7] = "Pirate";
            JobList[8] = "Fireman";
            JobList[9] = "Astronaut";
            JobList[10] = "Capitan";
            JobList[11] = "Solder";
                

        }
        public String selectJob(int i) { return JobList[i]; }

        public String[] getJobList()
        {
            return JobList;
        }
    }
}
