using DSBST.Containers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSBST
{
    public partial class BSTForm : Form
    {
        BinarySearchTree<int> tree = new BinarySearchTree<int>();
        BinarySearchTreeNode<int> selectedNode;
        public BSTForm()
        {
            InitializeComponent();

            bool Debug = true;
            if (Debug)
            {
                tree.Insert(20);
                tree.Insert(5);
                tree.Insert(2);
                tree.Insert(1);
                tree.Insert(7);
                tree.Insert(6);
                tree.Insert(9);
                tree.Insert(4);
                tree.Insert(10); 
                tree.Insert(8);
                selectedNode = tree.Root;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Tahoma", 10);
            PointF drawPoint = new PointF(10.0F, 10.0F);
            int level, _level = 0;
            int step = 1;
            float fx = panel1.Width / 2;
            float fy = 20;
            int radius = 20;

            foreach (var node in tree.BFS(tree.Root, node => node.Children))
            {
                if (node == null)
                    break;
                level = tree.Level(node);
                ++step;
                int diff = node.HasParent && node.IsLeftChild ? -1 : 1;
                if (_level != level)
                {
                    _level = level;
                }
                float XSCALE = 200 / _level;
                if (node.HasParent)
                {
                    fx = node.Parent.PointX + (node.IsLeftChild ? -50.0F : 50.0F) + (node.IsLeftChild ? XSCALE * -1: XSCALE);
                }
                node.PointX = fx;
                node.PointY = fy * _level;

                if (node.HasParent)
                {
                    // draw edge
                    int padding = (int)font.Size / 2;
                    Pen blackPen = new Pen(Color.Black, 1);
                    Point point1 = new Point((int)node.PointX, (int)node.PointY + padding);
                    Point point2 = new Point((int)node.Parent.PointX + padding, (int)node.Parent.PointY + (int)font.Size + padding + 5);
                    g.DrawLine(blackPen, point1, point2);
                }
                SolidBrush brush = new SolidBrush(System.Drawing.Color.White);
                Brush textBrush = Brushes.Black;
                if (node.CompareTo(selectedNode) == 0)
                {
                    brush = new SolidBrush(System.Drawing.Color.Green);
                    textBrush = Brushes.White;
                }
                
                // draw node
                g.FillEllipse(brush, node.PointX - 6, node.PointY, radius, radius);
                int fontPadding = (node.Value + "").Length > 1 ? (node.Value + "").Length + 2 : 0;
                drawPoint = new PointF(node.PointX - fontPadding, node.PointY);
                g.DrawString(node.Value + "", font, textBrush, drawPoint);
            }

            labelMinimum.Text = tree.Minimum(tree.Root) != null ? tree.Minimum(tree.Root).Value + "": "";
            labelMaximum.Text = tree.Maximum(tree.Root) != null ? tree.Maximum(tree.Root).Value + "": "";
            labelHeight.Text = tree.Height(tree.Root) - 1 >= 0 ? tree.Height(tree.Root) - 1 + "" : "";

            if (selectedNode != null)
            {
                labelSelected.Text = selectedNode.Value + "";
                labelSuc.Text = tree.Successor(selectedNode) != null ? tree.Successor(selectedNode).Value + "" : "";
                labelPre.Text = tree.Predecessor(selectedNode) != null ? tree.Predecessor(selectedNode).Value + "" : "";
            }
            else
            {
                labelSelected.Text = "";
                labelSuc.Text = "";
                labelPre.Text = "";
            }
            labelNodeMinimum.Text = tree.Minimum(selectedNode) != null ? tree.Minimum(selectedNode).Value + "" : "";
            labelNodeMaximum.Text = tree.Maximum(selectedNode) != null ? tree.Maximum(selectedNode).Value + "" : "";
            labelNodeHeight.Text = tree.Height(selectedNode) - 1 >= 0 ? tree.Height(selectedNode) - 1 + "": "";
            labelLevel.Text = tree.Level(selectedNode) >= 0 ? tree.Level(selectedNode) + "": "";
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim().Length == 0)
                return;
            string[] lines = Regex.Split(textBoxInput.Text, ",");
            try
            {
                foreach (int val in Array.ConvertAll<string, int>(lines, int.Parse))
                {
                    if (!tree.Insert(val))
                    {
                        MessageBox.Show(val + " already in tree", "Tree prompt");
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Input error", "Please check your input");
            }
            finally
            {
                panel1.Refresh();
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim().Length == 0)
                return;
            string[] lines = Regex.Split(textBoxInput.Text, ",");
            try
            {
                foreach (int val in Array.ConvertAll<string, int>(lines, int.Parse))
                {
                    if (!tree.Delete(val))
                    {
                        MessageBox.Show(val + " may not be in tree", "Tree prompt");
                    }
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Input error", "Please check your input");
            }
            finally
            {
                panel1.Refresh();
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tree.Clear();
            selectedNode = null;
            panel1.Refresh();
            textBoxInput.Clear();
            textBoxInput.Focus();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim().Length == 0)
                return;
            int searchValue;
            bool parsed = Int32.TryParse(textBoxInput.Text.Trim(), out searchValue);
            
            if (!parsed)
            {
                MessageBox.Show("Input must be integer.", "Invalid input");
                textBoxInput.Focus();
                return;
            }

            var searchNode = tree.Search(searchValue);
            if (searchNode == null)
            {
                MessageBox.Show(string.Format("{0} not found in tree.", searchValue + ""), "Tree prompt");
                textBoxInput.Focus();
                return;
            }
            else
            {
                selectedNode = searchNode;
                panel1.Refresh();
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
        }
    }
}
