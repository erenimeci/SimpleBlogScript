using BS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BS.Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        TContext context = EFDBContextSingleton<TContext>.Instance;


        public void Add(TEntity entity)
        {

            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();

        }

        public void Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();

        }


        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {

            return context.Set<TEntity>().SingleOrDefault(filter);

        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {

            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();

        }

        public void Update(TEntity entity)
        {

            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
