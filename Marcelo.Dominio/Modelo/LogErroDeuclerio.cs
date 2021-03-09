using Marcelo.Dominio.Modelo;
using System;
using System.Collections.Generic;

namespace Marcelo.Persistencia
{
    public partial class LogErroDeuclerio : IEntity
    {
        public int Id { get; set; }
        public string Mensagem { get; set; }
        public string StarkTracer { get; set; }
        public string Url { get; set; }
        public byte[] NomeUsuario { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
