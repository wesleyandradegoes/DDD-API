using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Domain.Core.Interfaces.Services
{
    public interface IServiceContaCorrente : IServiceBase<ContaCorrente>
    {
        public ContaCorrente GetContaCorrente(int idCooperativa, string numeroContaCorrente);
    }
}
