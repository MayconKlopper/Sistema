using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class ComputadorViewModelLista
    {
        [Display(Name = "Código do computador")]
        public int IDComputador { get; set; }

        public int IDFonte { get; set; }
        public int IDHD { get; set; }
        public int IDMemoriaRAM { get; set; }
        public int IDPlacaMae { get; set; }
        public int IDProcessador { get; set; }
    }

    public class ComputadorViewModelCria
    {
        [Display(Name = "Marca")]
        public string MarcaFonte { get; set; }
        [Display(Name = "Modelo")]
        public string ModeloFonte { get; set; }

        [Display(Name = "Quantidade")]
        public int QuantidadeHD { get; set; }
        [Display(Name = "Capacidade")]
        public string CapacidadeHD { get; set; }

        [Display(Name = "Quantidade")]
        public int QuantidadeMemoriaRAM { get; set; }
        [Display(Name = "capacidade")]
        public string CapacidadeMemoriaRAM { get; set; }

        [Display(Name = "Marca")]
        public string MarcaPlacaMae { get; set; }
        [Display(Name = "Modelo")]
        public string ModeloPlacaMae { get; set; }

        [Display(Name = "Marca")]
        public string MarcaProcessador { get; set; }
        [Display(Name = "Modelo")]
        public string ModeloProcessador { get; set; }
        [Display(Name = "Velocidade")]
        public string VelocidadeProcessador { get; set; }
    }

    public class ComputadorViewModelExclui
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }

        [Display(Name = "Código: ")]
        public int IDFonte { get; set; }
        [Display(Name = "Marca")]
        public string MarcaFonte { get; set; }
        [Display(Name = "Modelo")]
        public string ModeloFonte { get; set; }

        [Display(Name = "Código: ")]
        public int IDHD { get; set; }
        [Display(Name = "Quantidade")]
        public int QuantidadeHD { get; set; }
        [Display(Name = "Capacidade")]
        public string CapacidadeHD { get; set; }

        [Display(Name = "Código: ")]
        public int IDMemoriaRAM { get; set; }
        [Display(Name = "Quantidade")]
        public int QuantidadeMemoriaRAM { get; set; }
        [Display(Name = "capacidade")]
        public string CapacidadeMemoriaRAM { get; set; }

        [Display(Name = "Código: ")]
        public int IDPlacaMae { get; set; }
        [Display(Name = "Marca")]
        public string MarcaPlacaMae { get; set; }
        [Display(Name = "Modelo")]
        public string ModeloPlacaMae { get; set; }

        [Display(Name = "Código: ")]
        public int IDProcessador { get; set; }
        [Display(Name = "Marca")]
        public string MarcaProcessador { get; set; }
        [Display(Name = "Modelo")]
        public string ModeloProcessador { get; set; }
        [Display(Name = "Velocidade")]
        public string VelocidadeProcessador { get; set; }
    }
}