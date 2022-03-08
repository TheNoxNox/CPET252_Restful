using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallamNathan_Lab04
{
    class Model
    {
        public class Employee
        {
            public string emp_id { get; set; }
            public string fname { get; set; }
            public char? minit { get; set; }
            public string lname { get; set; }
            public int job_id { get; set; }
            public int job_lvl { get; set; }
            public string pub_id { get; set; }
            public string hire_date { get; set; }
        }

        public class Publisher
        {
            public string pub_id { get; set; }
            public string pub_name { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string country { get; set; }
        }

        public class Job
        {
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
