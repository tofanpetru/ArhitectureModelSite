using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistance;

namespace Application.MappingProfiles
{
    public class AllBooksProfile : Profile
    {
        public AllBooksProfile()
        {
            CreateMap<Book, AllBooksDto>().ReverseMap();
        }
    }
}
