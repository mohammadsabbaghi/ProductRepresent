using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProductRepresent.Commands
{
    interface ICommand<T> : IDisposable
    {
        T Read(Expression<Func<T, bool>> predicate);
        List<T> Reads();
        List<T> Reads(Expression<Func<T, bool>> predicate);

        bool Create(T entity);

        bool Update(T entity);
        bool Update(Expression<Func<T, bool>> predicate);

        bool Delete(T entity);
        bool Delete(Expression<Func<T, bool>> predicate);

        bool Exist(Expression<Func<T, bool>> predicate);
    }
}
