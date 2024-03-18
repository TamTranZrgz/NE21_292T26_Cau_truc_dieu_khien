using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_3_Cau_Truc_Dieu_Khien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 1 - Nhap vao 1 so nguyen, va kiem tra xem so do co chia het cho 3 hay khong
            //Console.Write("Nhap vao so nguyen i = ");
            //int i = int.Parse(Console.ReadLine());

            // Cach 1
            //if (i % 3 == 0) Console.WriteLine("So chia het cho 3");
            //else Console.WriteLine("So khong chia het cho 3");

            // Cach 2
            // Console.WriteLine(i % 3 == 0 ? "So chia het cho 3" : "So khong chia het cho 3");

            // Cach 3
            //string kq = "So chia het cho 3";
            //if (i % 3 != 0) kq = "So khong chia het cho 3";
            //Console.WriteLine(kq);

            // Bai 5- Viet chuong trinh nhap vao thang bat ky tu ban phim, hien thi so ngay co trong thang
            Console.Write("Nhap vao thang m = ");
            int m = int.Parse(Console.ReadLine());

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Co 31 ngay");
                    break;

                case 2:
                    Console.WriteLine("Co 28 hoac 29 ngay");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Co 30 ngay");
                    break;

                default:
                    Console.WriteLine("GIa tri khong hop le");
                    break;
            }

            Console.ReadKey();

            
        }
    }
}
