public class Program
{
    public static void Main()
    {
        int n = 1;
        string str = n.ToString();
        int reverso = Reverter(str);

        do
        {
            str = n.ToString();
            reverso = Reverter(str);

            if (ChecarReversivel(n, str, reverso) && n + reverso < 1000000)
            {
                Console.WriteLine(n);
            }
            n++;
        } while (n < 1000000);
        Console.ReadLine();
    }

    public static int Reverter(string str)
    {
        char[] cha = str.ToCharArray();
        Array.Reverse(cha);
        int x = int.Parse(cha);
        return x;
    }

    public static bool ChecarReversivel(int n, string str, int reverso)
    {
        int soma = n + reverso;
        if (str[str.Length - 1] != '0' && (n + reverso) % 2 != 0)
        {
            while (soma > 0 && soma % 2 != 0)
            {
                soma /= 10;
            }
            if (soma == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}