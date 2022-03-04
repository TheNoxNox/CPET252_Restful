using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HallamNathan_Lab04
{
    class Connection
    {
        public string GetConnection()
        {
            string url = "http://64.72.2.110/rest";

            return url;
        }

        #region Employees
        public List<Employee> GetEmployees()
        {
            string url = GetConnection() + "/employees";

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

                            return Employees;
                        }
                }

                return null;
            }
        }

        public Employee GetEmployee(string id)
        {
            string url = GetConnection() + "/employees/" + id;

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

                            List<Employee> Employee = JsonConvert.DeserializeObject<List<Employee>>(json);

                            return Employee[0];
                        }
                }

                return null;
            }
        }

        public bool PostEmployee(Employee employee)
        {
            string url = GetConnection() + "/employees";

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

        public bool DeleteEmployee(Employee employee)
        {
            string url = GetConnection() + "/employees";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); //  url);
            request.Method = "DELETE";
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
        #endregion Employees

        #region Jobs
        public List<Job> GetJobs()
        {
            string url = GetConnection() + "/jobs";

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

                        return Jobs;
                    }
                }

                return null;
            }
        }

        public Job GetJob(int id)
        {
            string url = GetConnection() + "/jobs/" + id;

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

                            List<Job> Job = JsonConvert.DeserializeObject<List<Job>>(json);

                            return Job[0];
                        }
                }

                return null;
            }
        }
        #endregion Jobs

        #region Publisher
        public List<Publisher> GetPublishers()
        {
            string url = GetConnection() + "/pubs";

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

                            return Publishers;
                        }
                }

                return null;
            }
        }

        public Publisher GetPublisher(string id)
        {
            string url = GetConnection() + "/pubs/" + id;

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

                            return Publisher[0];
                        }
                }

                return null;
            }
        }
        #endregion Publisher
    }
}
