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
        private Bitmap buffer = new Bitmap(100, 100);
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

            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tree.Root != null)
            {
                selectedNode = tree.Root;
            }
            Draw();
        }

        private void Draw()
        {
            Bitmap tempBuffer = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(tempBuffer))
            {
                Font font = new Font("Tahoma", 10);
                PointF drawPoint = new PointF(10.0F, 10.0F);
                int level, _level = 0;
                int step = 1;
                float fx = pictureBox1.Width / 2;
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
                        fx = node.Parent.PointX + (node.IsLeftChild ? -50.0F : 50.0F) + (node.IsLeftChild ? XSCALE * -1 : XSCALE);
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

                labelMinimum.Text = tree.Minimum(tree.Root) != null ? tree.Minimum(tree.Root).Value + "" : "";
                labelMaximum.Text = tree.Maximum(tree.Root) != null ? tree.Maximum(tree.Root).Value + "" : "";
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
                labelNodeHeight.Text = tree.Height(selectedNode) - 1 >= 0 ? tree.Height(selectedNode) - 1 + "" : "";
                labelLevel.Text = tree.Level(selectedNode) >= 0 ? tree.Level(selectedNode) + "" : "";
            }

            buffer = tempBuffer;
            pictureBox1.Image = buffer;
            pictureBox1.Invalidate();

            // set scroll pos
            if (selectedNode != null)
            {
                panel1.AutoScrollPosition = new Point((int)selectedNode.PointX - 350, (int)selectedNode.PointY - 350);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim().Length == 0)
                return;
            string[] lines = Regex.Split(textBoxInput.Text, ",");
            try
            {
                int lastVal = Array.ConvertAll<string, int>(lines, int.Parse).Last();
                foreach (int val in Array.ConvertAll<string, int>(lines, int.Parse))
                {
                    if (!tree.Insert(val))
                    {
                        MessageBox.Show(val + " already in tree", "Tree prompt");
                    }
                }
                selectedNode = tree.Search(lastVal);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please check your input. Must be of int type.", "Input error");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Value is too large or too small for an int", "Input error");
            }
            finally
            {
                Draw();
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim().Length == 0)
                return;
            string[] lines = Regex.Split(textBoxInput.Text, ",");
            BinarySearchTreeNode<int> toFocus;
            try
            {
                toFocus = tree.Search(Array.ConvertAll<string, int>(lines, int.Parse).Last());
                if (toFocus.HasParent)
                {
                    selectedNode = toFocus.Parent;
                }
                    
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
                Draw();
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tree.Clear();
            selectedNode = null;
            Draw();
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
                Draw();
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
        }
    }
}
