// // Uma agência bancária possui dois tipos de investimentos, conforme o quadro a seguir. 
// Faça um programa que receba o tipo de investimento e seu valor, 
// calcule e mostre o valor corrigido após um mês de
// // investimento, de acordo com o tipo de investimento.
// // TIPO DESCRIÇÃO RENDIMENTO MENSAL
// // 1 Poupança 3%
// // 2 Fundos de renda fixa 4%

namespace Cap04
{
    public class Cap04Ex15
    {
        public static void Run()
        {
            Console.WriteLine("Digite o tipo de investimento: ");
            Console.WriteLine("1 - Poupança");
            Console.WriteLine("2 - Renda Fixa");
            var investimento = short.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor: ");
            var valor = double.Parse(Console.ReadLine());

            if(investimento == 1)
            {
                valor *= 1.03;
            }
            else if(investimento == 2)
            {
                valor *= 1.04;
            }
            
            Console.WriteLine($"Valor após um mês: {valor:C}");
        }
    }
}