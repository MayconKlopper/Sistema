using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class ComputadorViewModelListar
    {
        [Display(Name = "Código do computador")]
        public int IDComputador { get; set; }

        [Display(Name = "Código da Fonte")]
        public int IDFonte { get; set; }
        [Display(Name = "Marca da fonte")]
        public string MarcaFonte { get; set; }
        [Display(Name = "Modelo da fonte")]
        public string ModeloFonte { get; set; }

        [Display(Name = "Código da placa mãe")]
        public int IDPlacaMae { get; set; }
        [Display(Name = "Marca da placa mãe")]
        public string MarcaPlacaMae { get; set; }
        [Display(Name = "Modelo da placa mãe")]
        public string ModeloPlacaMae { get; set; }

    }
}