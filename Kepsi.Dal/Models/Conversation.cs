using KeepItShort.Persistance.Models;

namespace Kepsi.Dal.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public List<Email> Emails { get; set; }
        public int RefactoredConversationId { get; set; }
        public RefactoredConversation? RefactoredConversationRef { get; set; }
    }
}
