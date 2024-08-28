/*Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas notas, c
onsiderando peso 2 para a primeira e peso 3 para a segunda.*/ 

namespace Cap03
{
    public class Cap03Ex04
    {
        public static void Run()
        {
            Console.WriteLine("Digite duas notas: ");
            var nota1 = double.Parse(Console.ReadLine());
            var nota2 = double.Parse(Console.ReadLine());
            
            var notaFinal = ((nota1 * 2) + (nota2 * 3)) / 5;

            Console.WriteLine($"O resultado final foi de: {notaFinal}");
        }
    }
}