namespace RestApiFavoriteContact.Domain.Entitys
{
    public class ContaCorrente : EntityBase
    {
        public virtual Cooperativa Cooperativa { get; set; }
        public virtual string Numero { get; set; }
        public virtual string NomeCooperado { get; set; }
    }
}
