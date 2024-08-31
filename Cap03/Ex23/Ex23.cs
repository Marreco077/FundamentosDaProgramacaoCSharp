/*Faça um programa que receba a medida de dois ângulos de um triângulo, calcule e mostre a medida do
terceiro ângulo. Sabe-se que a soma dos ângulos de um triângulo é 180 graus.*/

namespace Cap03
{
    public class Cap03Ex23
    {
        public static void Run()
        {
            Console.WriteLine("Digite a medida de dois ângulos de um triângulo: ");
            var angulo1 = double.Parse(Console.ReadLine());
            var angulo2 = double.Parse(Console.ReadLine());

            var angulo3 = 180 - (angulo1 + angulo2);

            Console.WriteLine($"O terceiro ângulo é de: {angulo3}");
        }
    }
}