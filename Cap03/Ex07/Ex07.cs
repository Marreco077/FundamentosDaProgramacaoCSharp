/*Faça um programa que receba o peso de uma pessoa, calcule e mostre:
a) o novo peso, se a pessoa engordar 15% sobre o peso digitado;
b) o novo peso, se a pessoa emagrecer 20% sobre o peso digitado.*/

namespace Cap03
{
    public class Cap03Ex07
    {
        public static void Run()
        {
            Console.WriteLine("Digite o peso de uma pessoa: ");
            var peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"O novo peso se a pessoa engordar será de: {peso * 1.15}");
            Console.WriteLine($"O novo peso se a pessoa emagrecer será de: {peso * 0.8}");
        }
    }
}