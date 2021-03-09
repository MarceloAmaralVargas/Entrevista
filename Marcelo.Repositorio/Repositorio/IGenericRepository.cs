using Marcelo.Dominio.Modelo;
using System.Linq;
using System.Threading.Tasks;

namespace Marcelo.Repositorio.Repositorio
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        Task Create(TEntity entity);
        Task Delete(int id);
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task Update(int id, TEntity entity);
    }
}