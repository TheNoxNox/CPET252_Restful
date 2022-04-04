using System;
using System.Collections.Generic;
using System.Windows.Forms;

using static HallamNathan_Lab04.ViewModels;
using System.Linq;
using System.Net;

namespace HallamNathan_Lab04
{
    public partial class formMain_Employees : Form
    {
        Service service;

        //Used for new ID generation
        private static Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-";

        //Used for column sorting
        private ColumnHeader SortingColumn = null;

        public formMain_Employees()
        {
            InitializeComponent();
        }

        public void FormLoad(object sender, EventArgs e)
        {
            service = new Service(Connection.Get());

            lstvu_employees.View = View.Details;
            lstvu_employees.GridLines = true;
            lstvu_employees.MultiSelect = false; // one row at a time
            lstvu_employees.FullRowSelect = true;
            lstvu_employees.Columns.Add("First");
            lstvu_employees.Columns[0].Width = 130;
            lstvu_employees.Columns.Add("M");
            lstvu_employees.Columns[1].Width = 35;
            lstvu_employees.Columns.Add("Last");
            lstvu_employees.Columns[2].Width = 260;

            #region Populate Employee List
            foreach (EmployeeViewModel _Employee in service.GetEmployees())
            {
                string[] empItems = new string[] { _Employee.FirstName, _Employee.MiddleInitial.ToString(), _Employee.LastName };
                ListViewItem LVI = new ListViewItem(empItems);
                LVI.Tag = _Employee;
                lstvu_employees.Items.Add(LVI);
            }
            #endregion Populate Employee List

            #region Populate Employees and Publishers Combo Boxes
            cmbobx_employeeJob.Items.AddRange(service.GetJobs().ToArray());
            cmbobx_employeeJob.SelectedIndex = 0;

            cmbobx_employeePublisher.Items.AddRange(service.GetPublishers().ToArray());
            cmbobx_employeePublisher.SelectedIndex = 0;
            #endregion Populate Employees and Publishers Combo Boxes

            #region Sort by First Name
            lstvu_employees.ListViewItemSorter =
                new ListViewComparer(lstvu_employees.Columns[0].Index, SortOrder.Ascending);
         
            SortingColumn = lstvu_employees.Columns[0];

            lstvu_employees.Columns[0].Text = "↑ " + SortingColumn.Text;

            lstvu_employees.Sort();
            #endregion Sort by First Name
        }

        #region Employee List View
        private void lstvu_employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvu_employees.SelectedItems.Count <= 0) return;

            ListViewItem item = lstvu_employees.SelectedItems[0];

            EmployeeViewModel employee = (EmployeeViewModel)item.Tag;

            btn_employeeSave.Tag = employee.ID;

            txtbx_employeeFirstName.Text = employee.FirstName;
            txtbx_employeeMiddleInit.Text = employee.MiddleInitial.ToString();
            txtbx_employeeLastName.Text = employee.LastName;

            //https://stackoverflow.com/questions/341175/datetime-parse-and-making-it-work-with-a-specific-format
            dttmpckr_employeeHireDate.Value = DateTime.ParseExact(employee.DateOfHire, "yyyymmdd", null);

            cmbobx_employeeJob.SelectedIndex = cmbobx_employeeJob.FindStringExact(employee.Job.Description);
            nmrcupdwn_employeeJobLevel.Maximum = employee.Job.MaxLevel;
            nmrcupdwn_employeeJobLevel.Minimum = employee.Job.MinLevel;
            nmrcupdwn_employeeJobLevel.Value = employee.JobLevel;

