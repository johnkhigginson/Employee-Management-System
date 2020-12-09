using Main_Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Project
{
	internal sealed class Sales : Salary
	{
		public Sales()
		{

		}

		public double commission
        {
			get;
			set;
        }
		public double grossSales
        {
			get;
			set;
        }
	}
}
