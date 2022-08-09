using AutoMapper;

namespace RestApiFavoriteContact.Application.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ContatoFavoritoProfileMap>();
            });
        }
    }
}
