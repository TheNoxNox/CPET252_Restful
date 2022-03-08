
namespace HallamNathan_Lab04
{
    partial class formMain_Employees
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain_Employees));
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.tsddbtn_file = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_new = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_new_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.spltcntnr_main = new System.Windows.Forms.SplitContainer();
            this.spltcntnr_employees = new System.Windows.Forms.SplitContainer();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.lstvu_employees = new System.Windows.Forms.ListView();
            this.ts_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcntnr_main)).BeginInit();
            this.spltcntnr_main.Panel1.SuspendLayout();
            this.spltcntnr_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcntnr_employees)).BeginInit();
            this.spltcntnr_employees.Panel1.SuspendLayout();
            this.spltcntnr_employees.Panel2.SuspendLayout();
            this.spltcntnr_employees.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_main
            // 
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtn_file});
            this.ts_main.Location = new System.Drawing.Point(0, 0);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(952, 25);
            this.ts_main.TabIndex = 0;
            this.ts_main.Text = "toolStrip1";
            // 
            // tsddbtn_file
            // 
            this.tsddbtn_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbtn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_new,
            this.tsmi_exit});
            this.tsddbtn_file.Image = ((System.Drawing.Image)(resources.GetObject("tsddbtn_file.Image")));
            this.tsddbtn_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtn_file.Name = "tsddbtn_file";
            this.tsddbtn_file.Size = new System.Drawing.Size(38, 22);
            this.tsddbtn_file.Text = "File";
            // 
            // tsmi_new
            // 
            this.tsmi_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_new_employee});
            this.tsmi_new.Name = "tsmi_new";
            this.tsmi_new.Size = new System.Drawing.Size(98, 22);
            this.tsmi_new.Text = "New";
            // 
            // tsmi_new_employee
            // 
            this.tsmi_new_employee.Name = "tsmi_new_employee";
            this.tsmi_new_employee.Size = new System.Drawing.Size(120, 22);
            this.tsmi_new_employee.Text = "Exployee";
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(98, 22);
            this.tsmi_exit.Text = "Exit";
            this.tsmi_exit.Click += new System.EventHandler(this.tsmi_exit_Click);
            // 
            // spltcntnr_main
            // 
            this.spltcntnr_main.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.spltcntnr_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcntnr_main.Location = new System.Drawing.Point(0, 25);
            this.spltcntnr_main.Name = "spltcntnr_main";
            // 
            // spltcntnr_main.Panel1
            // 
            this.spltcntnr_main.Panel1.Controls.Add(this.spltcntnr_employees);
            this.spltcntnr_main.Size = new System.Drawing.Size(952, 428);
            this.spltcntnr_main.SplitterDistance = 372;
            this.spltcntnr_main.TabIndex = 1;
            // 
            // spltcntnr_employees
            // 
            this.spltcntnr_employees.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.spltcntnr_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltcntnr_employees.Location = new System.Drawing.Point(0, 0);
            this.spltcntnr_employees.Name = "spltcntnr_employees";
            this.spltcntnr_employees.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltcntnr_employees.Panel1
            // 
            this.spltcntnr_employees.Panel1.Controls.Add(this.lbl_employee);
            // 
            // spltcntnr_employees.Panel2
            // 
            this.spltcntnr_employees.Panel2.Controls.Add(this.lstvu_employees);
            this.spltcntnr_employees.Size = new System.Drawing.Size(372, 428);
            this.spltcntnr_employees.SplitterDistance = 25;
            this.spltcntnr_employees.TabIndex = 1;
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_employee.Location = new System.Drawing.Point(0, 0);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(64, 15);
            this.lbl_employee.TabIndex = 0;
            this.lbl_employee.Text = "Employees";
            // 
            // lstvu_employees
            // 
            this.lstvu_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvu_employees.HideSelection = false;
            this.lstvu_employees.Location = new System.Drawing.Point(0, 0);
            this.lstvu_employees.Name = "lstvu_employees";
            this.lstvu_employees.Size = new System.Drawing.Size(372, 399);
            this.lstvu_employees.TabIndex = 0;
            this.lstvu_employees.UseCompatibleStateImageBehavior = false;
            // 
            // formMain_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 453);
            this.Controls.Add(this.spltcntnr_main);
            this.Controls.Add(this.ts_main);
            this.Name = "formMain_Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.spltcntnr_main.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcntnr_main)).EndInit();
            this.spltcntnr_main.ResumeLayout(false);
            this.spltcntnr_employees.Panel1.ResumeLayout(false);
            this.spltcntnr_employees.Panel1.PerformLayout();
            this.spltcntnr_employees.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcntnr_employees)).EndInit();
            this.spltcntnr_employees.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtn_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_new;
        private System.Windows.Forms.ToolStripMenuItem tsmi_new_employee;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.SplitContainer spltcntnr_main;
        private System.Windows.Forms.SplitContainer spltcntnr_employees;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.ListView lstvu_employees;
    }
}

