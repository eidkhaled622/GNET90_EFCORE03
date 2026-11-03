using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET90_EFCORE03.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.Property(s => s.FullName).IsRequired(true);
            builder.Property(s => s.Email).IsRequired(true);
            builder.Property(s => s.DOB).IsRequired(true);

            builder.HasMany(s => s.Enrollments)
            .WithOne(s => s.Student)
            .HasForeignKey(s => s.StudentId);

        }
    }
}