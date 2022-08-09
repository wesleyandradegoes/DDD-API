using System;

namespace RestApiFavoriteContact.Application.Exceptions
{
    [Serializable]
    public class ContaCorrenteNotFoundException : Exception
    {
        public ContaCorrenteNotFoundException() {}

        public ContaCorrenteNotFoundException(string message)
        : base(message) { }
    }
}
