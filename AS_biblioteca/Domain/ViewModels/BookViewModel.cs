namespace AS_biblioteca.Domain.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public UserViewModel User { get; set; }
        public List<AuthorViewModel> Author { get; set; }
    }
}