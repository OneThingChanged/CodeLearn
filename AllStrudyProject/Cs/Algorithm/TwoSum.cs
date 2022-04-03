using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs.Algorithm
{
    public class Algorithm_TwoSum
    {
        static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
            return null;
        }

        static int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> tempDic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int requir = target - nums[i];
                if (tempDic.ContainsKey(requir))
                {
                    return new int[2] { tempDic[requir], i };
                }
                else if (!tempDic.ContainsKey(nums[i]))
                {
                    tempDic.Add(nums[i], i);
                }
            }
            return null;
        }

        //static void Main(string[] args)
        //{
        //    int[] temp = new int[] { 2, 7, 11, 15 };
        //    int target = 26;
        //    //int answer = [0,1];
        //    var answer = TwoSum1(temp, target);

        //    for (int i = 0; i < answer.Length; i++)
        //    {
        //        Console.WriteLine(answer[i]);
        //    }
        //    Console.ReadLine();
        //}
    }
}
