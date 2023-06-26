namespace AS_biblioteca.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BookId { get; set; }
        public string Cpf { get; set; }
        public List<Book> Book { get; set;}
        public virtual List<Library> Librarys {get;set;}
    }
}