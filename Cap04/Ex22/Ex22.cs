// Faça um programa que receba a idade e o peso de uma pessoa. De acordo com a tabela a seguir, verifique
// e mostre em qual grupo de risco essa pessoa se encaixa.
// IDADE
// PESO
// Até 60 Entre 60 e 90 (inclusive) Acima de 90
// Menores que 20 9 8 7
// De 20 a 50 6 5 4
// Maiores que 50 3 2 1

namespace Cap04
{
    public class Cap04Ex22
    {
        public static void Run()
        {
            int risco = 0;

            Console.WriteLine("Digite a idade da pessoa:");
            var idade =  int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da pessoa: ");
            var peso = double.Parse(Console.ReadLine());

            if(idade < 20)
            {
                if(peso <= 60)
                {
                    risco = 9;
                }
                else if(peso <= 90)
                {
                    risco = 8;
                }
                else
                {
                    risco = 7;
                }
            }
            else if(idade <= 50)
            {
                if(peso <= 60)
                {
                    risco = 6;
                }
                else if(peso <= 90)
                {
                    risco = 5;
                }
                else
                {
                    risco = 4;
                }
            }
            else
            {
                {
                    if(peso <= 60)
                    {
                        risco = 3;
                    }
                    else if(peso <= 90)
                    {
                        risco = 2;
                    }
                    else
                    {
                        risco = 1;
                    }
                }
            }

            Console.WriteLine($"A pessoa está no grupo de risco: {risco}");
         }   
     }
}
