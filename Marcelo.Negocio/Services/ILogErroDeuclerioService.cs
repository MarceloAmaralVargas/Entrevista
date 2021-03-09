using Marcelo.Persistencia;
using System.Linq;
using System.Threading.Tasks;

namespace Marcelo.Negocio.Services
{
    public interface ILogErroDeuclerioService
    {
        Task Create(LogErroDeuclerio entity);
        Task Delete(int id);
        IQueryable<LogErroDeuclerio> GetAll();
        Task<LogErroDeuclerio> GetById(int id);
        Task Update(int id, LogErroDeuclerio entity);
    }
}