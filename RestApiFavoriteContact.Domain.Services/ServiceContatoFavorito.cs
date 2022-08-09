using RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys;
using RestApiFavoriteContact.Domain.Core.Interfaces.Services;
using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Domain.Services
{
    public class ServiceContatoFavorito : ServiceBase<ContatoFavorito>, IServiceContatoFavorito
    {
        private readonly IRepositoryContatoFavorito repositoryContatoFavorito;
        
        public ServiceContatoFavorito(IRepositoryContatoFavorito repositoryContatoFavorito) : base(repositoryContatoFavorito)
        {
            this.repositoryContatoFavorito = repositoryContatoFavorito;
        }

        public ContatoFavorito GetContatoFavorito(int idContaCorrente, string chavePix)
        {
            return repositoryContatoFavorito.GetContatoFavorito(idContaCorrente, chavePix);
        }
    }
}
