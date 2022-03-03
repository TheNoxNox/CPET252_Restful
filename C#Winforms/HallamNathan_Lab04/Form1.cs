using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace HallamNathan_Lab04
{
    public partial class formMain_Employees : Form
    {
        Connection conn = new Connection();
        string url;

        public formMain_Employees()
        {
            InitializeComponent();

            url = conn.GetConnection();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            lstbx_employees.Items.Add(new Job(10, "Test", 0, 1));

            GetJobs();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void GetJobs()
        {
            string url = conn.GetConnection() + "/jobs";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); //  url);
            request.Method = "GET";
            request.ContentLength = 0;
            request.ContentType = "application/json";

            using (var response = (System.Net.HttpWebResponse)request.GetResponse())
            {
                var json = string.Empty;

                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new ApplicationException(response.StatusCode.ToString());
                }

                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    using (var reader = new System.IO.StreamReader(responseStream))
                    {
                        json = reader.ReadToEnd();

                        List<Job> Jobs = JsonConvert.DeserializeObject<List<Job>>(json);

                        foreach(Job _Job in Jobs)
                        {
                            lstbx_employees.Items.Add(_Job.description);
                        }
                    }
                }
            }
        }
    }

    public class Employee
    {
        public Employee(string ID, string FirstName, string LastName, Publisher Pub = null, Job Work = null)
        {
            id = ID;
            fname = FirstName;
            lname = LastName;
            publisher = Pub;
            job = Work;
        }

        public string id;
        public string fname;
        public string lname;
        public Publisher publisher; // Join by pub_id
        public Job job;             // join by job_id
    }

    public class Publisher
    {
        public string id;
        public string name;
    }

    public class Job
    {
        public Job(int ID, string desc, int minlvl, int maxlvl)
        {
            id = ID;
            description = desc;
            min_level = minlvl;
            max_level = maxlvl;
        }

        public int id { get; set; }
        [JsonProperty("job_desc")]
        public string description { get; set; }

        [JsonProperty("min_lvl")]
        public int min_level { get; set; }

        [JsonProperty("max_lvl")]
        public int max_level { get; set; }
    }

}
