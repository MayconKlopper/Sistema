using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using Sistema.Dominio.Entidades;
using Sistema.Apresentacao.Models;

namespace Sistema.Apresentacao.Mapeamentos
{
    public class MapeamentoPlacaMae : Profile
    {
        public MapeamentoPlacaMae()
        {
            CreateMap<PlacaMae, PlacaMaeViewModelLista>()
                .ForMember(PlacaMaeViewModelLista => PlacaMaeViewModelLista.IDPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(placaMae => placaMae.IDPlacaMae))
                .ForMember(PlacaMaeViewModelLista => PlacaMaeViewModelLista.Marca, configuracaoMembro => configuracaoMembro.MapFrom(placaMae => placaMae.Marca))
                .ForMember(PlacaMaeViewModelLista => PlacaMaeViewModelLista.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(placaMae => placaMae.Modelo))
                ;

            CreateMap<PlacaMaeViewModelLista, PlacaMae>()
                .ForMember(placaMae => placaMae.IDPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(placaMaeViewModelLista => placaMaeViewModelLista.IDPlacaMae))
                .ForMember(placaMae => placaMae.Marca, configuracaoMembro => configuracaoMembro.MapFrom(placaMaeViewModelLista => placaMaeViewModelLista.Marca))
                .ForMember(placaMae => placaMae.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(placaMaeViewModelLista => placaMaeViewModelLista.Modelo))
                ;

            CreateMap<PlacaMae, PlacaMaeViewModelEdita>()
                .ForMember(PlacaMaeViewModelEdita => PlacaMaeViewModelEdita.IDPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(placaMae => placaMae.IDPlacaMae))
                .ForMember(PlacaMaeViewModelEdita => PlacaMaeViewModelEdita.Marca, configuracaoMembro => configuracaoMembro.MapFrom(placaMae => placaMae.Marca))
                .ForMember(PlacaMaeViewModelEdita => PlacaMaeViewModelEdita.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(placaMae => placaMae.Modelo))
                ;

            CreateMap<PlacaMaeViewModelEdita, PlacaMae>()
                .ForMember(placaMae => placaMae.IDPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(placaMaeViewModelEdita => placaMaeViewModelEdita.IDPlacaMae))
                .ForMember(placaMae => placaMae.Marca, configuracaoMembro => configuracaoMembro.MapFrom(placaMaeViewModelEdita => placaMaeViewModelEdita.Marca))
                .ForMember(placaMae => placaMae.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(placaMaeViewModelEdita => placaMaeViewModelEdita.Modelo))
                ;
        }
    }
}