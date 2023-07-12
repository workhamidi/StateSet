namespace StateSet.Dal.Entities
{
    public class Activity : BaseEntity
    {
        public int ActivityTypeId { get; set; }
        
        public int ProcessId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public virtual ActivityType ActivityTypeNavigation { get; set; } = null!;

        public virtual Process ProcessNavigation { get; set; } = null!;

        public virtual ICollection<StateActivity>? StateActivitiesNavigation { get; set; }
      
        public virtual ICollection<ActivityTargets>? ActivityTargetsNavigation { get; set; }

        public virtual ICollection<TransitionActivity>? TransitionActivityNavigation { get; set; }
    }
}
