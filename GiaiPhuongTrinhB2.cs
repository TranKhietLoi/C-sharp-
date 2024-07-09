using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class GiaiPhuongTrinhB2
    {

        //Hàm tính phương trình bậc 2
        public double delta(int a, int b, int c)
        {
            //Viết hàm phân tích trường hợp delta
            double delta = b*b - 4*a*c;

            return delta;

        }
        public void CacTruongHop(double delta)
        {
            if (delta > 0)
            {
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt!");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phương trình có nghiệpm kép!");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm!");
            }
        }
        public Tuple<double,double> TimNghiem(double delta,int a, int b, int c)
        
        {
            double x1, x2;
            if (delta > 0)
            {
                x1 = (-b+Math.Sqrt(delta))/ (2*a);
                x2 = (-b-Math.Sqrt(delta))/ (2*a);
                return Tuple.Create(x1, x2);

            }
            else if(delta == 0)
            {
                x1 = (-b)/2*a;
                x2 = x1; 
                return Tuple.Create(x1, x2);
            }
            return null;

        }
       
        public Tuple<int,int,int> InterfaceInput()
        {
            Console.WriteLine("Lần lượt nhập vào giá trị a,b,c,d cho phương trình bậc 2: ax+by+c = 0");
            Console.WriteLine("Nhập vào a:");
            string _a = Console.ReadLine();
            int a = Convert.ToInt32(_a);

            Console.WriteLine("Nhập vào b:");
            string _b = Console.ReadLine();
            int b = Convert.ToInt32(_b);

            Console.WriteLine("Nhập vào c:");
            string _c = Console.ReadLine();
            int c = Convert.ToInt32(_c);
            return Tuple.Create(a, b, c);

        }
    }
}
