// See https://aka.ms/new-console-template for more information
/*
 * comentário
 * de
 * bloco
 */
using System;

Console.WriteLine("Informe seu nome:");
string nome =Console.ReadLine();
Console.WriteLine($"Seja bem vindo(a){nome}");
Console.WriteLine("Informe sua idade:");
int idade = int.Parse(Console.ReadLine());
//De acordo com a idade informada, diga se o usuário pode ou não votar.
if (idade >= 16)
{
    Console.WriteLine("O usuário pode votar");
}
else
{
    Console.WriteLine("O usuário não pode votar.");
}
//Modifique o código para que diferencie o Pode Votar do Deve Votar.
if (18 > idade && idade >= 16 || idade >= 65)
{
    Console.WriteLine("O usuário pode, mas não deve votar.");
}
else if (16 > idade)
{
    Console.WriteLine("O usuário não pode votar.");
}
else if (18 >= idade && idade <65)
{
    Console.WriteLine("O usuário deve votar.");
}
int[] multiplos = new int[10];
int indice = 0;
for (int divisor = 2; divisor < multiplos.Length; divisor++)
{
    if (idade % divisor == 0)
    {
        multiplos[indice] = divisor;
        indice++;
    }
    
}
foreach  (int multiplo in multiplos) 
{
   if (multiplo != 0)
    Console.Write(multiplo + " - ");
}

