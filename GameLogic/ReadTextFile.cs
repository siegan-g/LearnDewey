using System.Text;
using System.IO;

namespace PROG7312_POE;

public class ReadTextFile 
{
    //global vars
    private const String fileName = "../Data/callnums.txt";
    private List<String> lines;
    private string[][] entries;   
    private CallNumberTree<Area> tree = new CallNumberTree<Area>();
 
    public void ReadCallNumbers()
 {
         List<CallNumberTree<String>> treeList = new List<CallNumberTree<String>>();
        var lines = File.ReadAllLines(fileName);
        foreach(var line in lines)   
        {
            CallNumberTree<String> tree = new CallNumberTree<String>();
            string[] lineDetails = line.Split(';');

                tree.Root = new CallNumberNode<String>() {Value = lineDetails[0]};
                tree.Root.Children = new List<CallNumberNode<string>>
                {
                    new CallNumberNode<string>(){Value = lineDetails[1], Parent = tree.Root}
                };
                tree.Root.Children[0].Children = new List<CallNumberNode<string>>
                {
                    new CallNumberNode<string>(){Value=lineDetails[2],Parent = tree.Root.Children[0]},
                    new CallNumberNode<string>(){Value=lineDetails[3],Parent = tree.Root.Children[0]},
                    new CallNumberNode<string>(){Value=lineDetails[4],Parent = tree.Root.Children[0]},
                    new CallNumberNode<string>(){Value=lineDetails[5],Parent = tree.Root.Children[0]},

                };
                treeList.Add(tree);            
        }

        foreach(var tree in treeList)
        {
            System.Console.WriteLine(tree);
        }
    }
}