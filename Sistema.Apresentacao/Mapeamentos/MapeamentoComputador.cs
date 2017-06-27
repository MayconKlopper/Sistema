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


            CreateMap<Computador, ComputadorViewModelExclui>()
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.IDFonte, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.Fonte.IDFonte))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.MarcaFonte, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.Fonte.Marca))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.ModeloFonte, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.Fonte.Modelo))

                .ForMember(computadorViewModelExclui => computadorViewModelExclui.IDHD, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.HD.IDHD))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.QuantidadeHD, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.HD.Quantidade))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.CapacidadeHD, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.HD.Capacidade))

                .ForMember(computadorViewModelExclui => computadorViewModelExclui.IDMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.MemoriaRAM.IDMemoriaRAM))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.QuantidadeMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.MemoriaRAM.Quantidade))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.CapacidadeMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.MemoriaRAM.Capacidade))

                .ForMember(computadorViewModelExclui => computadorViewModelExclui.IDPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.IDPlacaMae))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.MarcaPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.PlacaMae.Marca))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.ModeloPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.PlacaMae.Modelo))

                .ForMember(computadorViewModelExclui => computadorViewModelExclui.IDProcessador, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.IDProcessador))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.MarcaProcessador, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.Processador.Marca))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.ModeloProcessador, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.Processador.Modelo))
                .ForMember(computadorViewModelExclui => computadorViewModelExclui.VelocidadeProcessador, configuracaoMembro => configuracaoMembro.MapFrom(computador => computador.Processador.Velocidade))
                ;

            CreateMap<ComputadorViewModelExclui, Fonte>()
                .ForMember(fonte => fonte.IDFonte, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.IDFonte))
                .ForMember(fonte => fonte.Marca, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.MarcaFonte))
                .ForMember(fonte => fonte.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.ModeloFonte))
                ;

            CreateMap<ComputadorViewModelExclui, HD>()
                .ForMember(hd => hd.IDHD, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.IDHD))
                .ForMember(hd => hd.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.QuantidadeHD))
                .ForMember(hd => hd.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.CapacidadeHD))
                ;

            CreateMap<ComputadorViewModelExclui, MemoriaRAM>()
                .ForMember(memoriaRAM => memoriaRAM.IDMemoriaRAM, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.IDMemoriaRAM))
                .ForMember(memoriaRAM => memoriaRAM.Quantidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.QuantidadeMemoriaRAM))
                .ForMember(memoriaRAM => memoriaRAM.Capacidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.CapacidadeMemoriaRAM))
                ;

            CreateMap<ComputadorViewModelExclui, PlacaMae>()
                .ForMember(placaMae => placaMae.IDPlacaMae, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.IDPlacaMae))
                .ForMember(placaMae => placaMae.Marca, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.MarcaPlacaMae))
                .ForMember(placaMae => placaMae.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.ModeloPlacaMae))
                ;

            CreateMap<ComputadorViewModelExclui, Processador>()
                .ForMember(processador => processador.IDProcessador, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.IDProcessador))
                .ForMember(processador => processador.Marca, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.MarcaProcessador))
                .ForMember(processador => processador.Modelo, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.ModeloProcessador))
                .ForMember(processador => processador.Velocidade, configuracaoMembro => configuracaoMembro.MapFrom(computadorViewModelExclui => computadorViewModelExclui.VelocidadeProcessador))
                ;
        }
    }
}