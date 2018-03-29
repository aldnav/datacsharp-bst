using System;

namespace DSBST.Containers
{
    public class BinarySearchTreeNode : IComparable<BinarySearchTreeNode>
    {
        public int Value;
        public BinarySearchTreeNode Parent;
        public BinarySearchTreeNode Left;   // LL's prev
        public BinarySearchTreeNode Right;  // LL's next

        public BinarySearchTreeNode(int val)
        {
            Value = val;
        }

        public bool HasParent => Parent != null;

        public bool HasLeft => Left != null;

        public bool HasRight => Right != null;

        public bool IsLeftChild => Parent.Left != null && Parent.Left == this;

        public bool IsRightChild => Parent.Right != null && Parent.Right == this;

        public bool IsLeaf => !HasRight && !HasLeft;

        public int CompareTo(BinarySearchTreeNode other)
        {
            if (other == null)
                return 1;
            return Value.CompareTo(other.Value);
        }
    }

    class BinarySearchTree
    {
    }
}
