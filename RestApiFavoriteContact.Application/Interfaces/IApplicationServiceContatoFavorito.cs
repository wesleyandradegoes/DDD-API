using RestApiFavoriteContact.Application.Dtos;

namespace RestApiFavoriteContact.Application.Interfaces
{
    public interface IApplicationServiceContatoFavorito
    {
        void Salvar(ContatoFavoritoInclusaoDto contatoFavoritoDto);
        void Alterar(ContatoFavoritoAlteracaoDto contatoFavoritoDto);
        void Excluir(IdentificacaoContatoFavoritoDto identificacaoContatoFavoritoDto);
    };
}
