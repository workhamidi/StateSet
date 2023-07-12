namespace StateSet.Dal.Entities
{
    public class RequestFile : BaseEntity
    {
        public int RequestId { get; set; }

        public int UserId { get; set; }

        public string FileName { get; set; } = null!;

        public string FileContent { get; set; } = null!;

        public string MimeType { get; set; } = null!;

        public virtual Request RequestNavigation { get; set; } = null!;

        public virtual User UserNavigation { get; set; } = null!;

    }
}
