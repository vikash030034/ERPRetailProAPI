using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public class ERPRetailProDbContext : IdentityDbContext
    {
        public ERPRetailProDbContext(DbContextOptions<ERPRetailProDbContext> options)
            : base(options)
        {
        }
        public int TenantId { get; set; }
        public string UserId { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<ErrorLogs> ErrorLogs { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Apply query filters
            //builder.Entity<Lead>();
        }
        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is AuditEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var entity = (AuditEntity)entry.Entity;
                var utcNow = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.CreateDate = utcNow;
                    entity.CreatedBy = entity.CreatedBy;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entity.LastModifiedDate = utcNow;
                    entity.ModifiedBy = entity.ModifiedBy;
                }
            }

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is AuditEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var entity = (AuditEntity)entry.Entity;
                var utcNow = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.CreateDate = utcNow;
                    entity.CreatedBy = entity.CreatedBy;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entity.LastModifiedDate = utcNow;
                    entity.ModifiedBy = entity.ModifiedBy;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
