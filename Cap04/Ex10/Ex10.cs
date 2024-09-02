// O preço ao consumidor de um carro novo é a soma do custo de fábrica com a porcentagem do distribuidor e dos impostos, ambos aplicados ao custo de fábrica. As porcentagens encontram-se na tabela a
// seguir. Faça um programa que receba o custo de fábrica de um carro e mostre o preço ao consumidor.
// CUSTO DE FÁBRICA % DO DISTRIBUIDOR % dos IMPOSTOS
// Até R$ 12.000,00 5 isento
// Entre R$ 12.000,00 e R$ 25.000,00 10 15
// Acima de R$ 25.000,00 15 20

namespace Cap04
{
    public class Cap04Ex10
    {
        public static void Run()
        {
            double distribuidor, impostos;

            Console.WriteLine("Digite o custo de fábrica do carro: ");
            var custo = double.Parse(Console.ReadLine());

            if(custo > 25000)
            {
                distribuidor = 0.15;
                impostos = 0.2;
            }
            else if(custo >= 12000)
            {
                distribuidor = 0.10;
                impostos = 0.15;
            }
            else
            {
                distribuidor = 0.05;
                impostos = 0;
            }

            var custoFinal = custo + (custo * distribuidor) + (custo * impostos);

            Console.WriteLine($"O preço ao consumidor é: {custoFinal}");
        }
    }
}