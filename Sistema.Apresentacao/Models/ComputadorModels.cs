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
        [Display(Name = "Código do computador")]
        public int IDComputador { get; set; }

        [Display(Name = "Marca da fonte")]
        public string MarcaFonte { get; set; }
        [Display(Name = "Modelo da fonte")]
        public string ModeloFonte { get; set; }

        [Display(Name = "Quantidade de Hard Discs (HDs)")]
        public int QuantidadeHD { get; set; }
        [Display(Name = "Capacidade do(s) Hard Disc(s) (HD(s))")]
        public string CapacidadeHD { get; set; }

        [Display(Name = "Quantidade de Memórias RAMs")]
        public int QuantidadeMemoriaRAM { get; set; }
        [Display(Name = "capacidade da(s) Memória(s) RAM(s)")]
        public string CapacidadeMemoriaRAM { get; set; }

        [Display(Name = "Marca da placa mãe")]
        public string MarcaPlacaMae { get; set; }
        [Display(Name = "Modelo da placa mãe")]
        public string ModeloPlacaMae { get; set; }

        [Display(Name = "Marca do Processador")]
        public string MarcaProcessador { get; set; }
        [Display(Name = "Modelo do Processador")]
        public string ModeloProcessador { get; set; }
        [Display(Name = "Velocidade do Processador")]
        public string VelocidadeProcessador { get; set; }
    }
}