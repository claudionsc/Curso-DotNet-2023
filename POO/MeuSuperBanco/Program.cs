// See https://aka.ms/new-console-template for more information
using MeuSuperBanco;

Console.WriteLine("Hello, World!");

ContaBanco contaB = new ContaBanco("Diogo", 1000);
Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com o saldo de {contaB.Saldo} reais ");

contaB.Depositar(25, DateTime.Now, "Depósito realizado com sucesso");
Console.WriteLine($"Saldo: {contaB.Saldo} reais ");

contaB.Sacar(10000, DateTime.Now, "Saque realizado com sucesso");
Console.WriteLine($"Saldo: {contaB.Saldo} reais ");
