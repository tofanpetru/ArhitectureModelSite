using Infrastructure.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository.Abstract
{
    public abstract class AbstractRepository<TModel> : IRepository<TModel> where TModel : class
    {
        protected readonly BookSharingContext DatabaseContext;

        public AbstractRepository(BookSharingContext context)
        {
            this.DatabaseContext = context;
        }

        public void Add(TModel entity)
        {
            DatabaseContext.Set<TModel>().Add(entity);
        }

        public TModel Get<T>(T id)
        {
            return DatabaseContext.Set<TModel>().Find(id);
        }

        public ICollection<TModel> GetAll()
        {
            return DatabaseContext.Set<TModel>().ToList();
        }

        public void Remove(TModel entity)
        {
            DatabaseContext.Set<TModel>().Remove(entity);
        }
    }
}
