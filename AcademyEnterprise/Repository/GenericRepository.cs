using AcademyEnterprise.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace AcademyEnterprise.Repository
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected AcademyEnterpriseContext context;
        public GenericRepository(AcademyEnterpriseContext context)
        {
            this.context = context;
        }
        public  virtual T Add(T Entity)
        {
            return context.Add(Entity).Entity;
        }

        public virtual IEnumerable<T> All()
        {
            return context.Set<T>().ToList();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
             return context.Set<T>()
                .AsQueryable()
                .Where(predicate)
                .ToList();
        }

        public virtual T Get(Guid id)
        {
            return context.Find<T>(id);
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual T Update(T Entity)
        {
            return context.Update(Entity).Entity;
        }
       
    }
}
