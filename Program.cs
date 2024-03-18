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
            //* Bai 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không. Hiển thị kết quả ra màn hình.

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

            //* Bai 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình
            //Console.Write("Nhap vao so nguyen duong n = ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0; i <= 10; i++)  
            //{
            //    Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            //}

            //* Bai 3: Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình. Ex: S = 1! + 2! + 3! + … +n!
            //Console.Write("Nhap vao so nguyen duong n = ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int factorial = 1;

            //for(int i = 1; i <= n; i++)
            //{
            //    factorial *= i;
            //    sum += factorial;
            //}

            //Console.WriteLine("Tong giai thua tu 1 den {0} la {1}", n, sum);


            //* Bai 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            //* Bai 5: Viet chuong trinh nhap vao thang bat ky tu ban phim, hien thi so ngay co trong thang
            //Console.Write("Nhap vao thang m = ");
            //int m = int.Parse(Console.ReadLine());

            //switch (m)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Co 31 ngay");
            //        break;

            //    case 2:
            //        Console.WriteLine("Co 28 hoac 29 ngay");
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Co 30 ngay");
            //        break;

            //    default:
            //        Console.WriteLine("GIa tri khong hop le");
            //        break;
            //}

            //* Bai 6: Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị kết quả ra màn hình.
            // 𝑆 = 1*1 + 2*2 + 3*3 + 4*4 + ... + n*n

            //* Bai 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình

            //* Bai 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n

            //* Bai 9: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng.

            //* Bai 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình

            Console.ReadKey();           
        }
    }
}
