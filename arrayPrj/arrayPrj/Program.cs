using System;
using System.Text;

namespace HEHE
{
    class Program
    {
        // ---------------------------------------//

        // Void nhap mang
        static void nhapmang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        // Void Bai 1
        static void MaxMinmang(int[] arr, int n) 
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
        
        //Void Bai 2
        static void tongBP(int[] arr, int n)
        {
            int S=0;
            for (int i = 0;i < arr.Length; i++) 
            {
                if (arr[i] < 0)
                {
                    S = S + (arr[i] * arr[i]);
                }
            }
            Console.WriteLine("Tong binh phuong cac so am trong mang la: " + S);
        }

        //Void Bai 3
        static void sapxep (int[] arr, int n)
        {
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[i] > arr[j]))
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("Mang theo thu tu tang dan la: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        //Void Bai 4
        static void ktraTT(int[] arr, int n, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    Console.WriteLine("X \"ton tai\" trong mang");
                    return;
                }
                
            }
            Console.WriteLine("X \"khong ton tai\" trong mang");
        }

        //Void Bai 5
        static void tinhtong(int[] arr, int n)
        {
            int S=0;
            for (int i = 0; i < arr.Length; i++)
            {
                S += arr[i];

            }
            Console.WriteLine("Tong phan tu trong mang la: " + S);
        }

        //Void Bai 8
        static void 

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
                MaxMinmang(a, n);
            }

            // Bai 2
            else if (sobai == 2)
            {
                Console.WriteLine("De bai: Viết chương trình tính tổng bình phương của các số âm trong một mảng gồm N\r\nphần tử.");
                Console.WriteLine(" ");
                int[] a;
                int n;
                Console.Write("Nhap so phan tu:"); 
                n = int.Parse(Console.ReadLine());
                a = new int[n];
                nhapmang(a,n);
                tongBP(a, n);
            }

            // Bai 3
            else if (sobai == 3)
            {
                Console.WriteLine("De bai: Viết chương trình nhập vào một mảng gồm N số nguyên. Sắp xếp lại mảng theo\r\nthứ tự tăng dần, giảm dần và in kết quả ra màn hình.");
                Console.WriteLine(" ");
                int[] a;
                int n;
                Console.Write("Nhap so phan tu:");
                n = int.Parse(Console.ReadLine());
                a = new int[n];
                nhapmang(a, n);
                sapxep(a, n);
            }

            // Bai 4
            else if (sobai == 4)
            {
                Console.WriteLine("De bai: Viết chương trình nhập vào một mảng A gồm N số nguyên và nhập thêm vào một\r\nsố nguyên X. Hãy kiểm tra xem phần tử X có trong mảng A hay không?");
                Console.WriteLine(" ");
                int[] a;
                int n;
                int x;
                Console.Write("Nhap so phan tu:");
                n = int.Parse(Console.ReadLine());
                a = new int[n];
                nhapmang(a, n);
                Console.Write("Nhap so X:");
                x = int.Parse(Console.ReadLine());
                ktraTT(a, n, x);
            }

            // Bai 5
            else if (sobai == 5)
            {
                Console.WriteLine("De bai: Viết chương trình nhập vào một mảng, hãy xuất ra màn hình:\r\n\r\n- Phần tử lớn nhất của mảng.\r\n- Phần tử nhỏ nhất của mảng.\r\n- Tính tổng của các phần tử trong mảng .");
                Console.WriteLine(" ");
                int[] a;
                int n;
                int x;
                Console.Write("Nhap so phan tu:");
                n = int.Parse(Console.ReadLine());
                a = new int[n];
                nhapmang(a, n);
                MaxMinmang(a, n);
                tinhtong(a, n);
                
            }

            // Bai 8
            else if (sobai == 8)
            {
                // Khai báo mảng và con trỏ
                int[] a = new int[5];
                int* ptr = a;

                // Nhập mảng bằng con trỏ
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine("Nhập phần tử thứ " + i + ": ");
                    *(ptr + i) = int.Parse(Console.ReadLine());
                }

                // In mảng theo kiểu mảng
                Console.WriteLine("\nIn mảng theo kiểu mảng:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(a[i] + " ");
                }

                // In mảng theo kiểu con trỏ
                Console.WriteLine("\n\nIn mảng theo kiểu con trỏ:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write(*(ptr + i) + " ");
                }

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("So bai khong ton tai");
            }
        }
    }
}