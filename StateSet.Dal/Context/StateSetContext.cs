using Microsoft.EntityFrameworkCore;
using StateSet.Dal.Entities;


namespace StateSet.Dal.Context
{
    public class StateSetContext : DbContext
    {
        
        public StateSetContext(DbContextOptions<StateSetContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Flow> Flow { get; set; } = null!;
        public virtual DbSet<User> User { get; set; } = null!;
        public virtual DbSet<Cartable> Cartable { get; set; } = null!;
        public virtual DbSet<Message> Message { get; set; } = null!;
    }
}
