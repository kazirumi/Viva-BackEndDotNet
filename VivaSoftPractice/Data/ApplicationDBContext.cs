using Microsoft.EntityFrameworkCore;
using VivaSoftPractice.Model;

namespace VivaSoftPractice.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
               
        }

        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }

        public DbSet<UserRole> userRoles { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<SalesMain> SalesMains { get; set; }
        public DbSet<SalesSub> SalesSubs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserRole>()
                .HasOne(r => r.Role)
                .WithMany(ur => ur.UserRoles)
                .HasForeignKey(ur => ur.RoleId);

            modelBuilder.Entity<UserRole>()
                .HasOne(u => u.User)
                .WithMany(ur => ur.UserRoles)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<Role>()
                .HasData(new List<Role>
                {
                    new Role{Id=Guid.NewGuid(),Name="Admin"},
                    new Role{Id=Guid.NewGuid(),Name="User"},
                    new Role{Id=Guid.NewGuid(),Name="Organizer"},
                });

            modelBuilder.Entity<Item>()
                .HasData(new List<Item>
                {
                    new Item{Id=Guid.NewGuid(),Name="andoid",Price=327844.58},
                    new Item{Id=Guid.NewGuid(),Name="samsung",Price=6434.96},
                    new Item{Id=Guid.NewGuid(),Name="honda",Price=434.78},
                    new Item{Id=Guid.NewGuid(),Name="facewash",Price=327844.58},
                    new Item{Id=Guid.NewGuid(),Name="mini TV",Price=6434.96},
                    new Item{Id=Guid.NewGuid(),Name="Less",Price=434.78},
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
