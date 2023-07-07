using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumidor.API
{
    public class Trabalho
    {
        public long ID { get; set; }
        public string? Nome { get; set; }
        public bool Finalizado { get; set; }
    }
}
