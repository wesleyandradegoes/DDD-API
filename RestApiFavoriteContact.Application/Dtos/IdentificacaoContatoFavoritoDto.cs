using System;
using System.ComponentModel.DataAnnotations;

namespace RestApiFavoriteContact.Application.Dtos
{
    public class IdentificacaoContatoFavoritoDto
    {
        [Required(ErrorMessage = "É obrigatório informar a chave pix do contato.")]
        [StringLength(100, ErrorMessage = "Chave pix não pode ser maior que 100 caracteres.")]
        public string ChavePix { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o código da cooperativa do contato.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Código da cooperativa informado inválido.")]
        public int IdCooperativa { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a conta corrente do contato.")]
        [StringLength(50, ErrorMessage = "Conta corrente do contato não pode ser maior que 50 caracteres.")]
        public string ContaCorrente { get; set; }
    }
}
