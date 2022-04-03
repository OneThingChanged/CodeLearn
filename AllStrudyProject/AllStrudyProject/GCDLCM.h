#pragma once

namespace Algorithm {
	class GCDLCM
	{
	public:
		static int GCD(int a, int b) {
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

        static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }
	};

    //int main()
    //{
    //    int a = GCDLCM::GCD(36, 27);
    //    cout << a << endl;
    //    return 0;
    //}
}


