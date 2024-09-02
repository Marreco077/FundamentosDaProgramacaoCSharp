// Faça um programa que receba o salário de um funcionário e, usando a tabela a seguir, calcule e mostre
// o novo salário.
// FAIXA SALARIAL % DE AUMENTO
// Até R$ 300,00 50%
// R$ 300,00 R$ 500,00 40%
// R$ 500,00 R$ 700,00 30%
// R$ 700,00 R$ 800,00 20%
// R$ 800,00 R$ 1.000,00 10%
// Acima de R$ 1.000,00 5%

namespace Cap04
{
    public class Cap04Ex14
    {
        public static void Run()
        {
            Console.WriteLine("Digite o salario de um funcionario: ");
            var salario = double.Parse(Console.ReadLine());

            double aumento;

            if(salario > 1000)
            {
                aumento = 1.05;
            }
            else if(salario > 800)
            {
                aumento = 1.1;
            }
            else if(salario > 700)
            {
                aumento = 1.2;
            }
            else if(salario > 500)
            {
                aumento = 1.3;
            }
            else if(salario > 300)
            {
                aumento = 1.4;
            }
            else
            {
                aumento = 1.5;
            }

            salario *= aumento;

            Console.WriteLine($"Salario com aumento: {salario:C}");
        }
    }
}