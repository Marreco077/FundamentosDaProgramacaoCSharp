// Uma empresa decide aplicar descontos nos seus preços usando a tabela a seguir. Faça um programa que
// receba o preço atual de um produto e seu código, calcule e mostre o valor do desconto e o novo preço.
// PREÇO ATUAL % DE DESCONTO
// Até R$ 30,00 Sem desconto
// Entre R$ 30,00 e R$ 100,00 10%
// Acima de R$ 100,00 15%

namespace Cap04
{
    public class Cap04Ex16
    {
        public static void Run()
        {
            Console.WriteLine("Digite o preço atual do produto: ");
            var preco = double.Parse(Console.ReadLine());

            if(preco <= 30)
            {

            }
            else if(preco <= 100)
            {
                preco *= 1.1;
            }
            else
            {
                preco *= 1.5;
            }

            Console.WriteLine($"Preço após desconto: {preco}");
        }
    }
}