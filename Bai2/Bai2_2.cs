using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Bai2_2
    {
        public void ThoiGian()
        {
            //Viết chương trình nhập vào số nguyên dương là số giây, in ra định dạng sau hh:mm:ss.
            //Ví dụ số giây nhập vào là 350 thì in ra là 00:05:50.

            long tongSoGiay, gio, phut, giay;
            Console.Write("Nhập số giây cần tính: ");
            tongSoGiay = Convert.ToInt32(Console.ReadLine());
            gio = tongSoGiay / 3600;//1h = 3600s --> giờ = tổng số giây /3600
            phut = tongSoGiay % 3600 / 60; //chia lấy phần nguyên: 1p = 60s,vì ở trên ta đã chia 3600
                                           //để lấy giờ nên lấy phần dư của nó chia cho 60 
            giay = tongSoGiay % 60; //phần dư còn lại là số giây


            Console.WriteLine($"Định dạng hh:mm:ss: {gio:00}:{phut:00}:{giay:00}");
            //Ký tự $ đưa vào trước " để nhét biến trực tiếp vào các vị trí in ra màn hình console.

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt"));


            Console.ReadKey();
        }
    }
}



