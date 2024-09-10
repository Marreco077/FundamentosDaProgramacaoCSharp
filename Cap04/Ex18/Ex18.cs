// Faça um programa que receba a idade de uma pessoa e mostre a mensagem de maioridade ou não.

namespace Cap04
{
    public class Cap04Ex18
    {
        public static void Run()
        {
            Console.WriteLine("Digite sua idade: ");
            var idade = int.Parse(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine("De maior");
            }
            else
            {
                Console.WriteLine("De menor");
            }
        }
    }
}