using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryContatoFavorito : IRepositoryBase<ContatoFavorito>
    {
        ContatoFavorito GetContatoFavorito(int idContaCorrente, string chavePix);
    }
}
