using Core.DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core
{
    public class EfEntityRepositoryBase<Tentity, Kontext> : IEntityRepository<Tentity> where Tentity : class, IEntity, new() where Kontext : DbContext, new()
    {

        public void Add(Tentity entity)
        {
            using (Kontext context = new Kontext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (Kontext context = new Kontext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }



        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (Kontext context = new Kontext())
            {
                return context.Set<Tentity>().SingleOrDefault(filter);
            }
        }



        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (Kontext context = new Kontext())
            {
                return filter == null ? context.Set<Tentity>().ToList() : context.Set<Tentity>().Where(filter).ToList();
            }


        }



        public void Update(Tentity entity)
        {
            using (Kontext context = new Kontext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
