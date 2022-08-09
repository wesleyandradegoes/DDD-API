using FluentNHibernate.Mapping;
using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Infrastructure.Data.Mappings
{
    public class CooperativaMapping : ClassMap<Cooperativa>
    {
        const string TABELA = "Cooperativa";
        const string SEQUENCE = "Cooperativa_Seq";
        public CooperativaMapping()
        {
            Table(TABELA);
            Id(x => x.Id).GeneratedBy.Sequence(SEQUENCE).Not.Nullable();
            Map(x => x.Descricao).Length(50).Not.Nullable();
        }
    }
}
