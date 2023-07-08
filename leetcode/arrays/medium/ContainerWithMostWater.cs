﻿#region Description

/*
You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.

Example 1:

Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

Example 2:

Input: height = [1,1]
Output: 1

*/

#endregion

namespace leetcode.arrays.medium
{
    public static class ContainerWithMostWater
    {
        public static int Solution(int[] height)
        {
            int left = 0, right = height.Length - 1, maxWater = 0;

            while (left < right)
            {
                int currentHeight = Math.Min(height[left], height[right]);
                int currentWater = (right - left) * currentHeight;
                maxWater = Math.Max(maxWater, currentWater);

                while (height[right] <= currentHeight && left < right) right--;
                while (height[left] <= currentHeight && left < right) left++;
            }

            return maxWater;
        }
    }
}