using NHibernate;
using RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys;
using RestApiFavoriteContact.Domain.Entitys;
using System.Linq;

namespace RestApiFavoriteContact.Infrastructure.Data.Repositorys
{
    public class RepositoryContatoFavorito : RepositoryBase<ContatoFavorito>, IRepositoryContatoFavorito
    {
        public ContatoFavorito GetContatoFavorito(int idContaCorrente, string chavePix)
        {
            using (ISession session = OracleSessionFactory.OpenSession())
            {
                return session.Query<ContatoFavorito>().Where(cf => cf.ContaCorrente.Id == idContaCorrente && cf.ChavePix == chavePix).FirstOrDefault();
            }
        }
    }
}
