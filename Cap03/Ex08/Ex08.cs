/*Faça um programa que receba o peso de uma pessoa em quilos, calcule e mostre esse peso em gramas.*/

namespace Cap03
{
    public class Cap03Ex08
    {
        public static void Run() 
        {
            Console.WriteLine("Digite o peso da pessoa: ");
            var peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"O peso da pessoa em gramas é: {peso * 1000}");
        }
    }
}