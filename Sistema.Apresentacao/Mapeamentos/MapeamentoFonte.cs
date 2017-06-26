using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using Sistema.Dominio.Entidades;
using Sistema.Apresentacao.Models;

namespace Sistema.Apresentacao.Mapeamentos
{
    public class MapeamentoFonte : Profile
    {
        public MapeamentoFonte()
        {
            CreateMap<Fonte, FonteViewModelLista>()
                .ForMember(fonteViewModelLista => fonteViewModelLista.IDFonte, configuracaoMembro => configuracaoMembro.MapFrom(fonte => fonte.IDFonte))
                .ForMember(fonteViewModelLista => fonteViewModelLista.Marca, configuracaoMembro => configuracaoMembro.MapFrom(fonte => fonte.Marca))
                .ForMember(fonteViewModelLista => fonteViewModelLista.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(fonte => fonte.Modelo))
                ;

            CreateMap<FonteViewModelLista, Fonte>()
                .ForMember(fonte => fonte.IDFonte, configuracaoMembro => configuracaoMembro.MapFrom(fonteViewModelLista => fonteViewModelLista.IDFonte))
                .ForMember(fonte => fonte.Marca, configuracaoMembro => configuracaoMembro.MapFrom(fonteViewModelLista => fonteViewModelLista.Marca))
                .ForMember(fonte => fonte.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(fonteViewModelLista => fonteViewModelLista.Modelo))
                ;

            CreateMap<Fonte, FonteViewModelEdita>()
                .ForMember(fonteViewModelEdita => fonteViewModelEdita.IDFonte, configuracaoMembro => configuracaoMembro.MapFrom(fonte => fonte.IDFonte))
                .ForMember(fonteViewModelEdita => fonteViewModelEdita.Marca, configuracaoMembro => configuracaoMembro.MapFrom(fonte => fonte.Marca))
                .ForMember(fonteViewModelEdita => fonteViewModelEdita.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(fonte => fonte.Modelo))
                ;

            CreateMap<FonteViewModelEdita, Fonte>()
                .ForMember(fonte => fonte.IDFonte, configuracaoMembro => configuracaoMembro.MapFrom(fonteViewModelEdita => fonteViewModelEdita.IDFonte))
                .ForMember(fonte => fonte.Marca, configuracaoMembro => configuracaoMembro.MapFrom(fonteViewModelEdita => fonteViewModelEdita.Marca))
                .ForMember(fonte => fonte.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(fonteViewModelEdita => fonteViewModelEdita.Modelo))
                ;
        }
    }
}