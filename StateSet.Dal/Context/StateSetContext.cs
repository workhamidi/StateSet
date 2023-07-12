using Microsoft.EntityFrameworkCore;
using StateSet.Dal.Entities;


namespace StateSet.Dal.Context
{
    public class StateSetContext : DbContext
    {
        
        public StateSetContext(DbContextOptions<StateSetContext> options)
            : base(options)
        { }


        
    }
}
