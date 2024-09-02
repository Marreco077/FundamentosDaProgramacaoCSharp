// Faça um programa que receba o preço de um produto, calcule e mostre, de acordo com as tabelas a seguir, o novo preço e a classificação.
// TABELA 1 — PERCENTUAL DE AUMENTO
// PREÇO %
// Até R$ 50,00 5
// Entre R$ 50,00 e R$ 100,00 10
// Acima de R$ 100,00 15
// TABELA 2 — CLASSIFICAÇÕES
// NOVO PREÇO CLASSIFICAÇÃO
// Até R$ 80,00 Barato
// Entre R$ 80,00 e R$ 120,00 (inclusive) Normal
// Entre R$ 120,00 e R$ 200,00 (inclusive) Caro
// Maior que R$ 200,00 Muito caro

namespace Cap04
{
    public class Cap04Ex13
    {
        public static void Run()
        {
            Console.WriteLine("Digite o preço do produto: ");
            var preco = double.Parse(Console.ReadLine());
            
            double aumento;
            string classificacao;

            if(preco <= 50)
            {
                aumento = 1.05;
            }
            else if(preco <= 100)
            {
                aumento = 1.1;
            }
            else
            {
                aumento = 1.15;
            }

            if(preco <= 80)
            {
                classificacao = "Barato";
            }
            else if(preco <= 120)
            {
                classificacao = "Normal";
            }
            else if(preco <= 200)
            {
                classificacao = "Caro";
            }
            else
            {
                classificacao = "Muito caro";
            }

            preco *= aumento;

            Console.WriteLine($"Preço atualizado: {preco}");
            Console.WriteLine($"Classificação: {classificacao}");
        }
    }
}