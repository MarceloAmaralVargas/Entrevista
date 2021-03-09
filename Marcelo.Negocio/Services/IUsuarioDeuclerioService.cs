using Marcelo.Persistencia;
using System.Linq;
using System.Threading.Tasks;

namespace Marcelo.Negocio.Services
{
    public interface IUsuarioDeuclerioService
    {
        Task Create(UsuarioDeuclerio entity);
        Task Delete(int id);
        IQueryable<UsuarioDeuclerio> GetAll();
        Task<UsuarioDeuclerio> GetById(int id);
        Task Update(int id, UsuarioDeuclerio entity);
    }
}