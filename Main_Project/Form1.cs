using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Main_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            empTypeComboBox.SelectedIndexChanged += empTypeComboBox_IndexSelectedChanged;
            empList.SelectedIndexChanged += empList_SelectionChanged;
            deletedEmpList.SelectedIndexChanged += deletedEmpList_SelectionChanged;
            saveButton.Click += saveButton_Click;
            delete_Button.Click += delete_button_Click;
            cancelButton.Click += cancelButton_Click;
            newEmployeeButton.Click += newEmployeeButton_Click;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            searchTextBox.Click += searchTextBox_Click;
            aboutMenuItem.Click += aboutMenuItem_Click;
            exitMenuItem.Click += exitMenuItem_Click;
            openDBMenuItem.Click += openDBMenuItem_Click;
            saveDBMenuItem.Click += saveDBMenuItem_Click;

            activeMenuItem.Click += activeMenuItem_Click;
            deletedMenuItem.Click += deletedMenuItem_Click;

            educationButton.Click += educationButton_Click;
            workButton.Click += workButton_Click;

            enrollButton.Click += enrollButton_Click;
            availableCoursesList.SelectedIndexChanged += availableCoursesList_SelectionChanged;
            coursesTakenList.SelectedIndexChanged += coursesTakenList_SelectionChanged;

            viewAvailableCoursesButton.Click += viewAvailableCourses_Click;
            viewEnrolledCoursesButton.Click += viewEnrolledCourses_Click;
        }

        SortedDictionary<string, dynamic> EmployeeList = new SortedDictionary<string, dynamic>();
        SortedDictionary<string, dynamic> DeletedEmployeeList = new SortedDictionary<string, dynamic>();
        SortedDictionary<string, dynamic> CourseList = new SortedDictionary<string, dynamic>();
        private BusinessLogic businessLogic = BusinessLogic.Instance;
        bool isEdit;
        private FileIO inst = FileIO.Instance;
        private SaveFileDialog saveFile = new SaveFileDialog();
        private OpenFileDialog openFile = new OpenFileDialog();
        //Form2 educationForm = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            if (courseGradeComboBox.Text == "")
            {
                checkFieldsLabel.Text = "Check Required Fields";
            }
            else
            {
                string emp = empIdTextBox.Text;
                string course = courseIdTextBox.Text;
                checkFieldsLabel.Text = "";

                Employee empInfo = EmployeeList[emp];

                businessLogic.EnrollCourse(empInfo, course);

                List<string> list = new List<string>();
                availableCoursesList.Items.Clear();
                foreach (string x in empInfo.availableCourses)
                {
                    if (x.Contains(course))
                    {

                    }
                    else
                    {
                        availableCoursesList.Items.Add(x);
                        list.Add(x);
                    }
                }
                empInfo.availableCourses = list.ToArray();

                coursesTakenList.Items.Clear();
                foreach (string x in empInfo.coursesTaken)
                {
                    coursesTakenList.Items.Add(x);
                }
                Course enrolledCourse = businessLogic.CourseDict[course];
                empInfo.credits = empInfo.credits + enrolledCourse.courseCredits;

                /*
                double a = 4;
                double am = 3.67;
                double bp = 3.33;
                double b = 3;
                double bm = 2.67;
                double cp = 2.33;
                double c = 2;
                double cm = 1.67;
                double dp = 1.33;
                double d = 1;
                double dm = 0.67;
                double e = 0;
                double au = 0;
                double ic = 0;
                */

                double grade;
                if(courseGradeComboBox.Text == "A")
                {
                    grade = 4;
                }
                else if(courseGradeComboBox.Text == "A-")
                {
                    grade = 3.67;
                }
                else if (courseGradeComboBox.Text == "B+")
                {
                    grade = 3.33;
                }
                else if (courseGradeComboBox.Text == "B")
                {
                    grade = 3;
                }
                else if (courseGradeComboBox.Text == "B-")
                {
                    grade = 2.67;
                }
                else if (courseGradeComboBox.Text == "C+")
                {
                    grade = 2.33;
                }
                else if (courseGradeComboBox.Text == "C")
                {
                    grade = 2;
                }
                else if (courseGradeComboBox.Text == "C-")
                {
                    grade = 1.67;
                }
                else if (courseGradeComboBox.Text == "D+")
                {
                    grade = 1.33;
                }
                else if (courseGradeComboBox.Text == "D")
                {
                    grade = 1;
                }
                else if (courseGradeComboBox.Text == "D-")
                {
                    grade = 1.67;
                }
                else if (courseGradeComboBox.Text == "E" || courseGradeComboBox.Text == "AU" || courseGradeComboBox.Text == "IC")
                {
                    grade = 0;
                }
                else
                {
                    grade = 0;
                }

                double courseGPA = Convert.ToDouble(enrolledCourse.courseCredits) * grade;
                empInfo.grade = empInfo.grade + courseGPA;

                empInfo.semesterGPA = empInfo.grade / empInfo.credits;
                if(empInfo.empType == empType.Hourly)
                {
                    if(empInfo.semesterGPA >= 3.33)
                    {
                        empInfo.benefits = 3;
                    }
                    else
                    {
                        empInfo.benefits = 0;
                    }
                }
                else if(empInfo.empType == empType.Salary)
                {
                    if(empInfo.semesterGPA >= 3)
                    {
                        empInfo.benefits = 6;
                    }
                    else
                    {
                        empInfo.benefits = 0;
                    }
                }
                else if (empInfo.empType == empType.Sales)
                {
                    if (empInfo.semesterGPA >= 2)
                    {
                        empInfo.benefits = 5;
                    }
                    else
                    {
                        empInfo.benefits = 0;
                    }
                }
                else if(empInfo.empType == empType.Hourly)
                {
                    empInfo.benefits = 0;
                }
                benefitsTextBox.Text = empInfo.benefits.ToString();
            }
        }

        private void availableCoursesList_SelectionChanged(object sender, EventArgs e)
        {
            Course selectedCourse = businessLogic.CourseDict[availableCoursesList.SelectedItem.ToString()];
            courseIdTextBox.Text = selectedCourse.courseId;
            courseNameTextBox.Text = selectedCourse.courseName;
            courseCreditsTextBox.Text = selectedCourse.courseCredits.ToString();
        }

        private void coursesTakenList_SelectionChanged(object sender, EventArgs e)
        {
            Course selectedCourse = businessLogic.CourseDict[coursesTakenList.SelectedItem.ToString()];
            courseIdTextBox.Text = selectedCourse.courseId;
            courseNameTextBox.Text = selectedCourse.courseName;
            courseCreditsTextBox.Text = selectedCourse.courseCredits.ToString();
        }

        private void viewEnrolledCourses_Click(object sender, EventArgs e)
        {
            viewEnrolledCoursesButton.Visible = false;
            availableCoursesList.Visible = false;
            enrollButton.Visible = false;
            courseGradeComboBox.Enabled = false;

            viewAvailableCoursesButton.Visible = true;
            coursesTakenList.Visible = true;
        }

        private void viewAvailableCourses_Click(object sender, EventArgs e)
        {
            viewEnrolledCoursesButton.Visible = true;
            availableCoursesList.Visible = true;
            enrollButton.Visible = true;
            courseGradeComboBox.Enabled = true;

            viewAvailableCoursesButton.Visible = false;
            coursesTakenList.Visible = false;
        }

        private void educationButton_Click(object sender, EventArgs e)
        {
            //educationForm.Show();
            showEducation();
            clearWork();

            clearButtons();

            delete_Button.Visible = false;
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            showWork();
            clearEducation();

            showButtons();

            delete_Button.Visible = true;
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Main Project - Employee Database Management System\nBy: John K Higginson");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string empInfo = Convert.ToString(empList.SelectedItem);
            string[] empInfoSplit = empInfo.Split(" ");
            string selected = empInfoSplit[3];

            DeletedEmployeeList.Add(selected, EmployeeList[selected]);
            businessLogic.DeleteEmployee(selected);

            clearButtons();
            clearInput();

            clearHourly();
            clearSalary();
            clearSales();
            clearContract();

            delete_Button.Visible = false;

            empList.Items.Remove(empInfo);
            foreach (KeyValuePair<string, dynamic> pair in DeletedEmployeeList)
            {
                deletedEmpList.Items.Add(pair.Value.firstName + " " + pair.Value.lastName + " - " + pair.Key);
            }
        }

        private void openDBMenuItem_Click(object sender, EventArgs e)
        {
            /*
            FileIO inst = FileIO.Instance;
            inst.EmployeeDB = businessLogic.EmpDict;
            inst.OpenFileDB();
            inst.ReadDB(); 
            */
            openFile.ShowDialog();
            //foreach(Employee empId in openFile.)
        }

        private void saveDBMenuItem_Click(object sender, EventArgs e)
        {
            /*
            inst.SaveFileDB();
            inst.WriteDB();
            */
            saveFile.ShowDialog();
            string path = saveFile.FileName;
            File.WriteAllText(path, empList.Items.ToString());
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            delete_Button.Visible = false;
            empList.Visible = true;
            deletedEmpList.Visible = false;
            clearInput();

            newEmployee();
            clearHourly();
            clearSalary();
            clearSales();
            clearContract();

            showInput();
        }

        private void empList_SelectionChanged(object sender, EventArgs e)
        {
            delete_Button.Visible = true;
            try
            {
                string empInfo = Convert.ToString(empList.SelectedItem);
                string[] empInfoList = empInfo.Split(" ");
                string empId = empInfoList[3];
                Employee selectedEmployee = EmployeeList[empId];
                availableCoursesList.Items.Clear();
                benefitsTextBox.Text = selectedEmployee.benefits.ToString();
                foreach(string x in selectedEmployee.availableCourses)
                {
                    availableCoursesList.Items.Add(x);
                }

                firstNameTextBox.Text = selectedEmployee.firstName;
                lastNameTextBox.Text = selectedEmployee.lastName;

                startDatePicker.Value = Convert.ToDateTime(selectedEmployee.startDate);
                departmentTextBox.Text = selectedEmployee.departmentName;
                jobTitleTextBox.Text = selectedEmployee.jobTitle;

                foreach (KeyValuePair<string, dynamic> pair in EmployeeList)
                {
                    if (pair.Key == empInfoList[3])
                    {
                        if (pair.Value.empType == empType.Hourly)
                        {
                            clearSalary();
                            clearSales();
                            clearContract();

                            showInput();
                            showButtons();
                            showHourly();

                            empTypeComboBox.SelectedIndex = 0;
                            empTypeComboBox.Text = "Hourly";

                            string hrRate = Convert.ToString(pair.Value.hourlyRate);
                            string hrsWorked = Convert.ToString(pair.Value.hoursWorked);

                            hourlyRateTextBox.Text = hrRate;
                            hoursWorkedTextBox.Text = hrsWorked;
                            empIdTextBox.Text = pair.Key;
                        }
                        else if (pair.Value.empType == empType.Salary)
                        {
                            clearHourly();
                            clearSales();
                            clearContract();

                            showInput();
                            showButtons();
                            showSalary();

                            empTypeComboBox.SelectedIndex = 1;
                            empTypeComboBox.Text = "Salary";

                            string mnsal = Convert.ToString(pair.Value.monthlySalary);

                            monthlySalaryTextBox.Text = mnsal;
                            empIdTextBox.Text = pair.Key;
                        }
                        else if (pair.Value.empType == empType.Sales)
                        {
                            clearHourly();
                            clearSalary();
                            clearContract();

                            showInput();
                            showButtons();
                            showSales();

                            empTypeComboBox.SelectedIndex = 2;
                            empTypeComboBox.Text = "Sales";

                            string mnsal = Convert.ToString(pair.Value.monthlySalary);
                            string comm = Convert.ToString(pair.Value.commission);
                            string grSa = Convert.ToString(pair.Value.grossSales);

                            monthlySalaryTextBox.Text = mnsal;
                            commissionTextBox.Text = comm;
                            grossSalesTextBox.Text = grSa;
                            empIdTextBox.Text = pair.Key;
                        }
                        else if (pair.Value.empType == empType.Contract)
                        {
                            clearHourly();
                            clearSales();
                            clearSalary();


                            showInput();
                            showButtons();
                            showContract();

                            empTypeComboBox.SelectedIndex = 3;
                            empTypeComboBox.Text = "Contract";

                            string conWa = Convert.ToString(pair.Value.contractWage);

                            contractWageTextBox.Text = conWa;
                            empIdTextBox.Text = pair.Key;
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void deletedEmpList_SelectionChanged(object sender, EventArgs e)
        {
            delete_Button.Visible = false;
            try
            {
                string empInfo = Convert.ToString(deletedEmpList.SelectedItem);
                string[] empInfoList = empInfo.Split(" ");
                string empId = empInfoList[3];
                Employee selectedEmployee = DeletedEmployeeList[empId];

                firstNameTextBox.Text = selectedEmployee.firstName;
                lastNameTextBox.Text = selectedEmployee.lastName;

                startDatePicker.Value = Convert.ToDateTime(selectedEmployee.startDate);
                departmentTextBox.Text = selectedEmployee.departmentName;
                jobTitleTextBox.Text = selectedEmployee.jobTitle;

                foreach (KeyValuePair<string, dynamic> pair in EmployeeList)
                {
                    if (pair.Key == empInfoList[3])
                    {
                        if (pair.Value.empType == empType.Hourly)
                        {
                            clearSalary();
                            clearSales();
                            clearContract();

                            showInput();
                            showButtons();
                            showHourly();

                            empTypeComboBox.SelectedIndex = 0;
                            empTypeComboBox.Text = "Hourly";

                            string hrRate = Convert.ToString(pair.Value.hourlyRate);
                            string hrsWorked = Convert.ToString(pair.Value.hoursWorked);

                            hourlyRateTextBox.Text = hrRate;
                            hoursWorkedTextBox.Text = hrsWorked;
                            empIdTextBox.Text = pair.Key;
                        }
                        else if (pair.Value.empType == empType.Salary)
                        {
                            clearHourly();
                            clearSales();
                            clearContract();

                            showInput();
                            showButtons();
                            showSalary();

                            empTypeComboBox.SelectedIndex = 1;
                            empTypeComboBox.Text = "Salary";

                            string mnsal = Convert.ToString(pair.Value.monthlySalary);

                            monthlySalaryTextBox.Text = mnsal;
                            empIdTextBox.Text = pair.Key;
                        }
                        else if (pair.Value.empType == empType.Sales)
                        {
                            clearHourly();
                            clearSalary();
                            clearContract();

                            showInput();
                            showButtons();
                            showSales();

                            empTypeComboBox.SelectedIndex = 2;
                            empTypeComboBox.Text = "Sales";

                            string mnsal = Convert.ToString(pair.Value.monthlySalary);
                            string comm = Convert.ToString(pair.Value.commission);
                            string grSa = Convert.ToString(pair.Value.grossSales);

                            monthlySalaryTextBox.Text = mnsal;
                            commissionTextBox.Text = comm;
                            grossSalesTextBox.Text = grSa;
                            empIdTextBox.Text = pair.Key;
                        }
                        else if (pair.Value.empType == empType.Contract)
                        {
                            clearHourly();
                            clearSales();
                            clearSalary();


                            showInput();
                            showButtons();
                            showContract();

                            empTypeComboBox.SelectedIndex = 3;
                            empTypeComboBox.Text = "Contract";

                            string conWa = Convert.ToString(pair.Value.contractWage);

                            contractWageTextBox.Text = conWa;
                            empIdTextBox.Text = pair.Key;
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            delete_Button.Visible = true;
            int newEmpType = empTypeComboBox.SelectedIndex;
            if (firstNameTextBox.Text != "" && lastNameLabel.Text != "")
            {
                checkFieldsLabel.Text = "";
                if (newEmpType == 0)
                {
                    if (hourlyRateTextBox.Text != "" && hoursWorkedTextBox.Text != "")
                    {
                        Hourly newEmp = new Hourly();
                        newEmp.empType = empType.Hourly;
                        newEmp.hourlyRate = Double.Parse(hourlyRateTextBox.Text);
                        newEmp.hoursWorked = Double.Parse(hoursWorkedTextBox.Text);
                        newEmp.firstName = firstNameTextBox.Text;
                        newEmp.lastName = lastNameTextBox.Text;
                        newEmp.startDate = startDatePicker.Value.ToString();
                        newEmp.departmentName = departmentTextBox.Text;
                        newEmp.jobTitle = jobTitleTextBox.Text;
                        newEmp.deleted = false;
                        empList.Items.Clear();
                        if (!isEdit)
                        {
                            EmployeeList = businessLogic.AddEmployee(newEmp);
                        }
                        else
                        {
                            newEmp.empId = empIdTextBox.Text;
                            EmployeeList = businessLogic.EditEmployee(newEmp);
                            isEdit = false;
                        }
                    }
                    else
                    {
                        checkFieldsLabel.Text = "Check Required Fields";
                    }
                    foreach (KeyValuePair<string, dynamic> pair in EmployeeList)
                    {
                        empList.Items.Add(pair.Value.firstName + " " + pair.Value.lastName + " - " + pair.Key);
                    }
                }
                else if (newEmpType == 1)
                {
                    if (monthlySalaryTextBox.Text != "")
                    {
                        Salary newEmp = new Salary();
                        newEmp.empType = empType.Salary;
                        newEmp.monthlySalary = Double.Parse(monthlySalaryTextBox.Text);
                        newEmp.firstName = firstNameTextBox.Text;
                        newEmp.lastName = lastNameTextBox.Text;
                        newEmp.startDate = startDatePicker.Value.ToString();
                        newEmp.departmentName = departmentTextBox.Text;
                        newEmp.jobTitle = jobTitleTextBox.Text;
                        newEmp.deleted = false;
                        empList.Items.Clear();
                        if (!isEdit)
                        {
                            EmployeeList = businessLogic.AddEmployee(newEmp);
                        }
                        else
                        {
                            newEmp.empId = empIdTextBox.Text;
                            EmployeeList = businessLogic.EditEmployee(newEmp);
                            isEdit = false;
                        }
                        foreach (KeyValuePair<string, dynamic> pair in EmployeeList)
                        {
                            empList.Items.Add(pair.Value.firstName + " " + pair.Value.lastName + " - " + pair.Key);
                        }
                    }
                    else
                    {
                        checkFieldsLabel.Text = "Check Required Fields";
                    }
                }
                else if (newEmpType == 2)
                {
                    if (monthlySalaryTextBox.Text != "" && commissionTextBox.Text != "" && grossSalesTextBox.Text != "")
                    {
                        Sales newEmp = new Sales();
                        newEmp.empType = empType.Hourly;
                        newEmp.monthlySalary = Double.Parse(monthlySalaryTextBox.Text);
                        newEmp.commission = Double.Parse(commissionTextBox.Text);
                        newEmp.grossSales = Double.Parse(grossSalesTextBox.Text);
                        newEmp.firstName = firstNameTextBox.Text;
                        newEmp.lastName = lastNameTextBox.Text;
                        newEmp.startDate = startDatePicker.Value.ToString();
                        newEmp.departmentName = departmentTextBox.Text;
                        newEmp.jobTitle = jobTitleTextBox.Text;
                        newEmp.deleted = false;
                        empList.Items.Clear();
                        if (!isEdit)
                        {
                            EmployeeList = businessLogic.AddEmployee(newEmp);
                        }
                        else
                        {
                            newEmp.empId = empIdTextBox.Text;
                            EmployeeList = businessLogic.EditEmployee(newEmp);
                            isEdit = false;
                        }
                        foreach (KeyValuePair<string, dynamic> pair in EmployeeList)
                        {
                            empList.Items.Add(pair.Value.firstName + " " + pair.Value.lastName + " - " + pair.Key);
                        }
                    }
                    else
                    {
                        checkFieldsLabel.Text = "Check Required Fields";
                    }
                }
                else if (newEmpType == 3)
                {
                    if (contractWageTextBox.Text != "")
                    {
                        Contract newEmp = new Contract();
                        newEmp.empType = empType.Hourly;
                        newEmp.contractWage = Double.Parse(contractWageTextBox.Text);
                        newEmp.firstName = firstNameTextBox.Text;
                        newEmp.lastName = lastNameTextBox.Text;
                        newEmp.startDate = startDatePicker.Value.ToString();
                        newEmp.departmentName = departmentTextBox.Text;
                        newEmp.jobTitle = jobTitleTextBox.Text;
                        newEmp.deleted = false;
                        empList.Items.Clear();
                        if (!isEdit)
                        {
                            EmployeeList = businessLogic.AddEmployee(newEmp);
                        }
                        else
                        {
                            newEmp.empId = empIdTextBox.Text;
                            EmployeeList = businessLogic.EditEmployee(newEmp);
                            isEdit = false;
                        }
                        foreach (KeyValuePair<string, dynamic> pair in EmployeeList)
                        {
                            empList.Items.Add(pair.Value.firstName + " " + pair.Value.lastName + " - " + pair.Key);
                        }
                    }
                    else
                    {
                        checkFieldsLabel.Text = "Check Required Fields";
                    }
                }

                clearHourly();
                clearSalary();
                clearSales();
                clearContract();
            }
            else
            {
                checkFieldsLabel.Text = "Check Required Fields";
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            empTypeComboBox.Text = "";
            indexIndicator.Text = "-";
            clearHourly();
            clearSalary();
            clearSales();
            clearContract();

            clearInput();
            clearButtons();

            delete_Button.Visible = false;
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        void clearEducation()
        {
            viewEnrolledCoursesButton.Visible = false;
            availableCoursesList.Visible = false;

            viewAvailableCoursesButton.Visible = false;
            coursesTakenList.Visible = false;

            courseIdLabel.Visible = false;
            courseIdTextBox.Visible = false;

            courseNameLabel.Visible = false;
            courseNameTextBox.Visible = false;

            courseCreditsLabel.Visible = false;
            courseCreditsTextBox.Visible = false;

            courseGradeLabel.Visible = false;
            courseGradeComboBox.Visible = false;

            benefitsLabel.Visible = false;
            benefitsTextBox.Visible = false;

            enrollButton.Visible = false;

            workButton.Visible = false;
        }

        void showEducation()
        {
            viewEnrolledCoursesButton.Visible = true;
            availableCoursesList.Visible = true;

            courseIdLabel.Visible = true;
            courseIdTextBox.Visible = true;

            courseNameLabel.Visible = true;
            courseNameTextBox.Visible = true;

            courseCreditsLabel.Visible = true;
            courseCreditsTextBox.Visible = true;

            courseGradeLabel.Visible = true;
            courseGradeComboBox.Visible = true;
            courseGradeComboBox.Enabled = true;

            benefitsLabel.Visible = true;
            benefitsTextBox.Visible = true;

            enrollButton.Visible = true;

            workButton.Visible = true;

            firstNameTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;

            empTypeComboBox.Enabled = false;
        }

        void clearWork()
        {
            clearHourly();
            clearSalary();
            clearSales();
            clearContract();

            startDateLabel.Visible = false;
            startDatePicker.Visible = false;

            departmentLabel.Visible = false;
            departmentTextBox.Visible = false;

            jobTitleLabel.Visible = false;
            jobTitleTextBox.Visible = false;

            educationButton.Visible = false;

            newEmployeeButton.Visible = false;
            empList.Visible = false;
            searchTextBox.Visible = false;
        }

        void showWork()
        {
            firstNameTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;

            empTypeComboBox.Enabled = true;

            if (empTypeComboBox.SelectedIndex == 0)
            {
                showHourly();
            }
            else if (empTypeComboBox.SelectedIndex == 1)
            {
                showSalary();
            }
            else if (empTypeComboBox.SelectedIndex == 2)
            {
                showSales();
            }
            else if (empTypeComboBox.SelectedIndex == 3)
            {
                showContract();
            }

            startDateLabel.Visible = true;
            startDatePicker.Visible = true;

            departmentLabel.Visible = true;
            departmentTextBox.Visible = true;

            jobTitleLabel.Visible = true;
            jobTitleTextBox.Visible = true;

            //show education button because work menu will currently be showing
            educationButton.Visible = true;

            newEmployeeButton.Visible = true;
            empList.Visible = true;
            searchTextBox.Visible = true;
        }

        void newEmployee()
        {
            //work
            hourlyRateTextBox.Text = "";
            hoursWorkedTextBox.Text = "";
            monthlySalaryTextBox.Text = "";
            monthlySalaryTextBox.Text = "";
            commissionTextBox.Text = "";
            grossSalesTextBox.Text = "";
            contractWageTextBox.Text = "";
        }

        void clearInput()
        {
            employeeIDLabel.Visible = false;
            empIdTextBox.Visible = false;

            firstNameLabel.Visible = false;
            firstNameTextBox.Visible = false;
            firstNameTextBox.Text = "";

            lastNameLabel.Visible = false;
            lastNameTextBox.Visible = false;
            lastNameTextBox.Text = "";

            employeeTypeLabel.Visible = false;
            empTypeComboBox.Visible = false;
            empTypeComboBox.Text = "";

            startDateLabel.Visible = false;
            startDatePicker.Visible = false;
            startDatePicker.Value = DateTime.Today;

            departmentLabel.Visible = false;
            departmentTextBox.Visible = false;
            departmentTextBox.Text = "";

            jobTitleLabel.Visible = false;
            jobTitleTextBox.Visible = false;
            jobTitleTextBox.Text = "";

            requiredFieldsLabel.Visible = false;

            educationButton.Visible = false;
        }

        void showInput()
        {
            employeeIDLabel.Visible = true;
            empIdTextBox.Visible = true;

            firstNameLabel.Visible = true;
            firstNameTextBox.Visible = true;

            lastNameLabel.Visible = true;
            lastNameTextBox.Visible = true;

            employeeTypeLabel.Visible = true;
            empTypeComboBox.Visible = true;

            startDateLabel.Visible = true;
            startDatePicker.Visible = true;

            departmentLabel.Visible = true;
            departmentTextBox.Visible = true;

            jobTitleLabel.Visible = true;
            jobTitleTextBox.Visible = true;

            requiredFieldsLabel.Visible = true;

            educationButton.Visible = true;
        }

        void clearButtons()
        {
            saveButton.Visible = false;
            cancelButton.Visible = false;
        }

        void showButtons()
        {
            saveButton.Visible = true;
            cancelButton.Visible = true;
        }

        void clearHourly()
        {
            hourlyRateLabel.Visible = false;
            hourlyRateTextBox.Visible = false;

            hoursWorkedLabel.Visible = false;
            hoursWorkedTextBox.Visible = false;
        }

        void clearSalary()
        {
            monthlySalaryLabel.Visible = false;
            monthlySalaryTextBox.Visible = false;
        }

        void clearSales()
        {
            monthlySalaryLabel.Visible = false;
            monthlySalaryTextBox.Visible = false;
            commissionLabel.Visible = false;
            commissionTextBox.Visible = false;
            grossSalesLabel.Visible = false;
            grossSalesTextBox.Visible = false;
        }

        void clearContract()
        {
            contractWageLabel.Visible = false;
            contractWageTextBox.Visible = false;
        }

        void showHourly()
        {
            hourlyRateLabel.Visible = true;
            hourlyRateTextBox.Visible = true;

            hoursWorkedLabel.Visible = true;
            hoursWorkedTextBox.Visible = true;
        }

        void showSalary()
        {
            monthlySalaryLabel.Visible = true;
            monthlySalaryTextBox.Visible = true;
        }

        void showSales()
        {
            monthlySalaryLabel.Visible = true;
            monthlySalaryTextBox.Visible = true;

            commissionLabel.Visible = true;
            commissionTextBox.Visible = true;

            grossSalesLabel.Visible = true;
            grossSalesTextBox.Visible = true;
        }

        void showContract()
        {
            contractWageLabel.Visible = true;
            contractWageTextBox.Visible = true;
        }
        private void empTypeComboBox_IndexSelectedChanged(object sender, EventArgs e)
        {
            showButtons();
            int selectedType = empTypeComboBox.SelectedIndex;
            indexIndicator.Text = selectedType.ToString();

            if (selectedType == 0)
            {
                clearHourly();
                clearSalary();
                clearSales();
                clearContract();

                showHourly();
            }

            else if (selectedType == 1)
            {
                clearHourly();
                clearSalary();
                clearSales();
                clearContract();

                showSalary();
            }

            else if (selectedType == 2)
            {
                clearHourly();
                clearSalary();
                clearSales();
                clearContract();

                showSales();
            }

            else if (selectedType == 3)
            {
                clearHourly();
                clearSalary();
                clearSales();
                clearContract();

                showContract();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchTextBox.ForeColor = System.Drawing.Color.Black;
            string customSearch = searchTextBox.Text;
            EmployeeList = businessLogic.SearchEmployee(customSearch);

            empList.Items.Clear();
            string employee;
            foreach (KeyValuePair<string, dynamic> pair in EmployeeList)
            {
                employee = (pair.Value.firstName + " " + pair.Value.lastName + " - " + pair.Key);
                empList.Items.Add(employee);
            }

        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.ForeColor = System.Drawing.Color.Black;
        }

        private void activeMenuItem_Click(object sender, EventArgs e)
        {
            showWork();
            clearEducation();
            deletedEmpList.Visible = false;
        }

        private void deletedMenuItem_Click(object sender, EventArgs e)
        {
            showWork();
            clearHourly();
            clearSalary();
            clearSales();
            clearContract();
            clearEducation();
            empList.Visible = false;
            deletedEmpList.Visible = true;
            delete_Button.Visible = false;
        }

    }
}
