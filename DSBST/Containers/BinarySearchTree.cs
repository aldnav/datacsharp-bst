/**
 * Binary Search Tree
 * @author Aldrin A. Navarro
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
 */

using System;
using System.Collections.Generic;

namespace DSBST.Containers
{
    public enum Traversal { PreOrder, InOrder, PostOrder };
    public class BinarySearchTreeNode<T> where T: IComparable<T>
    {
        public T Value { get; set; }
        public BinarySearchTreeNode<T> Parent;
        public BinarySearchTreeNode<T> Left;   // LL's prev
        public BinarySearchTreeNode<T> Right;  // LL's next

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

        public bool Delete(T value)
        {
            if (Root == null)
            {
                // tree is empty. nothing to do here
                return false;
            }

            if (Root.IsLeaf && Root.Value.CompareTo(value) == 0)
            {
                // node to remove is the root and is the only node in tree
                Root = null;
                return true;
            }

            var nodeToRemove = Search(value);
            if (nodeToRemove == null)
            {
                // element not in tree
                return false;
            }

            if (nodeToRemove.IsLeaf)
            {
                if (nodeToRemove.IsLeftChild)
                {
                    nodeToRemove.Parent.Left = null;
                }
                else if (nodeToRemove.IsRightChild)
                {
                    nodeToRemove.Parent.Right = null;
                }
                nodeToRemove.Parent = null;
                return true;
            }

            // node has an only child
            bool hasOneChildOnly = false;
            if (nodeToRemove.HasLeft && !nodeToRemove.HasRight)
            {
                // if node has left child
                if (!nodeToRemove.HasParent)
                {
                    Root = nodeToRemove.Left;
                    nodeToRemove.Left.Parent = null;
                }
                else if (nodeToRemove.IsLeftChild)
                {
                    nodeToRemove.Parent.Left = nodeToRemove.Left;
                    nodeToRemove.Left.Parent = nodeToRemove.Parent;
                }
                else if (nodeToRemove.IsRightChild) 
                {
                    nodeToRemove.Parent.Right = nodeToRemove.Left;
                    nodeToRemove.Left.Parent = nodeToRemove.Parent;
                }
                hasOneChildOnly = true;
            }
            else if (nodeToRemove.HasRight && !nodeToRemove.HasLeft)
            {
                // if node has right child
                if (!nodeToRemove.HasParent)
                {
                    Root = nodeToRemove.Right;
                    nodeToRemove.Right.Parent = null;
                }
                else if (nodeToRemove.IsLeftChild)
                {
                    nodeToRemove.Parent.Left = nodeToRemove.Right;
                    nodeToRemove.Right.Parent = nodeToRemove.Parent;
                }
                else if (nodeToRemove.IsRightChild)
                {
                    nodeToRemove.Parent.Right = nodeToRemove.Right;
                    nodeToRemove.Right.Parent = nodeToRemove.Parent;
                }
                hasOneChildOnly = true;
            }
            if (hasOneChildOnly)
            {
                nodeToRemove = null;
                return true;
            }
            
            // both child is present; replace with successor
            BinarySearchTreeNode<T> successor = Successor(nodeToRemove);
            nodeToRemove.Value = successor.Value;
            nodeToRemove.Right = null;
            successor = null;

            return true;
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

        public void Print() => Print(Traversal.PreOrder);

        public void Print(Traversal traversal)
        {
            foreach (BinarySearchTreeNode<T> node in Traverse(traversal))
            {
                System.Console.Write(node.Value + " ");
            }
            System.Console.WriteLine();
        }
    }
}
