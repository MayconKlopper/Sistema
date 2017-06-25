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
    public class AplicacaoServicoHD : AplicacaoServicoGenerico<HD>, IAplicacaoServicoHD
    {
        private readonly IServicoHD servico;

        public AplicacaoServicoHD(IServicoHD servico)
            : base(servico)
        {
            this.servico = servico;
        }
    }
}
