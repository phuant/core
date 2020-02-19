using NetCore.Model;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Commom
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        private readonly ConnectDatabase _context;

        public RepositoryBase(ConnectDatabase context)
        {
            this._context = context;
        }

        public void Add(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this._context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            this._context.Remove(entity);
        }

        public  T Get(int Id)
        {
            return this._context.Set<T>().Find(Id);
        }

        public IEnumerable<T> GetAll()
        {
           return _context.Set<T>().AsNoTracking();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
