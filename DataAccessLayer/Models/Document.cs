
namespace DataAccessLayer.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; } = null!;
        public long DocumentNumber { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passenger { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; set; } = null!;
    }
}
