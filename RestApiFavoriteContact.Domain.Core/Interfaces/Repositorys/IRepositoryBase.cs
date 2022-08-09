
using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        void Save(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
