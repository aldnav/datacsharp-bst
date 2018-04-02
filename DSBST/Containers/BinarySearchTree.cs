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
            System.Console.WriteLine(Value);
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

            if (Find(Root, value) != null)
            {
                return false;
            }
            InsertNodeTo(Root, new BinarySearchTreeNode<T>(value));
            return true;
        }

        public BinarySearchTreeNode<T> Find(BinarySearchTreeNode<T> node, T value)
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
                    return Find(node.Left, value);
                }
                return null;
            }
            else
            {
                // value is greater, it must be on the right
                if (node.HasRight)
                {
                    return Find(node.Right, value);
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
    }
}
