using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class HDViewModelLista
    {
        [Display(Name = "Código do(s) Hard Disc(s) (HD(s))")]
        public int IDHD { get; set; }
        [Display(Name = "Quantidade de Hard Discs (HDs)")]
        public int Quantidade { get; set; }
        [Display(Name = "Capacidade do(s) Hard Disc(s) (HD(s))")]
        public string Capacidade { get; set; }
    }

    public class HDViewModelEdita
    {
        public int IDHD { get; set; }
        [Display(Name = "Quantidade de Hard Discs (HDs)")]
        public int Quantidade { get; set; }
        [Display(Name = "Capacidade do(s) Hard Disc(s) (HD(s))")]
        public string Capacidade { get; set; }
    }
}