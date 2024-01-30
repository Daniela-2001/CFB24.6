namespace aula24._6
{
    internal class Program
    {
        static void Main()
        {
            int v1, v2,r;
            v1 = Convert.ToInt32(Console.ReadLine());
            v2 = Convert.ToInt32(Console.ReadLine());
            r = soma(v1, v2);

            Console.WriteLine("A soma de {0} e {1} é {2}", v1, v2, r);
        }

        static int soma(int n1, int n2)
        {
            int res = n1 + n2;

            return res;
        }
    }
}