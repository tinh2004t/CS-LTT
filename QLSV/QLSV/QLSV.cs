using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class SinhVien
    {
        public int MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DTin { get; set; }
        public double DAnh { get; set; }
        public double DPhapLuat { get; set; }
        public SinhVien()
        {

        }

        public SinhVien(int maSV, string hoTen, DateTime ngaySinh, double dTin, double dAnh, double dPhapLuat)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DTin = dTin;
            DAnh = dAnh;
            DPhapLuat = dPhapLuat;
        }

        public double DTB()
        {
            double DTB;
            DTB = (DTin * 2 + DAnh * 3 + DPhapLuat * 2) / 7;
            return DTB;
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
        }

        public void InSV()
        {
            Console.WriteLine("{0,-10}{1,-15}{2,-15}{3,8}{4,10}  {5,8}{6,9}",
                MaSV, HoTen, NgaySinh, DTin, DAnh, DPhapLuat, DTB());
        }

    }

    public class SvCNTT : SinhVien
    {
        private float heSoDCSharp;

        public SvCNTT()
        {
        }

        public SvCNTT(int MaSV, string maSV, float diemTB, float heSoDCSharp) : base(hoTen, maSV, diemTB)
        {
            this.heSoDCSharp = heSoDCSharp;
        }

        public float HeSoDCSharp { get => heSoDCSharp; set => heSoDCSharp = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập hệ số DCSharp: ");
            heSoDCSharp = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Hệ số DCSharp: {0}", heSoDCSharp);
        }
    }
}
