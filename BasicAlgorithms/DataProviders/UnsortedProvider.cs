using BasicAlgorithms.DataProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms.DataProviders
{
    public class UnsortedProvider : ISearchData
    {
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        public int AvgValue { get; private set; }
        public int RandomValue { get; private set; }
        public int NotFoundValue { get; private set; }
        public List<int> Data { get; private set; }

        /// <summary>
        /// Provides a list of random integers
        /// </summary>
        /// <param name="size">Size of the list</param>
        public UnsortedProvider(int size)
        {
            Data = new List<int>();
            var rnd = new Random(1);
            for (var i = 0; i < size; i++)
            {
                Data.Add(rnd.Next(0, size * 10));
            }

            MinValue = Data.Min();
            MaxValue = Data.Max();
            AvgValue = Data.First(x => x > (MinValue + MaxValue) / 2);
            RandomValue = Data[new Random((int)DateTime.Now.Ticks).Next(0, Data.Count - 1)];
            NotFoundValue = Data.Max() + 1;
        }

    }
}
