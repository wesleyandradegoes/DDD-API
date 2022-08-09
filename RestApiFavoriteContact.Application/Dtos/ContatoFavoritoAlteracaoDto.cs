using System.ComponentModel.DataAnnotations;

namespace RestApiFavoriteContact.Application.Dtos
{
    public class ContatoFavoritoAlteracaoDto : ContatoFavoritoInclusaoDto
    {
        [Required(ErrorMessage = "É obrigatório informar a chave pix antiga do contato.")]
        [StringLength(100, ErrorMessage = "Chave pix não pode ser maior que 100 caracteres.")]
        public string ChavePixAntiga { get; set; }
    }
}
