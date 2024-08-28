/*Um funcionário recebe um salário fixo mais 4% de comissão sobre as vendas. Faça um programa
que receba o salário fixo do funcionário e o valor de suas vendas, calcule e mostre a comissão e seu
salário final. */

namespace Cap03
{
    public class Cap03Ex06
    {
        public static void Run()
        {
            Console.WriteLine("Digite o salario do funcionario: ");
            var salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor das suas vendas: ");
            var vendas = double.Parse(Console.ReadLine());

            var salarioFinal = salario + (vendas * 0.04);

            Console.WriteLine($"O salario com a comissão fica: {salarioFinal}");
        }
    }
}