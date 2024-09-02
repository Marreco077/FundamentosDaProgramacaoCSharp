// Faça um programa que receba duas notas, calcule e mostre a média aritmética e a mensagem que se encontra
// na tabela a seguir: 

namespace Cap04
{
    public class Cap04Ex02
    {
        public static void Run()
        {
            Console.WriteLine("Digite duas notas: ");
            var nota1 = double.Parse(Console.ReadLine());
            var nota2 = double.Parse(Console.ReadLine());

            var media = (nota1 + nota2) / 2.0;

            if(media >= 7)
            {
                Console.WriteLine("Aprovado!");
            } 
            else if(media >= 3)
            {
                Console.WriteLine("Exame!");
            }
            else 
            {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}