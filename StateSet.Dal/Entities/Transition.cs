namespace StateSet.Dal.Entities
{
    public class Transition : BaseEntity
    {
        public int ProcessId { get; set; }

        public int CurrentStateId { get; set; }

        public int NextStateId { get; set; }

        public virtual Process ProcessNavigation { get; set; } = null!;

        public virtual State CurrentStateNavigation { get; set; } = null!;

        public virtual State NextStateNavigation { get; set; } = null!;

        public virtual ICollection<TransitionActions>? TransitionActionsNavigation { get; set; }
        
    }
}
