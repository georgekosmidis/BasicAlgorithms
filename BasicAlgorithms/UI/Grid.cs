using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BasicAlgorithms.UI
{
    public class Grid
    {
        int _tableWidth = 90;
        ConsoleColor DefaultColor = Console.ForegroundColor;

        public Grid(int tableWith)
        {
            _tableWidth = tableWith;
        }
        public void PrintLine()
        {
            Console.WriteLine(new string('-', _tableWidth));
        }

        public void PrintRow(params string[] columns)
        {
            int width = (_tableWidth - columns.Length) / columns.Length;
            Console.Write("|");

            foreach (string column in columns)
            {
                var color = DefaultColor;
                var text = column;
                if (column.Contains("|"))
                {
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), column.Split("|")[0]);
                    text = column.Split("|")[1];
                }
                Console.ForegroundColor = color;
                Console.Write(AlignCentre(text, width));
                Console.ForegroundColor = DefaultColor;
                Console.Write("|");
            }

            Console.WriteLine();
        }

        private string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
                return new string(' ', width);
            else
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }
}
