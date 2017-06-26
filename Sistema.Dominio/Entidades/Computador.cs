using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Dominio.Entidades
{
    public class Computador
    {
        public int IDComputador { get; set; }
        public int IDPlacaMae { get; set; }
        public int IDMemoriaRAM { get; set; }
        public int IDHD { get; set; }
        public int IDFonte { get; set; }
        public int IDProcessador { get; set; }
        public string IDUsuario { get; set; }

        #region Relacionamentos

        public virtual PlacaMae PlacaMae { get; set; }
        public virtual MemoriaRAM MemoriaRAM { get; set; }
        public virtual HD HD { get; set; }
        public virtual Fonte Fonte { get; set; }
        public virtual Processador Processador { get; set; }

        #endregion
    }
}
