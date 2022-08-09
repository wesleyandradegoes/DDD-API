using RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys;
using RestApiFavoriteContact.Domain.Core.Interfaces.Services;
using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Domain.Services
{
    public class ServiceContaCorrente : ServiceBase<ContaCorrente>, IServiceContaCorrente
    {
        private readonly IRepositoryContaCorrente repositoryContaCorrente;

        public ServiceContaCorrente( IRepositoryContaCorrente repositoryContaCorrente) : base(repositoryContaCorrente)
        {
            this.repositoryContaCorrente = repositoryContaCorrente;
        }
        public ContaCorrente GetContaCorrente(int idCooperativa, string numeroContaCorrente)
        {
            return repositoryContaCorrente.GetContaCorrente(idCooperativa, numeroContaCorrente);
        }
    }
}
