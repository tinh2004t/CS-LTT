using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sochan = 0;
            int a;
            do
            {
                Console.WriteLine("Nhap so nguyen:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0 && a != 0) 
                {
                    Sochan++;                
                }
            }

            while (a != 0);
            Console.WriteLine("Co tat ca " + Sochan + " so chan duoc nhap vao");
        }
    }
}