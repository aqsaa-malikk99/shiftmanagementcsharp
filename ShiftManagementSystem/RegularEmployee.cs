using System;

namespace ShiftManagementSystem
{
    public class RegularEmployee : Employee
    {
        protected ShiftTime? ShiftTime;
        protected Supervisor? Supervisor;
      // PascalCase property

        public RegularEmployee(string name, EmployeeType employeeType, ShiftDays availableDays,Supervisor supervisor)
            : base(name, employeeType, availableDays)
        {
            this.Supervisor = supervisor;
        }

        public override bool AssignShift(ShiftTime shiftTime)
        {
            // Check if availableDays contains the shift's days
            if (this.availableDays.HasFlag(shiftTime.shiftDays))
            {
                this.ShiftTime = shiftTime;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsThereBonus()
        {
            // Example logic using switch expression on shift days
            return ShiftTime?.shiftDays switch
            {
                ShiftDays.Saturday or ShiftDays.Sunday => true,  // Weekend shifts get bonus
                _ => false,
            };
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            if (ShiftTime.HasValue)
                Console.WriteLine($"Assigned Shift: {ShiftTime.Value}");
            else
                Console.WriteLine("No shift assigned.");
            Console.WriteLine($"Bonus eligible: {IsThereBonus()}");
        }
        public override string ToString()
        {
            return $"My name is {this.Name} and I am a {this.employeeType} and i work for {this.Supervisor}";
        }
    }
}
