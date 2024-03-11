using System;

namespace HEHE
{
    class Program
    {
        static void nhapmang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Maxmang(int[] arr, int n) 
        {
            for (int i = 0;i < (arr.Length-1); i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            Console.Write("Max mang la: " + arr[n-1]);
           
        }
        static void Main(string[] args)
        {
        

                
                    int[] a;
                    int n;
                    Console.Write("Nhap so phan tu:");
                    n = int.Parse(Console.ReadLine());
                    a = new int[n];
                    nhapmang(a, n);
                    Maxmang(a, n);
                



        }
    }
}