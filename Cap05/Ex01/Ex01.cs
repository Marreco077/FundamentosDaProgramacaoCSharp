// Faça um programa que leia cinco grupos de quatro valores (A, B, C, D) e mostre-os na ordem lida. Em seguida, organize-os em ordem crescente e decrescente. 


namespace Cap05
{
    public class Cap05Ex01
    {
        public static void Run()
        {
            // Declarar 5 grupos de 4 valores
            var grupos = new int[5][];
            for (int i = 0; i < 5; i++)
            {
                grupos[i] = new int[4]; // Inicializa os arrays de cada grupo
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Digite o valor {j + 1} do grupo {i + 1}: ");
                    grupos[i][j] = int.Parse(Console.ReadLine());
                }
            }

             // Exibir os grupos na ordem lida
            Console.WriteLine("\nGrupos na ordem lida:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Grupo {i + 1}: {string.Join(", ", grupos[i])}");
            }

            // Organizar os grupos em ordem crescente
            Console.WriteLine("\nGrupos em ordem crescente:");
            for (int i = 0; i < 5; i++)
            {
                var crescente = grupos[i].OrderBy(x => x).ToArray(); // Organiza em ordem crescente
                Console.WriteLine($"Grupo {i + 1} (crescente): {string.Join(", ", crescente)}");
            }

            // Organizar os grupos em ordem decrescente
            Console.WriteLine("\nGrupos em ordem decrescente:");
            for (int i = 0; i < 5; i++)
            {
                var decrescente = grupos[i].OrderByDescending(x => x).ToArray(); // Organiza em ordem decrescente
                Console.WriteLine($"Grupo {i + 1} (decrescente): {string.Join(", ", decrescente)}");
            }
        }
    }
}