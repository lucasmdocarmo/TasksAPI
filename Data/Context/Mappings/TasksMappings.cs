using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context.Mappings
{
    public class TasksMappings : IEntityTypeConfiguration<Tasks>
    {

        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("Tasks");

            builder.Property(c => c.Title).IsRequired().HasMaxLength(250).HasColumnType("varchar(250)");
            builder.Property(c => c.Done).HasColumnType("bit");
            builder.Property(c => c.Date).IsRequired();

            //EF
            //builder.HasOne(c => c.Item).WithMany(c => c.Tasks).HasForeignKey(c => c.ItemId);
        }
    }
}