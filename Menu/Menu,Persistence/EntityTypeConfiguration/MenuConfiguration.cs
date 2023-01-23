using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Menu.Domain;

namespace Menu.Persistence.EntityTypeConfiguration
{
    public class MenuConfiguration : IEntityTypeConfiguration<Domain.Menu>
    {
        public void Configure(EntityTypeBuilder<Domain.Menu> builder)
        {
            builder.HasKey(menu => menu.Id);
            builder.HasIndex(menu => menu.Id).IsUnique();
            builder.Property(menu => menu.Name).HasMaxLength(250);
        }
    }
}
