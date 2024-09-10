// Faça um programa que verifique a validade de uma senha fornecida pelo usuário. A senha é 4531. O
// programa deve mostrar uma mensagem de permissão de acesso ou não. 

namespace Cap04
{
    public class Cap04Ex17
    {
        public static void Run()
        {
            Console.WriteLine("Digite a senha: ");
            var senha = int.Parse(Console.ReadLine());

            if(senha == 4531)
            {
                Console.WriteLine("Acesso liberado");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
        }
    }
}