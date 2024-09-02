// Faça um programa que receba três números e mostre o maior

namespace Cap04
{
    public class Cap04Ex04
    {
        public static void Run()
        {
            double maior = double.MinValue;

            Console.WriteLine("Digite três numeros: ");
            var numeros = new double[3];

            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = double.Parse(Console.ReadLine());
            }

            foreach(var numero in numeros)
            {
               if(numero > maior)
               {
                maior = numero;
               }
            }

            Console.WriteLine($"O maior numero é: {maior}");
        }
    }
}