using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nhap so - khai bao bien
            Console.Write("Nhap vao so thu nhat :");
            string a = Console.ReadLine();
            Console.Write("Nhap vao so thu hai :");
            string b = Console.ReadLine();
            Console.Write("Nhap vao so thu ba :");
            string c = Console.ReadLine();

            //Gan gia tri cho cac bien ( Convert.ToInt32() su dung de chuyen doi van ban thanh so gia tri de tinh toan )
            Convert.ToInt32(a);
            Convert.ToInt32(b);
            Convert.ToInt32(c);

            // Gan an cho cac bien de tien tinh toan va viet ngan gon hon
            int A = Convert.ToInt32(a);
            int B = Convert.ToInt32(b);
            int C = Convert.ToInt32(c);

            //Phep tinh ghep so va phep cong
            Console.WriteLine("Ghep cac so lai: "  + a + b + c);
            Console.WriteLine("Ket qua phep cong: " + (A + B + C));

            //Phep so sanh
            {
                //Phep so sanh lon nhat 

                int NN = 0;
                int LN = 0;

                if (A > B && A > C)
                {
                    LN = A;
                    Console.WriteLine("So thu nhat lon nhat " + LN);
                }
                if (B > A && B > C)
                {
                    LN = B;
                    Console.WriteLine("So thu hai lon nhat " + LN);
                }
                if (C > A && C > B)
                {
                    LN = C;
                    Console.WriteLine("So thu ba lon nhat " + LN);
                }

                // Phep so sanh nho nhat 

                if (A < B && A < C)
                {
                    NN = A;
                    Console.WriteLine("So thu nhat nho nhat " + NN);
                }
                if (B < A && B < C)
                {
                    NN = B;
                    Console.WriteLine("So thu hai nho nhat " + NN);
                }
                if (C < A && C < B)
                {
                    NN = C;
                    Console.WriteLine("So thu ba nho nhat " + NN);
                }

                // Phep so sanh khi ra ket qua bang nhau
                else if (A == B && A == C)
                {
                    Console.WriteLine("cac so bang nhau");
                }
            }

            double T = 0;
            for ( int i=0; i<= 3; i++)
            {
                T = (A + B + C) / 3;
            }

            Console.ReadKey();
            Console.ReadKey();






        }
    }
}


