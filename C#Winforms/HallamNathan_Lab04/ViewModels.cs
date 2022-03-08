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
            public EmployeeViewModel() { }

            public EmployeeViewModel(string emp_id, string fname, char? minit, string lname, JobViewModel job, PublisherViewModel publisher, string hire_date)
            {
                ID = emp_id;
                FirstName = fname;
                MiddleInitial = (minit.HasValue == true) ? minit.Value : null;
                LastName = lname;
                Job = job;
                Publisher = publisher;
                DateOfHire = hire_date;
            }

            public string ID;
            public string FirstName;
            public char? MiddleInitial;
            public string LastName;
            public JobViewModel Job;
            public PublisherViewModel Publisher;
            public string DateOfHire;
        }

        public class PublisherViewModel
        {
            public PublisherViewModel() { }

            public PublisherViewModel(string ID, string Name)
            {
                id = ID;
                name = Name;
            }

            public PublisherViewModel(string ID)
            {
                id = ID;

                //            Publisher temp = new Connection().GetPublisher(id);

                //            name = temp.name;
            }

            public string id;
            public string name;
        }

        public class JobViewModel
        {
            public JobViewModel() { }

            public JobViewModel(int ID, string desc, int minlvl, int maxlvl)
            {
                job_id = ID;
                job_desc = desc;
                min_lvl = minlvl;
                max_lvl = maxlvl;
            }

            public JobViewModel(int ID)
            {
//                job_id = ID;

//                JobViewModel temp;

 //               job_desc = temp.job_desc;
 //               min_lvl = temp.min_lvl;
 //               max_lvl = temp.max_lvl;
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
