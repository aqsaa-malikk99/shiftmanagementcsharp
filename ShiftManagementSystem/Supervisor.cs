using System;

namespace ShiftManagementSystem
{
    public class Supervisor : Employee
    {
        protected ShiftTime? ShiftTime { get; set; }

        public Supervisor(string name, EmployeeType employeeType, ShiftDays availableDays,ShiftTime shiftTime)
            : base(name, employeeType, availableDays)
        {
            this.ShiftTime = shiftTime;
        }

        public override bool AssignShift(ShiftTime shiftTime)
        {
            if (availableDays.HasFlag(shiftTime.shiftDays))
            {
                ShiftTime = shiftTime;
                return true;
            }
            return false;
        }

        public bool CanOverrideShifts(ShiftTime shiftTime,RegularEmployee regularEmployee)
        {
            // Logic to allow override shifts (simple example)
           
                ShiftTime = shiftTime;
                return true;


        
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            if (ShiftTime.HasValue)
                Console.WriteLine($"Assigned Shift: {ShiftTime.Value}");
            else
                Console.WriteLine("No shift assigned.");
        }
        public override string ToString()
        {
            return $"I am {this.Name} and I work on {this.ShiftTime} and I am {this.employeeType} ";
        }
    }
}
