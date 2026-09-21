namespace GetTheRepsWeb.Domain.MaintenanceBook.Events
{
    public abstract class Category
    {
        public abstract bool ResetsSchedule { get; }
        public abstract bool RequiresFollowUp { get; }
        public abstract bool IsInspection { get; }

        public abstract Action<Schedule, Category> ResetMaintenance { get; }
        public abstract Action<Schedule, Category> CreateIrregular { get; }
        public abstract Action<Schedule, Category> CreateMaintenance { get; }
        public abstract Action<Schedule, Category> MarkComplete { get; }

    }
}
