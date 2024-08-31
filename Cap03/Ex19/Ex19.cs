/*Sabe-se que, para iluminar de maneira correta os cômodos de uma casa, para cada m2
, deve-se usar 18 W
de potência. Faça um programa que receba as duas dimensões de um cômodo (em metros), calcule e mostre
a sua área (em m2
) e a potência de iluminação que deverá ser utilizada. */

namespace Cap03
{
    public class Cap03Ex19
    {
        public static void Run()
        {
            Console.WriteLine("Digite duas dimensões de um cómodo em metros: ");
            var dimensao1 = double.Parse(Console.ReadLine());
            var dimensao2 = double.Parse(Console.ReadLine());

            var area = dimensao1 * dimensao2;
            var iluminacao = area * 18;

            Console.WriteLine($"A area é de : {area}");
            Console.WriteLine($"A iluminação gasta é de: {iluminacao} W");
        }
    }
}