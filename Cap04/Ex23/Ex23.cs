// Faça um programa que receba:
//  ■ o código do produto comprado; e
//  ■ a quantidade comprada do produto.
// Calcule e mostre:
//  ■ o preço unitário do produto comprado, seguindo a Tabela I;
//  ■ o preço total da nota;
//  ■ o valor do desconto, seguindo a Tabela II e aplicado sobre o preço total da nota; e
//  ■ o preço final da nota depois do desconto.
// TABELA I
// CÓDIGO PREÇO
// 1 a 10 R$ 10,00
// 11 a 20 R$ 15,00
// 21 a 30 R$ 20,00
// 31 a 40 R$ 30,00
// TABELA II
// PREÇO TOTAL DA NOTA % DE DESCONTO
// Até R$ 250,00 5%
// Entre R$ 250,00 e R$ 500,00 10%
// Acima de R$ 500,00 15%

namespace Cap04
{
    public class Cap04Ex23
    {
        public static void Run()
        {
            Console.WriteLine("Digite o código do produto: ");
            var codigo = short.Parse(Console.ReadLine());

            double precoUnitario = 0;

            if(codigo >= 1 && codigo <= 10)
            {
                precoUnitario = 10;
            }
            else if(codigo <= 20)
            {
                precoUnitario = 15;
            }
            else if(codigo <= 30)
            {
                precoUnitario = 20;
            }
            else if(codigo <= 40)
            {
                precoUnitario = 30;
            }
            else
            {
                Console.WriteLine("Erro, digite novamente!");
                Run();
            }

            Console.WriteLine("Digite a quantidade comprada do produto: ");
            var quantidade = int.Parse(Console.ReadLine());

            double precoTotal = precoUnitario * quantidade;
            double desconto = 0;

            if(precoTotal <= 250)
            {
                desconto = 0.95;
            }
            else if(precoTotal <= 500)
            {
                desconto = 0.9;
            }
            else
            {
                desconto = 0.85;
            }
            
            double precoFinal = precoTotal * desconto;
            double valorDesconto = precoTotal - (desconto * precoTotal);

            Console.WriteLine($"Preço unitário do produto: {precoUnitario}");
            Console.WriteLine($"Preço total da nota: {precoTotal}");
            Console.WriteLine($"Valor do desconto: {valorDesconto}");
            Console.WriteLine($"Preço final: {precoFinal}");
        }
    }
}