using Domain.Entities;
using System.Collections.Generic;


namespace Application.Interfaces
{
    public interface IBookManager
    {
        ICollection<AllBooksDto> GetAll();
    }
}
