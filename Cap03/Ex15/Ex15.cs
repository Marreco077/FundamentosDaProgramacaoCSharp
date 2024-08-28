/*João recebeu seu salário e precisa pagar duas contas atrasadas. Em razão do atraso, ele deverá pagar
multa de 2% sobre cada conta. Faça um programa que calcule e mostre quanto restará do salário de
João.*/

namespace Cap03
{
    public class Cap03Ex15
    {
        public static void Run()
        {
            Console.WriteLine("Digite o salario de joão: ");
            var salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor das duas contas: ");
            var conta1 = double.Parse(Console.ReadLine());
            var conta2 = double.Parse(Console.ReadLine());

            var salarioAtual = salario - ((conta1 * 1.02) + (conta2 * 1.02)); 

            Console.WriteLine($"O salario atual de João é de: {salarioAtual}");
        }
    }
}