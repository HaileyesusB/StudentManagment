using Microsoft.EntityFrameworkCore;
using Studmgt.Domain.Model;
using Studmgt.Domain.Seeds;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Studmgt.Infrastructure.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { set; get; }

        public DbSet<Course> cources { set; get; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseAuditableModels>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = Guid.Empty;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = Guid.Empty;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
