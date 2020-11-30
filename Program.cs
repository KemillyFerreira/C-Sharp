using System;

namespace Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
           /*aqui vai o código*/

            // Console.WriteLine("Digite o seu nome:");
            // string nomeCompleto = Console.ReadLine();

            // Console.WriteLine("Bem vindo "+nomeCompleto);

        int valorUm; 
        int valorDois; 
        

        // Entrada de dados
        Console.WriteLine("soma de dois números");
        Console.WriteLine("-----------");
        Console.WriteLine("Digite o primeiro valor");
        valorUm = int.Parse(Console.ReadLine());
        Console.WriteLine("digite o segundo valor");
        valorDois = int.Parse(Console.ReadLine());

        // Processamento
        int soma = valorUm + valorDois;

        // Exibir
        Console.WriteLine("a soma de valor 1 + valor 2 = "+ soma);



        }
    }
}
