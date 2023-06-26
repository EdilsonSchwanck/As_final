using AS_biblioteca.Data.Context;
using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AS_biblioteca.Domain.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext context;

        public AuthorRepository()
        {
            this.context = new DataContext();
        }

        public AuthorRepository(DataContext context)
        {
            this.context = context;
        }
        
        public void Delete(int entityId)
        {
            var author = GetById(entityId);
            context.Authors.Remove(author);
            context.SaveChanges();
            System.Console.WriteLine("Autor deletado com sucesso!");
        }

        public IList<Author> GetAll()
        {
            return context.Authors.Include(p => p.Book).ToList();
        }

        public IList<Author> GetAllWithIncludes()
        {
            return context.Authors.Include(p => p.Book).ToList();
        }

        public Author GetById(int entityId)
        {
            return context.Authors.SingleOrDefault(x => x.Id == entityId);
        }

        public void Save(Author entity, int id)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Save(Author entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Author entity)
        {
            context.Authors.Update(entity);
            context.SaveChanges();
        }
    }
}