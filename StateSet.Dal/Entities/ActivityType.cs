namespace StateSet.Dal.Entities
{
    public class ActivityType : BaseEntity
    {
        public string Name { get; set; } = null!;

        public virtual ICollection<Activity>? ActivityNavigation { get; set; }

    }
}
