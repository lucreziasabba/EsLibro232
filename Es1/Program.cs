using System;

namespace Es1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la y: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la n: ");
            int n = int.Parse(Console.ReadLine());
            int mistero1 = Mistero1(x, y);
            int mistero2 = Mistero2(x, y);
            int mistero3 = Mistero3(x, y);
            int mistero4 = Mistero4(n);
            int mistero5 = Mistero5(n);
            int mistero6 = Mistero6(x, y);
            int mistero7 = Mistero7(x, y);
            int mistero8 = Mistero8(x, y);
            Console.WriteLine($"{mistero1},{mistero2},{mistero3},{mistero4},{mistero5},{mistero6},{mistero7},{mistero8}");

        }
        private static int Mistero1(int x, int y)
        {
            int prec;
            if (y == 0)
                return x;
            else
                return prec = Mistero1(x, y - 1);
        }
        private static int Mistero2(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return (Mistero1(x, Mistero2(x, y - 1)));
            }
        }
        private static int Mistero3(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return (Mistero2(x,Mistero3(x,y-1)));
        }
        private static int Mistero4(long n)
        {
            Console.WriteLine(n%10);
            if (n / 10 != 0)
                return Mistero4(n / 10);
            else
            throw new Exception("Non funziona");
        }
        private static int Mistero5(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return (Mistero5(n - 1) + Mistero5(n - 2));
        }
        private static int Mistero6(int x, int y)
        {
            if (x < 0)
                return Mistero6(x + y, y);
            else if (x < y)
                return x;
            else
                return Mistero6(x - y, y);
        }
        private static int Mistero7(int x, int y)
        {
            int z = 1;
            if (y < 0)
            {
                z = 0;
                throw new Exception("Parametro errato");
            }
            else if (y > 0)
            {
                z = x * Mistero7(x, y - 1);
            }
                return z;
        }
        private static int Mistero8(int x, int y)
        {
            int z;
            z = x & y;
            if (z==0)
            {
                return y;
            }
            else
            {
                x = y;
                y = z;
                return Mistero8(x, y);
            }
        }
    }
}
