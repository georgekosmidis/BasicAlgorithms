using BasicAlgorithms.Trees.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasicAlgorithms.Trees.Models;
using BasicAlgorithms.Trees.DataProviders.Interfaces;

namespace BasicAlgorithms.Trees.DataProviders.Providers
{
    public class TreeProvider : ITreeDataProvider
    {
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        public int AvgValue { get; private set; }
        public int RandomValue { get; private set; }
        public int NotFoundValue { get; private set; }
        public BinaryTree Tree { get; private set; }
        public List<int> Data { get; private set; }
        /// <summary>
        /// Provides a list of sorted but not uniformely distributed data
        /// </summary>
        /// <param name="size">Size of the list</param>
        public TreeProvider(ITree tree, int size)
        {
            Data = new List<int>();
            for (var i = size; i > 0; i--)
            {
                Data.Add(i);
            }

            MinValue = Data.Min();
            MaxValue = Data.Max();
            AvgValue = Data.Where(x => x > (MinValue + MaxValue) / 2).OrderBy(x => x).First();
            RandomValue = Data[new Random((int)DateTime.Now.Ticks).Next(0, Data.Count - 1)];
            NotFoundValue = Data.Max() + 1;

            Tree = tree.CreateTree(Data).Result;
        }
    }
}
