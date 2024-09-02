// Faça um programa que receba quatro notas de um aluno, calcule e mostre a média aritmética das notas e a
// mensagem de aprovado ou reprovado, considerando para aprovação média 7. 

namespace Cap04
{
    public class Cap04Ex01
    {
        public static void Run()
        {
            Console.WriteLine("Digite a nota de 4 alunos: ");
            var alunos = new double[4];
            
            for(int i = 0; i < alunos.Length; i++)
            {
                alunos[i] = double.Parse(Console.ReadLine());
            }

            for(int i = 0; i < alunos.Length; i++)
            {
                if(alunos[i] >= 7)
                {
                    Console.WriteLine($"Aluno {i+1} foi aprovado!");
                }
                else 
                {
                    Console.WriteLine($"Aluno {i+1} foi reprovado!");
                }
            }
        }
    }
}