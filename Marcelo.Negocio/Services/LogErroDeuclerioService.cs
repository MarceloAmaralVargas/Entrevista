using Marcelo.Persistencia;
using Marcelo.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Negocio.Services
{
    public class LogErroDeuclerioService : ILogErroDeuclerioRepositorio, ILogErroDeuclerioService
    {
        private readonly ILogErroDeuclerioRepositorio _logErroDeuclerioRepositorio;

        public LogErroDeuclerioService(ILogErroDeuclerioRepositorio logErroDeuclerioRepositorio)
        {
            _logErroDeuclerioRepositorio = logErroDeuclerioRepositorio;
        }

        public Task Create(LogErroDeuclerio entity)
        {
            return _logErroDeuclerioRepositorio.Create(entity);
        }

        public Task Delete(int id)
        {
            return _logErroDeuclerioRepositorio.Delete(id);
        }

        public IQueryable<LogErroDeuclerio> GetAll()
        {
            return _logErroDeuclerioRepositorio.GetAll();
        }

        public Task<LogErroDeuclerio> GetById(int id)
        {
            return _logErroDeuclerioRepositorio.GetById(id);
        }

        public Task Update(int id, LogErroDeuclerio entity)
        {
            return _logErroDeuclerioRepositorio.Update(id, entity);
        }
    }
}
