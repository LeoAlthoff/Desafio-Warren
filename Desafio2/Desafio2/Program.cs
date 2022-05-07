public class Program
{
    public static void Main()
    {
        int estudantesNecessarios, estudantesEmTempo = 0;
        List<int> tempoChegada = new List<int>();

        Console.Write("Digite a quantidade mínima de alunos presentes para a aula: ");
        estudantesNecessarios = int.Parse(Console.ReadLine());

        Console.WriteLine();
        imprimirCriterios();

        string[] vet = Console.ReadLine().Split(", ");
        foreach (string tempo in vet)
        {
            if (Convert.ToInt32(tempo) <= 0)
            {
                estudantesEmTempo++;
            }
        }
        if (estudantesEmTempo >= estudantesNecessarios)
        {
            Console.WriteLine();
            Console.WriteLine("Aula normal.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Aula cancelada.");
        }
    }
    public static void imprimirCriterios()
    {
        Console.WriteLine("Digite os horários de chegada de cada aluno conforme as seguintes orientações: ");
        Console.WriteLine("1) -1 = chegou 1 minuto adiantado.");
        Console.WriteLine("2) 0 = chegou no minuto exato.");
        Console.WriteLine("3) 1 = chegou 1 minuto adiantado.");
        Console.WriteLine("4) Os números devem ser separados por vírgula e espaço.");
        Console.WriteLine("Exemplo de entrada: 2, 0, -1, -2");
    }
}