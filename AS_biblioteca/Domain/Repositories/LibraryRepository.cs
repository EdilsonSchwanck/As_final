using AS_biblioteca.Data.Context;
using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;

namespace AS_biblioteca.Domain.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly DataContext context;

        public LibraryRepository()
        {
            this.context = new DataContext();
        }

        public LibraryRepository(DataContext context)
        {
            this.context = context;
        }

        public void Delete(int entityId)
        {
            context.Library.Remove(context.Library.Find(entityId));
            context.SaveChanges();
        }

        public IList<Library> GetAll()
        {
            return context.Library.ToList();
        }

        public Library GetById(int entityId)
        {
            return context.Library.Find(entityId);
        }

        public void Save(Library entity)
        {
            context.Library.Add(entity);
            context.SaveChanges();
        }

        public void Update(Library entity)
        {
            context.Library.Update(entity);
            context.SaveChanges();        
        }
    }
}