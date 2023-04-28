// ALGUMAS FUNÇÕES DO C#

string saudacao = "          Olá Mundo!            ";
Console.WriteLine($"[{saudacao}]");

// REMOVE ESPAÇOES EM BRANCO DO COMEÇO
string apararSaudacao = saudacao.TrimStart();
Console.WriteLine($"[{apararSaudacao}]");

// REMOVE ESPAÇOES EM BRANCO DO FINAL
apararSaudacao = saudacao.TrimEnd();
Console.WriteLine($"[{apararSaudacao}]");

// REMOVE TODOS OS ESPAÇOES EM BRANCO 
apararSaudacao = saudacao.Trim();
Console.WriteLine($"[{apararSaudacao}]");

// ===========================================================

string digOla = "Olá Mundo!";
Console.WriteLine(digOla);

// Encontra a primeira palavra descrita e substitui pela segunda

digOla = digOla.Replace("Olá", "eaÊ");
Console.WriteLine(digOla);

