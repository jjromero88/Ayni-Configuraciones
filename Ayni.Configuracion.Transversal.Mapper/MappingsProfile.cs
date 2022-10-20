using AutoMapper;
using Ayni.Configuracion.Aplication.Dto;
using Ayni.Configuracion.Domain.Entity;

namespace Ayni.Configuracion.Transversal.Mapper
{
    /*
     * Mapeo de manera automatica entrelos objetos DTO y entidades de negocio o biseversa
     * siempre y cuando el nombre y tip de dato sean los mimos caso contrario se tiene q hacer el mapeo atributo por atributo
     */

    public class MappingsProfile : Profile
    {

        public MappingsProfile()
        {

            /*
            * En caso que nombre y tipo de dato son iguales
            */

            CreateMap<Moneda, MonedaDto>().ReverseMap();

            /*
             * En caso que nombre y tipo de dato son distintos
             * mapear atributo por atributo
             */

            //CreateMap<Moneda, MonedaDto>().ReverseMap()
            //    .ForMember(destination => destination.moneda_id, source => source.MapFrom(src => src.moneda_id))
            //    .ForMember(destination => destination.descripcion, source => source.MapFrom(src => src.descripcion))
            //    .ForMember(destination => destination.abreviatura, source => source.MapFrom(src => src.abreviatura))
            //    .ForMember(destination => destination.simbolo, source => source.MapFrom(src => src.simbolo));


        }

    }
}