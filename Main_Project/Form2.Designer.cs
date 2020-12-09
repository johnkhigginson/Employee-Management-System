namespace Main_Project
{
    partial class Form2
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
            this.courseIdLabel = new System.Windows.Forms.Label();
            this.viewEnrolledCoursesButton = new System.Windows.Forms.Button();
            this.availableCoursesListView = new System.Windows.Forms.ListView();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.courseIdTextBox = new System.Windows.Forms.TextBox();
            this.courseNameTextBox = new System.Windows.Forms.TextBox();
            this.courseCreditsTextBox = new System.Windows.Forms.TextBox();
            this.courseCreditsLabel = new System.Windows.Forms.Label();
            this.courseGradeLabel = new System.Windows.Forms.Label();
            this.courseGradeComboBox = new System.Windows.Forms.ComboBox();
            this.enrollButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseIdLabel
            // 
            this.courseIdLabel.AutoSize = true;
            this.courseIdLabel.Location = new System.Drawing.Point(240, 41);
            this.courseIdLabel.Name = "courseIdLabel";
            this.courseIdLabel.Size = new System.Drawing.Size(73, 20);
            this.courseIdLabel.TabIndex = 0;
            this.courseIdLabel.Text = "Course ID";
            // 
            // viewEnrolledCoursesButton
            // 
            this.viewEnrolledCoursesButton.Location = new System.Drawing.Point(13, 13);
            this.viewEnrolledCoursesButton.Name = "viewEnrolledCoursesButton";
            this.viewEnrolledCoursesButton.Size = new System.Drawing.Size(180, 48);
            this.viewEnrolledCoursesButton.TabIndex = 1;
            this.viewEnrolledCoursesButton.Text = "View Enrolled Courses";
            this.viewEnrolledCoursesButton.UseVisualStyleBackColor = true;
            // 
            // availableCoursesListView
            // 
            this.availableCoursesListView.HideSelection = false;
            this.availableCoursesListView.Location = new System.Drawing.Point(13, 68);
            this.availableCoursesListView.MultiSelect = false;
            this.availableCoursesListView.Name = "availableCoursesListView";
            this.availableCoursesListView.Size = new System.Drawing.Size(180, 323);
            this.availableCoursesListView.TabIndex = 2;
            this.availableCoursesListView.UseCompatibleStateImageBehavior = false;
            this.availableCoursesListView.View = System.Windows.Forms.View.List;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(360, 41);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(98, 20);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course Name";
            // 
            // courseIdTextBox
            // 
            this.courseIdTextBox.Location = new System.Drawing.Point(240, 65);
            this.courseIdTextBox.Name = "courseIdTextBox";
            this.courseIdTextBox.ReadOnly = true;
            this.courseIdTextBox.Size = new System.Drawing.Size(93, 27);
            this.courseIdTextBox.TabIndex = 3;
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.Location = new System.Drawing.Point(360, 65);
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.ReadOnly = true;
            this.courseNameTextBox.Size = new System.Drawing.Size(280, 27);
            this.courseNameTextBox.TabIndex = 3;
            // 
            // courseCreditsTextBox
            // 
            this.courseCreditsTextBox.Location = new System.Drawing.Point(240, 130);
            this.courseCreditsTextBox.Name = "courseCreditsTextBox";
            this.courseCreditsTextBox.ReadOnly = true;
            this.courseCreditsTextBox.Size = new System.Drawing.Size(180, 27);
            this.courseCreditsTextBox.TabIndex = 3;
            // 
            // courseCreditsLabel
            // 
            this.courseCreditsLabel.AutoSize = true;
            this.courseCreditsLabel.Location = new System.Drawing.Point(240, 107);
            this.courseCreditsLabel.Name = "courseCreditsLabel";
            this.courseCreditsLabel.Size = new System.Drawing.Size(104, 20);
            this.courseCreditsLabel.TabIndex = 0;
            this.courseCreditsLabel.Text = "Course Credits";
            // 
            // courseGradeLabel
            // 
            this.courseGradeLabel.AutoSize = true;
            this.courseGradeLabel.Location = new System.Drawing.Point(440, 107);
            this.courseGradeLabel.Name = "courseGradeLabel";
            this.courseGradeLabel.Size = new System.Drawing.Size(98, 20);
            this.courseGradeLabel.TabIndex = 0;
            this.courseGradeLabel.Text = "Course Grade";
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
            this.courseGradeComboBox.Location = new System.Drawing.Point(440, 129);
            this.courseGradeComboBox.Name = "courseGradeComboBox";
            this.courseGradeComboBox.Size = new System.Drawing.Size(200, 28);
            this.courseGradeComboBox.TabIndex = 4;
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(240, 180);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(135, 29);
            this.enrollButton.TabIndex = 5;
            this.enrollButton.Text = "Add to Courses";
            this.enrollButton.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(545, 180);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(94, 29);
            this.doneButton.TabIndex = 6;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // Education
            // 
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.courseGradeComboBox);
            this.Controls.Add(this.courseGradeLabel);
            this.Controls.Add(this.courseCreditsLabel);
            this.Controls.Add(this.courseCreditsTextBox);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.courseIdTextBox);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.availableCoursesListView);
            this.Controls.Add(this.viewEnrolledCoursesButton);
            this.Controls.Add(this.courseIdLabel);
            this.Name = "Education";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label courseIdLabel;
        private System.Windows.Forms.Button viewEnrolledCoursesButton;
        private System.Windows.Forms.ListView availableCoursesListView;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.TextBox courseIdTextBox;
        private System.Windows.Forms.TextBox courseNameTextBox;
        private System.Windows.Forms.TextBox courseCreditsTextBox;
        private System.Windows.Forms.Label courseCreditsLabel;
        private System.Windows.Forms.Label courseGradeLabel;
        private System.Windows.Forms.ComboBox courseGradeComboBox;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Button doneButton;
    }
}

