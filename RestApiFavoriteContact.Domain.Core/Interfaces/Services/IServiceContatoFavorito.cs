using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Domain.Core.Interfaces.Services
{
    public interface IServiceContatoFavorito : IServiceBase<ContatoFavorito>
    {
        public ContatoFavorito GetContatoFavorito(int idContaCorrente, string chavePix);
    }
}
