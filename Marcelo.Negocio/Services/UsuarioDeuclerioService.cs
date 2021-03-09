using Marcelo.Persistencia;
using Marcelo.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcelo.Negocio.Services
{
    public class UsuarioDeuclerioService : IUsuarioDeuclerioRepositorio, IUsuarioDeuclerioService
    {
        private readonly IUsuarioDeuclerioRepositorio _usuarioDeuclerioRepositorio;

        public UsuarioDeuclerioService(IUsuarioDeuclerioRepositorio usuarioDeuclerioRepositorio)
        {
            _usuarioDeuclerioRepositorio = usuarioDeuclerioRepositorio;
        }

        public Task Create(UsuarioDeuclerio entity)
        {
            return _usuarioDeuclerioRepositorio.Create(entity);
        }

        public Task Delete(int id)
        {
            return _usuarioDeuclerioRepositorio.Delete(id);
        }

        public IQueryable<UsuarioDeuclerio> GetAll()
        {
            return _usuarioDeuclerioRepositorio.GetAll();
        }

        public Task<UsuarioDeuclerio> GetById(int id)
        {
            return _usuarioDeuclerioRepositorio.GetById(id);
        }

        public Task Update(int id, UsuarioDeuclerio entity)
        {
            return _usuarioDeuclerioRepositorio.Update(id,entity);
        }
    }
}
