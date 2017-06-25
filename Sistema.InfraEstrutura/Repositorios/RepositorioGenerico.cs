using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Sistema.InfraEstrutura.Contexto;
using Sistema.Dominio.Contratos.Repositorios;

namespace Sistema.InfraEstrutura.Repositorios
{
    public abstract class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity>
        where TEntity : class
    {

        protected Conexao conexao;
        protected DbContextTransaction transacao;

        public RepositorioGenerico()
        {
            conexao = new Conexao();
        }

        public void BeginTransaction()
        {
            transacao = conexao.Database.BeginTransaction();
        }

        public void Commit()
        {
            transacao.Commit();
        }

        public void Rollback()
        {
            transacao.Rollback();
        }

        public virtual void Insert(TEntity obj)
        {
            conexao.Entry(obj).State = EntityState.Added;
            conexao.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            conexao.Entry(obj).State = EntityState.Modified;
            conexao.SaveChanges();
        }

        public virtual void Delete(TEntity obj)
        {
            conexao.Entry(obj).State = EntityState.Deleted;
            conexao.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return conexao.Set<TEntity>().ToList();
        }

        public TEntity FindByID(int id)
        {
            return conexao.Set<TEntity>().Find(id);
        }
    }
}

