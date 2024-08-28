/*Faça um programa que calcule e mostre a área de um losango. Sabe-se que: A = (diagonal maior * diagonal menor)/2.*/

namespace Cap03
{
    public class Cap03Ex11
    {
        public static void Run()
        {
            Console.WriteLine("Digite a diagonal maior de um losango: ");
            var diagonalMaior = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a digonal menor de um losango: ");
            var diagonalMenor = double.Parse(Console.ReadLine());

            var area = (diagonalMaior * diagonalMenor) / 2;

            Console.WriteLine($"A área do losango é de: {area}");
        }
    }
}