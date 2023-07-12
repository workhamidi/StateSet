namespace StateSet.Dal.Entities
{
    public class Request : BaseEntity
    {
        public int ProcessId { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; } = null!;

        public int  CurrentStateId { get; set; }

        public virtual State CurrentStateNavigation { get; set; } = null!;

        public virtual Process ProcessNavigation { get; set; } = null!;

        public virtual User UserNavigation { get; set; } = null!;

        public virtual ICollection<RequestData>? RequestDataNavigation { get; set; }

        public virtual ICollection<StakeholdersRequest>? StakeholdersRequestNavigation { get; set; }
        
        public virtual ICollection<RequestNotes>? RequestNotesNavigation { get; set; }
       
        public virtual ICollection<RequestAction>? RequestActionNavigation { get; set; }

        public virtual ICollection<RequestFile>? RequestFileNavigation { get; set; }

    }
}
