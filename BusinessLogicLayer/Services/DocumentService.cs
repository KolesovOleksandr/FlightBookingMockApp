using DataAccessLayer.DTOs;
using DataAccessLayer.Repositories.InterfaceRepositories;
using BusinessLogicLayer.Services.ServiceInterfaces;

namespace BusinessLogicLayer.Services
{
    public class DocumentService : IDocumentService
    {
        readonly IDocumentRepository _documentRepository;
        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
        public DocumentDTO? GetDocumentByNumber(long number)
        {
            DocumentDTO correspDocument = new();
            try
            {
                correspDocument = new DocumentDTO(_documentRepository.GetAll()
                    .FirstOrDefault(x => x.DocumentNumber == number));
            }
            catch (ArgumentNullException)
            {
                return null;
            }
            return correspDocument;
        }
    }
}
