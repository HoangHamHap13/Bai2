using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenAcademy
{
    internal class Bai2_7
    {
        public void TinhTienGuiNganHang()
        {
            //
            int soTienGui, soThangGui;
            double laiSuatNam;
            Console.WriteLine("Nhập vào số tiền gửi: "); soTienGui = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số tháng: "); soThangGui = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lãi suất tính theo năm: "); laiSuatNam = Convert.ToDouble(Console.ReadLine());
            double laiSuatThang;
            laiSuatThang = (laiSuatNam / 12) / 100;
            double tienLaiThang;
            double TongTien = soTienGui;

            for (int i = 1; i <= soThangGui; i++)
            {
                tienLaiThang = TongTien * laiSuatThang;
                Console.WriteLine($"Lãi tháng thứ {i}: {tienLaiThang}");
                TongTien = TongTien + tienLaiThang;
                Console.WriteLine($"Tổng tiền đến tháng {i}: {TongTien}");
            }

            Console.ReadKey();

        }
    }
}
