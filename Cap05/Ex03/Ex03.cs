// Faça um programa que receba a idade de oito pessoas, calcule e mostre:
// a) a quantidade de pessoas em cada faixa etária;
// b) a porcentagem de pessoas na primeira faixa etária com relação ao total de pessoas.
// c) a porcentagem de pessoas na última faixa etária com relação ao total de pessoas
// FAIXA ETÁRIA IDADE
// 1
// a Até 15 anos
// 2
// a De 16 a 30 anos
// 3
// a De 31 a 45 anos
// 4
// a De 46 a 60 anos
// 5
// a Acima de 60 anos

namespace Cap05
{
    public class Cap05Ex03
    {
        public static void Run()
        {
            int faixa1 = 0, faixa2 = 0, faixa3 = 0, faixa4 = 0, faixa5 = 0;
            double porcentagemPrimeira, porcentagemUltima;

            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Digite a idade da pesssoa {i+1}: ");
                var idade = int.Parse(Console.ReadLine());

                if(idade >= 60)
                {
                    faixa5++;
                }
                else if(idade >= 46)
                {
                    faixa4++;
                }
                else if(idade >= 31)
                {
                    faixa3++;
                }
                else if(idade >= 16)
                {
                    faixa2++;
                }
                else
                {
                    faixa1++;
                }
            }

                Console.WriteLine($"Pessoa na faixa etária 1: {faixa1}");
                Console.WriteLine($"Pessoa na faixa etária 2: {faixa2}");
                Console.WriteLine($"Pessoa na faixa etária 3: {faixa3}");
                Console.WriteLine($"Pessoa na faixa etária 4: {faixa4}");
                Console.WriteLine($"Pessoa na faixa etária 5: {faixa5}");

                porcentagemPrimeira = (faixa1 / 8.0) * 100;
                porcentagemUltima = (faixa5 / 8.0) * 100;

                Console.WriteLine($"Porcentagem de pessoas na primeira faixa: {porcentagemPrimeira:F2}%");
                Console.WriteLine($"Porcentagem de pessoas na ultima faixa: {porcentagemUltima:F2}%");
            
        }
    }
}