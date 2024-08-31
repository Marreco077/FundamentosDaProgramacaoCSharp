/*. Faça um programa que receba uma temperatura em Celsius, calcule e mostre essa temperatura em
Fahrenheit. Sabe-se que F = 180*(C + 32)/100. */

namespace Cap03
{
    public class Cap03Ex18
    {
        public static void Run()
        {
            Console.WriteLine("Digite a temperatura em celsius: ");
            var celsius = double.Parse(Console.ReadLine());

            var fahrenheit = 180 * (celsius + 32) / 100;

            Console.WriteLine($"A temperatura em fahrenheint é: {fahrenheit}");
        }
    }
}