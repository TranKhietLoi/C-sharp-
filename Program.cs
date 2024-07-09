using System;
using System.Text;
using ConsoleApp23;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Chào mừng bạn đã đến với hệ thống tính toán giải phương trình bậc 2 thông thái!");

            GiaiPhuongTrinhB2 giaiPhuongTrinh = new GiaiPhuongTrinhB2();

            // Gọi phương thức InterfaceInput để nhận giá trị a, b, c
            var inputValues = giaiPhuongTrinh.InterfaceInput();
            int a = inputValues.Item1;
            int b = inputValues.Item2;
            int c = inputValues.Item3;

            // Tính delta
            double del = giaiPhuongTrinh.delta(a, b, c);

            // Hiển thị các trường hợp của delta
            giaiPhuongTrinh.CacTruongHop(del);

            // Tìm nghiệm và hiện thị kết quả
            var nghiem = giaiPhuongTrinh.TimNghiem(del, a, b, c);

            // Xuất thông báo nghiệm
            if (nghiem != null)
            {
                double x1 = nghiem.Item1;
                double x2 = nghiem.Item2;
                Console.WriteLine($"Nghiệm x1: {x1}, Nghiệm x2: {x2}");
            }

            Console.ReadKey();
        }
    }
}