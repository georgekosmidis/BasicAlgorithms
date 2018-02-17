using BasicAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms.DataProviders
{
    public class SortedAndUniformProvider : ISearchData
    {
        public string Name { get; } = "Sorted and Uniformely Distributed data";
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        public int AvgValue { get; private set; }
        public int RandomValue { get; private set; }
        public int NotFoundValue { get; private set; }
        public List<int> Data { get; private set; }

        public SortedAndUniformProvider(int size)
        {
            Data = Enumerable.Range(1, size).ToList();

            MinValue = Data[0];
            MaxValue = Data[size - 1];
            AvgValue = Data.First(x => x > (MinValue + MaxValue) / 2);
            RandomValue = Data[new Random((int)DateTime.Now.Ticks).Next(0, Data.Count - 1)];
            NotFoundValue = Data.Max() + 1;
        }

    }
}
