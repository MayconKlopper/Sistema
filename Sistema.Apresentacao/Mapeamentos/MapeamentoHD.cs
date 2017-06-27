using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using Sistema.Dominio.Entidades;
using Sistema.Apresentacao.Models;

namespace Sistema.Apresentacao.Mapeamentos
{
    public class MapeamentoHD : Profile
    {
        public MapeamentoHD()
        {
            CreateMap<HD, HDViewModelLista>()
                .ForMember(hdViewModelLista => hdViewModelLista.IDHD, configuracaoMembro => configuracaoMembro.MapFrom(hd => hd.IDHD))
                .ForMember(hdViewModelLista => hdViewModelLista.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(hd => hd.Quantidade))
                .ForMember(hdViewModelLista => hdViewModelLista.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(hd => hd.Capacidade))
                ;

            CreateMap<HDViewModelLista, HD>()
                .ForMember(hd => hd.IDHD, configuracaoMembro => configuracaoMembro.MapFrom(hdViewModelLista => hdViewModelLista.IDHD))
                .ForMember(hd => hd.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(hdViewModelLista => hdViewModelLista.Quantidade))
                .ForMember(hd => hd.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(hdViewModelLista => hdViewModelLista.Capacidade))

                //.ForMember(hd => hd.Computadores[0].IDComputador, configuracaoMembro => configuracaoMembro.MapFrom(hdViewModelLista => hdViewModelLista.IDComputador))
                ;

            CreateMap<HD, HDViewModelEdita>()
                .ForMember(hdViewModelEdita => hdViewModelEdita.IDHD, configuracaoMembro => configuracaoMembro.MapFrom(hd => hd.IDHD))
                .ForMember(hdViewModelEdita => hdViewModelEdita.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(hd => hd.Quantidade))
                .ForMember(hdViewModelEdita => hdViewModelEdita.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(hd => hd.Capacidade))
                ;

            CreateMap<HDViewModelEdita, HD>()
                .ForMember(hd => hd.IDHD, configuracaoMembro => configuracaoMembro.MapFrom(hdViewModelEdita => hdViewModelEdita.IDHD))
                .ForMember(hd => hd.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(hdViewModelEdita => hdViewModelEdita.Quantidade))
                .ForMember(hd => hd.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(hdViewModelEdita => hdViewModelEdita.Capacidade))

                //.ForMember(hd => hd.Computadores[0].IDComputador, configuracaoMembro => configuracaoMembro.MapFrom(hdViewModelEdita => hdViewModelEdita.IDComputador))
                ;
        }
    }
}