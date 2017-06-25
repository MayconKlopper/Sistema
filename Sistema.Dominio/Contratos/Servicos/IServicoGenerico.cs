using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Dominio.Contratos.Servicos
{
    public interface IServicoGenerico<TEntity>
        where TEntity : class
    {
        void Inserir(TEntity obj);
        void Atualizar(TEntity obj);
        void Deletar(TEntity obj);

        TEntity RetornarPorID(int ID);
        List<TEntity> RetornarTodos();
    }
}
