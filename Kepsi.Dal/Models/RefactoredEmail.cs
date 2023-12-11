using Kepsi.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItShort.Persistance.Models
{
    public class RefactoredEmail
    {
        public int Id { get; set; }
        public int EmailId { get; set; }
        public Email EmailRef { get; set; }
        public string CustomerName { get; set; }
        public string Topic { get; set; }
        public string Summary { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int? RefactoredConversationId { get; set; }
        public RefactoredConversation? RefactoredConversationRef { get; set; }
    }
}
