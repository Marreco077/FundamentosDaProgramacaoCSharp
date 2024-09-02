// Faça um programa que receba dois números e execute uma das operações listadas a seguir, de acordo com a
// escolha do usuário. Se for digitada uma opção inválida, mostre mensagem de erro e termine a execução do
// programa. As opções são:
// a) O primeiro número elevado ao segundo número.
// b) Raiz quadrada de cada um dos números.
// c) Raiz cúbica de cada um dos números. 

namespace Cap04
{
    public class Cap04Ex06
    {
        public static void Run()
        {
            Console.WriteLine("Digite dois numeros: ");
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - O primeiro elevado ao segundo");
            Console.WriteLine("2 - raiz quadrada de cada um dos numeros");
            Console.WriteLine("3 - raiz cúbica de cada um dos números");
        }
    }
}