namespace StateSet.Dal.Entities
{
    public class Group : BaseEntity
    {
        public int ProcessId { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public virtual Process ProcessNavigation { get; set; } = null!;
        public virtual ICollection<GroupMember>? GroupMemberNavigation { get; set; } = null!;

    }
}
