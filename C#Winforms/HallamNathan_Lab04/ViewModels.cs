using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallamNathan_Lab04
{
    class ViewModels
    {
        public class EmployeeViewModel
        {
            public EmployeeViewModel(string emp_id, string fname, char? minit, string lname, JobViewModel job, int job_lvl, PublisherViewModel publisher, string hire_date)
            {
                ID = emp_id;
                FirstName = fname;
                MiddleInitial = (minit.HasValue == true) ? minit.Value : null;
                LastName = lname;
                Job = job;
                JobLevel = job_lvl;
                Publisher = publisher;
                DateOfHire = hire_date;
            }

            public string ID;
            public string FirstName;
            public char? MiddleInitial;
            public string LastName;
            public JobViewModel Job;
            public int JobLevel;
            public PublisherViewModel Publisher;
            public string DateOfHire;
        }

        public class PublisherViewModel
        {
            public override string ToString()
            {
                return Name;
            }

            public PublisherViewModel(string id, string name, string city, string state, string country)
            {
                ID = id;
                Name = name;
                City = city;
                State = state;
                Country = country;
            }

            public string ID;
            public string Name;
            public string City;
            public string State;
            public string Country;
        }

        public class JobViewModel
        {
            public override string ToString()
            {
                return job_desc;
            }

            public JobViewModel(int ID, string desc, int minlvl, int maxlvl)
            {
                job_id = ID;
                job_desc = desc;
                min_lvl = minlvl;
                max_lvl = maxlvl;
            }

            public int job_id { get; set; }

            [JsonProperty("job_desc")]
            public string job_desc { get; set; }

            [JsonProperty("min_lvl")]
            public int min_lvl { get; set; }

            [JsonProperty("max_lvl")]
            public int max_lvl { get; set; }
        }
    }
}
