using RestApiFavoriteContact.Application;
using RestApiFavoriteContact.Application.Interfaces;
using RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys;
using RestApiFavoriteContact.Domain.Core.Interfaces.Services;
using RestApiFavoriteContact.Domain.Services;
using RestApiFavoriteContact.Infrastructure.Data.Repositorys;
using Unity;

namespace RestApiFavoriteContact.Infrastructure.CrossCutting
{
    public static class ContainerRegistration
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IApplicationServiceContatoFavorito, ApplicationServiceContatoFavorito>();
            container.RegisterType<IServiceContatoFavorito, ServiceContatoFavorito> ();
            container.RegisterType<IRepositoryContatoFavorito, RepositoryContatoFavorito>();
            container.RegisterType<IRepositoryContaCorrente, RepositoryContaCorrente>();
            container.RegisterType<IServiceContaCorrente, ServiceContaCorrente>();

        }
    }
}
