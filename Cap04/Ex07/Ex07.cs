// Uma empresa decide dar um aumento de 30% aos funcionários com salários inferiores a R$ 500,00. Faça um
// programa que receba o salário do funcionário e mostre o valor do salário reajustado ou uma mensagem, caso
// ele não tenha direito ao aumento

namespace Cap04
{
    public class Cap04Ex07
    {
        public static void Run()
        {
            Console.WriteLine("Digite o salario do funcionario: ");
            var salario = double.Parse(Console.ReadLine());

            if(salario <= 500)
            {
                salario *= 1.3;
                Console.WriteLine($"O salário reajustado é: {salario}");
            }
            else
            {
                Console.WriteLine("Não tem direito ao aumento");
            }
        }
    }
}