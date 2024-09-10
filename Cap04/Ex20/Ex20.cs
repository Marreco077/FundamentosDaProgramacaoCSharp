// Faça um programa que receba a idade de um nadador e mostre sua categoria, usando as regras a seguir.
// Para idade inferior a 5, deverá mostrar mensagem.
// CATEGORIA IDADE
// Infantil 5 a 7
// Juvenil 8 a 10
// Adolescente 11 a 15
// Adulto 16 a 30
// Sênior Acima de 30

namespace Cap04
{
    public class Cap04Ex20
    {
        public static void Run()
        {
            Console.WriteLine("Digite a idade do nadador: ");
            var idade = int.Parse(Console.ReadLine());

            if(idade > 30)
            {
                Console.WriteLine("Sênior");
            }
            else if(idade >= 16)
            {
                Console.WriteLine("Adulto");
            }
            else if(idade >= 11)
            {
                Console.WriteLine("Adolescente");
            }
            else if(idade >= 8)
            {
                Console.WriteLine("Juvenil");
            }
            else if(idade >= 5)
            {
                Console.WriteLine("Infantil");
            }
            else
            {
                Console.WriteLine("Não pode nadar");
            }
        }
    }
}