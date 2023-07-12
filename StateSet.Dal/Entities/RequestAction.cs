namespace StateSet.Dal.Entities
{
    public class RequestAction : BaseEntity
    {
        public int RequestId { get; set; }

        public int ActionId { get; set; }

        public int TransitionId { get; set; }

        public bool IsActive { get; set; }

        public bool IsComplete { get; set; }
        
        public virtual Request RequestNavigation { get; set; } = null!;

        public virtual Action ActionNavigation { get; set; } = null!;

        public virtual Transition TransitionNavigation { get; set; } = null!;

    }
}
