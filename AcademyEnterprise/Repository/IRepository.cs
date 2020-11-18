using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AcademyEnterprise.Repository
{
    public interface IRepository <T>
    {
        T Add(T Entity);
        T Update(T Entity);
        T Get(Guid Id);
        IEnumerable<T> All();
        IEnumerable<T> Find(Expression<Func<T,bool>>predicate);
        void SaveChanges();

    }
}
