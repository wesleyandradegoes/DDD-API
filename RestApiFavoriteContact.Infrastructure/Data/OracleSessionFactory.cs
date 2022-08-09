using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using RestApiFavoriteContact.Infrastructure.Data.Mappings;

namespace RestApiFavoriteContact.Infrastructure.Data
{
    public class OracleSessionFactory
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Fluently.Configure()
                    .Database(OracleManagedDataClientConfiguration.Oracle10
                    .ConnectionString("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=SYSTEM;Password=admin;")
                    .Driver<NHibernate.Driver.OracleManagedDataClientDriver>())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ContatoFavoritoMapping>())
                    .ExposeConfiguration(config =>
                    {
                        SchemaExport schemaExport = new SchemaExport(config);
                    })
                    .BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
