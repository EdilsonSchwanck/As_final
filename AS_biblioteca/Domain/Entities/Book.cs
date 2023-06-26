namespace AS_biblioteca.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int SerialNumber { get; set; }
        public User User { get; set; }
        public virtual List<Author> Author { get; set; }
        public virtual List<Library> Librarys {get;set;}

    }
}