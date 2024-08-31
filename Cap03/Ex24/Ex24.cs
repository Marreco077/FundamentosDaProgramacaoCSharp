/*Faça um programa que receba a quantidade de dinheiro em reais que uma pessoa que vai viajar possui. Ela
vai passar por vários países e precisa converter seu dinheiro em dólares, marco alemão e libra esterlina. Sabe-
-se que a cotação do dólar é de R$ 1,80; do marco alemão, de R$ 2,00; e da libra esterlina, de R$ 3,57. O
programa deve fazer as conversões e mostrá-las*/

namespace Cap03
{
    public class Cap03Ex24
    {
        public static void Run()
        {
            Console.WriteLine("Digite seu dinheiro disponivel: ");
            var dinheiro = double.Parse(Console.ReadLine());

            var dolar = dinheiro / 1.8;
            var marco = dinheiro / 2.0;
            var libra = dinheiro / 3.57;

            Console.WriteLine($"Total em dolar: {dolar:F2}");
            Console.WriteLine($"Total em marco: {marco:F2}");
            Console.WriteLine($"Total em libra: {libra:F2}");
        }
    }
}