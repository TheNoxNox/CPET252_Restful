using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net;
using System.IO;
using static HallamNathan_Lab04.ViewModels;

namespace HallamNathan_Lab04
{
    public partial class formMain_Employees : Form
    {
        Service service;

        public formMain_Employees()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            service = new Service(Connection.Get());

            lstvu_employees.View = View.Details;
            lstvu_employees.GridLines = true;
            lstvu_employees.MultiSelect = false; // one row at a time
            lstvu_employees.FullRowSelect = true;
            lstvu_employees.Columns.Add("First");
            lstvu_employees.Columns.Add("M");
            lstvu_employees.Columns.Add("Last");

            foreach (EmployeeViewModel _Employee in service.GetEmployees())
            {
                string[] empItems = new string[] { _Employee.FirstName, _Employee.MiddleInitial.ToString(), _Employee.LastName };
                ListViewItem LVI = new ListViewItem(empItems);
                LVI.Tag = _Employee;
                lstvu_employees.Items.Add(LVI);
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
}
