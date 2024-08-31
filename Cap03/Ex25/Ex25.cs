/*Faça um programa que receba uma hora (uma variável para hora e outra para minutos), calcule e
mostre:
a) a hora digitada convertida em minutos;
b) o total dos minutos, ou seja, os minutos digitados mais a conversão anterior;
c) o total dos minutos convertidos em segundos. */

namespace Cap03
{
    public class Cap03Ex25
    {
        public static void Run()
        {
            Console.WriteLine("Digite as horas e os minutos: ");
            var horas = int.Parse(Console.ReadLine());
            var minutos = int.Parse(Console.ReadLine());

            var horaMinutos = horas * 60;
            var minutosTotais = horaMinutos + minutos;
            var minutosSegundos = minutosTotais * 60;

            Console.WriteLine($"Hora convertidas em minutos: {horaMinutos}");
            Console.WriteLine($"Minutos totais: {minutosTotais}");
            Console.WriteLine($"Segundos totais: {minutosSegundos}");
            
        }
    }
}