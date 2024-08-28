/*Faça um programa que receba o preço de um produto, calcule e mostre o novo preço, sabendo-se
que este sofreu um desconto de 10%. */

namespace Cap03
{
    public class Cap03Ex05
    {
        public static void Run()
        {
            Console.WriteLine("Digite o preço de um produto: ");
            var preco = double.Parse(Console.ReadLine());

            preco *= 1.10;

            Console.WriteLine($"O preço atualizado do produto é: {preco}");
        }
    }
}