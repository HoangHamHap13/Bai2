using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Bai2_1
    {
        public void NamXThangY()
        {
            //Viết chương trình nhập vào năm x tháng y sau đó in ra số ngày trong tháng năm đó.

            //khai báo biến năm và tháng
            int namX;
            int thangY;


            Console.Write("Nhập năm: "); namX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            do
            {
                thangY = Convert.ToInt32(Console.ReadLine());
            } while (thangY < 1 || thangY > 12);

            //tạo biến isXLeap để kiểm tra phải năm nhuận hay không
            //Năm nhuận là năm chia hết cho 400 HOẶC [chia hết cho 4 nhưng không chia hết cho 100].
            bool isXLeap = false; // mặc định là giá trị false
            if (namX % 400 == 0) //kiểm tra điều kiện chia hết cho 400 thì đây là năm nhuận
            {
                Console.WriteLine("Năm {0} là năm nhuận", namX);
                isXLeap = true;
            }
            else if (namX % 100 == 0)  //nếu ko chia hết cho 400 thì kiểm tra thêm điều kiện chia hết cho 100
            {
                Console.WriteLine("Năm {0} không phải là năm nhuận", namX);
                isXLeap = false;
            }
            else if (namX % 4 == 0)
            {
                Console.WriteLine("Năm {0} là năm nhuận", namX);
                isXLeap = true;
            }
            else
            {
                Console.WriteLine("Năm {0} không phải là năm nhuận", namX);
                isXLeap = false;
            }

            switch (thangY)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Tháng có 31 ngày."); break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Tháng có 30 ngày."); break;
                case 2:
                    {
                        if (isXLeap) Console.WriteLine("Tháng có 29 ngày.");
                        else Console.WriteLine("Tháng có 28 ngày.");

                    }
                    break;
            }

            Console.ReadKey();
        }

    }
}

