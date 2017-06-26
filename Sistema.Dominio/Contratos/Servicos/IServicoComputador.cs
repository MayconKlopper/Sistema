using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Entidades;

namespace Sistema.Dominio.Contratos.Servicos
{
    public interface IServicoComputador : IServicoGenerico<Computador>
    {
        List<Computador> RetornarPorIDUsuario(string ID);
    }
}
