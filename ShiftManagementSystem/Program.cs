// See https://aka.ms/new-console-template for more information
using ShiftManagementSystem;

Console.WriteLine("Hello, World!");
Supervisor supervisor = new Supervisor("Sian Taylor", EmployeeType.Supervisor, ShiftDays.AllWeek,new ShiftTime(ShiftDays.AllWeek, TimeSpan.FromHours(9), TimeSpan.FromHours(17)));
RegularEmployee regularEmployee = new RegularEmployee("Aqsa Ali Malik", EmployeeType.Regular, ShiftDays.AllWeek, supervisor);
Console.WriteLine(regularEmployee.ToString());
Console.WriteLine(supervisor.ToString());



