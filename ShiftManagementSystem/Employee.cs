using System;
using System.Xml.Linq;

namespace ShiftManagementSystem
{
	 public abstract class Employee
	{
		protected string Name { get; set; }
		
		protected EmployeeType employeeType { get; set; }
		protected ShiftDays availableDays { get; set; }
		public abstract bool AssignShift(ShiftTime shiftTime);
		public virtual void DisplayInfo()
		{
            Console.WriteLine($"Name: {Name}, Type: {employeeType}, Available Days: {availableDays}");
        }
        public Employee(string Name,EmployeeType employeeType, ShiftDays availableDays)
		{
			this.Name = Name;
			this.employeeType = employeeType;
			this.availableDays = availableDays;
		}
		

	}
}

