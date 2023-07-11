using Microsoft.AspNetCore.Identity;

namespace StateSet.Dal.Entities
{
    public class User : IdentityUser
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public virtual ICollection<Request>? RequestNavigation { get; set; }

        public virtual ICollection<StakeholdersRequest>? StakeholdersRequestNavigation { get; set; }
        public virtual ICollection<GroupMember>? GroupMemberNavigation { get; set; }

    }
}
