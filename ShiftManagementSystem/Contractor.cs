using System;

namespace ShiftManagementSystem
{
    public class Contractor : Employee
    {
        protected string Agency { get; }
        protected ShiftTime? ShiftTime { get; set; }

        public Contractor(string name, string agency, EmployeeType employeeType, ShiftDays availableDays)
            : base(name, employeeType, availableDays)
        {
            Agency = agency;
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

        public override bool Equals(object? obj)
        {
            if (obj is Contractor other)
                return Name == other.Name && Agency == other.Agency;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Agency);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Agency: {Agency}");
            if (ShiftTime.HasValue)
                Console.WriteLine($"Assigned Shift: {ShiftTime.Value}");
            else
                Console.WriteLine("No shift assigned.");
        }
    }
}
