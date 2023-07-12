using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSet.Dal.Entities
{
    public class TransitionActivity : BaseEntity
    {
        public int TransitionId { get; set; }
        
        public int ActivityId { get; set; }

        public virtual Transition TransitionNavigation { get; set; } = null!;
      
        public virtual Activity ActivityNavigation { get; set; } = null!;

    }
}
