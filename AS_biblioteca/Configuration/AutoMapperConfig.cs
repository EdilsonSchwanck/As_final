using AutoMapper;
using AS_biblioteca.Domain.Entities;
using AS_biblioteca.Domain.DTOs;
using AS_biblioteca.Domain.ViewModels;
using AS_biblioteca.Domain.Enum;

namespace AS_biblioteca.Configuration
{
    public class AutoMapperDTOs : Profile
    {
        public AutoMapperDTOs()
        {
            CreateMap<Author, AuthorDTO>();
            CreateMap<Book, BookDTO>();
            CreateMap<User, UserDTO>();
            CreateMap<LibraryDevolverDTO, Library>()
              .ForMember(dst => dst.Acao,  map => map.MapFrom(src => EAcaoBilbioteca.Devolver));
            CreateMap<LibraryEmprestarDTO, Library>()
             .ForMember(dst => dst.Acao,  map => map.MapFrom(src => EAcaoBilbioteca.Emprestar));
        }
    }

    public class AutoMapperViewModels : Profile
    {
        public AutoMapperViewModels()
        {
            CreateMap<Author, AuthorViewModel>();
            CreateMap<Book, BookViewModel>();
            CreateMap<User, UserViewModel>();
            CreateMap<LibraryDevolverDTO, Library>()
                .ForMember(dst => dst.Acao,  map => map.MapFrom(src => EAcaoBilbioteca.Devolver));
            CreateMap<LibraryEmprestarDTO, Library>()
             .ForMember(dst => dst.Acao,  map => map.MapFrom(src => EAcaoBilbioteca.Emprestar));
        }
    }
}