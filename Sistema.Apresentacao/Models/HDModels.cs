using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class HDViewModelLista
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }
        [Display(Name = "Código: ")]
        public int IDHD { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "Capacidade")]
        public string Capacidade { get; set; }
    }

    public class HDViewModelEdita
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }
        [Display(Name = "Código: ")]
        public int IDHD { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "Capacidade")]
        public string Capacidade { get; set; }
    }
}