using Microsoft.AspNetCore.Mvc;
using RestApiFavoriteContact.Application.Dtos;
using RestApiFavoriteContact.Application.Exceptions;
using RestApiFavoriteContact.Application.Interfaces;
using RestApiFavoriteContact.Infrastructure.CrossCutting;
using Unity;

namespace RestApiFavoriteContact.API.Controllers
{
    [Route("ContatoFavorito/")]
    [ApiController]
    public class ContatoFavoritoController : ControllerBase
    {
        private readonly IApplicationServiceContatoFavorito applicationServiceContatoFavorito;

        public ContatoFavoritoController()
        {
            this.applicationServiceContatoFavorito = Program.Container.Resolve<IApplicationServiceContatoFavorito>();
        }

        [HttpPost]
        [Route("Incluir")]
        public ActionResult Incluir([FromBody] ContatoFavoritoInclusaoDto contatoFavoritoDto)
        {
            try
            {
                applicationServiceContatoFavorito.Salvar(contatoFavoritoDto);
                return Ok(StringRes.ContatoFavoritoAddSucesso);
            }
            catch (ContaCorrenteNotFoundException)
            {
                return BadRequest(StringRes.ContaCorrenteNaoEncontrada);
            }
        }

        [HttpPost]
        [Route("Alterar")]
        public ActionResult Alterar([FromBody] ContatoFavoritoAlteracaoDto contatoFavoritoDto)
        {
            try
            {
                applicationServiceContatoFavorito.Alterar(contatoFavoritoDto);
                return Ok(StringRes.ContatoFavoritoAlteradoSucesso);
            }
            catch (ContaCorrenteNotFoundException)
            {
                return BadRequest(StringRes.ContaCorrenteNaoEncontrada);
            }
            catch (ContatoFavoritoNotFoundException)
            {
                return BadRequest(StringRes.ContatoFavoritoNaoEncontrado);
            }
        }

        [HttpPost]
        [Route("Excluir")]
        public ActionResult Excluir([FromBody] IdentificacaoContatoFavoritoDto contatoFavoritoDto)
        {
            try
            {
                applicationServiceContatoFavorito.Excluir(contatoFavoritoDto);
                return Ok(StringRes.ContatoFavoritoExcluidoSucesso);
            }
            catch (ContaCorrenteNotFoundException)
            {
                return BadRequest(StringRes.ContaCorrenteNaoEncontrada);
            }
            catch (ContatoFavoritoNotFoundException)
            {
                return BadRequest(StringRes.ContatoFavoritoNaoEncontrado);
            }
        }
    }
}
