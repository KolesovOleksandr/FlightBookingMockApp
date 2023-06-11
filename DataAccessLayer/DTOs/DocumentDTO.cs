using DataAccessLayer.Models;

namespace DataAccessLayer.DTOs
{
    public class DocumentDTO
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; } = null!;
        public long DocumentNumber { get; set; }
        public DocumentDTO(){}
        public DocumentDTO(Document? document)
        {
            if (document == null)
            {
                throw new ArgumentNullException(nameof(document));
            }
            DocumentId = document.DocumentId;
            DocumentName = document.DocumentName;
            DocumentNumber = document.DocumentNumber;
        }
    }
}
