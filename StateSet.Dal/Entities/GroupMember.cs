namespace StateSet.Dal.Entities
{
    public class GroupMember : BaseEntity
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public User UserNavigation { get; set; } = null!;
        public Group GroupNavigation { get; set; } = null!;
    }
}
