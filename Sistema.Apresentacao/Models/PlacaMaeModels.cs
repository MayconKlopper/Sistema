using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class PlacaMaeViewModelLista
    {
        [Display(Name = "Código da placa mãe")]
        public int IDPlacaMae { get; set; }
        [Display(Name = "Marca da placa mãe")]
        public string Marca { get; set; }
        [Display(Name = "Modelo da placa mãe")]
        public string Modelo { get; set; }
    }

    public class PlacaMaeViewModelEdita
    {
        public int IDPlacaMae { get; set; }
        [Display(Name = "Marca da placa mãe")]
        public string Marca { get; set; }
        [Display(Name = "Modelo da placa mãe")]
        public string Modelo { get; set; }
    }
}