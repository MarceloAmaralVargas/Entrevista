using Marcelo.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marcelo.Persistencia
{
    public partial class UsuarioDeuclerio : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public static explicit operator UsuarioDeuclerio(Task v)
        {
            throw new NotImplementedException();
        }
    }
}
