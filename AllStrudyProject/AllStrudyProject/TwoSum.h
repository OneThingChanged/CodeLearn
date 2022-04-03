

#pragma once
#include <iostream>;
#include <vector>;
#include <unordered_map>;
using namespace std;
namespace Algorithm
{
    class Solution {
    public:
        vector<int> twoSum(vector<int>& nums, int target) {
            vector<int> temp;
            for (int i = 0; i < nums.size() - 1; i++)
                for (int j = i + 1; j < nums.size(); j++)
                    if (nums[i] + nums[j] == target) {
                      
                        temp.push_back(i);
                        temp.push_back(j);
                        return temp;
                    }
                       
            return temp;
        }

        vector<int> twoSum(vector<int>& numbers, int target)
        {
            //Key is the number and value is its index in the vector.
            unordered_map<int, int> hash;
            vector<int> result;
            for (int i = 0; i < numbers.size(); i++) {
                int numberToFind = target - numbers[i];

                //if numberToFind is found in map, return them
                if (hash.find(numberToFind) != hash.end()) {
                    //+1 because indices are NOT zero based
                    result.push_back(hash[numberToFind] + 1);
                    result.push_back(i + 1);
                    return result;
                }

                //number was not found. Put it in the map.
                hash[numbers[i]] = i;
            }
            return result;
        }
    };
}

