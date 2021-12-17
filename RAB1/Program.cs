using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabota1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(Ass(0.1 * Math.PI / 180), 7));
            double ll = Math.Atan(0.1 * Math.PI / 180);
            Console.WriteLine(ll);
            Console.ReadKey();
            Console.WriteLine(Math.Atan(0.3 + Math.PI / 180));
        }

        public static double Ass(double x)
        {
            const double eps = 1e-15;
            double s = 0;
            double r = x;
            int n = 1;
            while (Math.Abs(r) > eps)
            {
                s = s + r;
                n = n + 2;
                r = -r * x * x / (n);
            }
            return s;
        }

    }
}