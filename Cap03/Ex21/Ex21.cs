/*Faça um programa que receba o número de horas trabalhadas, o valor do salário mínimo e o número
de horas extras trabalhadas, calcule e mostre o salário a receber, de acordo com as regras a seguir:
a) a hora trabalhada vale 1/8 do salário mínimo;
b) a hora extra vale 1/4 do salário mínimo; 
c) o salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora trabalhada;
d) a quantia a receber pelas horas extras equivale ao número de horas extras trabalhadas multiplicado pelo valor
da hora extra;
e) o salário a receber equivale ao salário bruto mais a quantia a receber pelas horas extras.*/

namespace Cap03
{
    public class Cap03Ex21
    {
        public static void Run()
        {
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            var horasTrabalhadas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do salario minimo: ");
            var salarioMinimo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de horas extras: ");
            var horasExtras = double.Parse(Console.ReadLine());

            var horaTrabalhada = salarioMinimo / 8;
            var horaExtra = salarioMinimo / 4;
            var salarioBruto = horasTrabalhadas * horaTrabalhada;
            var salarioExtra = horasExtras * horaExtra;
            var salarioFinal = salarioBruto + salarioExtra;

            Console.WriteLine($"O salário a receber é de: {salarioFinal}");
        }
    }
}