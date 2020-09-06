namespace AMA.Persistence.Contexts
{
    using AMA.Persistence.Models;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<PersonModel> Persons { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
