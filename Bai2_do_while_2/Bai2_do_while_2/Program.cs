using System;

class Program
{
    static void Main(string[] args)
    {
        int countChan = 0, countLe = 0;
        int a, b;

        do
        {
            Console.Write("Nhap so nguyen a:");
            a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());

            // Kiểm tra tính chẵn lẻ của a và b
            if (a != 0 && b!=0)
            {
                if (a % 2 == 0 && b % 2 == 0)
                {
                    countChan++;
                }
                else if (a % 2 == 1 && b % 2 == 1)
                {
                    countLe++;
                }
            }

        } while (a != 0 && b != 0);

        Console.WriteLine("So cap so nguyen cung chan: {0}", countChan);
        Console.WriteLine("So cap so nguyen cung le: {0}", countLe);
    }
}
