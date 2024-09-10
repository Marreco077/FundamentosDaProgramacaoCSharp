// Uma empresa decidiu dar uma gratificação de Natal a seus funcionários, baseada no número de horas
// extras e no número de horas que o funcionário faltou ao trabalho. O valor do prêmio é obtido pela consulta à tabela que se segue, na qual:
// H = número de horas extras – (2/3 * (número de horas falta))
// H (MINUTOS) PRÊMIO (R$)
// > = 2.400 500,00
// 1.800 2.400 400,00
// 1.200 1.800 300,00
// 600 1.200 200,00
// < 600 100,00

namespace Cap04
{
    public class Cap04Ex25
    {
        public static void Run()
        {
            Console.WriteLine("Digite o número de horas extras trabalhadas: ");
            var horasExtras = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o número de horas faltadas: ");
            var horasFaltas = int.Parse(Console.ReadLine());

            double horasFinais = (horasExtras - (2.0 / 3.0 * (horasFaltas))) * 60;

            double premio;

            if(horasFinais >= 2400)
            {
                premio = 500;
            }
            else if(horasFinais > 1800)
            {
                premio = 400;
            }
            else if(horasFinais >= 1200)
            {
                premio = 300;
            }
            else if(horasFinais >= 600)
            {
                premio = 200;
            }
            else
            {
                premio = 100;
            }

            Console.WriteLine($"O prêmio para o funcionário é: {premio:C}");
        }
    }
}