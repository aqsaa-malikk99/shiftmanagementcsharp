using System;
namespace ShiftManagementSystem
{
	public readonly struct ShiftTime
	{
		public ShiftDays shiftDays { get; }
		public TimeSpan StartTime { get; }
		public TimeSpan EndTime { get;}
		public TimeSpan Duration => EndTime - StartTime;
		public ShiftTime(ShiftDays shiftDays,TimeSpan StartTime,TimeSpan EndTime)
		{
			if (EndTime <= StartTime)
				throw new ArgumentException("End time must be greater than start time");
			this.shiftDays = shiftDays;
			this.StartTime = StartTime;
			this.EndTime = EndTime;
			
		}
        public override string ToString()
        {
            return $"{shiftDays}: {StartTime} - {EndTime} (Duration: {Duration})";
        }

    }
}
