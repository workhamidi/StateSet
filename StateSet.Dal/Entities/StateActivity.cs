namespace StateSet.Dal.Entities
{
    public class StateActivity : BaseEntity
    {
        public int ActivityId { get; set; }

        public int StateId { get; set; }

        public virtual Activity ActivityNavigation { get; set; } = null!;

        public virtual State StateNavigation { get; set; } = null!;

    }
}
