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
    public class AplicacaoServicoMemoriaRAM : AplicacaoServicoGenerico<MemoriaRAM>, IAplicacaoServicoMemoriaRAM
    {
        private readonly IServicoMemoriaRAM servico;

        public AplicacaoServicoMemoriaRAM(IServicoMemoriaRAM servico)
            : base(servico)
        {
            this.servico = servico;
        }
    }
}
