using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Contratos.Servicos;
using Sistema.Dominio.Contratos.Repositorios;
using Sistema.Dominio.Entidades;

namespace Sistema.Dominio.Servicos
{
    public class ServicoMemoriaRAM : ServicoGenerico<MemoriaRAM>, IServicoMemoriaRAM
    {
        private readonly IRepositorioMemoriaRAM repositorio;

        public ServicoMemoriaRAM(IRepositorioMemoriaRAM repositorio)
            : base(repositorio)
        {
            this.repositorio = repositorio;
        }
    }
}
