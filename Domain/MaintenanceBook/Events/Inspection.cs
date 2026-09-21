
namespace GetTheRepsWeb.Domain.MaintenanceBook.Events
{
    public class Inspection : Category
    {
        public override bool ResetsSchedule => false;
        public override bool RequiresFollowUp => false;
        public override bool IsInspection => true;

    }
}
