﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Dominio.Entidades
{
    public class PlacaMae
    {
        public int IDPlacaMae { get; set; }
        //public int IDComputador { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }

        #region Relacionamentos

        public virtual List<Computador> Computadores { get; set; }

        #endregion
    }
}
