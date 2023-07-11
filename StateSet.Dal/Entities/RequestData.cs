namespace StateSet.Dal.Entities
{
    public class RequestData : BaseEntity
    {
        public int RequestId { get; set; }

        public string? Key { get; set; }

        public string? Value { get; set; }

        public virtual Request RequestNavigation { get; set; } = null!;

    }
}
