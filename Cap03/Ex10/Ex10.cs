/*Faça um programa que calcule e mostre a área de um quadrado. Sabe-se que: A = lado * lado.*/

namespace Cap03
{
    public class Cap03Ex10
    {
        public static void Run() 
        {
            Console.WriteLine("Digite o lado de um quadrado: ");
            var lado = double.Parse(Console.ReadLine());

            var area = lado * lado;

            Console.WriteLine($"A área de um quadrado é: {area}");
        }
    }
}