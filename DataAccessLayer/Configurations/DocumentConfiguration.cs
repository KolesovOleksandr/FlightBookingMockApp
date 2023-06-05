using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Models;

namespace DataAccessLayer.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasData(
                new Document { DocumentId = 1, DocumentName = "Passport", DocumentNumber = 213123, PassengerId = 1 },
                new Document { DocumentId = 2, DocumentName = "Foreign Passport", DocumentNumber = 214324, PassengerId = 2 },
                new Document { DocumentId = 3, DocumentName = "Passport", DocumentNumber = 215234, PassengerId = 3 },
                new Document { DocumentId = 4, DocumentName = "Foreign Passport", DocumentNumber = 215564, PassengerId = 4 },
                new Document { DocumentId = 5, DocumentName = "Passport", DocumentNumber = 216237, PassengerId = 5 }
                );
        }
    }
}
