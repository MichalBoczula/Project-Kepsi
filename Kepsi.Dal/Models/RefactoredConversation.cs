using KeepItShort.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepsi.Dal.Models
{
    public class RefactoredConversation
    {
        public int Id { get; set; }
        public int ConversationId { get; set; }
        public Conversation ConversationRef { get; set; }
        public string Content { get; set; }
        public List<RefactoredEmail> RefactoredEmails { get; set; }
    }
}
