using RestApiFavoriteContact.Domain.Enums;

namespace RestApiFavoriteContact.Domain.Entitys
{
    public class ContatoFavorito : EntityBase
    {
        public virtual string Nome { get; set; }
        public virtual TipoChavePix TipoChavePix { get; set; }
        public virtual string ChavePix { get; set; }
        public virtual ContaCorrente ContaCorrente { get; set;}
    }
}
