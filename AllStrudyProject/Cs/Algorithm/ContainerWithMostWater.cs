using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Algorithm
{
    public static class Algorithm_ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int answer = 0;
            for (int i = 0; i < height.Length -1; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int min = Math.Min(height[i], height[j]);

                    answer = Math.Max(answer, min * (j - i));
                }
            }
            return answer;
        }

        public static int MaxArea1(int[] height)
        {
            int answer = 0;
            int i = 0;
            int j = height.Length - 1;
            while (i < j)
            {
                answer = Math.Max((j - i) * Math.Min(height[i], height[j]), answer);
                if (height[i] < height[j])
                    i++;
                else 
                    j--;
            }
            return answer;
        }

        //static void Main(string[] args)
        //{
        //    int[] temp = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        //    //int[] temp = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        //    //int answer = 49;

        //    //int[] temp = new int[] { 4, 8, 1, 2, 3, 9 };
        //    //int answer = 32;
        //    var answer = MaxArea1(temp);

        //    Console.WriteLine(answer);
        //    Console.ReadLine();
        //}
    }
}
