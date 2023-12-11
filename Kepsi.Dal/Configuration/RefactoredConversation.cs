using KeepItShort.Persistance.Models;

using Kepsi.Dal.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kepsi.Dal.Configuration
{
    internal class RefactoredConversationConfiguration : IEntityTypeConfiguration<RefactoredConversation>
    {
        public void Configure(EntityTypeBuilder<RefactoredConversation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.HasOne(x => x.ConversationRef)
                .WithOne(x => x.RefactoredConversationRef)
                .HasForeignKey<RefactoredConversation>(x => x.ConversationId);
        }
    }
}
