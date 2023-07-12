namespace StateSet.Dal.Entities
{
    public class GroupMember : BaseEntity
    {
        public int UserId { get; set; }
        
        public int GroupId { get; set; }
        
        public virtual User UserNavigation { get; set; } = null!;
      
        public virtual Group GroupNavigation { get; set; } = null!;
    }
}
