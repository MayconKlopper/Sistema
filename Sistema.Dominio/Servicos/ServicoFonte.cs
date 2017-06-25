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
    public class ServicoFonte : ServicoGenerico<Fonte>, IServicoFonte
    {
        private readonly IRepositorioFonte repositorio;

        public ServicoFonte(IRepositorioFonte repositorio)
            : base(repositorio)
        {
            this.repositorio = repositorio;
        }
    }
}
