using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class FonteViewModelLista
    {
        [Display(Name = "Código da Fonte")]
        public int IDFonte { get; set; }
        [Display(Name = "Marca da fonte")]
        public string Marca { get; set; }
        [Display(Name = "Modelo da fonte")]
        public string Modelo { get; set; }
    }

    public class FonteViewModelEdita
    {
        public int IDFonte { get; set; }
        [Display(Name = "Marca da fonte")]
        public string Marca { get; set; }
        [Display(Name = "Modelo da fonte")]
        public string Modelo { get; set; }
    }
}