using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Dominio.Contratos.Repositorios
{
    public interface IRepositorioGenerico<TEntity>
        where TEntity : class
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);

        TEntity FindByID(int ID);
        List<TEntity> FindAll();
    }
}
