using BSynchro.RJP.Domain.irepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.RJP.EntityFramework
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected BSynchroRJPDbContext BSynchroRJPDbContext { get; set; }
        public RepositoryBase(BSynchroRJPDbContext repositoryContext)
        {
            BSynchroRJPDbContext = repositoryContext;
        }
        public IQueryable<T> FindAll() => BSynchroRJPDbContext.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            BSynchroRJPDbContext.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => BSynchroRJPDbContext.Set<T>().Add(entity);
        public void Update(T entity) => BSynchroRJPDbContext.Set<T>().Update(entity);
        public void Delete(T entity) => BSynchroRJPDbContext.Set<T>().Remove(entity);
    }
}
