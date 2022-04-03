#pragma once
#include <iostream>
#include <vector>
#include <cmath>
using namespace std;

namespace Algorithm
{
    class Solution {
    public:
        static int maxArea(vector<int>& height) {
            int answer = 0;
            for (int i = 0; i < height.size() - 1; i++)
            {
                for (int j = i + 1; j < height.size(); j++)
                {
                    int min = fmin(height[i], height[j]);

                    answer = (int)fmax(answer, min * (j - i));
                }
            }
            return answer;
        }

        static int maxArea(vector<int>& height) {
            int ans = 0;
            int n = height.size(), low = 0, high = n - 1;
            while (low < high) {
                ans = fmax(ans, (high - low) * min(height[low], height[high]));
                if (height[low] < height[high])low++;
                else high--;
            }
            return ans;
        }


    };

    int main()
    {
        vector<int> temp;
        temp.push_back(1);
        temp.push_back(8);
        temp.push_back(6);
        temp.push_back(2);
        temp.push_back(5);
        temp.push_back(4);
        temp.push_back(8);
        temp.push_back(3);
        temp.push_back(7);
        int a = Solution::maxArea(temp);
        cout << a << endl;
        return 0;
    }


}

