namespace StateSet.Dal.Entities
{
    public class TransitionActions : BaseEntity
    {
        public int TransitionId { get; set; }

        public int ActionId { get; set; }

        public virtual Transition TransitionNavigation { get; set; } = null!;

        public virtual Action ActionNavigation { get; set; } = null!;
        
    }
}
