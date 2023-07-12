namespace StateSet.Dal.Entities
{
    public class State : BaseEntity
    {
        public int StateTypesId { get; set; }
        public int ProcessId { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public virtual StateTypes StateTypesNavigation { get; set; } = null!;
        
        public virtual Process ProcessNavigation { get; set; } = null!;

        public virtual ICollection<Transition>? CurrentStatesNavigation { get; set; }
        
        public virtual ICollection<Transition>? NextStatesNavigation { get; set; }
        
        public virtual ICollection<StateActivity>? StateActivitiesNavigation { get; set; }
        
        public virtual ICollection<Request>? RequestNavigation { get; set; }
    }
}
