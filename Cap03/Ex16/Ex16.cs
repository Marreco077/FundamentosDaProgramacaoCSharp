/*Faça um programa que receba o valor dos catetos de um triângulo, calcule e mostre o valor da hipotenusa*/

namespace Cap03
{
    public class Cap03Ex16
    {
        public  static void Run()
        {
            Console.WriteLine("Digite os catetos de um triângulo: ");
            var cateto1 = double.Parse(Console.ReadLine());
            var cateto2 = double.Parse(Console.ReadLine());

            var quadradoCateto1 = Math.Pow(cateto1, 2);
            var quadradoCateto2 = Math.Pow(cateto2, 2);

            double hipotenusa = Math.Sqrt(quadradoCateto1 + quadradoCateto2);

            Console.WriteLine($"A hipotenusa é: {hipotenusa}");
        }
    }
}