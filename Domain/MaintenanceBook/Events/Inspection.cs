
using System.ComponentModel;

namespace GetTheRepsWeb.Domain.MaintenanceBook.Events
{
    public class Inspection : Category
    {
        public override bool ResetsSchedule => false;
        public override bool RequiresFollowUp => false;
        public override bool IsInspection => true;

        public override Action<Schedule, Category> CreateIrregular => 
            (schedule, category) => {
                var inspectionEvent = schedule.MarkInspectionAsIrregular(category);
                schedule.MarkEventOpen(inspectionEvent);
            };
        public override Action<Schedule, Category> MarkComplete =>
            (schedule, category) => {
                schedule.MarkInspectionAsComplete(category);
            };
        public override Action<Schedule, Category> ResetMaintenance => (schedule, category) => { };
        public override Action<Schedule, Category> CreateMaintenance => (schedule, category) => { };
    }
}
