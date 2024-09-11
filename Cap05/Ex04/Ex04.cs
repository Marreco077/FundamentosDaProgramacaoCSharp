// Faça um programa que receba um número, calcule e mostre a tabuada desse número.
// Exemplo:
// Digite um número: 5
// 5 × 0 = 0
// 5 × 1 = 5
// 5 × 2 = 10
// 5 × 3 = 15
// 5 × 4 = 20
// 5 × 5 = 25
// 5 × 6 = 30
// 5 × 7 = 35
// 5 × 8 = 40
// 5 × 9 = 45
// 5 × 10 = 50

namespace Cap05
{
    public class Cap05Ex04
    {
        public static void Run()
        {
            Console.WriteLine("Digite um numero: ");
            var numero = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }
        }
    }
}