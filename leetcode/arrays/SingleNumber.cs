﻿namespace leetcode.arrays
{
    public static class SingleNumber
    {
        public static int Find(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (map.ContainsKey(num)) map[num]++;
                else map[num] = 1;
            }

            foreach (var pair in map)
            {
                if (pair.Value == 1) return pair.Key;
            }

            return -1;
        }
    }
}