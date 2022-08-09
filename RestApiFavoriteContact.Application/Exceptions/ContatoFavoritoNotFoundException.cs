using System;

namespace RestApiFavoriteContact.Application.Exceptions
{
    [Serializable]
    public class ContatoFavoritoNotFoundException : Exception
    {
        public ContatoFavoritoNotFoundException() { }

        public ContatoFavoritoNotFoundException(string message)
        : base(message) { }
    }
}