            cmbobx_employeePublisher.SelectedIndex = cmbobx_employeePublisher.FindStringExact(employee.Publisher.Name);
        }

        //http://csharphelper.com/blog/2014/09/sort-a-listview-using-the-column-you-click-in-c/
        private void lstvu_employees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = lstvu_employees.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn.Text.StartsWith("↑ "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }

                // Remove the old sort indicator.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "↑ " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "↓ " + SortingColumn.Text;
            }

            // Create a comparer.
            lstvu_employees.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            lstvu_employees.Sort();
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
                btn_employeeSave.Enabled = (btn_employeeSave.Tag != null) ? true : false;
                btn_employeeCreate.Enabled = true;
            }
            else
            {
                btn_employeeSave.Enabled = false;
                btn_employeeCreate.Enabled = false;
            }
        }
        #endregion Employee List View

        private void cmbobx_employeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            JobViewModel job = (JobViewModel)cmbobx_employeeJob.SelectedItem;

            nmrcupdwn_employeeJobLevel.Maximum = job.MaxLevel;
            nmrcupdwn_employeeJobLevel.Minimum = job.MinLevel;
            nmrcupdwn_employeeJobLevel.Value = job.MinLevel;
        }

        #region Buttons and ToolStripButtons
        private void btn_employeeJobLevelMin_Click(object sender, EventArgs e)
        {
            JobViewModel job = (JobViewModel)cmbobx_employeeJob.SelectedItem;
            nmrcupdwn_employeeJobLevel.Value = job.MinLevel;
        }

        private void btn_employeeJobLevelMax_Click(object sender, EventArgs e)
        {
            JobViewModel job = (JobViewModel)cmbobx_employeeJob.SelectedItem;
            nmrcupdwn_employeeJobLevel.Value = job.MaxLevel;
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

            if (!service.PutEmployee(employee, out HttpWebResponse response)) MessageBox.Show($"Could not update Employee! CODE: {response}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

            MessageBox.Show("Employee Updated!", "Updated Database Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lstvu_employees.SelectedItems[0].SubItems[0].Text = employee.FirstName;
            lstvu_employees.SelectedItems[0].SubItems[1].Text = employee.MiddleInitial.ToString();
            lstvu_employees.SelectedItems[0].SubItems[2].Text = employee.LastName;
            lstvu_employees.SelectedItems[0].Tag = employee;
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

            if (!service.PostEmployee(employee, out HttpWebResponse response)) MessageBox.Show($"Could not create Employee\n CODE: {response}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

            MessageBox.Show("Employee Created!", "New Database Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string[] empItems = new string[] { employee.FirstName, employee.MiddleInitial.ToString(), employee.LastName };
            ListViewItem LVI = new ListViewItem(empItems);
            LVI.Tag = employee;
            lstvu_employees.Items.Add(LVI);
        }

        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Remove {txtbx_employeeFirstName.Text} {txtbx_employeeLastName.Text} from the database?", "Delete Database Entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    if (!service.DeleteEmployee(btn_employeeSave.Tag.ToString(), out HttpWebResponse response))
                    {
                        MessageBox.Show($"Could not delete Employee! \n CODE: {response.StatusCode}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lstvu_employees.Items.Remove(lstvu_employees.SelectedItems[0]);
                    break;
                case DialogResult.No:
                    break;
                default:
                    MessageBox.Show("Message Box Result Error", "How did you get here?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        #endregion Buttons and ToolStripButtons

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

    //http://csharphelper.com/blog/2014/09/sort-a-listview-using-the-column-you-click-in-c/
    // Compares two ListView items based on a selected column.
    public class ListViewComparer : System.Collections.IComparer
    {
        private int ColumnNumber;
        private SortOrder SortOrder;

        public ListViewComparer(int column_number,
            SortOrder sort_order)
        {
            ColumnNumber = column_number;
            SortOrder = sort_order;
        }

        // Compare two ListViewItems.
        public int Compare(object object_x, object object_y)
        {
            // Get the objects as ListViewItems.
            ListViewItem item_x = object_x as ListViewItem;
            ListViewItem item_y = object_y as ListViewItem;

            // Get the corresponding sub-item values.
            string string_x;
            if (item_x.SubItems.Count <= ColumnNumber)
            {
                string_x = "";
            }
            else
            {
                string_x = item_x.SubItems[ColumnNumber].Text;
            }

            string string_y;
            if (item_y.SubItems.Count <= ColumnNumber)
            {
                string_y = "";
            }
            else
            {
                string_y = item_y.SubItems[ColumnNumber].Text;
            }

            // Compare them.
            int result;
            double double_x, double_y;
            if (double.TryParse(string_x, out double_x) &&
                double.TryParse(string_y, out double_y))
            {
                // Treat as a number.
                result = double_x.CompareTo(double_y);
            }
            else
            {
                DateTime date_x, date_y;
                if (DateTime.TryParse(string_x, out date_x) &&
                    DateTime.TryParse(string_y, out date_y))
                {
                    // Treat as a date.
                    result = date_x.CompareTo(date_y);
                }
                else
                {
                    // Treat as a string.
                    result = string_x.CompareTo(string_y);
                }
            }

            // Return the correct result depending on whether
            // we're sorting ascending or descending.
            if (SortOrder == SortOrder.Ascending)
            {
                return result;
            }
            else
            {
                return -result;
            }
        }
    }
}
