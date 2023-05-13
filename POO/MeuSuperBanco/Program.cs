// See https://aka.ms/new-console-template for more information
using MeuSuperBanco;

Console.WriteLine("Hello, World!");

ContaBanco contaB = new ContaBanco("Diogo", 1000);
Console.WriteLine($"A conta {contaB.Numero} de {contaB.Dono} foi criada com o saldo de {contaB.Saldo:C} ");

contaB.Depositar(25, DateTime.Now, "Depósito realizado com sucesso");

try
{
    contaB.Sacar(10000, DateTime.Now, "Saque realizado com sucesso");

}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message );
}
catch(Exception ex)
{
    Console.WriteLine($"Falha na operação");
}


contaB.Sacar(500, DateTime.Now, "Saque realizado com sucesso");

contaB.Depositar(250, DateTime.Now, "Depósito realizado com sucesso");
Console.WriteLine(contaB.PegarMovimentação());

Console.WriteLine($"Saldo da conta: {contaB.Saldo:C} ");
