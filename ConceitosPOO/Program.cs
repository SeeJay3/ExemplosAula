// See https://aka.ms/new-console-template for more information
using ConceitosPOO;
using System.Collections.Specialized;




int opcao;
do
{
    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine("0) Sair");
    Console.WriteLine("1) Somar");
    Console.WriteLine("2) Verificar Primo");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Calculadora calc = new Calculadora();
            Console.WriteLine("Informe o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = calc.Soma(num1, num2);
            Console.WriteLine("A soma entre os números {0} e {1} é {2}", num1, num2, resultado);
            break;
        case 2:
            Console.WriteLine("Informe o número a ser testado:");
            int valor = Convert.ToInt32(Console.ReadLine());
            var util = new Util();
            if (util.VerificaPrimo(valor))
                Console.WriteLine($"O número {valor} é primo.");
            else
                Console.WriteLine($"O número {valor} não é primo.");
            break;
        default:
            Console.WriteLine("Opção Inválida.");
            break;
    }
} while (opcao == 0);