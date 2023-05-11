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
        public decimal Saldo 
        { 
            get
            {
                decimal saldo = 0;
                foreach (var item in todasTransacoes) 
                {
                    saldo += item.Valor;
                }
                return saldo;
            }
        }

        /* static é um modificador de variáveis.
         uma variável estática não depende da instanciação
        de uma classe pra ser acessada, pois a mesma pertence 
         à classe e não à sua instância */
        public static int numeroConta = 1234567890;

        private List<Transacao> todasTransacoes = new List<Transacao>();

        public ContaBanco(string nome, decimal valor)
        {
            this.Dono = nome;

            numeroConta++;

            this.Numero = numeroConta.ToString();
            Depositar(valor, DateTime.Now, "Saldo Inicial");
        }


    public void Depositar(decimal valor, DateTime data, string obs)
    {
            Transacao trans = new Transacao(valor, data, obs);
            todasTransacoes.Add(trans);
    }

    public void Sacar()
    {

    }

    }
}
