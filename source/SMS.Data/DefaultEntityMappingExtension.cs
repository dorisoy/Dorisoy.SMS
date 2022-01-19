using Microsoft.EntityFrameworkCore;

namespace SMS.Data
{
    public static class DefaultEntityMappingExtension
    {
        public static void DefalutMappingValue(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .Property(b => b.ModifiedDate)
            //    .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }

        public static void DefalutDeleteValueFilter(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //.HasQueryFilter(p => !p.IsDeleted);

        }
    }
}
