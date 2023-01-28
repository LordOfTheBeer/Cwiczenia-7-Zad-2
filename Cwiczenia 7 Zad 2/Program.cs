namespace Cwiczenia_7_Zad_2
{
    internal class Program
    {
        static double SredniaH(double x1, double x2)
        {
            return 2 / (1 / x1 + 1 / x2); ;
        }
        static int Suma_do_n(int n)
        {
            int i, s = 0;
            for (i = 1; i <= n; i++)
                s += i;
            return s;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)

            Console.WriteLine(i + " " + Suma_do_n(i));
        }
    }
}