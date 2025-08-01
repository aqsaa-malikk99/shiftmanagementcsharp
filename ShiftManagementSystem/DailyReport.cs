namespace ShiftManagementSystem
{
    public struct DailyReport
    {
        public string Note { get; }
        public int OutputCount { get; }

        public DailyReport(string note, int outputCount)
        {
            Note = note;
            OutputCount = outputCount;
        }

        public override string ToString()
        {
            return $"Note: {Note}, Output Count: {OutputCount}";
        }
    }
}
