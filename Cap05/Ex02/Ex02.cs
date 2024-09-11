//  Uma companhia de teatro deseja montar uma série de espetáculos. A direção calcula que, a
// R$ 5,00 o ingresso, serão vendidos 120 ingressos, e que as despesas serão de R$ 200,00. Diminuindo-se em
// R$ 0,50 o preço dos ingressos, espera-se que as vendas aumentem em 26 ingressos. Faça um programa que
// escreva uma tabela de valores de lucros esperados em função do preço do ingresso,
// fazendo-se variar esse preço de R$ 5,00 a R$ 1,00, de R$ 0,50 em R$ 0,50.
// Escreva, ainda, para cada novo preço de ingresso, o lucro
// máximo esperado, o preço do ingresso e a quantidade de ingressos vendidos para a obtenção desse lucro. 

namespace Cap05
{
    public class Cap05Ex02
    {
        public static void Run()
        {
             double precoInicial = 5.00;
            int ingressosIniciais = 120;
            double decrementoPreco = 0.50;
            int aumentoIngressos = 26;
            double despesas = 200.00;
            double preco, lucro, receita;
            int ingressosVendidos;

            double lucroMaximo = double.MinValue; // Para guardar o lucro máximo
            double melhorPreco = 0; // Para guardar o preço associado ao lucro máximo
            int melhorQuantidade = 0; // Para guardar a quantidade de ingressos associada ao lucro máximo

            Console.WriteLine("Preço\tIngressos Vendidos\tLucro");
            for (preco = precoInicial; preco >= 1.00; preco -= decrementoPreco)
            {
                ingressosVendidos = ingressosIniciais + (int)((precoInicial - preco) / decrementoPreco) * aumentoIngressos;
                receita = preco * ingressosVendidos;
                lucro = receita - despesas;

                Console.WriteLine($"{preco:F2}\t{ingressosVendidos}\t\t\t{lucro:F2}");

                // Verifica se o lucro atual é maior que o lucro máximo encontrado
                if (lucro > lucroMaximo)
                {
                    lucroMaximo = lucro;
                    melhorPreco = preco;
                    melhorQuantidade = ingressosVendidos;
                }
            }

            // Exibe o lucro máximo e as informações associadas
            Console.WriteLine($"\nLucro máximo esperado: R$ {lucroMaximo:F2}");
            Console.WriteLine($"Melhor preço do ingresso: R$ {melhorPreco:F2}");
            Console.WriteLine($"Quantidade de ingressos vendidos para obter o lucro máximo: {melhorQuantidade}");
        }
    }
}