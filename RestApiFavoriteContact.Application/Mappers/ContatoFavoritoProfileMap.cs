using AutoMapper;
using RestApiFavoriteContact.Application.Dtos;
using RestApiFavoriteContact.Domain.Entitys;
using RestApiFavoriteContact.Domain.Enums;
using System;

namespace RestApiFavoriteContact.Application.Mappers
{
    public class ContatoFavoritoProfileMap : Profile
    {
        public ContatoFavoritoProfileMap()
        {
            CreateMap<ContatoFavoritoInclusaoDto, ContatoFavorito>(MemberList.None)
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.TipoChavePix, opt => opt.MapFrom(src => Enum.GetName(typeof(TipoChavePix), src.TipoChavePix)))
                .ForMember(dest => dest.ChavePix, opt => opt.MapFrom(src => src.ChavePix))
                .ForMember(dest => dest.ContaCorrente, opt => opt.Ignore());
            //.ForMember(dest => dest.ContaCorrente, opt => opt.MapFrom(src => Mapper.Map<ContaCorrente>(src)));

            //CreateMap<ContatoFavoritoDto, ContaCorrente>(MemberList.None)
            //    .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.ContaCorrente))
            //    .ForMember(dest => dest.Cooperativa, opt => opt.MapFrom(src => Mapper.Map<Cooperativa>(src)));

            //CreateMap<ContatoFavoritoDto, Cooperativa>(MemberList.None)
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdCooperativa));
        }
    }
}
