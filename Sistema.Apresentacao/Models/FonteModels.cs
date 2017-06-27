using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class FonteViewModelLista
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }
        [Display(Name = "Código: ")]
        public int IDFonte { get; set; }
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
    }

    public class FonteViewModelEdita
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }
        [Display(Name = "Código: ")]
        public int IDFonte { get; set; }
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
    }
}