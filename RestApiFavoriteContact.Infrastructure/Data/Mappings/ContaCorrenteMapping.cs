using FluentNHibernate.Mapping;
using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Infrastructure.Data.Mappings
{
    public class ContaCorrenteMapping : ClassMap<ContaCorrente>
    {
        const string TABELA = "ContaCorrente";
        const string SEQUENCE = "ContaCorrente_Seq";
        public ContaCorrenteMapping()
        {
            Table(TABELA);
            Id(x => x.Id).GeneratedBy.Sequence(SEQUENCE).Not.Nullable();
            Map(x => x.NomeCooperado).Length(50).Not.Nullable();
            Map(x => x.Numero).UniqueKey("NumeroCooperativa").Length(50).Not.Nullable();
            References(x => x.Cooperativa).UniqueKey("NumeroCooperativa").Not.Nullable();
        }
    }
}
