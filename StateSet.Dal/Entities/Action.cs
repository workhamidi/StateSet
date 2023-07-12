namespace StateSet.Dal.Entities
{
    public class Action : BaseEntity
    {
        public int ActionTypeId { get; set; }

        public int ProcessId { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public virtual ActionType ActionTypeNavigation { get; set; } = null!;

        public virtual Process ProcessNavigation { get; set; } = null!;
        
        public virtual ICollection<TransitionActions>? TransitionActionsNavigation { get; set; }

        public virtual ICollection<ActionTargets>? ActionTargetsNavigation { get; set; }
      
        public virtual ICollection<RequestAction>? RequestActionNavigation { get; set; }

    }
}
