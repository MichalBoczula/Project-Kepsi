using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kepsi.Dal.Models;

namespace Kepsi.Dal.Seed
{
    internal static class ConversationSeed
    {
        internal static void AddConversation(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conversation>().HasData(new Conversation { Id = 1 });
            modelBuilder.Entity<Conversation>().HasData(new Conversation { Id = 2 });
            modelBuilder.Entity<Conversation>().HasData(new Conversation { Id = 3 });
            modelBuilder.Entity<Conversation>().HasData(new Conversation { Id = 4 });
            modelBuilder.Entity<Conversation>().HasData(new Conversation { Id = 5 });
        }
    }
}
