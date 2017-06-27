using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class ProcessadorViewModelLista
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }
        [Display(Name = "Código: ")]
        public int IDProcessador { get; set; }
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Display(Name = "Velocidade")]
        public string Velocidade { get; set; }
    }

    public class ProcessadorViewModelEdita
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }
        [Display(Name = "Código: ")]
        public int IDProcessador { get; set; }
        [Display(Name = "Marca")]
        public string Marca { get; set; }
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        [Display(Name = "Velocidade")]
        public string Velocidade { get; set; }
    }
}