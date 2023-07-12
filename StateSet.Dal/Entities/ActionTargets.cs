namespace StateSet.Dal.Entities
{
    public class ActionTargets
    {
        public int ActionId { get; set; }

        public int TargetsId { get; set; }

        public int GroupId { get; set; }

        public virtual Action ActionNavigation { get; set; } = null!;

        public virtual Targets TargetsNavigation { get; set; } = null!;

        public virtual Group GroupNavigation { get; set; } = null!;

    }
}
