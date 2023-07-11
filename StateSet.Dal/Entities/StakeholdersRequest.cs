namespace StateSet.Dal.Entities
{
    public class StakeholdersRequest : BaseEntity
    {
        public int UserId { get; set; }

        public int RequestId { get; set; }

        public virtual User UserNavigation { get; set; } = null!;

        public virtual Request RequestNavigation { get; set; } = null!;

    }
}
