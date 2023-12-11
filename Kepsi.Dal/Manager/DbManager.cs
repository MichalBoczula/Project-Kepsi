using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KeepItShort.Persistance.Context;
using KeepItShort.Persistance.Models;

using Kepsi.Bl.Interfaces;
using Kepsi.Dal.Models;

using Microsoft.EntityFrameworkCore;

namespace Kepsi.Bl.Queries
{
    internal class DbManager : IDbManager
    {
        private readonly KeepItShortContext _context;

        public DbManager(KeepItShortContext context)
        {
            this._context = context;
        }

        public async Task<List<Conversation>> GetConversationWithEmails()
        {
            return await this._context.Conversations.Include(x => x.Emails)
                       .Select(x => new Conversation()
                       {
                           Id = x.Id,
                           Emails = x.Emails.Select(e => new Email()
                           {
                               Id = e.Id,
                               Content = e.Content
                           }).ToList()
                       })
                       .ToListAsync();
        }

        public async Task<int> AddRefactoredEmail(RefactoredEmail email)
        {
            try
            {
                await this._context.RefactoredEmails.AddAsync(email);
                await this._context.SaveChangesAsync();
                return email.Id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
