using StateSet.Dal.Enums;

namespace StateSet.Dal.Entities
{
    public class StateTypes : BaseEntity
    {

        public StateTypesEnum State { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }
        
        public virtual ICollection<State>? States { get; set; }

    }
}
 