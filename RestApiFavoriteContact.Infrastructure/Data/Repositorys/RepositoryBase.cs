using NHibernate;
using RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys;
using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Infrastructure.Data.Repositorys
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        public void Save(T entity)
        {
            using (ISession session = OracleSessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(entity);
                transaction.Commit();
            }
        }

        public void Update(T entity)
        {
            using (ISession session = OracleSessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(entity);
                transaction.Commit();
            }
        }

        public void Delete(T entity)
        {
            using (ISession session = OracleSessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(entity);
                transaction.Commit();
            }
        }
    }
}
