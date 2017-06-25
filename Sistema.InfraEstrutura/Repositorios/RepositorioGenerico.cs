using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Sistema.InfraEstrutura.Contexto;

namespace Sistema.InfraEstrutura.Repositorios
{
    //classe abstrata -> somente para ser herdada..
    //TEntity -> tipo de dado generico (qualquer classe)
    public abstract class RepositorioGenerico<TEntity>
        where TEntity : class
    {

        //método para inserir um registro na base de dados..
        public virtual void Insert(TEntity obj)
        {
            using (Conexao Con = new Conexao()) //instanciando..
            {
                Con.Entry(obj).State = EntityState.Added; //INSERT
                Con.SaveChanges(); //executar..
            } //destruindo..
        }

        //método para atualizar um registro na base de dados..
        public virtual void Update(TEntity obj)
        {
            using (Conexao Con = new Conexao()) //instanciando..
            {
                Con.Entry(obj).State = EntityState.Modified; //UPDATE
                Con.SaveChanges(); //executar..
            } //destruindo..
        }

        //método para excluir um registro na base de dados..
        public virtual void Delete(TEntity obj)
        {
            using (Conexao Con = new Conexao()) //instanciando..
            {
                Con.Entry(obj).State = EntityState.Deleted; //DELETE
                Con.SaveChanges(); //executar..
            } //destruindo..
        }

        //método para listar todos os registros de uma entidade..
        public List<TEntity> FindAll()
        {
            Conexao Con = new Conexao();
           
            //select * from TEntity
            return Con.Set<TEntity>().ToList();

        }

        //método para buscar 1 registro pelo id..
        public TEntity FindById(int id)
        {
            Conexao Con = new Conexao();

            //select * from Entity where Id = ?
            return Con.Set<TEntity>().Find(id);
        }

        public TEntity FindByIDWithoutConnection(int id)
        {
            using(Conexao Con = new Conexao())
            {
                //select * from Entity where Id = ?
                return Con.Set<TEntity>().Find(id);
            }
        }
    }
}

