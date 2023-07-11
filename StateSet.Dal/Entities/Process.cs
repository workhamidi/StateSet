namespace StateSet.Dal.Entities
{
    public class Process : BaseEntity
    {
        public string ProcessName { get; set; } = null!;
        
        public virtual ICollection<Request>? RequestsNavigation { get; set; }

        public virtual ICollection<State>? StateNavigation { get; set; }

        public virtual ICollection<Transition>? TransitionsNavigation { get; set; }

        public virtual ICollection<Action>? ActionNavigation { get; set; }

        public virtual ICollection<Activity>? ActivityNavigation { get; set; }

        public virtual ICollection<Group>? GroupNavigation { get; set; }
        
    }
}
