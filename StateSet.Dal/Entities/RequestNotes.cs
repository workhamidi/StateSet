namespace StateSet.Dal.Entities
{
    public class RequestNotes : BaseEntity
    {
        public int RequestId { get; set; }

        public string Note { get; set; } = null!;

        public virtual Request RequestNavigation { get; set; } = null!;

    }
}
