using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HallamNathan_Lab04.Model;
using static HallamNathan_Lab04.ViewModels;

namespace HallamNathan_Lab04
{
    class Service
    {
        public static string ConnectionURI;


        public Service(string connection)
        {
            ConnectionURI = connection;
        }



        #region Employees
        public List<EmployeeViewModel> GetEmployees()
        {
            string url = ConnectionURI + "/employees";

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

                            List<Employee> Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
                            List<EmployeeViewModel> EmpModels = new List<EmployeeViewModel>();

                            foreach(Employee emp in Employees)
                            {
                                EmployeeViewModel EmployeeModel = (emp.minit.HasValue == true) 
                                    ? new EmployeeViewModel(emp.emp_id, emp.fname, emp.minit.Value, emp.lname, GetJob(emp.job_id), GetPublisher(emp.pub_id), emp.hire_date) 
                                    : new EmployeeViewModel(emp.emp_id, emp.fname, null, emp.lname, GetJob(emp.job_id), GetPublisher(emp.pub_id), emp.hire_date);
                                EmpModels.Add(EmployeeModel);
                            }

                            return EmpModels;
                        }
                }

                return null;
            }
        }

        public EmployeeViewModel GetEmployee(string id)
        {
            string url = ConnectionURI + "/employees/" + id;

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

                            List<Employee> emp = JsonConvert.DeserializeObject<List<Employee>>(json);

                            if (emp.Count == 0) return null;

                            EmployeeViewModel Employee = (emp[0].minit.HasValue == true)
                                    ? new EmployeeViewModel(emp[0].emp_id, emp[0].fname, emp[0].minit.Value, emp[0].lname, GetJob(emp[0].job_id), GetPublisher(emp[0].pub_id), emp[0].hire_date)
                                    : new EmployeeViewModel(emp[0].emp_id, emp[0].fname, null, emp[0].lname, GetJob(emp[0].job_id), GetPublisher(emp[0].pub_id), emp[0].hire_date);

                            return Employee;
                        }
                }

                return null;
            }
        }

        public bool PostEmployee(Employee employee)
        {
            string url = ConnectionURI + "/employees";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); //  url);
            request.Method = "POST";
            request.ContentType = "application/json";

            string json = JsonConvert.SerializeObject(employee);

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            MessageBox.Show(response.StatusCode.ToString());

            if (response.StatusCode == HttpStatusCode.OK) return true;

            return false;
        }

        public bool DeleteEmployee(string id)
        {
            string url = ConnectionURI + "/employees/" + id;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); //  url);
            request.Method = "DELETE";
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            MessageBox.Show(response.StatusCode.ToString());

            if (response.StatusCode == HttpStatusCode.OK) return true;

            return false;
        }
        #endregion Employees

        #region Jobs
        public List<JobViewModel> GetJobs()
        {
            string url = ConnectionURI + "/jobs";

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
                            List<JobViewModel> JobModels = new List<JobViewModel>();

                            foreach (Job job in Jobs)
                            {
                                JobViewModel JobModel = new JobViewModel(job.job_id, job.job_desc, job.min_lvl, job.max_lvl);
                                JobModels.Add(JobModel);
                            }

                            return JobModels;
                        }
                }

                return null;
            }
        }

        public JobViewModel GetJob(int id)
        {
            string url = ConnectionURI + "/jobs/" + id;

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

                            List<Job> job = JsonConvert.DeserializeObject<List<Job>>(json);

                            if (job.Count == 0) return null;

                            JobViewModel JobModel = new JobViewModel(job[0].job_id, job[0].job_desc, job[0].min_lvl, job[0].max_lvl);

                            return JobModel;
                        }
                }

                return null;
            }
        }
        #endregion Jobs

        #region Publisher
        public List<PublisherViewModel> GetPublishers()
        {
            string url = ConnectionURI + "/pubs";

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

                            List<Publisher> Publishers = JsonConvert.DeserializeObject<List<Publisher>>(json);
                            List<PublisherViewModel> PubModels = new List<PublisherViewModel>();

                            foreach (Publisher pub in Publishers)
                            {
                                PublisherViewModel PubModel = new PublisherViewModel(pub.id, pub.name);
                                PubModels.Add(PubModel);
                            }

                            return PubModels;
                        }
                }

                return null;
            }
        }

        public PublisherViewModel GetPublisher(string id)
        {
            string url = ConnectionURI + "/pubs/" + id;

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

                            List<Publisher> Publisher = JsonConvert.DeserializeObject<List<Publisher>>(json);

                            if (Publisher.Count == 0) return null;

                            PublisherViewModel PubModel = new PublisherViewModel(Publisher[0].id, Publisher[0].name);

                            return PubModel;
                        }
                }

                return null;
            }
        }
        #endregion Publisher
    }
}
