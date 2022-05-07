namespace Desafio3
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Digite o número/resultado: ");
            int objetivo = int.Parse(Console.ReadLine());

            Console.Write("Digite o vetor de números inteiros separados por vírgula: ");
            string[] vet = Console.ReadLine().Split(",");
            int[] candidatos = new int[vet.Length];
            for (int i = 0; i < vet.Length; i++)
            {
                candidatos[i] = Convert.ToInt32(vet[i]);
            }

            List<List<int>> resultado = new List<List<int>>();

            acharCombinacoes(candidatos, 0, objetivo, new List<int>(), resultado);
            resultado.Sort((x, y) => x.Count.CompareTo(y.Count));

            Console.WriteLine();
            Console.WriteLine(objetivo);
            foreach (List<int> lista in resultado)
            {
                if (lista.Count == resultado[0].Count)
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", lista));
                    Console.WriteLine("]");
                }
            }
            Console.ReadLine();
        }

        public static void acharCombinacoes(int[] candidatos, int indexador, int objetivo, List<int> atual, List<List<int>> resultado)
        {
            if (objetivo == 0)
            {
                resultado.Add(new List<int>(atual));
                return;
            }
            for (int i = indexador; i < candidatos.Length; i++)
            {
                if (candidatos[i] <= objetivo)
                {
                    atual.Add(candidatos[i]);
                    acharCombinacoes(candidatos, i, objetivo - candidatos[i], atual, resultado);
                    atual.Remove(candidatos[i]);
                }
            }
        }
    }
}