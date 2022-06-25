using Microsoft.EntityFrameworkCore;
using tph_mapping.Models;

namespace tph_mapping.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("ContextConnectionString"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserAccount>()
            //    .HasOne(a => a.Address)
            //    .WithOne(b => b.UserAccount)
            //    .HasForeignKey<Address>(b => b.AccountId);
        }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<StudentAccount> StudentAccounts { get; set; }
        public DbSet<TeacherAccount> TeacherAccounts { get; set; }
    }
}
