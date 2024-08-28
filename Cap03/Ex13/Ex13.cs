/*Faça um programa que calcule e mostre a tabuada de um número digitado pelo usuário. */

namespace Cap03
{
    public class Cap03Ex13
    {
        public static void Run()
        {
            Console.WriteLine("Digite um numero: ");
            var num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}