using System;
using System.Linq;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using TopShelfDAL.DatabaseContext.Tables;

namespace TopShelfDAL.DatabaseContext
{
    class TopShelfContext : DbContext
    {
        public DbSet<User> User { get; set; }


        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is Audit && (
                                e.State == EntityState.Added
                                || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((Audit)entityEntry.Entity).Updated = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((Audit)entityEntry.Entity).Created = DateTime.Now;
                }

                if (entityEntry.State == EntityState.Deleted)
                {
                    ((Audit) entityEntry.Entity).Deleted = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
