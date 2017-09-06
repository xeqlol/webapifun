using System;
using System.Collections.Generic;
using System.Text;
using Scheduler.Model;
using System.Linq.Expressions;

namespace Scheduler.Data.Abstract
{
    // trust me, better to use entity framework's DbContext and DbSet for all that things,
    // but im learning these 'custom repository' abstractions, so...
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> GetAll();
        int Count();
        T GetSingle(int id);
        T GetSingle(Expression<Func<T, bool>> predicate);
        T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteWhere(T entity, Expression<Func<T, bool>> predicate);
        void Commit();
    }
}
