using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class MemoriaRAMViewModelLista
    {
        [Display(Name = "Código da(s) Memória(s) RAM(s)")]
        public int IDMemoriaRAM { get; set; }
        [Display(Name = "Quantidade de Memórias RAMs")]
        public int Quantidade { get; set; }
        [Display(Name = "capacidade da(s) Memória(s) RAM(s)")]
        public string Capacidade { get; set; }
    }

    public class MemoriaRAMViewModelEdita
    {
        public int IDMemoriaRAM { get; set; }
        [Display(Name = "Quantidade de Memórias RAMs")]
        public int Quantidade { get; set; }
        [Display(Name = "capacidade da(s) Memória(s) RAM(s)")]
        public string Capacidade { get; set; }
    }
}