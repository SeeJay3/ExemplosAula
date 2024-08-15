// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Calculadora calc = new Calculadora();
Console.WriteLine("Informe o primeiro número:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o segundo número:");
int num2 = int.Parse(Console.ReadLine());
int resultado = calc.Soma(num1, num2);
Console.WriteLine("A soma entre os números {0} e {1} é {2}", num1, num2, resultado);