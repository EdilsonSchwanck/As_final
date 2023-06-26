namespace AS_biblioteca.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BookId { get; set; }
        public List<Book> Book { get; set; }
    }
}