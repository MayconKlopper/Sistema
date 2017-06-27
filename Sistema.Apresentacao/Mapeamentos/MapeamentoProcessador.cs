using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using Sistema.Dominio.Entidades;
using Sistema.Apresentacao.Models;

namespace Sistema.Apresentacao.Mapeamentos
{
    public class MapeamentoProcessador : Profile
    {
        public MapeamentoProcessador()
        {
            CreateMap<Processador, ProcessadorViewModelLista>()
                .ForMember(processadorViewModelLista => processadorViewModelLista.IDProcessador, configuracaoMembro => configuracaoMembro.MapFrom(processador => processador.IDProcessador))
                .ForMember(processadorViewModelLista => processadorViewModelLista.Marca, configuracaoMembro => configuracaoMembro.MapFrom(processador => processador.Marca))
                .ForMember(processadorViewModelLista => processadorViewModelLista.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(processador => processador.Modelo))
                .ForMember(processadorViewModelLista => processadorViewModelLista.Velocidade, configuracaoMembro => configuracaoMembro.MapFrom(processador => processador.Velocidade))
                ;

            CreateMap<ProcessadorViewModelLista, Processador>()
                .ForMember(processador => processador.IDProcessador, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelLista => processadorViewModelLista.IDProcessador))
                .ForMember(processador => processador.Marca, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelLista => processadorViewModelLista.Marca))
                .ForMember(processador => processador.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelLista => processadorViewModelLista.Modelo))
                .ForMember(processador => processador.Velocidade, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelLista => processadorViewModelLista.Velocidade))

                //.ForMember(processador => processador.Computadores[0].IDComputador, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelLista => processadorViewModelLista.IDComputador))
                ;

            CreateMap<Processador, ProcessadorViewModelEdita>()
                .ForMember(processadorViewModelEdita => processadorViewModelEdita.IDProcessador, configuracaoMembro => configuracaoMembro.MapFrom(processador => processador.IDProcessador))
                .ForMember(processadorViewModelEdita => processadorViewModelEdita.Marca, configuracaoMembro => configuracaoMembro.MapFrom(processador => processador.Marca))
                .ForMember(processadorViewModelEdita => processadorViewModelEdita.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(processador => processador.Modelo))
                .ForMember(processadorViewModelEdita => processadorViewModelEdita.Velocidade, configuracaoMembro => configuracaoMembro.MapFrom(processador => processador.Velocidade))
                ;

            CreateMap<ProcessadorViewModelEdita, Processador>()
                .ForMember(processador => processador.IDProcessador, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelEdita => processadorViewModelEdita.IDProcessador))
                .ForMember(processador => processador.Marca, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelEdita => processadorViewModelEdita.Marca))
                .ForMember(processador => processador.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelEdita => processadorViewModelEdita.Modelo))
                .ForMember(processador => processador.Velocidade, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelEdita => processadorViewModelEdita.Velocidade))

                //.ForMember(processador => processador.Computadores[0].IDComputador, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelEdita => processadorViewModelEdita.IDComputador))
                ;

        }
    }
}