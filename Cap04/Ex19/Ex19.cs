// Faça um programa que receba a altura e o sexo de uma pessoa e calcule e mostre seu peso ideal, utilizando as seguintes fórmulas (onde h é a altura):
//  ■ para homens: (72.7 * h) – 58.
//  ■ para mulheres: (62.1 * h) – 44.7.

namespace Cap04
{
    public class Cap04Ex19
    {
        public static void Run()
        {
           double pesoIdeal = 0;

           Console.WriteLine("Digite sua altura: ");
           var altura = double.Parse(Console.ReadLine());

           Console.WriteLine("Digite seu sexo: ");
           char sexo = char.Parse(Console.ReadLine());

           if(sexo == 'H')
           {
              pesoIdeal = (72.7 * altura) - 58;
           }
           else if(sexo == 'M')
           {
              pesoIdeal = (62.1 * altura) - 44.7;
           }

           Console.WriteLine($"Seu peso ideal é: {pesoIdeal:F2}");

        }
    }
}