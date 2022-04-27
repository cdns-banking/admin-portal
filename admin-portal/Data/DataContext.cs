

namespace admin_portal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<AdminUser> Admins { get; set; }
    }
}
