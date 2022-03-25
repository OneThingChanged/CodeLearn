using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Algorithm
{
    //GCD = Greatest Common Divisor = 최대공약수;
    //LCM = Least Common Multiple = 최소 공배수
    public  static class GCDLCM
    {
        public static int GCD(int a, int b) {
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
    }
}
