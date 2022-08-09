using RestApiFavoriteContact.Domain.Entitys;
using RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys;
using NHibernate;
using System.Linq;

namespace RestApiFavoriteContact.Infrastructure.Data.Repositorys
{
    public class RepositoryContaCorrente : RepositoryBase<ContaCorrente>, IRepositoryContaCorrente
    {
        public ContaCorrente GetContaCorrente(int idCooperativa, string numeroContaCorrente)
        {
            using (ISession session = OracleSessionFactory.OpenSession())
            {
                return session.Query<ContaCorrente>().Where(cc => cc.Cooperativa.Id == idCooperativa && cc.Numero.Equals(numeroContaCorrente)).FirstOrDefault();
            }
        }
    }
}
