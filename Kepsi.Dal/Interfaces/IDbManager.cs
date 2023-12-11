using KeepItShort.Persistance.Models;
using Kepsi.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepsi.Bl.Interfaces
{
    public interface IDbManager
    {
        Task<List<Conversation>> GetConversationWithEmails();
        Task<int> AddRefactoredEmail(RefactoredEmail email);
    }
}
