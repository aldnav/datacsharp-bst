using DSBST.Containers;
using System.Windows.Forms;

namespace DSBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BSTForm());


            // For testing only
            //BinarySearchTree<int> tree = new BinarySearchTree<int>();

            //tree.Insert(5);
            //tree.Insert(2);
            //tree.Insert(7);
            //tree.Insert(1);
            //tree.Insert(9);
            //tree.Insert(6);

            //tree.Delete(5);
            //tree.Print();

            //int level, _level = 0;
            //int step = 1;

            //foreach (var node in tree.BFS(tree.Root, node => node.Children))
            //{
            //    level = tree.Level(node);
            //    ++step;
            //    if (_level != level)
            //    {
            //        step = 1;
            //        _level = level;
            //    }
            //    System.Console.WriteLine(string.Format("{0} : {1} : {2}", node.Value, level, node.HasParent && node.IsLeftChild ? -1: 1));
            //}

            //System.Console.WriteLine("Pre order");
            //tree.Print();

            //System.Console.WriteLine("In order");
            //tree.Print(Traversal.InOrder);

            //System.Console.WriteLine("Post order");
            //foreach (BinarySearchTreeNode<int> node in tree.Traverse(Traversal.PostOrder))
            //{
            //    System.Console.Write(node.Value + " ");
            //}
            //System.Console.WriteLine();

            //System.Console.WriteLine("Search (9): " + tree.Search(9).Value);
            //System.Console.WriteLine("Search (10): " + tree.Search(10));

            //System.Console.WriteLine("Min of tree: " + tree.Minimum(tree.Root).Value);
            //System.Console.WriteLine("Max of tree: " + tree.Maximum(tree.Root).Value);
            //System.Console.WriteLine("Min of sub-tree 7: " + tree.Minimum(tree.Search(7)).Value);
            //System.Console.WriteLine("Successor of sub-tree 5: " + tree.Successor(tree.Search(5)).Value);
            //System.Console.WriteLine("Successor of sub-tree 7: " + tree.Successor(tree.Search(7)).Value);

            //tree.Print();
            //System.Console.WriteLine("Removing 7");
            //tree.Delete(7);
            //tree.Print();

            //System.Console.WriteLine("Removing 9");
            //tree.Delete(9);
            //tree.Print();
            //System.Console.WriteLine("Removing root");
            //tree.Delete(tree.Root.Value);
            //tree.Print();
            //System.Console.WriteLine("Removing root");
            //tree.Delete(tree.Root.Value);
            //tree.Print();

            //BinarySearchTree<int> tree2 = new BinarySearchTree<int>();
            //tree2.Insert(6);
            //tree2.Insert(7);
            //tree2.Insert(9);
            //tree2.Print();
            //System.Console.WriteLine("Removing root");
            //tree2.Delete(tree2.Root.Value);
            //tree2.Print();
            //System.Console.WriteLine("Removing root");
            //tree2.Delete(tree2.Root.Value);
            //tree2.Print();
            //System.Console.WriteLine("Removing root");
            //tree2.Delete(tree2.Root.Value);
            //tree2.Print();

            //System.Console.Read();


        }
    }
}
