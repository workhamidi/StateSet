namespace StateSet.Dal.Entities
{
    public class Targets : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; }
        
        public virtual ICollection<ActionTargets>? ActionTargetsNavigation { get; set; }

        public virtual ICollection<ActivityTargets>? ActivityTargetsNavigation  { get; set; }

    }
}
