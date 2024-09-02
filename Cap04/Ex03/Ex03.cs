// Faça um programa que receba dois números e mostre o menor. 

namespace Cap04
{
    public class Cap04Ex03
    {
        public static void Run()
        {
            Console.WriteLine("Digite dois numeros: ");
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            if(num1 < num2)
            {
                Console.WriteLine($"O menor numero é: {num1}");
            }
            else if(num2 < num1)
            {
                Console.WriteLine($"O menor numero é: {num2}");
            }
            else
            {
                Console.WriteLine("Números iguais");
            }
        }
    }
}