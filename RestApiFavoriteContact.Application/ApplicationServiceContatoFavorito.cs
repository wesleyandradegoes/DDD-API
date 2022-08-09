using AutoMapper;
using RestApiFavoriteContact.Application.Dtos;
using RestApiFavoriteContact.Application.Exceptions;
using RestApiFavoriteContact.Application.Interfaces;
using RestApiFavoriteContact.Domain.Core.Interfaces.Services;
using RestApiFavoriteContact.Domain.Entitys;
using RestApiFavoriteContact.Domain.Enums;

namespace RestApiFavoriteContact.Application
{
    public class ApplicationServiceContatoFavorito : IApplicationServiceContatoFavorito
    {
        private readonly IServiceContatoFavorito serviceContatoFavorito;
        private readonly IServiceContaCorrente serviceContaCorrente;

        public ApplicationServiceContatoFavorito(IServiceContatoFavorito serviceContatoFavorito, IServiceContaCorrente serviceContaCorrente)
        {
            this.serviceContatoFavorito = serviceContatoFavorito;
            this.serviceContaCorrente = serviceContaCorrente;
        }

        public void Salvar(ContatoFavoritoInclusaoDto contatoFavoritoDto)
        {
            var contaCorrente = BuscaContaCorrente(contatoFavoritoDto.IdCooperativa, contatoFavoritoDto.ContaCorrente);
            
            if (contaCorrente == null)
                throw new ContaCorrenteNotFoundException();

            var contatoFavorito = Mapper.Map<ContatoFavorito>(contatoFavoritoDto);
            contatoFavorito.ContaCorrente = contaCorrente;

            serviceContatoFavorito.Save(contatoFavorito);
        }

        public void Alterar(ContatoFavoritoAlteracaoDto contatoFavoritoDto)
        {
            var contatoFavoritoEdicao = BuscaContatoFavorito(contatoFavoritoDto.IdCooperativa, contatoFavoritoDto.ContaCorrente, contatoFavoritoDto.ChavePixAntiga);

            if (contatoFavoritoEdicao == null)
                throw new ContatoFavoritoNotFoundException();

            contatoFavoritoEdicao.ChavePix = contatoFavoritoDto.ChavePix;
            contatoFavoritoEdicao.Nome = contatoFavoritoDto.Nome;
            contatoFavoritoEdicao.TipoChavePix = (TipoChavePix) contatoFavoritoDto.TipoChavePix;

            serviceContatoFavorito.Update(contatoFavoritoEdicao);
        }

        public void Excluir(IdentificacaoContatoFavoritoDto identificacaoContatoFavoritoDto)
        {
            var contatoFavoritoExclusao = BuscaContatoFavorito(identificacaoContatoFavoritoDto.IdCooperativa, identificacaoContatoFavoritoDto.ContaCorrente, identificacaoContatoFavoritoDto.ChavePix);
            
            if (contatoFavoritoExclusao == null)
                throw new ContatoFavoritoNotFoundException();

            serviceContatoFavorito.Delete(contatoFavoritoExclusao);

        }

        private ContaCorrente BuscaContaCorrente(int idCooperativa, string contaCorrente)
        {
            return serviceContaCorrente.GetContaCorrente(idCooperativa, contaCorrente);
        }

        private ContatoFavorito BuscaContatoFavorito(int idCooperativa, string numeroContaCorrente, string chavePix)
        {
            var contaCorrente = BuscaContaCorrente(idCooperativa, numeroContaCorrente);

            if (contaCorrente == null)
                throw new ContaCorrenteNotFoundException();

            return serviceContatoFavorito.GetContatoFavorito(contaCorrente.Id, chavePix);
        }
    }
}
