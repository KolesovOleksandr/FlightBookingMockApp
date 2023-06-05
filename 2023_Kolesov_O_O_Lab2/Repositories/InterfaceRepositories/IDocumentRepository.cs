using DataAccessLayer.Models;

namespace DataAccessLayer.Repositories.InterfaceRepositories
{
    public interface IDocumentRepository : IEntityRepository<Document>
    {
        Document? GetDocumentByNumber(long documentNumber);
    }
}
