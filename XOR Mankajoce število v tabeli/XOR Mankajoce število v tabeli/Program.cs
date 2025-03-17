
internal class Program
{
    private static void Main(string[] args)
    {
        int[] podaniNiz = { 3, 7, 1, 2, 8, 4, 5 };

        int n = podaniNiz.Length + 1;
        int xorVse = 0;
        int xorNiz = 0;

        for (int i = 1; i <= n; i++) 
        {
            xorVse ^= i;
        }

        foreach (int k in podaniNiz)
        {
            xorNiz = k;
        }

        int mankajoceStevilo = xorVse ^ xorNiz;

        Console.WriteLine("Mankajoče število je: " + xorNiz);
    }
}