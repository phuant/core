using System.Collections.Generic;

namespace NetCore.Commom
{
    public interface IRepositoryBase<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int Id);
        void Add(TEntity book);
        void Update(TEntity book);
        void Delete(TEntity Id);
        void Save();
    }
}
