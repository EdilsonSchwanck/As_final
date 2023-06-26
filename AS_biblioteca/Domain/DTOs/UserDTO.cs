namespace AS_biblioteca.Domain.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public List<BookDTO> Book { get; set;}
    }
}