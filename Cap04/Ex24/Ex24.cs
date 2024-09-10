// Faça um programa que receba o preço, a categoria (1 — limpeza; 2 — alimentação; ou 3 — vestuário)
// e a situação (R — produtos que necessitam de refrigeração; e N — produtos que não necessitam de refrigeração).
// Calcule e mostre:
//  ■ O valor do aumento, usando as regras que se seguem.
// PREÇO CATEGORIA PERCENTUAL DE AUMENTO
// < = 25
// 1 5%
// 2 8%
// 3 10%
// > 25
// 1 12%
// 2 15%
// 3 18%
//  ■ O valor do imposto, usando as regras a seguir.
//  O produto que preencher pelo menos um dos seguintes requisitos pagará imposto equivalente a 5%
// do preço; caso contrário, pagará 8%. Os requisitos são:
// Categoria: 2
// Situação: R
//  ■ O novo preço, ou seja, o preço mais aumento menos imposto.
//  ■ A classificação, usando as regras a seguir.
// NOVO PREÇO CLASSIFICAÇÃO
// < = R$ 50,00 Barato
// Entre R$ 50,00 e R$ 120,00 Normal
// > = R$ 120,00 Caro


namespace Cap04
{
    public class Cap04Ex24
    {
        public static void Run()
        {
            Console.WriteLine("Digite o preço do produto: ");
            var preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a categoria do produto: ");
            var categoria = short.Parse(Console.ReadLine());

            Console.WriteLine("Digite a situação do produto: [R/N]");
            var situacao = char.Parse(Console.ReadLine());

            double aumento = 0;

            if(preco > 25)
            {
                switch(categoria)
                {
                    case 1:
                        aumento = 1.12;
                        break;
                    case 2:
                        aumento = 1.15;
                        break;
                    case 3:
                        aumento = 1.18;
                        break;
                    default:
                        Console.WriteLine("Inválido, digite novamente!");
                        Run();
                        break;
                }
            }
            else
            {
                switch(categoria)
                {
                    case 1:
                        aumento = 1.05;
                        break;
                    case 2:
                        aumento = 1.08;
                        break;
                    case 3:
                        aumento = 1.1;
                        break;
                    default:
                        Console.WriteLine("Inválido, digite novamente!");
                        Run();
                        break;
                }
            }
             
             double imposto;

             if(categoria == 2 || situacao == 'R')
             {
                imposto = 1.05;
             }
             else
             {
                imposto = 1.08;
             }

             double precoFinal = preco * aumento * imposto;

             string classificacao;

            Console.WriteLine($"O preço final do produto é: {precoFinal:F2}");
            
             if(precoFinal <= 50)
             {
                classificacao = "Barato";
             }
             else if(precoFinal < 120)
             {
                classificacao = "Normal";
             }
             else
             {
                classificacao = "Caro";
             }

             Console.WriteLine($"Classificação: {classificacao}");
        }
    }
}