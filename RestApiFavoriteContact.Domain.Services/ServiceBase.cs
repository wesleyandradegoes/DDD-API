using RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys;
using RestApiFavoriteContact.Domain.Core.Interfaces.Services;
using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : EntityBase
    {
        private readonly IRepositoryBase<T> repositoryBase;

        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }
        public void Save(T entity)
        {
            repositoryBase.Save(entity);
        }

        public void Update(T entity)
        {
            repositoryBase.Update(entity);
        }

        public void Delete(T entity)
        {
            repositoryBase.Delete(entity);
        }
    }
}
