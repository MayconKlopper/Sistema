using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Aplicacao.Contratos;
using Sistema.Dominio.Contratos.Servicos;

namespace Sistema.Aplicacao.Servicos
{
    public class AplicacaoServicoGenerico<TEntity> : IAplicacaoServicoGenerico<TEntity>
        where TEntity : class
    {
        private readonly IServicoGenerico<TEntity> servico;

        public AplicacaoServicoGenerico(IServicoGenerico<TEntity> servico)
        {
            this.servico = servico;
        }

        public void Inserir(TEntity obj)
        {
            servico.Inserir(obj);
        }

        public void Atualizar(TEntity obj)
        {
            servico.Atualizar(obj);
        }

        public void Deletar(TEntity obj)
        {
            servico.Deletar(obj);
        }

        public TEntity RetornarPorID(int ID)
        {
            return servico.RetornarPorID(ID);
        }

        public List<TEntity> RetornaTodos()
        {
            return servico.RetornarTodos();
        }
    }
}
