using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Sistema.Apresentacao.Models
{
    public class ProcessadorViewModelLista
    {
        [Display(Name = "Código do Processador")]
        public int IDProcessador { get; set; }
        [Display(Name = "Marca do PRocessador")]
        public string Marca { get; set; }
        [Display(Name = "Modelo do Processador")]
        public string Modelo { get; set; }
        [Display(Name = "Velocidade do Processador")]
        public string Velocidade { get; set; }
    }

    public class ProcessadorViewModelEdita
    {
        public int IDProcessador { get; set; }
        [Display(Name = "Marca do Processador")]
        public string Marca { get; set; }
        [Display(Name = "Modelo do Processador")]
        public string Modelo { get; set; }
        [Display(Name = "Velocidade do Processador")]
        public string Velocidade { get; set; }
    }
}