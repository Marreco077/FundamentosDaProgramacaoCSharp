//  Faça um programa para calcular e mostrar o salário reajustado de um funcionário. O percentual de aumento
// encontra-se na tabela a seguir.
// SALÁRIO PERCENTUAL DE AUMENTO
// Até R$ 300,00 35%
// Acima de R$ 300,00 15%

namespace Cap04
{
    public class Cap04Ex08
    {
        public static void Run()
        {
            Console.WriteLine("Digite o salario do funcionario: ");
            var salario = double.Parse(Console.ReadLine());

            if(salario <= 300)
            {
                salario *= 1.35;
            }
            else
            {
                salario *= 1.15;
            }

            Console.WriteLine($"O salário reajustado é: {salario}");
        }
    }
}