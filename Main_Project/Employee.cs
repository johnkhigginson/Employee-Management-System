using System;

namespace Main_Project
{
    internal abstract class Employee
    {
        public Employee()
        {

        }

        public string empId
        {
            get;
            set;
        }

        public empType empType
        {
            get;
            set;
        }

        public string firstName
        {
            get;
            set;
        }

        public string fullName
        {
            get;
            set;
        }

        public string lastName
        {
            get;
            set;
        }

        public string departmentName
        {
            get;
            set;
        }

        public string jobTitle
        {
            get;
            set;
        }

        public string startDate
        {
            get;
            set;
        }

        public int benefits
        {
            get;
            set;
        }
        
        public string[] availableCourses
        {
            get;
            set;
        }
        public string[] coursesTaken
        {
            get;
            set;
        }

        public int credits
        {
            get;
            set;
        }

        public double grade
        {
            get;
            set;
        }

        public double semesterGPA
        {
            get;
            set;
        }

        public bool deleted
        {
            get;
            set;
        }
    }
}
