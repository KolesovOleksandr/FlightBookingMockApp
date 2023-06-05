using DataAccessLayer.Models;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Repositories.InterfaceRepositories;

namespace DataAccessLayer.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly DbSet<Document> _documents;

        public DocumentRepository(TimetableContext context)
        {
            _documents = context.Documents;
        }

        public void Add(Document document)
        {
            _documents.Add(document);
        }

        public void Delete(Document document)
        {
            _documents.Remove(document);
        }

        public IEnumerable<Document> GetAll()
        {
            return _documents.ToList();
        }

        public Document? GetById(int id)
        {
            return _documents.Find(id);
        }

        public Document? GetDocumentByNumber(long documentNumber)
        {
            return _documents.FirstOrDefault(x=>x.DocumentNumber == documentNumber);
        }

        public void Update(Document document)
        {
            _documents.Update(document);
        }
    }
}
