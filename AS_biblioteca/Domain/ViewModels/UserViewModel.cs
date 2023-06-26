namespace AS_biblioteca.Domain.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public List<BookViewModel> Book { get; set;}
    }
}