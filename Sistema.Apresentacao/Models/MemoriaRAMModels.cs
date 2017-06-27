using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class MemoriaRAMViewModelLista
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }
        [Display(Name = "Código: ")]
        public int IDMemoriaRAM { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "capacidade")]
        public string Capacidade { get; set; }
    }

    public class MemoriaRAMViewModelEdita
    {
        [Display(Name = "Código do Computador: ")]
        public int IDComputador { get; set; }
        [Display(Name = "Código: ")]
        public int IDMemoriaRAM { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "capacidade")]
        public string Capacidade { get; set; }
    }
}