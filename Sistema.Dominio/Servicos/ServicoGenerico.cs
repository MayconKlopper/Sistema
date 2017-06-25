using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Contratos.Servicos;
using Sistema.Dominio.Contratos.Repositorios;

namespace Sistema.Dominio.Servicos
{
    public class ServicoGenerico<TEntity> : IServicoGenerico<TEntity>
        where TEntity : class
    {
        private readonly IRepositorioGenerico<TEntity> repositorio;

        public ServicoGenerico(IRepositorioGenerico<TEntity> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Inserir(TEntity obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Insert(obj);
            }
            catch (Exception ex)
            {
                repositorio.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(TEntity obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Update(obj);
            }
            catch (Exception ex)
            {
                repositorio.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public void Deletar(TEntity obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Delete(obj);
            }
            catch (Exception ex)
            {
                repositorio.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public TEntity RetornarPorID(int ID)
        {
            try
            {
                return repositorio.FindByID(ID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TEntity> RetornarTodos()
        {
            try
            {
                return repositorio.FindAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
