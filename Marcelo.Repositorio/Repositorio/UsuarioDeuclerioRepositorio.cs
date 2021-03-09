using Marcelo.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Repositorio.Repositorio
{
    public class UsuarioDeuclerioRepositorio : GenericRepository<UsuarioDeuclerio>, IUsuarioDeuclerioRepositorio
    {
        public UsuarioDeuclerioRepositorio(BancoDeuclerioContext dbContext) : base(dbContext)
        {
        }

    }
}
