using BasicAlgorithms.Arrays.DataProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicAlgorithms.Arrays.DataProviders.Providers;

public class SortedProvider : IArrayDataProvider
{
    public int MinValue { get; private set; }
    public int MaxValue { get; private set; }
    public int AvgValue { get; private set; }
    public int RandomValue { get; private set; }
    public int NotFoundValue { get; private set; }
    public List<int> Data { get; private set; }

    /// <summary>
    /// Provides a list of sorted but not uniformely distributed data
    /// </summary>
    /// <param name="size">Size of the list</param>
    public SortedProvider(int size)
    {
        Data = new List<int>();
        for (var i = 0; i < size; i++)
        {

            if (i < size / 2)
            {
                Data.Add(i);
            }
            else
            {
                Data.Add(int.MaxValue - i);
            }
        }

        MinValue = Data[0];
        MaxValue = Data[size - 1];
        AvgValue = Data.First(x => x > (MinValue + MaxValue) / 2);
        RandomValue = Data[new Random((int)DateTime.Now.Ticks).Next(0, Data.Count - 1)];
        NotFoundValue = Data.Max() + 1;
    }

}
