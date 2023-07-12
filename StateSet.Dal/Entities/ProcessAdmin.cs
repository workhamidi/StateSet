using Microsoft.AspNetCore.Identity;

namespace StateSet.Dal.Entities
{
    public class ProcessAdmin : BaseEntity
    {
        public string UserId { get; set; } = null!;

        public int ProcessId { get; set; } 
        
        public virtual Process ProcessNavigation { get; set; } = null!;

        public virtual User UserNavigation { get; set; } = null!;

    }
}
