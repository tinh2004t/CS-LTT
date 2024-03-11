using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b, ucln;

        Console.Write("Nhap so nguyen a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so nguyen b: ");
        b = int.Parse(Console.ReadLine());

        // Tìm USCLN bằng vòng lặp do-while
        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }

        ucln = a + b;

        Console.WriteLine("USCLN cua 2 so la: {2}", a, b, ucln);
    }
}
