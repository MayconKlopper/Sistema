using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AutoMapper;
using Sistema.Dominio.Entidades;
using Sistema.Apresentacao.Models;

namespace Sistema.Apresentacao.Mapeamentos
{
    public class MapeamentoComputador : Profile
    {
        public MapeamentoComputador()
        {
            CreateMap<Computador, ComputadorViewModelLista>()
                .ForMember(computadorViewModelLista => computadorViewModelLista.IDComputador, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.IDComputador))
                .ForMember(computadorViewModelLista => computadorViewModelLista.IDFonte, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.Fonte.IDFonte))
                .ForMember(computadorViewModelLista => computadorViewModelLista.IDHD, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.HD.IDHD))
                .ForMember(computadorViewModelLista => computadorViewModelLista.IDMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.MemoriaRAM.IDMemoriaRAM))
                .ForMember(computadorViewModelLista => computadorViewModelLista.IDPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.PlacaMae.IDPlacaMae))
                .ForMember(computadorViewModelLista => computadorViewModelLista.IDProcessador, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.Processador.IDProcessador))
                ;

            CreateMap<ComputadorViewModelCria, Fonte>()
                .ForMember(fonte => fonte.Marca, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelCria => computadorViewModelCria.MarcaFonte))
                .ForMember(fonte => fonte.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelCria => computadorViewModelCria.ModeloFonte))
                ;

            CreateMap<ComputadorViewModelCria, HD>()
                .ForMember(hd => hd.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelCria => computadorViewModelCria.QuantidadeHD))
                .ForMember(hd => hd.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelCria => computadorViewModelCria.CapacidadeHD))
                ;

            CreateMap<ComputadorViewModelCria, MemoriaRAM>()
                .ForMember(memoriaRAM => memoriaRAM.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelCria => computadorViewModelCria.QuantidadeMemoriaRAM))
                .ForMember(memoriaRAM => memoriaRAM.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelCria => computadorViewModelCria.CapacidadeMemoriaRAM))
                ;

            CreateMap<ComputadorViewModelCria, PlacaMae>()
                .ForMember(placaMae => placaMae.Marca, configuracaoMembro => configuracaoMembro.MapFrom(placaMaeViewModelLista => placaMaeViewModelLista.MarcaPlacaMae))
                .ForMember(placaMae => placaMae.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(placaMaeViewModelLista => placaMaeViewModelLista.ModeloPlacaMae))
                ;

            CreateMap<ComputadorViewModelCria, Processador>()
                .ForMember(processador => processador.Marca, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelLista => processadorViewModelLista.MarcaProcessador))
                .ForMember(processador => processador.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelLista => processadorViewModelLista.ModeloProcessador))
                .ForMember(processador => processador.Velocidade, configuracaoMembro => configuracaoMembro.MapFrom(processadorViewModelLista => processadorViewModelLista.VelocidadeProcessador))
                ;
        }
    }
}