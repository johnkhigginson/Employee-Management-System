using System;
using System.Collections.Generic;

namespace Main_Project
{
    internal sealed class BusinessLogic
    {
        BusinessLogic()
        {
            Hourly emp1 = new Hourly();
            emp1.empId = "146-00";
            emp1.empType = empType.Hourly;
            emp1.firstName = "John";
            emp1.lastName = "Higginson";
            emp1.hourlyRate = (Double)11.50;
            emp1.hoursWorked = (Double)36;
            emp1.startDate = "12/25/2012";
            emp1.departmentName = "Data Science";
            emp1.jobTitle = "Data Scientist";
            //emp1.benefits
            emp1.availableCourses = allCourses.ToArray();
            //emp1.coursesTaken
            //emp1.credits
            //emp1.semesterGPA
            emp1.deleted = false;


            Salary emp2 = new Salary();
            emp2.empId = "137-01";
            emp2.empType = empType.Salary;
            emp2.firstName = "Alyssa";
            emp2.lastName = "Higginson";
            emp2.monthlySalary = (Double)3333;
            emp2.startDate = "05/15/2020";
            emp2.departmentName = "Spanish Oaks";
            emp2.jobTitle = "Teacher";
            //emp2.benefits
            emp2.availableCourses = allCourses.ToArray();
            //emp2.coursesTaken
            //emp2.credits
            //emp2.semesterGPA
            emp2.deleted = false;

            Sales emp3 = new Sales();
            emp3.empId = "188-02";
            emp3.empType = empType.Sales;
            emp3.firstName = "Winston";
            emp3.lastName = "Koda";
            emp3.monthlySalary = (Double)8000;
            emp3.commission = (Double)400;
            emp3.grossSales = (Double)800;
            emp3.startDate = "10/22/2019";
            emp3.departmentName = "Custodial";
            emp3.jobTitle = "Janitor";
            //emp3.benefits
            emp3.availableCourses = allCourses.ToArray();
            //emp3.coursesTaken
            //emp3.credits
            //emp3.semesterGPA
            emp3.deleted = false;

            Contract emp4 = new Contract();
            emp4.empId = "166-03";
            emp4.empType = empType.Contract;
            emp4.firstName = "Max";
            emp4.lastName = "Miles";
            emp4.contractWage = (Double)650;
            emp4.startDate = "01/01/2021";
            emp4.departmentName = "Planning Committee";
            emp4.jobTitle = "Party Planner";
            //emp4.benefits
            emp4.availableCourses = allCourses.ToArray();
            //emp4.coursesTaken
            //emp4.credits
            //emp4.semesterGPA
            emp4.deleted = false;

            EmpDictData.Add(emp1.empId, emp1);
            EmpDictData.Add(emp2.empId, emp2);
            EmpDictData.Add(emp3.empId, emp3);
            EmpDictData.Add(emp4.empId, emp4);

            Course cs1400 = new Course();
            cs1400.courseId = "CS1400";
            cs1400.courseName = "Fundamentals of Programming";
            cs1400.courseCredits = 3;

            Course cs1410 = new Course();
            cs1410.courseId = "CS1410";
            cs1410.courseName = "Object Oriented Programming";
            cs1410.courseCredits = 3;

            Course cs2300 = new Course();
            cs2300.courseId = "CS2300";
            cs2300.courseName = "Discrete Mathematical Structures I";
            cs2300.courseCredits = 3;

            Course cs2420 = new Course();
            cs2420.courseId = "CS2420";
            cs2420.courseName = "Algorithms & Data Structures";
            cs2420.courseCredits = 3;

            Course cs2450 = new Course();
            cs2450.courseId = "CS2450";
            cs2450.courseName = "Software Engineering";
            cs2450.courseCredits = 3;

            Course cs2550 = new Course();
            cs2550.courseId = "CS2550";
            cs2550.courseName = "Web Programming I";
            cs2550.courseCredits = 3;

            Course cs2600 = new Course();
            cs2600.courseId = "CS2600";
            cs2600.courseName = "Computer Networks I";
            cs2600.courseCredits = 3;

            Course cs2810 = new Course();
            cs2810.courseId = "CS2810";
            cs2810.courseName = "Computer Architecture";
            cs2810.courseCredits = 3;

            Course cs3060 = new Course();
            cs3060.courseId = "CS3060";
            cs3060.courseName = "Operating Systems";
            cs3060.courseCredits = 3;

            Course cs3240 = new Course();
            cs3240.courseId = "CS3240";
            cs3240.courseName = "Discrete Mathematical Structures II";
            cs3240.courseCredits = 3;

            Course cs3260 = new Course();
            cs3260.courseId = "CS3260";
            cs3260.courseName = "C# Software Development";
            cs3260.courseCredits = 3;

            Course cs3370 = new Course();
            cs3370.courseId = "CS3370";
            cs3370.courseName = "C++ Software Development";
            cs3370.courseCredits = 3;

            Course cs3520 = new Course();
            cs3520.courseId = "CS3520";
            cs3520.courseName = "Database Theory";
            cs3520.courseCredits = 3;

            CourseDictData.Add(cs1400.courseId, cs1400);
            CourseDictData.Add(cs1410.courseId, cs1410);
            CourseDictData.Add(cs2300.courseId, cs2300);
            CourseDictData.Add(cs2420.courseId, cs2420);
            CourseDictData.Add(cs2450.courseId, cs2450);
            CourseDictData.Add(cs2550.courseId, cs2550);
            CourseDictData.Add(cs2600.courseId, cs2600);
            CourseDictData.Add(cs2810.courseId, cs2810);
            CourseDictData.Add(cs3060.courseId, cs3060);
            CourseDictData.Add(cs3240.courseId, cs3240);
            CourseDictData.Add(cs3260.courseId, cs3260);
            CourseDictData.Add(cs3370.courseId, cs3370);
            CourseDictData.Add(cs3520.courseId, cs3520);
        }
        private static readonly object padlock = new object();
        private static BusinessLogic instance = null;
        public static BusinessLogic Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new BusinessLogic();
                    }
                    return instance;
                }
            }
        }

        private SortedDictionary<string, dynamic> EmpDictData = new SortedDictionary<string, dynamic>();
        private SortedDictionary<string, dynamic> SortedDictData = new SortedDictionary<string, dynamic>();
        private SortedDictionary<string, dynamic> DeletedDictData = new SortedDictionary<string, dynamic>();
        private SortedDictionary<string, dynamic> CourseDictData = new SortedDictionary<string, dynamic>();
        private SortedDictionary<string, dynamic> EmployeeCourseData = new SortedDictionary<string, dynamic>();
        private int empCounter = 4;

        public SortedDictionary<string, dynamic> EmpDict
        {
            get { return EmpDictData; }
        }

        public SortedDictionary<string, dynamic> CourseDict
        {
            get { return CourseDictData; }
        }

        public SortedDictionary<string, dynamic> EnrollCourse(Employee empInfo, string courseId)
        {
            foreach (KeyValuePair<string, dynamic> pair in EmpDictData)
            {
                if (empInfo.empId == pair.Key)
                {

                    string addCourse = courseId;
                    int y = 0;
                    List<string> list = new List<string>();
                    List<string> list2 = new List<string>();
                    if (empInfo.coursesTaken != null)
                    {
                        foreach (string x in empInfo.coursesTaken)
                        {
                            list.Add(x);
                        }
                        foreach (string x in empInfo.coursesTaken)
                        {
                            if (x.Contains(addCourse))
                            {
                                y = 0;
                            }
                            else
                            {
                                y = 1;
                            }
                        }
                        if (y == 0)
                        {
                            empInfo.coursesTaken = list.ToArray();
                            return EmpDictData;
                        }
                        else
                        {
                            list.Add(addCourse);
                            empInfo.coursesTaken = list.ToArray();
                            return EmpDictData;
                        }
                    }
                    else
                    {
                        list.Add(addCourse);
                        empInfo.coursesTaken = list.ToArray();
                        return EmpDictData;
                    }

                }
            }
            return EmpDictData;
        }

        public SortedDictionary<string, dynamic> AddEmployee(Employee empInfo)
        {
            string idNum;
            if(empCounter < 10)
            {
                idNum = "0" + empCounter.ToString();
            }
            else
            {
                idNum = empCounter.ToString();
            }
            string empIdStr = empInfo.firstName[0] + empInfo.lastName[0] + "-" + idNum;
            empInfo.availableCourses = allCourses.ToArray();
            empInfo.deleted = false;
            empInfo.empId = empIdStr;
            EmpDictData.Add(empIdStr, empInfo);
            empCounter++;
            return EmpDictData;
        }
        public SortedDictionary<string, dynamic> EditEmployee(Employee empInfo)
        {
            ;
            foreach (KeyValuePair<string, dynamic> pair in EmpDictData)
            {
                if (pair.Key == empInfo.empId)
                {
                    EmpDictData.Remove(pair.Key);
                    EmpDictData.Add(empInfo.empId, empInfo);
                    return EmpDictData;
                }
            }
            return EmpDictData;

        }



        public void DeleteEmployee(string empId)
        {
            EmpDictData[empId].deleted = true;
            DeletedDictData.Add(empId, EmpDictData[empId]);
            EmpDictData.Remove(empId);
        }

        public SortedDictionary<string, dynamic> SearchEmployee(string searchString)
        {
            SortedDictData.Clear();
            foreach (KeyValuePair<string, dynamic> pair in EmpDictData)
            {
                string fullName = pair.Value.firstName.ToLower() + " " + pair.Value.lastName.ToLower();

                if (pair.Key.ToLower().Contains(searchString.ToLower()) || searchString != "" && fullName.Contains(searchString.ToLower()))
                {
                    SortedDictData.Add(pair.Key, pair.Value);
                }
                else if (searchString == "")
                {
                    SortedDictData = EmpDictData;
                }
            }
            return SortedDictData;
        }

        private List<string> grades = new List<string>()
        {
            "A", //4.00
            "A-", //3.67
            "B+", //3.33
            "B", //3.00
            "B-", //2.67
            "C+", //2.33
            "C", //2.00
            "C-", //1.67
            "D+", //1.33
            "D", //1.00
            "D-", //0.67
            "E", //0.00
            "AU", //unsatisfactory??
            "IC", //incomplete (0.00)
            "WD" //no effect
        };

        List<string> allCourses = new List<string>()
        { 
            "CS1400",
            "CS1410",
            "CS2300",
            "CS2420",
            "CS2450",
            "CS2550",
            "CS2600",
            "CS2810",
            "CS3060", 
            "CS3240", 
            "CS3260", 
            "CS3370", 
            "CS3520"
        };

        public SortedDictionary<string, dynamic> EducationData = new SortedDictionary<string, dynamic>();
        private bool EducationalBenefits(Employee emp)
        {
            /*
                int salaryCredits = 6; //if grade >= B
                int hourlyCredits = 3; //if grade >= B+
                int salesCredits = 5; //if grade >= C
                //int contractCredits = 0; //no benefits
            */

            if(emp.empType == empType.Hourly)
            {
                if(emp.semesterGPA >= 3.33)
                {
                    emp.benefits = 3;
                    return true;
                }
                else
                {
                    emp.benefits = 0;
                    return false;
                }
            }
            else if(emp.empType == empType.Salary)
            {
                if (emp.semesterGPA >= 3.00)
                {
                    emp.benefits = 6;
                    return true;
                }
                else
                {
                    emp.benefits = 0;
                    return false;
                }
            }
            else if(emp.empType == empType.Sales)
            {
                if (emp.semesterGPA >= 2.00)
                {
                    emp.benefits = 5;
                    return true;
                }
                else
                {
                    emp.benefits = 0;
                    return false;
                }
            }
            else if(emp.empType == empType.Contract)
            {
                emp.benefits = 0;
                return false;
            }
            else
            {
                emp.benefits = 0;
                return false;
            }
        }
    }
}
