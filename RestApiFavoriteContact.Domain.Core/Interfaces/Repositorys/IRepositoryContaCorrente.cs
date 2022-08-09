using RestApiFavoriteContact.Domain.Entitys;

namespace RestApiFavoriteContact.Domain.Core.Interfaces.Repositorys
{
    public interface IRepositoryContaCorrente : IRepositoryBase<ContaCorrente>
    {
        public ContaCorrente GetContaCorrente(int idCooperativa, string numeroContaCorrente);
    }
}
