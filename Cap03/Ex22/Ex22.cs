/*Faça um programa que receba o número de lados de um polígono convexo, calcule e mostre o número
de diagonais desse polígono. Sabe-se que ND = N * (N − 3)/2, em que N é o número de lados do
polígono.*/

namespace Cap03
{
    public class Cap03Ex22
    {
        public static void Run()
        {
            Console.WriteLine("Digite o numero de lados de um poligono convexo: ");
            var lados = int.Parse(Console.ReadLine());

            var diagonais = lados * (lados - 3) / 2;

            Console.WriteLine($"O número de diagonais é: {diagonais}");
        }
    }
}