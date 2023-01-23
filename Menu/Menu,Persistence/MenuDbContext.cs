using Microsoft.EntityFrameworkCore;
using Menu.Domain;
using Menu.Persistence.EntityTypeConfiguration;
using Menu.Application.Interfaces;

namespace Menu.Persistence
{
    public class MenuDbContext : DbContext, IMenuDbContext
    {
        public DbSet<Domain.Menu> Menus { get; set; }

        public MenuDbContext(DbContextOptions<MenuDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MenuConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
