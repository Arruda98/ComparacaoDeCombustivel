using System;
using System.ComponentModel.Design;
using System.Threading;

namespace Desafio
{
    class Combustivel
    {
        public static void Main(string[] args)
        {
            double gasolina = 0;
            double alcool = 0;

            Console.WriteLine("Verificador de valores de Combustivéis");
            Console.WriteLine("Valor atual da Gasolina: ");
            gasolina = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor atual do Alcool: ");
            alcool = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Calculando...");
            Thread.Sleep(1000);
            Console.Clear();

            double porcentagem = gasolina * 0.7;
            double divisao = gasolina - alcool;

            if (alcool <= porcentagem)
            {
                Console.WriteLine($"O Valor do Alcool é de R$ {alcool} e o da Gasolina é de R$ {gasolina}. \n" +
                    $"A porcentagem de 70% da gasolina é de R$ {porcentagem}.\n" +
                    $"A diferença de valores dos combustiveis é de R$ {divisao}");
                Console.WriteLine("");
                Console.WriteLine("Compensa mais abastecer com Alcool!");
            }
            else
            {
                Console.WriteLine($"O Valor do Alcool é de R$ {alcool} e o da Gasolina é de R$ {gasolina}. \n" +
                    $"A porcentagem de 70% da gasolina é de R$ {porcentagem}.\n" +
                    $"A diferença de valores dos combustiveis é de R$ {divisao}");
                Console.WriteLine("");
                Console.WriteLine("Compensa mais abastecer com Gasolina");
            }

        }
    }
}
    