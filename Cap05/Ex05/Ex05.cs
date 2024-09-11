// Faça um programa que mostre as tabuadas dos números de 1 a 10. 

namespace Cap05
{
    public class Cap05Ex05
    {
        public static void Run()
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}