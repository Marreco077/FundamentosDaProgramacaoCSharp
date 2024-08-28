/* Faça um programa que receba o ano de nascimento de uma pessoa e o ano atual, calcule e mostre:
a) a idade dessa pessoa em anos;
b) a idade dessa pessoa em meses;
c) a idade dessa pessoa em dias;
d) a idade dessa pessoa em semanas.*/

namespace Cap03
{
    public class Cap03Ex14
    {
        public static void Run()
        {
            Console.WriteLine("Digite o ano que você nasceu: ");
            var nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            var anoAtual = int.Parse(Console.ReadLine());

            var idadeAnos = anoAtual - nascimento;
            var idadeMeses = idadeAnos * 12;
            var idadeSemanas = idadeAnos * 52;
            var idadeDias = idadeAnos * 365;

            Console.WriteLine($"Idade em anos: {idadeAnos}");
            Console.WriteLine($"Idade em meses: {idadeMeses}");
            Console.WriteLine($"Idade em semanas: {idadeSemanas}");
            Console.WriteLine($"Idade em dias: {idadeDias}");
        }
    }
}