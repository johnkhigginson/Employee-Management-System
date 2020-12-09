using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Project
{
    internal sealed class Hourly : Employee
    {
        public Hourly()
        {
        }

        public double hourlyRate
        {
            get;
            set;
        }
        public double hoursWorked
        {
            get;
            set;
        }
    }
}

