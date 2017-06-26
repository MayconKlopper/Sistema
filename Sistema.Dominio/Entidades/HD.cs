using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Dominio.Entidades
{
    public class HD
    {
        public int IDHD { get; set; }
        //public int IDComputador { get; set; }
        public int Quantidade { get; set; }
        public string Capacidade { get; set; }

        #region Relacionamentos

        public virtual List<Computador> Computadores { get; set; }

        #endregion
    }
}
