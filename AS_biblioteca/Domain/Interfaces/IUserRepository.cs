using AS_biblioteca.Domain.Entities;

namespace AS_biblioteca.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        void Save(int id);
        public List<User> GetAllWithInclude();
    }
}