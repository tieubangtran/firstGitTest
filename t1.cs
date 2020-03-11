using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLU_Exercise1
{
    class Dung_an_cac
    {
        public static void inRaSoChinhPhuong(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (Math.Pow(i, 2) < n)
                {
                    Console.WriteLine(i * i);
                }
            }
        }

        public static void inRaSoNguyenTo(int n)
        {
            int dem = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                Console.WriteLine(n);
            }
        }

        public static int daoNguocSo(int n)
        {
            string m = n.ToString();
            string revstr = "";

            for (int i = (m.Length - 1); i >= 0; i--)
            {
                revstr = revstr + m[i];
            }

            int a = int.Parse(revstr);
            return a;
        }

        public static void kiemTraSoDaoNguoc(int n)
        {

            if (daoNguocSo(n) == n)
            {
                Console.WriteLine(n);
            }
        }

       public static double demSoChuSo(int n)
        {
            string m = n.ToString();
            int dem = m.Length;
            return dem;
        }

        public static bool isAmstrong(int n)
        {
            double temp, sum = 0;
            double m, k;
            k = demSoChuSo(n);
            temp = n;
            while (n > 0)
            {
                m = n % 10;
                sum = sum + Math.Pow(m, k);
                n = n / 10;
            }
            if(temp == sum)
            {
                return true;
            }
            return false;
        }

        public static void isPerfect(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    sum += i;
                }
                if (n == sum)
                {
                    Console.WriteLine(n);
                    break;
                }
            }

        }

        static void Main(string[] args)
        {
            string m;
            Console.Write("Nhap n: ");
            m = Console.ReadLine();

            int n = int.Parse(m);

            //inRaSoChinhPhuong(n);

            /*for(int i = 2; i <= n; i++)
            {
                inRaSoNguyenTo(i);
            }*/

            /*for(int i = 1; i <= n; i++)
            {
                kiemTraSoDaoNguoc(i);
            }*/

            /*for(int i = 0; i <= n; i++)
            {
                if (isAmstrong(i))
                {
                    Console.WriteLine(i);
                }
            }*/
            
            for(int i = 1; i <= n; i++)
            {
                isPerfect(i);
            }


            Console.Read();
        }
    }
}
