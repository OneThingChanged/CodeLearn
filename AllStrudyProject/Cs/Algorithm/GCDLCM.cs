using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Algorithm
{

    //GCD = Greatest Common Divisor = 최대공약수;
    //LCM = Least Common Multiple = 최소 공배수
    public static class Algorithm_GCDLCM
    {
        #region Code
        public static int GCD(int a, int b)
        {
            if (b > a)
            {
                int tempSwap = a;
                a = b;
                b = tempSwap;
            }
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }

        #endregion

        #region Program
        //static void Main(string[] args)
        //{
        //    int a = 38;
        //    int b = 27;
        //    Console.WriteLine($"a:{a} b:{b} {GCDLCM.GCD(a, b)}");
        //    Console.WriteLine($"a:{a} b:{b} {GCDLCM.LCM(a, b)}");
        //    Console.ReadLine();
        //}
        #endregion
    }
}
