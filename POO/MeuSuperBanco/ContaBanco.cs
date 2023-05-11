using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuSuperBanco
{
    public class ContaBanco
    {
        public string Numero { get; }
        public string Dono { get; set; }
        public decimal Saldo { get; }

        public ContaBanco(string nome, decimal valor)
        {
            this.Dono = nome;
            this.Saldo = valor;
        }
    }
}
