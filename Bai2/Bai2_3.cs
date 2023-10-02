using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GreenAcademy
{
    internal class Bai2_3
    {
        public void InCacSoTongChan()
        {
            //Viết chương trình in ra các số tổng 3 ký số là chẵn từ 100 - 999.
            int hangTram, hangChuc, hangDonVi;
            Console.WriteLine("Hiển thị các số có tổng 3 chữ số là số chẵn từ 100-999.");
            for (int i = 100; i <= 999; i++)
            {
                hangTram = i / 100; //chia 100 lấy phần nguyên
                hangChuc = (i / 10) % 10;
                hangDonVi = i % 10;

                if ((hangTram + hangChuc + hangDonVi) % 2 == 0)
                {
                    Console.WriteLine($"Số {i} có tổng = {hangTram + hangChuc + hangDonVi}");
                }

            }



        }
    }
}
