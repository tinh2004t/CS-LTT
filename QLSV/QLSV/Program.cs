using System;
using System.Collections;


namespace QLSV
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien qlsv1;
            qlsv1 = new SinhVien();
            SinhVien[] nv = new SinhVien[50];
            Console.Write("Nhap so Sinh Vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap Sinh Vien thu {0}:", i + 1);
                nv[i] = new SinhVien();
                nv[i].NhapSV();
            }

            Console.WriteLine("Ds.Sinh Vien");
            Console.WriteLine("{0,-10}{1,-15}{2,-15}{3,8}{4,10}  {5,8}{6,9}",
            for (int i = 0; i < n; i++)
            {
                nv[i].InSV();


            }
        }
    }
}