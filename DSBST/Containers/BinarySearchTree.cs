/**
 * Binary Search Tree
 * 
 * Implementation of the BST
 * @author Aldrin A. Navarro
 * @sn 2011-36650
 * 
 * Methods/Properties:
 *   Insert
 *   Delete
 *   Minimum
 *   Maximum
 *   Successor
 *   Predecessor
 *   Search
 *   Print
 *   
 * Extras added:
 *   BFS
 *   Height
 *   Level
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace DSBST.Containers
{
    public enum Traversal { PreOrder, InOrder, PostOrder };
    public class BinarySearchTreeNode<T> where T: IComparable<T>
    {
        public T Value { get; set; }
        public BinarySearchTreeNode<T> Parent;
        public BinarySearchTreeNode<T> Left;   // LL's prev
        public BinarySearchTreeNode<T> Right;  // LL's next

        public float PointX;
        public float PointY;

        public BinarySearchTreeNode(T val)
        {
            Value = val;
        }

        public bool HasParent => Parent != null;

        public bool HasLeft => Left != null;

        public bool HasRight => Right != null;

        public bool IsLeftChild => Parent.Left != null && Parent.Left == this;

        public bool IsRightChild => Parent.Right != null && Parent.Right == this;

        public bool IsLeaf => !HasRight && !HasLeft;

        public IEnumerable<BinarySearchTreeNode<T>> Children { get { return new[] { Left, Right }.Where(x => x != null); } }

        public int CompareTo(BinarySearchTreeNode<T> other)
        {
            if (other == null)
                return 1;
            return Value.CompareTo(other.Value);
        }
    }

    public class BinarySearchTree<T> where T: IComparable<T>
    {
        public BinarySearchTreeNode<T> Root;

        public void Clear()
        {
            Root = null;
        }
    
        public bool Insert(T value)
        {
            if (Root == null)
            {
                Root = new BinarySearchTreeNode<T>(value);
                return true;
            }

            if (Search(Root, value) != null)
            {
                return false;
            }
            InsertNodeTo(Root, new BinarySearchTreeNode<T>(value));
            return true;
        }

        public BinarySearchTreeNode<T> Search(T value) => Search(Root, value);

        public BinarySearchTreeNode<T> Search(BinarySearchTreeNode<T> node, T value)
        {
            if (this.Root == null)
            {
                return null;
            }

            if (node.Value.CompareTo(value) == 0)
            {
                return node;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                // value is lesser, it must be on the left
                if (node.HasLeft)
                {
                    return Search(node.Left, value);
                }
                return null;
            }
            else
            {
                // value is greater, it must be on the right
                if (node.HasRight)
                {
                    return Search(node.Right, value);
                }
                return null;
            }
        }

        public void InsertNodeTo(BinarySearchTreeNode<T> node, BinarySearchTreeNode<T> newNode)
        {
            if (node.CompareTo(newNode) > 0)
            {
                // new node is lesser
                if (node.HasLeft)
                {
                    this.InsertNodeTo(node.Left, newNode);
                    return;
                }
                else
                {
                    node.Left = newNode;
                    node.Left.Parent = node;
                    return;
                }
            }
            else
            {
                // new node is greater
                if (node.HasRight)
                {
                    this.InsertNodeTo(node.Right, newNode);
                    return;
                }
                else
                {
                    node.Right = newNode;
                    node.Right.Parent = node;
                    return;
                }
            }
        }

        public IEnumerable<BinarySearchTreeNode<T>> Traverse() => Traverse(this.Root, Traversal.InOrder);

        public IEnumerable<BinarySearchTreeNode<T>> Traverse(Traversal traversal) => Traverse(this.Root, traversal);

        public IEnumerable<BinarySearchTreeNode<T>> Traverse(BinarySearchTreeNode<T> node, Traversal traversal)
        {
            if (node == null)
            {
                yield break;
            }

            if (traversal == Traversal.PreOrder)
            {
                // Node, Left, Right
                yield return node;
                foreach (var n in Traverse(node.Left, traversal))
                {
                    yield return n;
                }
                foreach (var n in Traverse(node.Right, traversal))
                {
                    yield return n;
                }
            }
            else if (traversal == Traversal.InOrder)
            {
                // Left, Node, Right
                foreach (var n in Traverse(node.Left, traversal))
                {
                    yield return n;
                }
                yield return node;
                foreach (var n in Traverse(node.Right, traversal))
                {
                    yield return n;
                }
            }
            else if (traversal == Traversal.PostOrder)
            {
                // Left, Right, Node
                foreach (var n in Traverse(node.Left, traversal))
                {
                    yield return n;
                }
                foreach (var n in Traverse(node.Right, traversal))
                {
                    yield return n;
                }
                yield return node;
            }
        }

        public IEnumerable<BinarySearchTreeNode<T>> BFS(BinarySearchTreeNode<T> node, Func<BinarySearchTreeNode<T>, IEnumerable<BinarySearchTreeNode<T>>> children)
        {
            Queue<BinarySearchTreeNode<T>> q = new Queue<BinarySearchTreeNode<T>>();
            q.Enqueue(node);
            while(q.Count > 0)
            {
                BinarySearchTreeNode<T> current = q.Dequeue();
                yield return current;
                foreach(var child in children(current))
                {
                    q.Enqueue(child);
                }
            }
        }

        public bool Delete(T value)
        {
            if (this.Root == null)
            {
                return false;
            }

            if (this.Root.Value.CompareTo(value) == 0 && this.Root.IsLeaf)
            {
                this.Root = null;
                return true;
            }

            var nodeToRemove = this.Search(value);
            if (nodeToRemove == null)
            {
                return false;
            }

            this.Delete(nodeToRemove);
            return true;
        }

        private void Delete(BinarySearchTreeNode<T> node)
        {
            // if node hasn't children then just remove this node
            if (node.IsLeaf)
            {
                if (node.IsLeftChild)
                {
                    node.Parent.Left = null;
                }
                else if (node.IsRightChild)
                {
                    node.Parent.Right = null;
                }

                node.Parent = null;
                return;
            }

            // if node has only 1 child then replace node by child
            if (node.HasLeft ^ node.HasRight)
            {
                if (!node.HasParent)
                {
                    if (!node.HasRight && node.HasLeft)
                        Root = node.Left;
                    else if (node.HasRight && !node.HasLeft)
                        Root = node.Right;
                    Root.Parent = null;
                    return;
                }

                if (node.HasLeft)
                {
                    if (node.IsLeftChild)
                    {
                        node.Parent.Left = node.Left;
                    }
                    else
                    {
                        node.Parent.Right = node.Left;
                    }

                    node.Left.Parent = node.Parent;
                }
                else if (node.HasRight)
                {
                    if (node.IsLeftChild)
                    {
                        node.Parent.Left = node.Right;
                    }
                    else
                    {
                        node.Parent.Right = node.Right;
                    }

                    node.Right.Parent = node.Parent;
                }

                return;
            }

            // if node has both childs
            var successor = Successor(node);
            node.Value = successor.Value;
            this.Delete(successor);
        }
        
        // Left-most leaf node
        public BinarySearchTreeNode<T> Minimum(BinarySearchTreeNode<T> node)
        {
            if (node == null)
                return null;
            BinarySearchTreeNode<T> current = node;

            while (current.HasLeft)
            {
                current = current.Left;
            }
            return current;
        }

        // Right-most leaf node
        public BinarySearchTreeNode<T> Maximum(BinarySearchTreeNode<T> node)
        {
            if (node == null)
                return null;
            BinarySearchTreeNode<T> current = node;

            while (current.HasRight)
            {
                current = current.Right;
            }
            return current;
        }

        // Minimum of right subtree
        public BinarySearchTreeNode<T> Successor(BinarySearchTreeNode<T> node)
        {
            return Minimum(node.Right);
        }

        // Maximum of left subtree
        public BinarySearchTreeNode<T> Predecessor(BinarySearchTreeNode<T> node)
        {
            return Maximum(node.Left);
        }

        public void Print() => Print(Traversal.InOrder);

        public void Print(Traversal traversal)
        {
            foreach (BinarySearchTreeNode<T> node in Traverse(traversal))
            {
                System.Console.Write(node.Value + " ");
            }
            System.Console.WriteLine();
        }
        
        /**
         * Same as Print but returns string
         */
        public String Display(Traversal traversal, Boolean isBFS)
        {
            String display = "";
            if (isBFS)
            {
                foreach (var node in BFS(Root, node => node.Children))
                {
                    if (node == null)
                        break;
                    display += node.Value + " ";
                }
                return display;
            }

            foreach (BinarySearchTreeNode<T> node in Traverse(traversal))
            {
                display += node.Value + " ";
            }
            return display;
        }

        public int Level(BinarySearchTreeNode<T> searchNode)
        {
            if (searchNode == null)
                return -1;
            int level = 1;
            Queue<BinarySearchTreeNode<T>> q = new Queue<BinarySearchTreeNode<T>>();
            q.Enqueue(Root);
            q.Enqueue(null);
            while (q.Count > 0)
            {
                BinarySearchTreeNode<T> current = q.Dequeue();
                if (current == null)
                {
                    try
                    {
                        if (q.Peek() != null)
                            q.Enqueue(null);
                        ++level;
                    }
                    catch (Exception){}
                }
                else
                {
                    if (searchNode.CompareTo(current) == 0)
                        break;
                    if (current.HasLeft)
                        q.Enqueue(current.Left);
                    if (current.HasRight)
                        q.Enqueue(current.Right);
                }
            }
            return level;
        }

        public int Height(BinarySearchTreeNode<T> node)
        {
            var result = 0;

            if (node != null)
            {
                result = Math.Max(Height(node.Left), Height(node.Right)) + 1;
            }

            return result;
        }

        /**
         * Helper function to get the total number of nodes
         */
        public int NodeCount {
            get
            {
                int count = 0;
                foreach (BinarySearchTreeNode<T> node in Traverse())
                {
                    ++count;
                }
                return count;
            }
        }
    }
}
