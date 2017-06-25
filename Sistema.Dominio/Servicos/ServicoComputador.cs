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
    public class ServicoComputador : ServicoGenerico<Computador>, IServicoComputador
    {
        private readonly IRepositorioComputador repositorio;

        public ServicoComputador(IRepositorioComputador repositorio)
            : base(repositorio)
        {
            this.repositorio = repositorio;
        }
    }
}
