using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace GreenAcademy
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            //Hiển thị tiếng Việt trên màn hình Console
            Console.OutputEncoding = Encoding.Unicode;


            //Chạy bài 1
            //Bai2_1 b1 = new Bai2_1();
            //b1.NamXThangY();

            //Chạy bài 2
            //Bai2_2 b2 = new Bai2_2();
            //b2.ThoiGian();

            //Chạy bài 3
            //Bai2_3 b3 = new Bai2_3();
            //b3.InCacSoTongChan();


            //Chạy bài 5
            //Bai2_5 b5 = new Bai2_5();
            //b5.TamGiac();

            //Chạy bài 7
            Bai2_7 b7 = new Bai2_7();
            b7.TinhTienGuiNganHang();


        }
    }

}

