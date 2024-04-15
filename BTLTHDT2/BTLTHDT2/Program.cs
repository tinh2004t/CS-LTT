using System;
using System.Collections;

namespace BTLTHDT2
{
    class Program
    {
        static void SV()
        {
            SinhVien[] sv = new SinhVien[50];
            Console.Write("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                sv[i] = new SinhVien();
                //Console.Write("Nhap Ma Sinh Vien: ");
                //sv[i].MaSV = i;
                //Console.Write("Nhap Ho Ten Sinh Vien: ");
                //sv[i].HoTen = "sinh vien" + (i + 1);
                //Console.Write("Nhap Ngay Sinh Sinh Vien: ");
                //sv[i].NgaySinh = DateTime.Parse("2/2/222");
                //Console.Write("Nhap Diem Tin: ");
                //sv[i].DTin = double.Parse(Console.ReadLine());
                //Console.Write("Nhap Diem Anh: ");
                //sv[i].DAnh = double.Parse(Console.ReadLine());
                //Console.Write("Nhap Diem Phap Luat: ");
                //sv[i].DPhapLuat = double.Parse(Console.ReadLine());
                //Console.WriteLine("");
                sv[i].NhapSV();
            }

            Console.WriteLine("");
            Console.WriteLine("");



            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (sv[j].DTB() > sv[i].DTB())
                    {
                        SinhVien temp = new SinhVien();
                        temp = sv[j];
                        sv[j] = sv[i];
                        sv[i] = temp;
                    }
                }
            }

            Console.WriteLine("Danh Sach Sinh Vien");
            Console.WriteLine("{0,-10}{1,-15}{2,8}{3,13}{4,10}  {5,13}{6,7}",
                "MaSV", "HoTen", "NgaySinh", "DTin", "DAnh", "DPhapLuat", "DTB");

            for (int i = 0; i < n; i++)
            {
                sv[i].InSV();
            }
        }

        static void SVCNTT()
        {
                svCNTT[] svcntt = new svCNTT[50];
                Console.Write("Nhap so sinh vien CNTT: ");
                int cn = int.Parse(Console.ReadLine());
                for (int i = 0; i < cn; i++)
                {
                Console.WriteLine("Nhap sinh vien thu {0}", i + 1);
                svcntt[i] = new svCNTT();

                //Console.Write("Nhap Ma Sinh Vien: ");
                //svcntt[i].MaSV = i+1;
                //Console.Write("Nhap Ho Ten Sinh Vien: ");
                //svcntt[i].HoTen = "sinh vien" + (i + 1);
                //Console.Write("Nhap Ngay Sinh Sinh Vien: ");
                //svcntt[i].NgaySinh = DateTime.Parse("2/2/222");
                //Console.Write("Nhap Diem Tin: ");
                //svcntt[i].DTin = double.Parse(Console.ReadLine());
                //Console.Write("Nhap Diem Anh: ");
                //svcntt[i].DAnh = double.Parse(Console.ReadLine());
                //Console.Write("Nhap Diem Phap Luat: ");
                //svcntt[i].DPhapLuat = double.Parse(Console.ReadLine());
                //Console.Write("Nhap Diem CSharp: ");
                //svcntt[i].DCSharp = double.Parse(Console.ReadLine());
                //Console.WriteLine("");

                svcntt[i].NhapSVCNTT();
                }

                Console.WriteLine("");
                Console.WriteLine("");



                for (int i = 0; i < (cn - 1); i++)
                {
                    for (int j = i + 1; j < cn; j++)
                    {
                        if (svcntt[j].DTB() < svcntt[i].DTB())
                        {
                            svCNTT temp = new svCNTT();
                            temp = svcntt[j];
                            svcntt[j] = svcntt[i];
                            svcntt[i] = temp;
                        }
                    }
                }

                Console.WriteLine("Danh Sach Sinh Vien CNTT");
                Console.WriteLine("{0,-10}{1,-15}{2,8}{3,13}{4,10}  {5,12}{6,13}{7,9}",
                    "MaSV", "HoTen", "NgaySinh", "DTin", "DAnh", "DPhapLuat","DCSharp", "DTB");

                for (int i = 0; i < cn; i++)
                {
                    svcntt[i].InSVCNTT();
                }
            
        }
        static void Main(string[] args)
        {
            SV();
            Console.WriteLine("");
            SVCNTT();
            
        }
    }
}