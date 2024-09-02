// Um banco concederá um crédito especial aos seus clientes, de acordo com o saldo médio no último ano. Faça
// um programa que receba o saldo médio de um cliente e calcule o valor do crédito, de acordo com a tabela a
// seguir. Mostre o saldo médio e o valor do crédito.
// SALDO MÉDIO PERCENTUAL
// Acima de R$ 400,00 30% do saldo médio
// R$ 400,00 R$ 300,00 25% do saldo médio
// R$ 300,00 R$ 200,00 20% do saldo médio
// Até R$ 200,00 10% do saldo médio

namespace Cap04
{
    public class Cap04Ex09
    {
        public static void Run()
        {
            Console.WriteLine("Digite o saldo médio do cliente: ");
            var saldo = double.Parse(Console.ReadLine());

            if(saldo > 400)
            {
                saldo *= 1.3;
            }
            else if(saldo > 300)
            {
                saldo *= 1.25;
            }
            else if(saldo > 200)
            {
                saldo *= 1.2;
            }
            else
            {
                saldo *= 1.1;
            }

            Console.WriteLine($"Valor do crédito: {saldo}");
        }
    }
}