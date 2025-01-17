﻿using KeepItShort.Persistance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItShort.Persistance.Configuration
{
    internal class RefactoredEmailConfiguration : IEntityTypeConfiguration<RefactoredEmail>
    {
        public void Configure(EntityTypeBuilder<RefactoredEmail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Summary).HasColumnType("varchar(max)");
            builder.Property(x => x.Topic).HasColumnType("varchar(max)");
            builder.Property(x => x.CustomerName).HasColumnType("varchar(max)");
            builder.HasOne(x => x.RefactoredConversationRef).WithMany(x => x.RefactoredEmails)
                .HasForeignKey(x => x.RefactoredConversationId);
        }
    }
}
