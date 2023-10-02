using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Bai2_5
    {
        public void TamGiac()
        {
            //Kiểm tra các loại tam giác
            int a, b, c;
            Console.Write("Nhập số nguyên dương a = "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số nguyên dương b = "); b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số nguyên dương c = "); c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)//tổng 2 cạnh bất kỳ > cạnh còn lại
            {
                Console.WriteLine("Đây là độ dài 3 cạnh của tam giác.");
                if (a == b && b == c && a == c) { Console.WriteLine("Tam giác đều."); }
                else if (a == b || b == c || c == a) { Console.WriteLine("Tam giác cân."); }
                else if ((a * a + b * b == c * c || a * c + c * c == b * b || b * b + c * c == a * c))
                {
                    Console.WriteLine("Tam giác vuông.");
                }
                else Console.WriteLine("Tam giác thường.");
            }
            else
            {
                Console.WriteLine("Đây không phải độ dài 3 cạnh của tam giác.");
            } 
                

        }
    }
}
