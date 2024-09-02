// Faça um programa que receba o salário bruto de um funcionário e, usando a tabela a seguir, calcule e
// mostre o valor a receber. Sabe-se que este é composto pelo salário bruto acrescido de gratificação e descontado o imposto de 7% sobre o salário.
// TABELA DAS GRATIFICAÇÕES
// SALÁRIO GRATIFICAÇÃO
// Até R$ 350,00 R$ 100,00
// R$ 350,00 R$ 600,00 R$ 75,00
// R$ 600,00 R$ 900,00 R$ 50,00
// Acima de R$ 900,00 R$ 35,00

namespace Cap04
{
    public class Cap04Ex12
    {
        public static void Run()
        {
            Console.WriteLine("Digite o salário do funcionario: ");
            var salario = double.Parse(Console.ReadLine());

            if(salario > 900)
            {
                salario += 35;
            }
            else if(salario >= 600)
            {
                salario += 50;
            }
            else if(salario > 350)
            {
                salario += 75;
            }
            else
            {
                salario += 100;
            }

            salario *= 0.93; // 7% do imposto

            Console.WriteLine($"O salário final é: {salario}");
        }
    }
}