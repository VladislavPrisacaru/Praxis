using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Praxis.Data.Entities;

namespace Praxis.Data
{
    public class PraxisDbContext : IdentityDbContext<AplicationUser>
    {
        public PraxisDbContext(DbContextOptions<PraxisDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(PraxisDbContext).Assembly);
        }
    }
}
