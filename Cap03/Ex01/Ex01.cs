namespace Cap03
{
    public class Cap03Ex01
    {
        public static void Run()
        {
            Console.WriteLine("Digite dois numeros: ");
            var num1 = float.Parse(Console.ReadLine());
            var num2 = float.Parse(Console.ReadLine());
            Console.WriteLine(num1 - num2);
        }
    }
}
