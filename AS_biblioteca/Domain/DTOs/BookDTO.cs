namespace AS_biblioteca.Domain.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int SerialNumber { get; set; }
        public UserDTO User { get; set; }
        public List<AuthorDTO> Author { get; set; }
    }
}