using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_biblioteca.Domain.Enum;

namespace AS_biblioteca.Domain.Entities
{
    public class Library
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public EAcaoBilbioteca Acao {get;set;}
        public virtual User User {get;set;}
        public virtual Book Book {get;set;}
    }
}