using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLTHDT2
{
    public class SinhVien
    {
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DTin { get; set; }
        public double DAnh { get; set; }
        public double DPhapLuat { get; set; }
    
        public SinhVien() { }
        
        public SinhVien (int masv, string hoten, DateTime ngaysinh, double dtin, double danh, double dphapluat) 
        {
            masv = MaSV;
            ngaysinh = NgaySinh;
            dtin = DTin;
            danh = DAnh;
            dphapluat = DPhapLuat;
        
        }

        public double DTB()
        {
            static double RoundToNearestTenth(double DTB)
            {
                return Math.Round(DTB * 10) / 10;
            }
            double DTB;
            DTB = (DTin * 2 + DAnh * 3 + DPhapLuat * 2) / 7;
            double roundedNumber = RoundToNearestTenth(DTB);

            return roundedNumber;
        }

        public void NhapSV()
        {
            Console.Write("Nhap Ma Sinh Vien: ");
            MaSV = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho Ten Sinh Vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Ngay Sinh Sinh Vien: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Tin: ");
            DTin = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Anh: ");
            DAnh = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Phap Luat: ");
            DPhapLuat = double.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        public void InSV()
        {
            Console.WriteLine("{0,-10}{1,-15}{2:dd/mm/yyyy}{3,8}{4,10}  {5,8}{6,14}",
                MaSV, HoTen, NgaySinh, DTin, DAnh, DPhapLuat, DTB());
        }
    }

    public class svCNTT : SinhVien
    {
        public double DCSharp { get; set; }

        public svCNTT() { }

        public svCNTT(double dcsharp)
        {
            dcsharp = DCSharp;
        }

        public double DTBsvCNTT()
        {
            double DTB;
            DTB = (DTin * 2 + DAnh * 3 + DPhapLuat * 2 + DCSharp * 4) / 11;
            return DTB;
        }

        public void NhapSVCNTT()
        {
            Console.Write("Nhap Ma Sinh Vien: ");
            MaSV = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho Ten Sinh Vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Ngay Sinh Sinh Vien: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Tin: ");
            DTin = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Anh: ");
            DAnh = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Phap Luat: ");
            DPhapLuat = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem C Sharp: ");
            DCSharp = double.Parse(Console.ReadLine());
        }

        public void InSVCNTT()
        {
            Console.WriteLine("{0,-10}{1,-15}{2:dd/mm/yyyy}{3,8}{4,10} {5, 8} {6,14}{7,15}",
                MaSV, HoTen, NgaySinh, DTin, DAnh, DPhapLuat,DCSharp ,DTB());
        }
    }
}
