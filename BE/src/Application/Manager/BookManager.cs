using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Infrastracture.Repository.Interfaces;
using System.Collections.Generic;

namespace Application.Manager
{
    public class BookManager : IBookManager
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookManager(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public ICollection<AllBooksDto> GetAll()
        {
            var books = _bookRepository.GetAll();

            var model = _mapper.Map<ICollection<AllBooksDto>>(books);
            return model;
        }
    }
}
