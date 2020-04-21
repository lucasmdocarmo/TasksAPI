using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context.Mappings
{
    public class UserMappings : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("Users");

            builder.Property(c => c.Name).IsRequired().HasColumnType("varchar(250)").HasMaxLength(250);
            builder.Property(c => c.Job).IsRequired().HasColumnType("varchar(100)").HasMaxLength(250);

            // 1 : N => Voucher : Pedidos
            builder.HasMany(c => c.Items).WithOne(c => c.User).HasForeignKey(c => c.UserId);
        }
    }
}
