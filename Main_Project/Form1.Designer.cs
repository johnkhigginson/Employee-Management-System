namespace Main_Project
{
    partial class Form1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.empTypeComboBox = new System.Windows.Forms.ComboBox();
            this.employeeTypeLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.hourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedLabel = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.monthlySalaryLabel = new System.Windows.Forms.Label();
            this.monthlySalaryTextBox = new System.Windows.Forms.TextBox();
            this.commissionLabel = new System.Windows.Forms.Label();
            this.commissionTextBox = new System.Windows.Forms.TextBox();
            this.grossSalesTextBox = new System.Windows.Forms.TextBox();
            this.grossSalesLabel = new System.Windows.Forms.Label();
            this.indexIndicator = new System.Windows.Forms.Label();
            this.contractWageTextBox = new System.Windows.Forms.TextBox();
            this.contractWageLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.requiredFieldsLabel = new System.Windows.Forms.Label();
            this.checkFieldsLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.delete_Button = new System.Windows.Forms.Button();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.jobTitleTextBox = new System.Windows.Forms.TextBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.educationButton = new System.Windows.Forms.Button();
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.viewEnrolledCoursesButton = new System.Windows.Forms.Button();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseCreditsTextBox = new System.Windows.Forms.TextBox();
            this.courseCreditsLabel = new System.Windows.Forms.Label();
            this.courseGradeLabel = new System.Windows.Forms.Label();
            this.courseGradeComboBox = new System.Windows.Forms.ComboBox();
            this.enrollButton = new System.Windows.Forms.Button();
            this.workButton = new System.Windows.Forms.Button();
            this.empList = new System.Windows.Forms.ListBox();
            this.deletedEmpList = new System.Windows.Forms.ListBox();
            this.availableCoursesList = new System.Windows.Forms.ListBox();
            this.benefitsTextBox = new System.Windows.Forms.TextBox();
            this.benefitsLabel = new System.Windows.Forms.Label();
            this.empIdTextBox = new System.Windows.Forms.TextBox();
            this.coursesTakenList = new System.Windows.Forms.ListBox();
            this.viewAvailableCoursesButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(782, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.employeeDBMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "File";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(182, 26);
            this.aboutMenuItem.Text = "About";
            // 
            // employeeDBMenuItem
            // 
            this.employeeDBMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDBMenuItem,
            this.saveDBMenuItem});
            this.employeeDBMenuItem.Name = "employeeDBMenuItem";
            this.employeeDBMenuItem.Size = new System.Drawing.Size(182, 26);
            this.employeeDBMenuItem.Text = "Employee DB";
            // 
            // openDBMenuItem
            // 
            this.openDBMenuItem.Name = "openDBMenuItem";
            this.openDBMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openDBMenuItem.Text = "Open";
            // 
            // saveDBMenuItem
            // 
            this.saveDBMenuItem.Name = "saveDBMenuItem";
            this.saveDBMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveDBMenuItem.Text = "Save";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(182, 26);
            this.exitMenuItem.Text = "Exit";
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeMenuItem,
            this.deletedMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewMenuItem.Text = "View";
            // 
            // activeMenuItem
            // 
            this.activeMenuItem.Name = "activeMenuItem";
            this.activeMenuItem.Size = new System.Drawing.Size(221, 26);
            this.activeMenuItem.Text = "Active Employees";
            // 
            // deletedMenuItem
            // 
            this.deletedMenuItem.Name = "deletedMenuItem";
            this.deletedMenuItem.Size = new System.Drawing.Size(221, 26);
            this.deletedMenuItem.Text = "Deleted Employees";
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Location = new System.Drawing.Point(12, 32);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(180, 48);
            this.newEmployeeButton.TabIndex = 1;
            this.newEmployeeButton.Text = "New Employee";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(232, 92);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name *";
            this.firstNameLabel.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(232, 115);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(151, 27);
            this.firstNameTextBox.TabIndex = 4;
            this.firstNameTextBox.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(232, 190);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(151, 27);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Visible = false;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(232, 167);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(89, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name *";
            this.lastNameLabel.Visible = false;
            // 
            // empTypeComboBox
            // 
            this.empTypeComboBox.FormattingEnabled = true;
            this.empTypeComboBox.Items.AddRange(new object[] {
            "Hourly",
            "Salary",
            "Sales",
            "Contract"});
            this.empTypeComboBox.Location = new System.Drawing.Point(232, 265);
            this.empTypeComboBox.Name = "empTypeComboBox";
            this.empTypeComboBox.Size = new System.Drawing.Size(151, 28);
            this.empTypeComboBox.TabIndex = 5;
            this.empTypeComboBox.Visible = false;
            // 
            // employeeTypeLabel
            // 
            this.employeeTypeLabel.AutoSize = true;
            this.employeeTypeLabel.Location = new System.Drawing.Point(232, 242);
            this.employeeTypeLabel.Name = "employeeTypeLabel";
            this.employeeTypeLabel.Size = new System.Drawing.Size(120, 20);
            this.employeeTypeLabel.TabIndex = 3;
            this.employeeTypeLabel.Text = "Employee Type *";
            this.employeeTypeLabel.Visible = false;
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeIDLabel.Location = new System.Drawing.Point(232, 33);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(94, 20);
            this.employeeIDLabel.TabIndex = 6;
            this.employeeIDLabel.Text = "Employee ID";
            this.employeeIDLabel.Visible = false;
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Location = new System.Drawing.Point(412, 92);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(97, 20);
            this.hourlyRateLabel.TabIndex = 3;
            this.hourlyRateLabel.Text = "Hourly Rate *";
            this.hourlyRateLabel.Visible = false;
            this.hourlyRateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // hourlyRateTextBox
            // 
            this.hourlyRateTextBox.Location = new System.Drawing.Point(412, 115);
            this.hourlyRateTextBox.Name = "hourlyRateTextBox";
            this.hourlyRateTextBox.Size = new System.Drawing.Size(151, 27);
            this.hourlyRateTextBox.TabIndex = 4;
            this.hourlyRateTextBox.Visible = false;
            // 
            // hoursWorkedLabel
            // 
            this.hoursWorkedLabel.AutoSize = true;
            this.hoursWorkedLabel.Location = new System.Drawing.Point(412, 167);
            this.hoursWorkedLabel.Name = "hoursWorkedLabel";
            this.hoursWorkedLabel.Size = new System.Drawing.Size(113, 20);
            this.hoursWorkedLabel.TabIndex = 3;
            this.hoursWorkedLabel.Text = "Hours Worked *";
            this.hoursWorkedLabel.Visible = false;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(412, 190);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(151, 27);
            this.hoursWorkedTextBox.TabIndex = 4;
            this.hoursWorkedTextBox.Visible = false;
            // 
            // monthlySalaryLabel
            // 
            this.monthlySalaryLabel.AutoSize = true;
            this.monthlySalaryLabel.Location = new System.Drawing.Point(411, 92);
            this.monthlySalaryLabel.Name = "monthlySalaryLabel";
            this.monthlySalaryLabel.Size = new System.Drawing.Size(117, 20);
            this.monthlySalaryLabel.TabIndex = 3;
            this.monthlySalaryLabel.Text = "Monthly Salary *";
            this.monthlySalaryLabel.Visible = false;
            this.monthlySalaryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // monthlySalaryTextBox
            // 
            this.monthlySalaryTextBox.Location = new System.Drawing.Point(412, 115);
            this.monthlySalaryTextBox.Name = "monthlySalaryTextBox";
            this.monthlySalaryTextBox.Size = new System.Drawing.Size(151, 27);
            this.monthlySalaryTextBox.TabIndex = 4;
            this.monthlySalaryTextBox.Visible = false;
            // 
            // commissionLabel
            // 
            this.commissionLabel.AutoSize = true;
            this.commissionLabel.Location = new System.Drawing.Point(412, 167);
            this.commissionLabel.Name = "commissionLabel";
            this.commissionLabel.Size = new System.Drawing.Size(100, 20);
            this.commissionLabel.TabIndex = 3;
            this.commissionLabel.Text = "Commission *";
            this.commissionLabel.Visible = false;
            // 
            // commissionTextBox
            // 
            this.commissionTextBox.Location = new System.Drawing.Point(412, 190);
            this.commissionTextBox.Name = "commissionTextBox";
            this.commissionTextBox.Size = new System.Drawing.Size(151, 27);
            this.commissionTextBox.TabIndex = 4;
            this.commissionTextBox.Visible = false;
            // 
            // grossSalesTextBox
            // 
            this.grossSalesTextBox.Location = new System.Drawing.Point(412, 265);
            this.grossSalesTextBox.Name = "grossSalesTextBox";
            this.grossSalesTextBox.Size = new System.Drawing.Size(151, 27);
            this.grossSalesTextBox.TabIndex = 4;
            this.grossSalesTextBox.Visible = false;
            // 
            // grossSalesLabel
            // 
            this.grossSalesLabel.AutoSize = true;
            this.grossSalesLabel.Location = new System.Drawing.Point(411, 242);
            this.grossSalesLabel.Name = "grossSalesLabel";
            this.grossSalesLabel.Size = new System.Drawing.Size(93, 20);
            this.grossSalesLabel.TabIndex = 3;
            this.grossSalesLabel.Text = "Gross Sales *";
            this.grossSalesLabel.Visible = false;
            // 
            // indexIndicator
            // 
            this.indexIndicator.AutoSize = true;
            this.indexIndicator.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.indexIndicator.Location = new System.Drawing.Point(213, 269);
            this.indexIndicator.Name = "indexIndicator";
            this.indexIndicator.Size = new System.Drawing.Size(15, 20);
            this.indexIndicator.TabIndex = 7;
            this.indexIndicator.Text = "-";
            // 
            // contractWageTextBox
            // 
            this.contractWageTextBox.Location = new System.Drawing.Point(412, 115);
            this.contractWageTextBox.Name = "contractWageTextBox";
            this.contractWageTextBox.Size = new System.Drawing.Size(151, 27);
            this.contractWageTextBox.TabIndex = 4;
            this.contractWageTextBox.Visible = false;
            // 
            // contractWageLabel
            // 
            this.contractWageLabel.AutoSize = true;
            this.contractWageLabel.Location = new System.Drawing.Point(411, 92);
            this.contractWageLabel.Name = "contractWageLabel";
            this.contractWageLabel.Size = new System.Drawing.Size(117, 20);
            this.contractWageLabel.TabIndex = 3;
            this.contractWageLabel.Text = "Contract Wage *";
            this.contractWageLabel.Visible = false;
            this.contractWageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(621, 340);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(438, 340);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            // 
            // requiredFieldsLabel
            // 
            this.requiredFieldsLabel.AutoSize = true;
            this.requiredFieldsLabel.Location = new System.Drawing.Point(649, 424);
            this.requiredFieldsLabel.Name = "requiredFieldsLabel";
            this.requiredFieldsLabel.Size = new System.Drawing.Size(121, 20);
            this.requiredFieldsLabel.TabIndex = 10;
            this.requiredFieldsLabel.Text = "* Required Fields";
            // 
            // checkFieldsLabel
            // 
            this.checkFieldsLabel.AutoSize = true;
            this.checkFieldsLabel.ForeColor = System.Drawing.Color.Red;
            this.checkFieldsLabel.Location = new System.Drawing.Point(412, 59);
            this.checkFieldsLabel.Name = "checkFieldsLabel";
            this.checkFieldsLabel.Size = new System.Drawing.Size(0, 20);
            this.checkFieldsLabel.TabIndex = 11;
            // 
            // searchTextBox
            // 
            this.searchTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.searchTextBox.Location = new System.Drawing.Point(12, 421);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(180, 27);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.Text = "Search...";
            // 
            // delete_Button
            // 
            this.delete_Button.ForeColor = System.Drawing.Color.DarkRed;
            this.delete_Button.Location = new System.Drawing.Point(258, 338);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(94, 29);
            this.delete_Button.TabIndex = 9;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Visible = false;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(592, 190);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(151, 27);
            this.departmentTextBox.TabIndex = 4;
            this.departmentTextBox.Visible = false;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(592, 167);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(89, 20);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Department";
            this.departmentLabel.Visible = false;
            this.departmentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // jobTitleTextBox
            // 
            this.jobTitleTextBox.Location = new System.Drawing.Point(592, 266);
            this.jobTitleTextBox.Name = "jobTitleTextBox";
            this.jobTitleTextBox.Size = new System.Drawing.Size(151, 27);
            this.jobTitleTextBox.TabIndex = 4;
            this.jobTitleTextBox.Visible = false;
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(592, 242);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(65, 20);
            this.jobTitleLabel.TabIndex = 3;
            this.jobTitleLabel.Text = "Job Title";
            this.jobTitleLabel.Visible = false;
            this.jobTitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(592, 115);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(151, 27);
            this.startDatePicker.TabIndex = 14;
            this.startDatePicker.Value = new System.DateTime(2020, 12, 7, 0, 51, 46, 0);
            this.startDatePicker.Visible = false;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(592, 92);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(97, 20);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Starting Date";
            this.startDateLabel.Visible = false;
            this.startDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // educationButton
            // 
            this.educationButton.Location = new System.Drawing.Point(650, 45);
            this.educationButton.Name = "educationButton";
            this.educationButton.Size = new System.Drawing.Size(94, 29);
            this.educationButton.TabIndex = 15;
            this.educationButton.Text = "Education";
            this.educationButton.UseVisualStyleBackColor = true;
            this.educationButton.Visible = false;
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Location = new System.Drawing.Point(412, 92);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(73, 20);
            this.courseIdLabel.TabIndex = 0;
            this.courseIdLabel.Text = "Course ID";
            this.courseIdLabel.Visible = false;
            // 
            // viewEnrolledCoursesButton
            // 
            this.viewEnrolledCoursesButton.Location = new System.Drawing.Point(12, 33);
            this.viewEnrolledCoursesButton.Name = "viewEnrolledCoursesButton";
            this.viewEnrolledCoursesButton.Size = new System.Drawing.Size(180, 47);
            this.viewEnrolledCoursesButton.TabIndex = 1;
            this.viewEnrolledCoursesButton.Text = "View Enrolled Courses";
            this.viewEnrolledCoursesButton.UseVisualStyleBackColor = true;
            this.viewEnrolledCoursesButton.Visible = false;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(411, 167);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(98, 20);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course Name";
            this.courseNameLabel.Visible = false;
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(412, 115);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.ReadOnly = true;
            this.courseIdTextBox.Size = new System.Drawing.Size(151, 27);
            this.courseIdTextBox.TabIndex = 3;
            this.courseIdTextBox.Visible = false;
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(412, 190);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.ReadOnly = true;
            this.courseNameTextBox.Size = new System.Drawing.Size(331, 27);
            this.courseNameTextBox.TabIndex = 3;
            this.courseNameTextBox.Visible = false;
            // 
            // courseCreditsTextBox
            // 
            this.courseCreditsTextBox.Location = new System.Drawing.Point(412, 265);
            this.courseCreditsTextBox.Name = "courseCreditsTextBox";
            this.courseCreditsTextBox.ReadOnly = true;
            this.courseCreditsTextBox.Size = new System.Drawing.Size(151, 27);
            this.courseCreditsTextBox.TabIndex = 3;
            this.courseCreditsTextBox.Visible = false;
            // 
            // courseCreditsLabel
            // 
            this.courseCreditsLabel.AutoSize = true;
            this.courseCreditsLabel.Location = new System.Drawing.Point(412, 242);
            this.courseCreditsLabel.Name = "courseCreditsLabel";
            this.courseCreditsLabel.Size = new System.Drawing.Size(104, 20);
            this.courseCreditsLabel.TabIndex = 0;
            this.courseCreditsLabel.Text = "Course Credits";
            this.courseCreditsLabel.Visible = false;
            // 
            // courseGradeLabel
            // 
            this.courseGradeLabel.AutoSize = true;
            this.courseGradeLabel.Location = new System.Drawing.Point(592, 92);
            this.courseGradeLabel.Name = "courseGradeLabel";
            this.courseGradeLabel.Size = new System.Drawing.Size(108, 20);
            this.courseGradeLabel.TabIndex = 0;
            this.courseGradeLabel.Text = "Course Grade *";
            this.courseGradeLabel.Visible = false;
            // 
            // courseGradeComboBox
            // 
            this.courseGradeComboBox.FormattingEnabled = true;
            this.courseGradeComboBox.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "E",
            "AU",
            "IC",
            "WD"});
            this.courseGradeComboBox.Location = new System.Drawing.Point(592, 115);
            this.courseGradeComboBox.Name = "courseGradeComboBox";
            this.courseGradeComboBox.Size = new System.Drawing.Size(151, 28);
            this.courseGradeComboBox.TabIndex = 4;
            this.courseGradeComboBox.Visible = false;
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(412, 338);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(151, 29);
            this.enrollButton.TabIndex = 5;
            this.enrollButton.Text = "Add to Courses";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Visible = false;
            // 
            // workButton
            // 
            this.workButton.Location = new System.Drawing.Point(649, 45);
            this.workButton.Name = "workButton";
            this.workButton.Size = new System.Drawing.Size(94, 29);
            this.workButton.TabIndex = 15;
            this.workButton.Text = "Work";
            this.workButton.UseVisualStyleBackColor = true;
            this.workButton.Visible = false;
            // 
            // empList
            // 
            this.empList.FormattingEnabled = true;
            this.empList.ItemHeight = 20;
            this.empList.Location = new System.Drawing.Point(12, 87);
            this.empList.Name = "empList";
            this.empList.Size = new System.Drawing.Size(180, 324);
            this.empList.TabIndex = 16;
            // 
            // deletedEmpList
            // 
            this.deletedEmpList.FormattingEnabled = true;
            this.deletedEmpList.ItemHeight = 20;
            this.deletedEmpList.Location = new System.Drawing.Point(12, 87);
            this.deletedEmpList.Name = "deletedEmpList";
            this.deletedEmpList.Size = new System.Drawing.Size(180, 324);
            this.deletedEmpList.TabIndex = 16;
            this.deletedEmpList.Visible = false;
            // 
            // availableCoursesList
            // 
            this.availableCoursesList.FormattingEnabled = true;
            this.availableCoursesList.ItemHeight = 20;
            this.availableCoursesList.Location = new System.Drawing.Point(12, 87);
            this.availableCoursesList.Name = "availableCoursesList";
            this.availableCoursesList.Size = new System.Drawing.Size(180, 324);
            this.availableCoursesList.TabIndex = 17;
            this.availableCoursesList.Visible = false;
            // 
            // benefitsTextBox
            // 
            this.benefitsTextBox.Location = new System.Drawing.Point(592, 265);
            this.benefitsTextBox.Name = "benefitsTextBox";
            this.benefitsTextBox.ReadOnly = true;
            this.benefitsTextBox.Size = new System.Drawing.Size(151, 27);
            this.benefitsTextBox.TabIndex = 4;
            this.benefitsTextBox.Visible = false;
            // 
            // benefitsLabel
            // 
            this.benefitsLabel.AutoSize = true;
            this.benefitsLabel.Location = new System.Drawing.Point(592, 243);
            this.benefitsLabel.Name = "benefitsLabel";
            this.benefitsLabel.Size = new System.Drawing.Size(132, 20);
            this.benefitsLabel.TabIndex = 3;
            this.benefitsLabel.Text = "Employee Benefits";
            this.benefitsLabel.Visible = false;
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.Location = new System.Drawing.Point(232, 53);
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.ReadOnly = true;
            this.empIdTextBox.Size = new System.Drawing.Size(151, 27);
            this.empIdTextBox.TabIndex = 4;
            this.empIdTextBox.Visible = false;
            // 
            // coursesTakenList
            // 
            this.coursesTakenList.FormattingEnabled = true;
            this.coursesTakenList.ItemHeight = 20;
            this.coursesTakenList.Location = new System.Drawing.Point(12, 87);
            this.coursesTakenList.Name = "coursesTakenList";
            this.coursesTakenList.Size = new System.Drawing.Size(180, 324);
            this.coursesTakenList.TabIndex = 17;
            this.coursesTakenList.Visible = false;
            // 
            // viewAvailableCoursesButton
            // 
            this.viewAvailableCoursesButton.Location = new System.Drawing.Point(12, 33);
            this.viewAvailableCoursesButton.Name = "viewAvailableCoursesButton";
            this.viewAvailableCoursesButton.Size = new System.Drawing.Size(180, 48);
            this.viewAvailableCoursesButton.TabIndex = 1;
            this.viewAvailableCoursesButton.Text = "View Available Courses";
            this.viewAvailableCoursesButton.UseVisualStyleBackColor = true;
            this.viewAvailableCoursesButton.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.viewAvailableCoursesButton);
            this.Controls.Add(this.coursesTakenList);
            this.Controls.Add(this.empIdTextBox);
            this.Controls.Add(this.benefitsLabel);
            this.Controls.Add(this.benefitsTextBox);
            this.Controls.Add(this.availableCoursesList);
            this.Controls.Add(this.deletedEmpList);
            this.Controls.Add(this.empList);
            this.Controls.Add(this.workButton);
            this.Controls.Add(this.educationButton);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.jobTitleTextBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.checkFieldsLabel);
            this.Controls.Add(this.requiredFieldsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.contractWageLabel);
            this.Controls.Add(this.contractWageTextBox);
            this.Controls.Add(this.indexIndicator);
            this.Controls.Add(this.grossSalesLabel);
            this.Controls.Add(this.grossSalesTextBox);
            this.Controls.Add(this.commissionTextBox);
            this.Controls.Add(this.commissionLabel);
            this.Controls.Add(this.monthlySalaryTextBox);
            this.Controls.Add(this.monthlySalaryLabel);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hoursWorkedLabel);
            this.Controls.Add(this.hourlyRateTextBox);
            this.Controls.Add(this.hourlyRateLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.employeeTypeLabel);
            this.Controls.Add(this.empTypeComboBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.newEmployeeButton);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.courseGradeComboBox);
            this.Controls.Add(this.courseGradeLabel);
            this.Controls.Add(this.courseCreditsLabel);
            this.Controls.Add(this.courseCreditsTextBox);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.viewEnrolledCoursesButton);
            this.Controls.Add(this.courseIdLabel);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ComboBox empTypeComboBox;
        private System.Windows.Forms.Label employeeTypeLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.TextBox hourlyRateTextBox;
        private System.Windows.Forms.Label hoursWorkedLabel;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label monthlySalaryLabel;
        private System.Windows.Forms.TextBox monthlySalaryTextBox;
        private System.Windows.Forms.Label commissionLabel;
        private System.Windows.Forms.TextBox commissionTextBox;
        private System.Windows.Forms.TextBox grossSalesTextBox;
        private System.Windows.Forms.Label grossSalesLabel;
        private System.Windows.Forms.Label indexIndicator;
        private System.Windows.Forms.TextBox contractWageTextBox;
        private System.Windows.Forms.Label contractWageLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label requiredFieldsLabel;
        private System.Windows.Forms.Label checkFieldsLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ToolStripMenuItem employeeDBMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDBMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDBMenuItem;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox jobTitleTextBox;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletedMenuItem;
        private System.Windows.Forms.Button educationButton;

        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.Button viewEnrolledCoursesButton;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.TextBox courseCreditsTextBox;
        private System.Windows.Forms.Label courseCreditsLabel;
        private System.Windows.Forms.Label courseGradeLabel;
        private System.Windows.Forms.ComboBox courseGradeComboBox;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button workButton;
        private System.Windows.Forms.ListBox empList;
        private System.Windows.Forms.ListBox deletedEmpList;
        private System.Windows.Forms.ListBox availableCoursesList;
        private System.Windows.Forms.TextBox benefitsTextBox;
        private System.Windows.Forms.Label benefitsLabel;
        private System.Windows.Forms.TextBox empIdTextBox;
        private System.Windows.Forms.ListBox coursesTakenList;
        private System.Windows.Forms.Button viewAvailableCoursesButton;
    }
}

