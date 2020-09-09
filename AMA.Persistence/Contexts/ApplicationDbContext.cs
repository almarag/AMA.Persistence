namespace AMA.Persistence.Contexts
{
    using AMA.Persistence.Models;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<GroupModel> Groups { get; set; }
        public DbSet<UserGroupModel> UserGroups { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserGroupModel>()
                .HasKey(bc => new { bc.UserId, bc.GroupId });
            modelBuilder.Entity<UserGroupModel>()
                .HasOne(bc => bc.UserModel)
                .WithMany(b => b.UserGroups)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserGroupModel>()
                .HasOne(bc => bc.GroupModel)
                .WithMany(c => c.UserGroups)
                .HasForeignKey(bc => bc.GroupId);
        }
    }
}
