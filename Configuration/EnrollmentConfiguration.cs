using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET90_EFCORE03.Configuration
{
    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.HasKey(e => new { e.CourseId, e.StudentId });

            builder.Property(e => e.FinalGrade).HasPrecision(5, 2).IsRequired(true);

            builder.ToTable("Enrollments", t =>
            {
                t.HasCheckConstraint("CK_ENROLLMENT_CONSTRAIN", "[Progress] BETWEEN 0 AND 100");
            });
        }
    }
}