using DSBST.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSBST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Insert(5);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(9);

            System.Console.WriteLine("Pre order");
            foreach(BinarySearchTreeNode<int> node in tree.Traverse(Traversal.PreOrder))
            {
                System.Console.WriteLine(node.Value);
            }

            System.Console.WriteLine("In order");
            foreach (BinarySearchTreeNode<int> node in tree.Traverse())
            {
                System.Console.WriteLine(node.Value);
            }

            System.Console.WriteLine("Post order");
            foreach (BinarySearchTreeNode<int> node in tree.Traverse(Traversal.PostOrder))
            {
                System.Console.WriteLine(node.Value);
            }

            System.Console.Read();
        }
    }
}
