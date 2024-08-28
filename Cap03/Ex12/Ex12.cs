/*Faça um programa que receba o valor do salário mínimo e o valor do salário de um funcionário, calcule
e mostre a quantidade de salários mínimos que esse funcionário ganha. */

namespace Cap03
{
    public class Cap03Ex12
    {
        public static void Run()
        {
            Console.WriteLine("Digite o valor do salario minimo: ");
            var salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do salario do funcionario: ");
            var salarioFuncionario = double.Parse(Console.ReadLine());

            Console.WriteLine($"O funcinario recebe {salarioFuncionario / salarioMinimo}x o salario minimo");
        }
    }
}