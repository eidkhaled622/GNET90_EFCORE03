using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET90_EFCORE03.Configuration
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(i => i.FullName).IsRequired().HasMaxLength(25);
            builder.Property(i => i.Email).IsRequired().HasMaxLength(50);
            builder.Property(i => i.Bio).HasMaxLength(100);
            builder.Property(i => i.JoinDate).IsRequired();

            builder.HasMany(a => a.Courses)
            .WithOne(c => c.Instructor)
            .HasForeignKey(c => c.InstructorId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(i => i.Id);

            builder.Property(c => c.Id)
                .UseIdentityColumn(seed: 1000, increment: 1);
        }
    }
}