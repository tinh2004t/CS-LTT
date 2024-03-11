using System;
using System.Text;

namespace HEHE
{
    class Program
    {
        // ---------------------------------------//
        static void nhapmang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        // Void Bai 1
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
            Console.WriteLine("Max mang la: " + arr[n-1]);
            Console.WriteLine("Min mang la: " + arr[0]);

        }

        // ---------------------------------------//
        // ---------------------------------------//
        // Main
        static void Main(string[] args)
        {
            Console.InputEncoding = UnicodeEncoding.UTF8;
            Console.OutputEncoding = UnicodeEncoding.UTF8;
            int sobai = 0;
            do
            {
                Console.Write("Nhap so bai (Nhap \"999\" de thoat): ");
                sobai = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                if (sobai == 999)
                {
                    Console.WriteLine("Da Thoat!");
                    return;
                }
            }
            while (sobai == 0);


            // ---------------------------------------//
            // Bai 1
            if (sobai == 1)
            {
                Console.WriteLine("De Bai: Viết chương trình tìm giá trị lớn nhất, nhỏ nhất của một mảng chứa các số\r\nnguyên gồm N phần tử. Hãy in mảng và gia trị lớn nhất, nhỏ nhất ra màn hình.");
                Console.WriteLine(" ");
                int[] a;
                int n;
                Console.Write("Nhap so phan tu:");
                n = int.Parse(Console.ReadLine());
                a = new int[n];
                nhapmang(a, n);
                Maxmang(a, n);
            }

            // ---------------------------------------//
            // Bai 2
            else if (sobai == 2)
            {
                Console.WriteLine("De bai: Viết chương trình tính tổng bình phương của các số âm trong một mảng gồm N\r\nphần tử.");
                int[] a;
                int n;
                Console.Write("Nhap so phan tu:");
                n = int.Parse(Console.ReadLine());
                a = new int[n];
                nhapmang(a,n);
            }

            else
            {
                Console.WriteLine("So bai khong ton tai");
            }
        }
    }
}