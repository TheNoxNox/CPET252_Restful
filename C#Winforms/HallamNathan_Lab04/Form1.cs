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

        public formMain_Employees()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            foreach (Employee _Employee in conn.GetEmployees())
            {
                _Employee.job = new Job(_Employee.job_id);
                _Employee.publisher = new Publisher(_Employee.pub_id);
                lstbx_employees.Items.Add(_Employee.publisher.id);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Employee
    {
        public Employee()
        {

        }

        public Employee(string ID, string FirstName, char MiddleInitial, string LastName, int JobID, int JobLevel, string PubID, string DateOfHire)
        {
            emp_id = ID;
            fname = FirstName;
            mint = MiddleInitial;
            lname = LastName;
            job_id = JobID;
            job = new Job(job_id);
            job_lvl = JobLevel;
            pub_id = PubID;
            publisher = new Publisher(pub_id);
            hire_date = DateOfHire;
        }

        public string emp_id;
        public string fname;
        public char mint;
        public string lname;
        public int job_id;
        public int job_lvl;
        public string pub_id;
        public string hire_date;
        public Job job;
        public Publisher publisher;
    }

    public class Publisher
    {
        public Publisher()
        {

        }

        public Publisher(string ID, string Name)
        {
            id = ID;
            name = Name;
        }

        public Publisher(string ID)
        {
            id = ID;

//            Publisher temp = new Connection().GetPublisher(id);

//            name = temp.name;
        }

        public string id;
        public string name;
    }

    public class Job
    {
        public Job()
        {

        }

        public Job(int ID, string desc, int minlvl, int maxlvl)
        {
            job_id = ID;
            job_desc = desc;
            min_lvl = minlvl;
            max_lvl = maxlvl;
        }

        public Job(int ID)
        {
            job_id = ID;

            Job temp = new Connection().GetJob(job_id);

            job_desc = temp.job_desc;
            min_lvl = temp.min_lvl;
            max_lvl = temp.max_lvl;
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
