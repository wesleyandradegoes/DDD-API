using System;
using System.ComponentModel.DataAnnotations;

namespace RestApiFavoriteContact.Application.Dtos
{
    public class ContatoFavoritoInclusaoDto : IdentificacaoContatoFavoritoDto
    {
        [Required (ErrorMessage = "É obrigatório informar o nome do contato.")]
        [StringLength(50, ErrorMessage = "Nome não pode ser maior que 50 caracteres.")]
        public string Nome { get; set; }

        [Required (ErrorMessage = "É obrigatório informar o tipo de chave pix do contato.")]
        [Range(0,4, ErrorMessage = "Tipo de chave pix informado inválido.")]
        public int TipoChavePix { get; set; }
    }
}
