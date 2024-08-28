/* Faça um programa que calcule e mostre a área de um trapézio.
Sabe-se que: A = ((base maior + base menor) * altura)/2 */

namespace Cap03
{
    public class Cap03Ex09
    {
        public static void Run()
        {
            Console.WriteLine("Digite a base maior do trapezio: ");
            var baseMaior = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base menor de um trapezio: ");
            var baseMenor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do trapezio: ");
            var altura = double.Parse(Console.ReadLine());

            var area = ((baseMaior + baseMenor) * altura) / 2;

            Console.WriteLine($"O tamanho da área é: {area}");
        }
    }
}