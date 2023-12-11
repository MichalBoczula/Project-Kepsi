using Kepsi.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItShort.Persistance.Models
{
    public class Email
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public string Content { get; set; }
        public RefactoredEmail? RefactoredEmailRef { get; set; }
        public int ConversationId { get; set; }
        public Conversation Conversation { get; set; }
    }
}
