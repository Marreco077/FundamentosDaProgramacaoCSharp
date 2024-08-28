/*Faça um programa que receba dois números, calcule e mostre a divisão do primeiro número pelo
segundo. Sabe-se que o segundo número não pode ser zero, portanto, não é necessário se preocupar
com validações.*/

namespace Cap03
{
    public class Cap03Ex03
    {
        public static void Run()
        {
            Console.WriteLine("Digite dois números: ");
            
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            
            var divisao = num1 / num2;

            Console.WriteLine($"A divisão é: {divisao}");
        }
    }
}