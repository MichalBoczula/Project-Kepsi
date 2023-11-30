using KeepItShort.Persistance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItShort.Persistance.Configuration
{
    internal class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.AddedDate);
            builder.HasOne(x => x.RefactoredEmailRef).WithOne(x => x.EmailRef)
                .HasForeignKey<RefactoredEmail>(x => x.EmailId);
            builder.Property(x => x.Content).HasColumnType("varchar");
        }
    }
}
