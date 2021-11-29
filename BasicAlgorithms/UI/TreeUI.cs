using BasicAlgorithms.Trees;
using BasicAlgorithms.Trees.TreeAlgorithms.Models;

namespace BasicAlgorithms.UI;

public class TreeUI : Grid
{

    private readonly TreeFactory _treeFactory;
    public TreeUI(TreeFactory treeFactory, int tableWith) : base(tableWith)
    {
        _treeFactory = treeFactory;
    }

    public void Print()
    {
        PrintLine();

        PrintRow("Ticks needed for a tree of " + _treeFactory.SampleSize + " integers");
        PrintLine();

        PrintLine();
        PrintRow("", "Creation", "Search", "Insert");
        PrintLine();

        PrintGrid("Heap",
            _treeFactory.Estimate(EnumTreeTypes.Heap)
        );
        PrintGrid("BST",
            _treeFactory.Estimate(EnumTreeTypes.BST)
        );
    }

    private void PrintGrid(string title, BinaryTreeEstimation r)
    {

        PrintRow(title,
            r.Deserialize.Ticks.ToString("00000000"),
            r.Search.Ticks.ToString("00000000"),
            r.Insert.Ticks.ToString("00000000")
        );
        PrintLine();
    }
}
