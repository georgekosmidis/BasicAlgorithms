using BasicAlgorithms.Arrays;
using BasicAlgorithms.Trees;
using BasicAlgorithms.UI;
using System;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Home:
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Home();
            } while (keyInfo.KeyChar != '1' && keyInfo.KeyChar != '2' && keyInfo.KeyChar != '3' && keyInfo.KeyChar != '4');

            if (keyInfo.KeyChar == '1')
                SortScreen();
            if (keyInfo.KeyChar == '2')
                SearchScreen();
            if (keyInfo.KeyChar == '3')
                TreeScreen();
            if (keyInfo.KeyChar == '4')
                TraversalScreen();
            goto Home;
        }
        static ConsoleKeyInfo Home()
        {
            Console.Clear();
            Console.WriteLine("Hello! Please choose:");
            Console.WriteLine("1: Sort Algorithms");
            Console.WriteLine("2: Search Algorithms");
            Console.WriteLine("3: Tree Algorithms");
            Console.WriteLine("4: Traversal Algorithms");
            return Console.ReadKey(true);
        }
        static ConsoleKeyInfo TraversalScreen()
        {
            Console.Clear();
            new TraversalUI(
                new TraversalFactory(6),
                90
            ).Print();

            Console.WriteLine();
            Console.WriteLine("Press any key for home screen!");

            return Console.ReadKey(true);
        }

        static ConsoleKeyInfo TreeScreen()
        {
            Console.Clear();
            new TreeUI(
                new TreeFactory(1000000),
                90
            ).Print();

            Console.WriteLine();
            Console.WriteLine("Press any key for home screen!");

            return Console.ReadKey(true);
        }

        static ConsoleKeyInfo SortScreen()
        {
            Console.Clear();
            new ArraySortUI(
                new ArraySortFactory(10000),
                90
            ).Print();

            Console.WriteLine();
            Console.WriteLine("Press any key for home screen!");

            return Console.ReadKey(true);
        }

        static ConsoleKeyInfo SearchScreen()
        {
            Console.Clear();
            new ArraySearchUI(
                new ArraySearchFactory(1000000),
                90
            ).Print();

            Console.WriteLine();
            Console.WriteLine("Press any key for home screen!");

            return Console.ReadKey(true);
        }
    }
}
