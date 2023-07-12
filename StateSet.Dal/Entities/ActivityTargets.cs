namespace StateSet.Dal.Entities
{
    public class ActivityTargets : BaseEntity
    {
        public int ActivityId { get; set; }

        public int TargetsId { get; set; }

        public int GroupId { get; set; }

        public virtual Activity ActivityNavigation { get; set; } = null!;

        public virtual Targets TargetsNavigation { get; set; } = null!;

        public virtual Group GroupNavigation { get; set; } = null!;
    }
}
