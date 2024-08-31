/*Faça um programa que receba o raio, calcule e mostre:
a) o comprimento de uma esfera; sabe-se que C = 2 * p R;
b) a área de uma esfera; sabe-se que A = p R2
;
c) o volume de uma esfera; sabe-se que V = ¾ * p R3
. */

namespace Cap03
{
    public class Cap03Ex17
    {
        public static void Run()
        {
            Console.WriteLine("Digite o raio de uma esfera: ");
            var raio = double.Parse(Console.ReadLine());

            var comprimento = 2 * Math.PI * raio;
            var area = Math.PI * Math.Pow(raio, 2);
            var volume = (3.0 / 4.0) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine($"O comprimento é: {comprimento}");
            Console.WriteLine($"A área é: {area}");
            Console.WriteLine($"O volume é: {volume}");
        }
    }
}