using System;
namespace ShiftManagementSystem
{
	public static class ShiftUtils
	{
		public static bool HasWeekend(ShiftDays days)
		{
			return (days.HasFlag(ShiftDays.Weekend));
				
		}
		public static string FormatShifTime(ShiftTime time)
		{
			return $"Working days: {time.shiftDays}\nStart Time: {time.StartTime}\nEnd Time: {time.EndTime}";
		}
	}
}

