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
    public class AplicacaoServicoProcessador : AplicacaoServicoGenerico<Processador>, IAplicacaoServicoProcessador
    {
        private readonly IServicoProcessador servico;

        public AplicacaoServicoProcessador(IServicoProcessador servico)
            : base(servico)
        {
            this.servico = servico;
        }
    }
}
