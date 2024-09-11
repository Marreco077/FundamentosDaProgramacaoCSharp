// Uma loja utiliza o código V para transação à vista e P para transação a prazo. Faça um programa que receba
// o código e o valor de quinze transações, calcule e mostre:
//  ■ o valor total das compras à vista;
//  ■ o valor total das compras a prazo;
//  ■ o valor total das compras efetuadas; e
//  ■ o valor da primeira prestação das compras a prazo juntas, sabendo-se que serão pagas em três vezes. 

namespace Cap05
{
    public class Cap05Ex06
    {
        public static void Run()
        {
            double valorVista = 0, valorPrazo = 0, valorTotal = 0, valorPrimeira;

            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o código: [V/P]");
                var codigo = char.Parse(Console.ReadLine().ToUpper());

                Console.WriteLine("Digite o valor do produto: ");
                var valor = double.Parse(Console.ReadLine().ToUpper());

                valorTotal += valor; // adiciona valor total

                if(codigo == 'V')
                {
                    valorVista += valor;
                }
                else if(codigo == 'P')
                {
                    valorPrazo += valor;
                }
                else
                {
                    Console.WriteLine("Invalido!");
                }
            }

            valorPrimeira = valorPrazo / 3.0;

            Console.WriteLine($"Valor total das compras a vista: {valorVista:C}");        
            Console.WriteLine($"Valor total das compras a prazo: {valorPrazo:C}");        
            Console.WriteLine($"Valor total das compras: {valorTotal:C}");        
            Console.WriteLine($"Valor da primeira prestação: {valorPrimeira}");
        }
    }
}