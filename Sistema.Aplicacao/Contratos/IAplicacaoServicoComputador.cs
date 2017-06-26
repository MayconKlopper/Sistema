using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Entidades;

namespace Sistema.Aplicacao.Contratos
{
    public interface IAplicacaoServicoComputador : IAplicacaoServicoGenerico<Computador>
    {
        List<Computador> RetornarPorIDUsuario(string ID);
    }
}
