// Faça um programa que receba o preço de um produto e seu código de origem e mostre sua procedência.
// A procedência obedece à tabela a seguir.
// CÓDIGO DE ORIGEM PROCEDÊNCIA
// 1 Sul
// 2 Norte
// 3 Leste
// 4 Oeste
// 5 ou 6 Nordeste
// 7 ou 8 ou 9 Sudeste
// 10 a 20 Centro-oeste
// 21 a 30 Nordeste

namespace Cap04
{
    public class Cap04Ex21
    {
        public static void Run()
        {
            string procedencia = "";

            Console.WriteLine("Digite o código de origem: ");
            var codigo = int.Parse(Console.ReadLine());

            switch(codigo)
            {
                case 1: 
                    procedencia = "Sul";
                    break;
                case 2:
                    procedencia = "Norte";
                    break;
                case 3:
                    procedencia = "Leste";
                    break;
                case 4:
                    procedencia = "Oeste";
                    break;
                case 5:
                case 6:
                    procedencia = "Nordeste";
                    break;
                case 7:
                case 8:
                case 9:
                    procedencia = "Sudeste";
                    break;
                default:
                    if (codigo >= 10 && codigo <= 20)
                    {
                        procedencia = "Centro-oeste";
                    }
                    else if (codigo >= 21 && codigo <= 30)
                    {
                        procedencia = "Nordeste";
                    }
                    else
                    {
                        procedencia = "Código inválido";
                    }
                    break;
            }

            Console.WriteLine(procedencia);
        }
    }
}
