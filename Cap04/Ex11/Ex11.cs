// Faça um programa que receba o salário atual de um funcionário e, usando a tabela a seguir, calcule e
// mostre o valor do aumento e o novo salário.
// SALÁRIO PERCENTUAL DE AUMENTO
// Até R$ 300,00 15%
// R$ 300,00 R$ 600,00 10%
// R$ 600,00 R$ 900,00 5%
// Acima de R$ 900,00 0%

using System.Net;

namespace Cap04
{
    public class Cap04Ex11
    {
        public static void Run()
        {
            Console.WriteLine("Digite o salário atual do funcionario: ");
            var salario = double.Parse(Console.ReadLine());

            if(salario > 900)
            {
               // nao faz nada
            }
            else if(salario >= 600)
            {
                salario *= 1.05;
            }
            else if(salario > 300)
            {
                salario *= 1.10;
            }
            else
            {
                salario *= 1.15;
            }

            Console.WriteLine($"O salário reajustado é: {salario}");
        }
    }
}