using DataAccessLayer.DTOs;

namespace BusinessLogicLayer.Services.ServiceInterfaces
{
    public interface IDocumentService
    {
        DocumentDTO? GetDocumentByNumber(long number);
    }
}
