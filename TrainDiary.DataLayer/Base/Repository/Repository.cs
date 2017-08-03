namespace TrainDiary.DataLayer.Repository
{
    using System;
    using Base;
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public System.Linq.IQueryable<T> SearchFor(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
