using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context.Mappings
{
    public class ItemMappings : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("Items");

            builder.Property(c => c.Name).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(c => c.Started).IsRequired();
            builder.Property(c => c.Ended);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(250).HasColumnType("varchar");

            //EF
            builder.HasMany(c => c.Tasks).WithOne(c => c.Item).HasForeignKey(c => c.ItemId);
        }
    }
}