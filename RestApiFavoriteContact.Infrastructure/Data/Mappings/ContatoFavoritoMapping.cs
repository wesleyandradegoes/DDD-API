using FluentNHibernate.Mapping;
using RestApiFavoriteContact.Domain.Entitys;
using RestApiFavoriteContact.Domain.Enums;

namespace RestApiFavoriteContact.Infrastructure.Data.Mappings
{
    public class ContatoFavoritoMapping : ClassMap<ContatoFavorito>
    {
        const string TABELA = "ContatoFavorito";
        const string SEQUENCE = "ContatoFavorito_Seq";

        public ContatoFavoritoMapping()
        {
            Table(TABELA);
            Id(x => x.Id).GeneratedBy.Sequence(SEQUENCE).Not.Nullable();
            Map(x => x.Nome).Length(50).Not.Nullable();
            Map(x => x.TipoChavePix).CustomType<TipoChavePix>().Not.Nullable();
            Map(x => x.ChavePix).UniqueKey("ChavePixCC").Length(100).Not.Nullable();
            References(x => x.ContaCorrente).UniqueKey("ChavePixCC").Not.Nullable();
        }
    }
}
