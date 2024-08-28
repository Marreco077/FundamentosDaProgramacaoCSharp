namespace Cap03
{
    public class Cap03Ex02
    {
        public static void Run()
        {
            
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            // Solicita e lê o terceiro número
            Console.Write("Digite o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

          
            double resultado = numero1 * numero2 * numero3;

            
            Console.WriteLine($"A multiplicação dos três números é: {resultado}");
        }
    }
}
