using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net;
using System.IO;
using static HallamNathan_Lab04.ViewModels;
using System.Linq;

namespace HallamNathan_Lab04
{
    public partial class formMain_Employees : Form
    {
        Service service;

        //Used for new ID generation
        private static Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-";

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

            cmbobx_employeeJob.Items.AddRange(service.GetJobs().ToArray());
            cmbobx_employeeJob.SelectedIndex = 0;

            cmbobx_employeePublisher.Items.AddRange(service.GetPublishers().ToArray());
            cmbobx_employeePublisher.SelectedIndex = 0;

            GenerateID();
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstvu_employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvu_employees.SelectedItems.Count <= 0) return;

            ListViewItem item = lstvu_employees.SelectedItems[0];

            EmployeeViewModel employee = (EmployeeViewModel)item.Tag;

            txtbx_employeeFirstName.Text = employee.FirstName;
            txtbx_employeeMiddleInit.Text = employee.MiddleInitial.ToString();
            txtbx_employeeLastName.Text = employee.LastName;

            //https://stackoverflow.com/questions/341175/datetime-parse-and-making-it-work-with-a-specific-format
            dttmpckr_employeeHireDate.Value = DateTime.ParseExact(employee.DateOfHire, "yyyymmdd", null);

            nmrcupdwn_employeeJobLevel.Maximum = employee.Job.max_lvl;
            nmrcupdwn_employeeJobLevel.Minimum = employee.Job.min_lvl;
            nmrcupdwn_employeeJobLevel.Value = employee.JobLevel;

            btn_employeeSave.Tag = employee.ID;

            employeeOnValueChange();
        }

        private void cmbobx_employeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobViewModel job = (JobViewModel)cmbobx_employeeJob.SelectedItem;

            nmrcupdwn_employeeJobLevel.Maximum = job.max_lvl;
            nmrcupdwn_employeeJobLevel.Minimum = job.min_lvl;
            nmrcupdwn_employeeJobLevel.Value = job.min_lvl;
        }

        private void btn_employeeJobLevelMin_Click(object sender, EventArgs e)
        {
            JobViewModel job = (JobViewModel)cmbobx_employeeJob.SelectedItem;
            nmrcupdwn_employeeJobLevel.Value = job.min_lvl;
        }

        private void btn_employeeJobLevelMax_Click(object sender, EventArgs e)
        {
            JobViewModel job = (JobViewModel)cmbobx_employeeJob.SelectedItem;
            nmrcupdwn_employeeJobLevel.Value = job.max_lvl;
        }

        private void employeeOnValueChange(object sender = null, EventArgs e = null)
        {
            bool canSave = true;

            if (txtbx_employeeFirstName.Text.Length == 0) canSave = false;

            if (txtbx_employeeLastName.Text.Length == 0) canSave = false;

            if (cmbobx_employeeJob.SelectedItem == null) canSave = false;

            if (cmbobx_employeePublisher.SelectedItem == null) canSave = false;

            if (canSave)
            {
                if (btn_employeeSave.Tag != null) btn_employeeSave.Enabled = true;
                btn_employeeCreate.Enabled = true;
            }
            else
            {
                btn_employeeSave.Enabled = false;
                btn_employeeCreate.Enabled = false;
            }
        }

        private void btn_employeeSave_Click(object sender, EventArgs e)
        {
            char? middleInit = null;

            if (txtbx_employeeMiddleInit.Text.Length > 0) middleInit = txtbx_employeeMiddleInit.Text.ToCharArray()[0];

            EmployeeViewModel employee = new EmployeeViewModel(
                btn_employeeSave.Tag.ToString(),
                txtbx_employeeFirstName.Text,
                middleInit,
                txtbx_employeeLastName.Text,
                (JobViewModel)cmbobx_employeeJob.SelectedItem,
                (int)nmrcupdwn_employeeJobLevel.Value,
                (PublisherViewModel)cmbobx_employeePublisher.SelectedItem,
                dttmpckr_employeeHireDate.Value.ToSQLString());

            if (!service.PutEmployee(employee)) MessageBox.Show("Could not update Employee", "Database Error", MessageBoxButtons.OK); ;

            MessageBox.Show("Employee Updated!", "Updated Database Entry", MessageBoxButtons.OK);
        }

        private void btn_employeeCreate_Click(object sender, EventArgs e)
        {
            char? middleInit = null;

            if (txtbx_employeeMiddleInit.Text.Length > 0) middleInit = txtbx_employeeMiddleInit.Text.ToCharArray()[0];

            EmployeeViewModel employee = new EmployeeViewModel(
                GenerateID(),
                txtbx_employeeFirstName.Text,
                middleInit,
                txtbx_employeeLastName.Text,
                (JobViewModel)cmbobx_employeeJob.SelectedItem,
                (int)nmrcupdwn_employeeJobLevel.Value,
                (PublisherViewModel)cmbobx_employeePublisher.SelectedItem,
                dttmpckr_employeeHireDate.Value.ToSQLString());

            if (!service.PostEmployee(employee)) MessageBox.Show("Could not create Employee", "Database Error", MessageBoxButtons.OK); ;

            MessageBox.Show("Employee Created!", "New Database Entry", MessageBoxButtons.OK);
        }

        //https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        private string GenerateID()
        {
            string ID = null;

            do
            {
                ID = new string(Enumerable.Repeat(chars, 9).Select(s => s[random.Next(s.Length)]).ToArray());
            } while (service.GetEmployee(ID) != null);

            return ID;
        }
    }

    public static class ExtensionMethods
    {
        public static string ToSQLString(this DateTime DT)
        {
            return DT.Year.ToString("0000") + DT.Month.ToString("00") + DT.Day.ToString("00");
        }
    }
}
