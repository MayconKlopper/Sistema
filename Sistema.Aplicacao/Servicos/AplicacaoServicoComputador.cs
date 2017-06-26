using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Aplicacao.Contratos;
using Sistema.Dominio.Contratos.Servicos;
using Sistema.Dominio.Entidades;

namespace Sistema.Aplicacao.Servicos
{
    public class AplicacaoServicoComputador : AplicacaoServicoGenerico<Computador>, IAplicacaoServicoComputador
    {
        private readonly IServicoComputador servico;

        public AplicacaoServicoComputador(IServicoComputador servico)
            : base(servico)
        {
            this.servico = servico;
        }

        public List<Computador> RetornarPorIDUsuario(string ID)
        {
            return servico.RetornarPorIDUsuario(ID);
        }
    }
}
