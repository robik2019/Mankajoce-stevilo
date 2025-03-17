using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] podaniNiz = { 3, 7, 1, 2, 8, 4, 5 };

        int n = podaniNiz.Length + 1;
        int pričakovanaVsota = n * (n + 1) / 2;
        int dejanskaVsota = podaniNiz.Sum();
        int mankajoceStevilo = pričakovanaVsota - dejanskaVsota;

        Console.WriteLine("Mankajoče število je: "+mankajoceStevilo);
    }
}