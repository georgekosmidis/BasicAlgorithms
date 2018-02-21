using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace BasicAlgorithms.Practice
{
    public class VariousProblems
    {

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
