using KeepItShort.Persistance.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KeepItShort.Persistance.Context
{
    internal class KeepItShortContext : DbContext
    {
        public KeepItShortContext([NotNull] DbContextOptions<KeepItShortContext> options) : base(options)
        {
        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<RefactoredEmail> RefactoredEmails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
