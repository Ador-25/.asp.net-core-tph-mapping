using Microsoft.EntityFrameworkCore;
using tph_mapping.Models;

namespace tph_mapping.Contexts
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>()
                .HasOne(a => a.UserAddress)
                .WithOne(b => b.UserAccount)
                .HasForeignKey<Address>(b => b.AccountRef);
        }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<StudentAccount> StudentAccounts { get; set; }
        public DbSet<TeacherAccount> TeacherAccounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
