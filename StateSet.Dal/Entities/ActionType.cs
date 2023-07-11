using StateSet.Dal.Enums;

namespace StateSet.Dal.Entities
{
    public class ActionType : BaseEntity
    {
        public ActionTypeEnum State { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public virtual ICollection<Action>? ActionNavigation { get; set; }
    }
}
