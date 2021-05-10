using Infrastracture.Repository.Interfaces;
using Infrastructure.Persistance;
using Infrastructure.Repository.Abstract;

namespace Infrastructure.Repository.Implementations
{
    public class BookRepository : AbstractRepository<Book>, IBookRepository
    {
        public BookRepository(BookSharingContext context) : base(context) { }
    }
}
