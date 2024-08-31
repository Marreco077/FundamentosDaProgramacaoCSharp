/*Faça um programa que receba a medida do ângulo formado por uma escada apoiada no chão 
e a distância em que a escada está da parede, 
calcule e mostre a medida da escada para que se possa alcançar sua ponta.*/

namespace Cap03
{
    public class Cap03Ex20
    {
        public static void Run()
        {
            Console.WriteLine("Digite a medida do ângulo fomrmado por uma escada apoiada no chão: ");
            var angulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distância que está escada está da parede: ");
            var distancia = double.Parse(Console.ReadLine());

            var anguloEmRadianos = angulo * (Math.PI / 180.0);
            var comprimentoEscada = distancia / Math.Cos(anguloEmRadianos);

            Console.WriteLine($"A medida da escada necessária é: {comprimentoEscada} metros");
        }
    }
}