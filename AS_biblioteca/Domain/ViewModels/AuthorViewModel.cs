namespace AS_biblioteca.Domain.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookViewModel> Book { get; set; }
    }
}