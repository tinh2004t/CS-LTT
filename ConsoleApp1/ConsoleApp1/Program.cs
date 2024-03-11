using System;
using System.Collections;
using System.Text;

namespace USCBSC
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[] a;
            int spt;
            a = new int[6];
            int[] b= {1,2,3,4,};
            Console.Write("Nhập số phần tử:");
            spt = int.Parse(Console.ReadLine());
            for (int i = 0; i < spt; i++)
            {
                Console.Write("a[{0}]= ", i);   
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < spt; i++)
            {
                Console.Write(a[i]+ "\t");
                if (i == (spt-1)) {
                    Console.Write("|| ");
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + "\t");
            }

        }

    }

}