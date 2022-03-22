
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
            this.tsmi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.spltcntnr_main = new System.Windows.Forms.SplitContainer();
            this.spltcntnr_employees = new System.Windows.Forms.SplitContainer();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.lstvu_employees = new System.Windows.Forms.ListView();
            this.grpbx_employeeInfo = new System.Windows.Forms.GroupBox();
            this.pnl_employeeSaveNew = new System.Windows.Forms.Panel();
            this.btn_employeeCreate = new System.Windows.Forms.Button();
            this.btn_employeeSave = new System.Windows.Forms.Button();
            this.grpbx_employeePublisher = new System.Windows.Forms.GroupBox();
            this.cmbobx_employeePublisher = new System.Windows.Forms.ComboBox();
            this.grpbx_employeeJob = new System.Windows.Forms.GroupBox();
            this.pnl_jobLevelButtons = new System.Windows.Forms.Panel();
            this.btn_employeeJobLevelMin = new System.Windows.Forms.Button();
            this.btn_employeeJobLevelMax = new System.Windows.Forms.Button();
            this.lbl_employeeJobLevel = new System.Windows.Forms.Label();
            this.cmbobx_employeeJob = new System.Windows.Forms.ComboBox();
            this.nmrcupdwn_employeeJobLevel = new System.Windows.Forms.NumericUpDown();
            this.grpbx_employeeHireDate = new System.Windows.Forms.GroupBox();
            this.dttmpckr_employeeHireDate = new System.Windows.Forms.DateTimePicker();
            this.grpbx_employeeLastNam = new System.Windows.Forms.GroupBox();
            this.txtbx_employeeLastName = new System.Windows.Forms.TextBox();
            this.grpbx_employeeMiddleInit = new System.Windows.Forms.GroupBox();
            this.txtbx_employeeMiddleInit = new System.Windows.Forms.TextBox();
            this.grpbx_employeeFirstName = new System.Windows.Forms.GroupBox();
            this.txtbx_employeeFirstName = new System.Windows.Forms.TextBox();
            this.ts_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcntnr_main)).BeginInit();
            this.spltcntnr_main.Panel1.SuspendLayout();
            this.spltcntnr_main.Panel2.SuspendLayout();
            this.spltcntnr_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltcntnr_employees)).BeginInit();
            this.spltcntnr_employees.Panel1.SuspendLayout();
            this.spltcntnr_employees.Panel2.SuspendLayout();
            this.spltcntnr_employees.SuspendLayout();
            this.grpbx_employeeInfo.SuspendLayout();
            this.pnl_employeeSaveNew.SuspendLayout();
            this.grpbx_employeePublisher.SuspendLayout();
            this.grpbx_employeeJob.SuspendLayout();
            this.pnl_jobLevelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcupdwn_employeeJobLevel)).BeginInit();
            this.grpbx_employeeHireDate.SuspendLayout();
            this.grpbx_employeeLastNam.SuspendLayout();
            this.grpbx_employeeMiddleInit.SuspendLayout();
            this.grpbx_employeeFirstName.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_main
            // 
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtn_file});
            this.ts_main.Location = new System.Drawing.Point(0, 0);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(727, 25);
            this.ts_main.TabIndex = 0;
            this.ts_main.Text = "toolStrip1";
            // 
            // tsddbtn_file
            // 
            this.tsddbtn_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbtn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_exit});
            this.tsddbtn_file.Image = ((System.Drawing.Image)(resources.GetObject("tsddbtn_file.Image")));
            this.tsddbtn_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtn_file.Name = "tsddbtn_file";
            this.tsddbtn_file.Size = new System.Drawing.Size(38, 22);
            this.tsddbtn_file.Text = "File";
            // 
            // tsmi_exit
            // 
            this.tsmi_exit.Name = "tsmi_exit";
            this.tsmi_exit.Size = new System.Drawing.Size(92, 22);
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
            // 
            // spltcntnr_main.Panel2
            // 
            this.spltcntnr_main.Panel2.Controls.Add(this.grpbx_employeeInfo);
            this.spltcntnr_main.Size = new System.Drawing.Size(727, 308);
            this.spltcntnr_main.SplitterDistance = 283;
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
            this.spltcntnr_employees.Size = new System.Drawing.Size(283, 308);
            this.spltcntnr_employees.SplitterDistance = 25;
            this.spltcntnr_employees.TabIndex = 1;
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_employee.Location = new System.Drawing.Point(0, 0);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(64, 15);
            this.lbl_employee.TabIndex = 0;
            this.lbl_employee.Text = "Employees";
            this.lbl_employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstvu_employees
            // 
            this.lstvu_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvu_employees.HideSelection = false;
            this.lstvu_employees.Location = new System.Drawing.Point(0, 0);
            this.lstvu_employees.Name = "lstvu_employees";
            this.lstvu_employees.Size = new System.Drawing.Size(283, 279);
            this.lstvu_employees.TabIndex = 0;
            this.lstvu_employees.UseCompatibleStateImageBehavior = false;
            this.lstvu_employees.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstvu_employees_ColumnClick);
            this.lstvu_employees.SelectedIndexChanged += new System.EventHandler(this.lstvu_employees_SelectedIndexChanged);
            // 
            // grpbx_employeeInfo
            // 
            this.grpbx_employeeInfo.Controls.Add(this.pnl_employeeSaveNew);
            this.grpbx_employeeInfo.Controls.Add(this.grpbx_employeePublisher);
            this.grpbx_employeeInfo.Controls.Add(this.grpbx_employeeJob);
            this.grpbx_employeeInfo.Controls.Add(this.grpbx_employeeHireDate);
            this.grpbx_employeeInfo.Controls.Add(this.grpbx_employeeLastNam);
            this.grpbx_employeeInfo.Controls.Add(this.grpbx_employeeMiddleInit);
            this.grpbx_employeeInfo.Controls.Add(this.grpbx_employeeFirstName);
            this.grpbx_employeeInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbx_employeeInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbx_employeeInfo.Name = "grpbx_employeeInfo";
            this.grpbx_employeeInfo.Size = new System.Drawing.Size(440, 298);
            this.grpbx_employeeInfo.TabIndex = 0;
            this.grpbx_employeeInfo.TabStop = false;
            // 
            // pnl_employeeSaveNew
            // 
            this.pnl_employeeSaveNew.Controls.Add(this.btn_employeeCreate);
            this.pnl_employeeSaveNew.Controls.Add(this.btn_employeeSave);
            this.pnl_employeeSaveNew.Location = new System.Drawing.Point(212, 209);
            this.pnl_employeeSaveNew.Name = "pnl_employeeSaveNew";
            this.pnl_employeeSaveNew.Size = new System.Drawing.Size(210, 83);
            this.pnl_employeeSaveNew.TabIndex = 9;
            // 
            // btn_employeeCreate
            // 
            this.btn_employeeCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_employeeCreate.Location = new System.Drawing.Point(0, 45);
            this.btn_employeeCreate.Name = "btn_employeeCreate";
            this.btn_employeeCreate.Size = new System.Drawing.Size(210, 38);
            this.btn_employeeCreate.TabIndex = 1;
            this.btn_employeeCreate.Text = "Create";
            this.btn_employeeCreate.UseVisualStyleBackColor = true;
            this.btn_employeeCreate.Click += new System.EventHandler(this.btn_employeeCreate_Click);
            // 
            // btn_employeeSave
            // 
            this.btn_employeeSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_employeeSave.Location = new System.Drawing.Point(0, 0);
            this.btn_employeeSave.Name = "btn_employeeSave";
            this.btn_employeeSave.Size = new System.Drawing.Size(210, 38);
            this.btn_employeeSave.TabIndex = 0;
            this.btn_employeeSave.Text = "Save";
            this.btn_employeeSave.UseVisualStyleBackColor = true;
            this.btn_employeeSave.Click += new System.EventHandler(this.btn_employeeSave_Click);
            // 
            // grpbx_employeePublisher
            // 
            this.grpbx_employeePublisher.Controls.Add(this.cmbobx_employeePublisher);
            this.grpbx_employeePublisher.Location = new System.Drawing.Point(212, 152);
            this.grpbx_employeePublisher.Name = "grpbx_employeePublisher";
            this.grpbx_employeePublisher.Size = new System.Drawing.Size(213, 50);
            this.grpbx_employeePublisher.TabIndex = 8;
            this.grpbx_employeePublisher.TabStop = false;
            this.grpbx_employeePublisher.Text = "Publisher";
            // 
            // cmbobx_employeePublisher
            // 
            this.cmbobx_employeePublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbobx_employeePublisher.FormattingEnabled = true;
            this.cmbobx_employeePublisher.Location = new System.Drawing.Point(3, 19);
            this.cmbobx_employeePublisher.Name = "cmbobx_employeePublisher";
            this.cmbobx_employeePublisher.Size = new System.Drawing.Size(207, 23);
            this.cmbobx_employeePublisher.TabIndex = 7;
            this.cmbobx_employeePublisher.SelectedValueChanged += new System.EventHandler(this.employeeOnValueChange);
            // 
            // grpbx_employeeJob
            // 
            this.grpbx_employeeJob.Controls.Add(this.pnl_jobLevelButtons);
            this.grpbx_employeeJob.Controls.Add(this.lbl_employeeJobLevel);
            this.grpbx_employeeJob.Controls.Add(this.cmbobx_employeeJob);
            this.grpbx_employeeJob.Controls.Add(this.nmrcupdwn_employeeJobLevel);
            this.grpbx_employeeJob.Location = new System.Drawing.Point(6, 152);
            this.grpbx_employeeJob.Name = "grpbx_employeeJob";
            this.grpbx_employeeJob.Size = new System.Drawing.Size(200, 140);
            this.grpbx_employeeJob.TabIndex = 1;
            this.grpbx_employeeJob.TabStop = false;
            this.grpbx_employeeJob.Text = "Job";
            // 
            // pnl_jobLevelButtons
            // 
            this.pnl_jobLevelButtons.Controls.Add(this.btn_employeeJobLevelMin);
            this.pnl_jobLevelButtons.Controls.Add(this.btn_employeeJobLevelMax);
            this.pnl_jobLevelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_jobLevelButtons.Location = new System.Drawing.Point(3, 104);
            this.pnl_jobLevelButtons.Name = "pnl_jobLevelButtons";
            this.pnl_jobLevelButtons.Size = new System.Drawing.Size(194, 33);
            this.pnl_jobLevelButtons.TabIndex = 4;
            // 
            // btn_employeeJobLevelMin
            // 
            this.btn_employeeJobLevelMin.AutoSize = true;
            this.btn_employeeJobLevelMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_employeeJobLevelMin.Location = new System.Drawing.Point(0, 0);
            this.btn_employeeJobLevelMin.Name = "btn_employeeJobLevelMin";
            this.btn_employeeJobLevelMin.Size = new System.Drawing.Size(97, 33);
            this.btn_employeeJobLevelMin.TabIndex = 7;
            this.btn_employeeJobLevelMin.Text = "Min";
            this.btn_employeeJobLevelMin.UseVisualStyleBackColor = true;
            this.btn_employeeJobLevelMin.Click += new System.EventHandler(this.btn_employeeJobLevelMin_Click);
            // 
            // btn_employeeJobLevelMax
            // 
            this.btn_employeeJobLevelMax.AutoSize = true;
            this.btn_employeeJobLevelMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_employeeJobLevelMax.Location = new System.Drawing.Point(97, 0);
            this.btn_employeeJobLevelMax.Name = "btn_employeeJobLevelMax";
            this.btn_employeeJobLevelMax.Size = new System.Drawing.Size(97, 33);
            this.btn_employeeJobLevelMax.TabIndex = 8;
            this.btn_employeeJobLevelMax.Text = "Max";
            this.btn_employeeJobLevelMax.UseVisualStyleBackColor = true;
            this.btn_employeeJobLevelMax.Click += new System.EventHandler(this.btn_employeeJobLevelMax_Click);
            // 
            // lbl_employeeJobLevel
            // 
            this.lbl_employeeJobLevel.AutoSize = true;
            this.lbl_employeeJobLevel.Location = new System.Drawing.Point(6, 57);
            this.lbl_employeeJobLevel.Name = "lbl_employeeJobLevel";
            this.lbl_employeeJobLevel.Size = new System.Drawing.Size(34, 15);
            this.lbl_employeeJobLevel.TabIndex = 6;
            this.lbl_employeeJobLevel.Text = "Level";
            // 
            // cmbobx_employeeJob
            // 
            this.cmbobx_employeeJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbobx_employeeJob.FormattingEnabled = true;
            this.cmbobx_employeeJob.Location = new System.Drawing.Point(3, 19);
            this.cmbobx_employeeJob.Name = "cmbobx_employeeJob";
            this.cmbobx_employeeJob.Size = new System.Drawing.Size(194, 23);
            this.cmbobx_employeeJob.TabIndex = 2;
            this.cmbobx_employeeJob.SelectedIndexChanged += new System.EventHandler(this.cmbobx_employeeJob_SelectedIndexChanged);
            this.cmbobx_employeeJob.SelectedValueChanged += new System.EventHandler(this.employeeOnValueChange);
            // 
            // nmrcupdwn_employeeJobLevel
            // 
            this.nmrcupdwn_employeeJobLevel.Location = new System.Drawing.Point(6, 75);
            this.nmrcupdwn_employeeJobLevel.Name = "nmrcupdwn_employeeJobLevel";
            this.nmrcupdwn_employeeJobLevel.Size = new System.Drawing.Size(186, 23);
            this.nmrcupdwn_employeeJobLevel.TabIndex = 5;
            this.nmrcupdwn_employeeJobLevel.ValueChanged += new System.EventHandler(this.employeeOnValueChange);
            // 
            // grpbx_employeeHireDate
            // 
            this.grpbx_employeeHireDate.Controls.Add(this.dttmpckr_employeeHireDate);
            this.grpbx_employeeHireDate.Location = new System.Drawing.Point(6, 83);
            this.grpbx_employeeHireDate.Name = "grpbx_employeeHireDate";
            this.grpbx_employeeHireDate.Size = new System.Drawing.Size(422, 50);
            this.grpbx_employeeHireDate.TabIndex = 2;
            this.grpbx_employeeHireDate.TabStop = false;
            this.grpbx_employeeHireDate.Text = "Date Hired";
            // 
            // dttmpckr_employeeHireDate
            // 
            this.dttmpckr_employeeHireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dttmpckr_employeeHireDate.Location = new System.Drawing.Point(3, 19);
            this.dttmpckr_employeeHireDate.Name = "dttmpckr_employeeHireDate";
            this.dttmpckr_employeeHireDate.Size = new System.Drawing.Size(416, 23);
            this.dttmpckr_employeeHireDate.TabIndex = 1;
            this.dttmpckr_employeeHireDate.ValueChanged += new System.EventHandler(this.employeeOnValueChange);
            // 
            // grpbx_employeeLastNam
            // 
            this.grpbx_employeeLastNam.Controls.Add(this.txtbx_employeeLastName);
            this.grpbx_employeeLastNam.Location = new System.Drawing.Point(230, 22);
            this.grpbx_employeeLastNam.Name = "grpbx_employeeLastNam";
            this.grpbx_employeeLastNam.Size = new System.Drawing.Size(200, 50);
            this.grpbx_employeeLastNam.TabIndex = 3;
            this.grpbx_employeeLastNam.TabStop = false;
            this.grpbx_employeeLastNam.Text = "Last Name";
            // 
            // txtbx_employeeLastName
            // 
            this.txtbx_employeeLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_employeeLastName.Location = new System.Drawing.Point(3, 19);
            this.txtbx_employeeLastName.MaxLength = 30;
            this.txtbx_employeeLastName.Name = "txtbx_employeeLastName";
            this.txtbx_employeeLastName.Size = new System.Drawing.Size(194, 23);
            this.txtbx_employeeLastName.TabIndex = 2;
            this.txtbx_employeeLastName.TextChanged += new System.EventHandler(this.employeeOnValueChange);
            // 
            // grpbx_employeeMiddleInit
            // 
            this.grpbx_employeeMiddleInit.Controls.Add(this.txtbx_employeeMiddleInit);
            this.grpbx_employeeMiddleInit.Location = new System.Drawing.Point(158, 22);
            this.grpbx_employeeMiddleInit.Name = "grpbx_employeeMiddleInit";
            this.grpbx_employeeMiddleInit.Size = new System.Drawing.Size(66, 50);
            this.grpbx_employeeMiddleInit.TabIndex = 1;
            this.grpbx_employeeMiddleInit.TabStop = false;
            this.grpbx_employeeMiddleInit.Text = "M lnitial";
            // 
            // txtbx_employeeMiddleInit
            // 
            this.txtbx_employeeMiddleInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_employeeMiddleInit.Location = new System.Drawing.Point(3, 19);
            this.txtbx_employeeMiddleInit.MaxLength = 1;
            this.txtbx_employeeMiddleInit.Name = "txtbx_employeeMiddleInit";
            this.txtbx_employeeMiddleInit.Size = new System.Drawing.Size(60, 23);
            this.txtbx_employeeMiddleInit.TabIndex = 1;
            this.txtbx_employeeMiddleInit.TextChanged += new System.EventHandler(this.employeeOnValueChange);
            // 
            // grpbx_employeeFirstName
            // 
            this.grpbx_employeeFirstName.Controls.Add(this.txtbx_employeeFirstName);
            this.grpbx_employeeFirstName.Location = new System.Drawing.Point(6, 22);
            this.grpbx_employeeFirstName.Name = "grpbx_employeeFirstName";
            this.grpbx_employeeFirstName.Size = new System.Drawing.Size(146, 50);
            this.grpbx_employeeFirstName.TabIndex = 1;
            this.grpbx_employeeFirstName.TabStop = false;
            this.grpbx_employeeFirstName.Text = "First Name";
            // 
            // txtbx_employeeFirstName
            // 
            this.txtbx_employeeFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_employeeFirstName.Location = new System.Drawing.Point(3, 19);
            this.txtbx_employeeFirstName.MaxLength = 20;
            this.txtbx_employeeFirstName.Name = "txtbx_employeeFirstName";
            this.txtbx_employeeFirstName.Size = new System.Drawing.Size(140, 23);
            this.txtbx_employeeFirstName.TabIndex = 0;
            this.txtbx_employeeFirstName.TextChanged += new System.EventHandler(this.employeeOnValueChange);
            // 
            // formMain_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 333);
            this.Controls.Add(this.spltcntnr_main);
            this.Controls.Add(this.ts_main);
            this.Name = "formMain_Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.spltcntnr_main.Panel1.ResumeLayout(false);
            this.spltcntnr_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcntnr_main)).EndInit();
            this.spltcntnr_main.ResumeLayout(false);
            this.spltcntnr_employees.Panel1.ResumeLayout(false);
            this.spltcntnr_employees.Panel1.PerformLayout();
            this.spltcntnr_employees.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltcntnr_employees)).EndInit();
            this.spltcntnr_employees.ResumeLayout(false);
            this.grpbx_employeeInfo.ResumeLayout(false);
            this.pnl_employeeSaveNew.ResumeLayout(false);
            this.grpbx_employeePublisher.ResumeLayout(false);
            this.grpbx_employeeJob.ResumeLayout(false);
            this.grpbx_employeeJob.PerformLayout();
            this.pnl_jobLevelButtons.ResumeLayout(false);
            this.pnl_jobLevelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcupdwn_employeeJobLevel)).EndInit();
            this.grpbx_employeeHireDate.ResumeLayout(false);
            this.grpbx_employeeLastNam.ResumeLayout(false);
            this.grpbx_employeeLastNam.PerformLayout();
            this.grpbx_employeeMiddleInit.ResumeLayout(false);
            this.grpbx_employeeMiddleInit.PerformLayout();
            this.grpbx_employeeFirstName.ResumeLayout(false);
            this.grpbx_employeeFirstName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtn_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exit;
        private System.Windows.Forms.SplitContainer spltcntnr_main;
        private System.Windows.Forms.SplitContainer spltcntnr_employees;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.ListView lstvu_employees;
        private System.Windows.Forms.GroupBox grpbx_employeeInfo;
        private System.Windows.Forms.TextBox txtbx_employeeLastName;
        private System.Windows.Forms.TextBox txtbx_employeeMiddleInit;
        private System.Windows.Forms.TextBox txtbx_employeeFirstName;
        private System.Windows.Forms.GroupBox grpbx_employeeLastNam;
        private System.Windows.Forms.GroupBox grpbx_employeeMiddleInit;
        private System.Windows.Forms.GroupBox grpbx_employeeFirstName;
        private System.Windows.Forms.GroupBox grpbx_employeeHireDate;
        private System.Windows.Forms.DateTimePicker dttmpckr_employeeHireDate;
        private System.Windows.Forms.NumericUpDown nmrcupdwn_employeeJobLevel;
        private System.Windows.Forms.GroupBox grpbx_employeeJob;
        private System.Windows.Forms.ComboBox cmbobx_employeeJob;
        private System.Windows.Forms.Label lbl_employeeJobLevel;
        private System.Windows.Forms.Button btn_employeeJobLevelMax;
        private System.Windows.Forms.Button btn_employeeJobLevelMin;
        private System.Windows.Forms.Panel pnl_jobLevelButtons;
        private System.Windows.Forms.GroupBox grpbx_employeePublisher;
        private System.Windows.Forms.ComboBox cmbobx_employeePublisher;
        private System.Windows.Forms.Panel pnl_employeeSaveNew;
        private System.Windows.Forms.Button btn_employeeCreate;
        private System.Windows.Forms.Button btn_employeeSave;
    }
}

