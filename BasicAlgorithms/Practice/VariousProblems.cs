using System;
using System.Collections.Generic;
using System.Linq;


namespace BasicAlgorithms.Practice
{
    public class VariousProblems
    {

        /// <summary>
        /// Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
        /// 
        /// </summary>
        public string LongestPalindrom(string s)
        {
            var start = 0;
            var end = 0;
            for (var i = 0; i < s.Length; i++)
            {
                var tmp = LongestPalindrom_CheckLength(s, i, i);
                var tmp2 = LongestPalindrom_CheckLength(s, i, i + 1);
                var max = Math.Max(tmp, tmp2);
                if (max > end - start)
                {
                    start = i - (max - 1) / 2;
                    end = i + max / 2;
                }
            }
            return s.Substring(start, end - start + 1);
        }
        private int LongestPalindrom_CheckLength(string s, int left, int right)
        {
            var _left = left;
            var _right = right;

            while (_left >= 0 && _right < s.Length && s.Substring(_left, 1) == s.Substring(_right, 1))
            {
                _left--;
                _right++;
            }
            //if (_left <= 0)
            //    _left = 0;
            //else
            //    _left++;

            //_right = Math.Min(_right, s.Length);
            return _right - _left - 1;// - (right - left);
        }

        /// <summary>
        /// Given a Matrix of size M x N. Your task is to print the matrix K times left rotated.
        /// https://practice.geeksforgeeks.org/problems/left-rotate-matrix-k-times/0
        /// </summary>
        public List<int> LeftRotateMatrix(int M, int N, int K, List<int> data)
        {
            var rotated = new List<int>();
            while (data.Count > 0)
            {
                var tmp = new List<int>();
                for (var i = N - 1; i >= 0; i--)
                {
                    tmp.Add(data[i]);
                    data.Remove(data[i]);
                }
                rotated.AddRange(tmp);

            }

            return rotated;
        }

        /// <summary>
        /// Given two integers ‘L’ and ‘R’, write a program that finds the count of numbers having prime number of set bits in their binary representation in the range [L, R].
        /// https://practice.geeksforgeeks.org/problems/prime-number-of-set-bits/0
        /// </summary>
        public int PrimeNumberSets(int L, int R)
        {
            var primesCount = 0;
            for (var i = L; i <= R; i++)
            {
                var setBitsCount = Convert.ToString(i, 2).Where(x => x == '1').Count();
                if (setBitsCount == 1)
                    continue;
                if (setBitsCount == 2 || setBitsCount == 3)
                {
                    primesCount++;
                    continue;
                }

                var root = (int)Math.Sqrt(setBitsCount);
                var isPrime = true;
                for (var j = 2; j <= root; j++)
                {
                    if (setBitsCount % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    primesCount++;
            }

            return primesCount;

        }

        /// <summary>
        /// https://practice.geeksforgeeks.org/problems/find-k-th-character-in-string/0
        /// </summary>
        public int FindCharacterBinary(int m, int k, int n)
        {
            var result = Convert.ToString(m, 2);
            for (var i = 0; i < n; i++)
            {
                var iteration = "";
                foreach (var c in result)
                {
                    iteration += c == '0' ? "01" : "10";
                }
                result = iteration;
            }
            return Convert.ToInt32(result.Substring(k, 1));
        }

        /// <summary>
        /// https://practice.geeksforgeeks.org/problems/maximum-tip-calculator/0
        /// N=orders[0], X=orders[1], Y=orders[2]
        /// </summary>
        public int MaximumTipCalculator(List<int> orders, List<int> tipsA, List<int> tipsB)
        {
            var countOrders = 0;
            var countA = 0;
            var countB = 0;
            var sumOrders = 0;
            for (var i = 0; i < tipsA.Count; i++)
            {
                if (countOrders >= orders[0])
                    break;
                if (countA <= orders[1] && tipsA[i] >= tipsB[i])
                {
                    sumOrders = sumOrders + tipsA[i];
                    countA++;
                    countOrders++;
                    continue;
                }
                if (countB <= orders[2] && tipsA[i] <= tipsB[i])
                {
                    sumOrders = sumOrders + tipsB[i];
                    countB++;
                    countOrders++;
                    continue;
                }
            }

            return sumOrders;
        }

        /// <summary>
        /// Given an array of n integers(duplicates allowed). Print “Yes” if it is a set of contiguous integers else print “No”.
        /// https://practice.geeksforgeeks.org/problems/check-if-array-contains-contiguous-integers-with-duplicates-allowed/0
        /// </summary>
        public bool ArrayContiguousIntegers(List<int> data)
        {
            data.Sort();
            var list = data.Distinct().ToList();
            return list[list.Count - 1] == list[0] + list.Count - 1;

        }

        /// <summary>
        /// Given an array of distinct integers, print all the pairs having positive value and negative value of a number that exists in the array.
        /// https://practice.geeksforgeeks.org/problems/pairs-with-positive-negative-values/0
        /// </summary>
        public List<int> OrderByAbsoluteOrder(List<int> data)
        {
            var dup = new List<int>();

            while (data.Count > 0)
            {
                var i = data.First();
                data.Remove(i);

                for (var j = 0; j < data.Count; j++)
                {
                    if (i == -1 * data[j])
                    {
                        int k;
                        for (k = 0; k < dup.Count; k = k + 2)
                        {
                            if (Math.Abs(i) < Math.Abs(dup[k]))
                                break;
                        }
                        if (data[j] > i)
                        {
                            dup.Insert(k, data[j]);
                            dup.Insert(k, i);
                        }
                        else
                        {
                            dup.Insert(k, i);
                            dup.Insert(k, data[j]);
                        }

                        data.Remove(data[j]);
                        break;
                    }
                }
            }
            return dup;
        }
    }
}
