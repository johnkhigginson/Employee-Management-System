using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Project
{
	internal sealed class Contract : Employee
	{
		public Contract()
		{
		}

		public double contractWage
		{
			get;
			set;
		}
	}
}