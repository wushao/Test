using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable("Students");
            HasKey(t => t.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasOptional(x => x.Contact).WithRequired(l => l.Student);
        }
    }
    public class StudentContactMap : EntityTypeConfiguration<StudentContact>
    {
        public StudentContactMap()
        {
            ToTable("StudentContacts");
            HasKey(t => t.Id);

            Property(x => x.Id).HasColumnName("StudentId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }

    }
}
