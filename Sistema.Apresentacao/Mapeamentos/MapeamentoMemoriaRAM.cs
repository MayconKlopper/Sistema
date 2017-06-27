using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using Sistema.Dominio.Entidades;
using Sistema.Apresentacao.Models;

namespace Sistema.Apresentacao.Mapeamentos
{
    public class MapeamentoMemoriaRAM : Profile
    {
        public MapeamentoMemoriaRAM()
        {
            CreateMap<MemoriaRAM, MemoriaRAMViewModelLista>()
                .ForMember(memoriaRAMViewModelLista => memoriaRAMViewModelLista.IDMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAM => memoriaRAM.IDMemoriaRAM))
                .ForMember(memoriaRAMViewModelLista => memoriaRAMViewModelLista.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAM => memoriaRAM.Quantidade))
                .ForMember(memoriaRAMViewModelLista => memoriaRAMViewModelLista.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAM => memoriaRAM.Capacidade))
                ;

            CreateMap<MemoriaRAMViewModelLista, MemoriaRAM>()
                .ForMember(memoriaRAM => memoriaRAM.IDMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAMViewModelLista => memoriaRAMViewModelLista.IDMemoriaRAM))
                .ForMember(memoriaRAM => memoriaRAM.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAMViewModelLista => memoriaRAMViewModelLista.Quantidade))
                .ForMember(memoriaRAM => memoriaRAM.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAMViewModelLista => memoriaRAMViewModelLista.Capacidade))

                //.ForMember(memoriaRAM => memoriaRAM.Computadores[0].IDComputador, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAMViewModelLista => memoriaRAMViewModelLista.IDComputador))
                ;

            CreateMap<MemoriaRAM, MemoriaRAMViewModelEdita>()
                .ForMember(memoriaRAMViewModelEdita => memoriaRAMViewModelEdita.IDMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAM => memoriaRAM.IDMemoriaRAM))
                .ForMember(memoriaRAMViewModelEdita => memoriaRAMViewModelEdita.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAM => memoriaRAM.Quantidade))
                .ForMember(memoriaRAMViewModelEdita => memoriaRAMViewModelEdita.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAM => memoriaRAM.Capacidade))
                ;

            CreateMap<MemoriaRAMViewModelEdita, MemoriaRAM>()
                .ForMember(memoriaRAM => memoriaRAM.IDMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAMViewModelEdita => memoriaRAMViewModelEdita.IDMemoriaRAM))
                .ForMember(memoriaRAM => memoriaRAM.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAMViewModelEdita => memoriaRAMViewModelEdita.Quantidade))
                .ForMember(memoriaRAM => memoriaRAM.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAMViewModelEdita => memoriaRAMViewModelEdita.Capacidade))

                //.ForMember(memoriaRAM => memoriaRAM.Computadores[0].IDComputador, configuracaoMembro => configuracaoMembro.MapFrom(memoriaRAMViewModelEdita => memoriaRAMViewModelEdita.IDComputador))
                ;
        }
    }
}