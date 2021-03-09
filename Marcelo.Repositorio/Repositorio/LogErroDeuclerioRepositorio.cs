using Marcelo.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Repositorio.Repositorio
{
    public class LogErroDeuclerioRepositorio : GenericRepository<LogErroDeuclerio>, ILogErroDeuclerioRepositorio
    {
        public LogErroDeuclerioRepositorio(BancoDeuclerioContext dbContext) : base(dbContext)
        {
        }

    }
}
