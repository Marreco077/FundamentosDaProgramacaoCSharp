// Faça um programa que receba dois números e execute as operações listadas a seguir, de acordo com a escolha
// do usuário.
// ESCOLHA DO USUÁRIO OPERAÇÃO
// 1 Média entre os números digitados
// 2 Diferença do maior pelo menor
// 3 Produto entre os números digitados
// 4 Divisão do primeiro pelo segundo
// Se a opção digitada for inválida, mostre uma mensagem de erro e termine a execução do programa.
// Lembre-se de que, na operação 4, o segundo número deve ser diferente de zero.

namespace Cap04
{
    public class Cap04Ex05
    {
        public static void Run()
        {
            Console.WriteLine("Digite dois numeros: ");
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma opção: ");
            Console.WriteLine("1 - Média entre os números digitados: ");
            Console.WriteLine("2 - Diferença do maior pelo menor: ");
            Console.WriteLine("3 -Produto entre os números digitados: ");
            Console.WriteLine("4 - Divisão do primeiro pelo segundo: ");
            var opcao = short.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Console.WriteLine($"A média entre os números é: {(num1 + num2) / 2.0:F2}");
                    break;
                case 2:
                    if(num1 >= num2)
                    {
                        Console.WriteLine($"A diferença do maior pelo menos é: {num1 - num2:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"A diferença do maior pelo menos é: {num2 - num1:F2}");
                    }
                    break;
                case 3:
                    Console.WriteLine($"O produto entre os números digitados é: {num1 * num2:F2}");
                    break;
                case 4:
                    if(num2 == 0)
                    {
                        Console.WriteLine("O segundo número não pode ser zero!");
                        Run();
                    }
                    else
                    {
                        Console.WriteLine($"A divisão do primeiro pelo segundo é: {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("ERRO!");
                    Environment.Exit(1);
                    break;
            }
        }
    }
}