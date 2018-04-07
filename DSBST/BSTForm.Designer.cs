namespace DSBST
{
    partial class BSTForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.labelMinimum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelNodeMaximum = new System.Windows.Forms.Label();
            this.labelNodeMinimum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNodeHeight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPre = new System.Windows.Forms.Label();
            this.labelSuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButtonPreOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonInOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonPostOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonBFS = new System.Windows.Forms.RadioButton();
            this.buttonTraverse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(20, 20);
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(188, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 525);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1920);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(13, 13);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(157, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(13, 39);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(95, 39);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(13, 69);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHeight);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelMaximum);
            this.groupBox1.Controls.Add(this.labelMinimum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree info";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(85, 56);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(0, 13);
            this.labelHeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height";
            // 
            // labelMaximum
            // 
            this.labelMaximum.AutoSize = true;
            this.labelMaximum.Location = new System.Drawing.Point(82, 36);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(0, 13);
            this.labelMaximum.TabIndex = 3;
            // 
            // labelMinimum
            // 
            this.labelMinimum.AutoSize = true;
            this.labelMinimum.Location = new System.Drawing.Point(82, 20);
            this.labelMinimum.Name = "labelMinimum";
            this.labelMinimum.Size = new System.Drawing.Size(0, 13);
            this.labelMinimum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelLevel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelNodeMaximum);
            this.groupBox2.Controls.Add(this.labelNodeMinimum);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelNodeHeight);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labelSelected);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.labelPre);
            this.groupBox2.Controls.Add(this.labelSuc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 132);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Node info";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(85, 35);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(55, 13);
            this.labelLevel.TabIndex = 13;
            this.labelLevel.Text = "labelLevel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Level";
            // 
            // labelNodeMaximum
            // 
            this.labelNodeMaximum.AutoSize = true;
            this.labelNodeMaximum.Location = new System.Drawing.Point(85, 96);
            this.labelNodeMaximum.Name = "labelNodeMaximum";
            this.labelNodeMaximum.Size = new System.Drawing.Size(99, 13);
            this.labelNodeMaximum.TabIndex = 11;
            this.labelNodeMaximum.Text = "labelNodeMaximum";
            // 
            // labelNodeMinimum
            // 
            this.labelNodeMinimum.AutoSize = true;
            this.labelNodeMinimum.Location = new System.Drawing.Point(85, 83);
            this.labelNodeMinimum.Name = "labelNodeMinimum";
            this.labelNodeMinimum.Size = new System.Drawing.Size(96, 13);
            this.labelNodeMinimum.TabIndex = 10;
            this.labelNodeMinimum.Text = "labelNodeMinimum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Maximum";
            // 
            // labelNodeHeight
            // 
            this.labelNodeHeight.AutoSize = true;
            this.labelNodeHeight.Location = new System.Drawing.Point(85, 112);
            this.labelNodeHeight.Name = "labelNodeHeight";
            this.labelNodeHeight.Size = new System.Drawing.Size(86, 13);
            this.labelNodeHeight.TabIndex = 9;
            this.labelNodeHeight.Text = "labelNodeHeight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Minimum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Height";
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(85, 18);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(71, 13);
            this.labelSelected.TabIndex = 5;
            this.labelSelected.Text = "labelSelected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Selected";
            // 
            // labelPre
            // 
            this.labelPre.AutoSize = true;
            this.labelPre.Location = new System.Drawing.Point(85, 66);
            this.labelPre.Name = "labelPre";
            this.labelPre.Size = new System.Drawing.Size(45, 13);
            this.labelPre.TabIndex = 3;
            this.labelPre.Text = "labelPre";
            // 
            // labelSuc
            // 
            this.labelSuc.AutoSize = true;
            this.labelSuc.Location = new System.Drawing.Point(85, 49);
            this.labelSuc.Name = "labelSuc";
            this.labelSuc.Size = new System.Drawing.Size(48, 13);
            this.labelSuc.TabIndex = 2;
            this.labelSuc.Text = "labelSuc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Predecessor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Successor";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(95, 69);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(13, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 101);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Note";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(8, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 76);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "* To select a node, use Search\n* Input can be single int value or comma-separated" +
    " int values";
            // 
            // radioButtonPreOrder
            // 
            this.radioButtonPreOrder.AutoSize = true;
            this.radioButtonPreOrder.Checked = true;
            this.radioButtonPreOrder.Location = new System.Drawing.Point(15, 98);
            this.radioButtonPreOrder.Name = "radioButtonPreOrder";
            this.radioButtonPreOrder.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPreOrder.TabIndex = 9;
            this.radioButtonPreOrder.TabStop = true;
            this.radioButtonPreOrder.Text = "Pre Order";
            this.radioButtonPreOrder.UseVisualStyleBackColor = true;
            this.radioButtonPreOrder.CheckedChanged += new System.EventHandler(this.radioButtonPreOrder_CheckedChanged);
            // 
            // radioButtonInOrder
            // 
            this.radioButtonInOrder.AutoSize = true;
            this.radioButtonInOrder.Location = new System.Drawing.Point(15, 121);
            this.radioButtonInOrder.Name = "radioButtonInOrder";
            this.radioButtonInOrder.Size = new System.Drawing.Size(63, 17);
            this.radioButtonInOrder.TabIndex = 10;
            this.radioButtonInOrder.Text = "In Order";
            this.radioButtonInOrder.UseVisualStyleBackColor = true;
            this.radioButtonInOrder.CheckedChanged += new System.EventHandler(this.radioButtonInOrder_CheckedChanged);
            // 
            // radioButtonPostOrder
            // 
            this.radioButtonPostOrder.AutoSize = true;
            this.radioButtonPostOrder.Location = new System.Drawing.Point(95, 98);
            this.radioButtonPostOrder.Name = "radioButtonPostOrder";
            this.radioButtonPostOrder.Size = new System.Drawing.Size(75, 17);
            this.radioButtonPostOrder.TabIndex = 11;
            this.radioButtonPostOrder.Text = "Post Order";
            this.radioButtonPostOrder.UseVisualStyleBackColor = true;
            this.radioButtonPostOrder.CheckedChanged += new System.EventHandler(this.radioButtonPostOrder_CheckedChanged);
            // 
            // radioButtonBFS
            // 
            this.radioButtonBFS.AutoSize = true;
            this.radioButtonBFS.Location = new System.Drawing.Point(95, 121);
            this.radioButtonBFS.Name = "radioButtonBFS";
            this.radioButtonBFS.Size = new System.Drawing.Size(45, 17);
            this.radioButtonBFS.TabIndex = 12;
            this.radioButtonBFS.Text = "BFS";
            this.radioButtonBFS.UseVisualStyleBackColor = true;
            this.radioButtonBFS.CheckedChanged += new System.EventHandler(this.radioButtonBFS_CheckedChanged);
            // 
            // buttonTraverse
            // 
            this.buttonTraverse.Location = new System.Drawing.Point(15, 145);
            this.buttonTraverse.Name = "buttonTraverse";
            this.buttonTraverse.Size = new System.Drawing.Size(155, 23);
            this.buttonTraverse.TabIndex = 13;
            this.buttonTraverse.Text = "Traverse";
            this.buttonTraverse.UseVisualStyleBackColor = true;
            this.buttonTraverse.Click += new System.EventHandler(this.buttonTraverse_Click);
            // 
            // BSTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 525);
            this.Controls.Add(this.buttonTraverse);
            this.Controls.Add(this.radioButtonBFS);
            this.Controls.Add(this.radioButtonPostOrder);
            this.Controls.Add(this.radioButtonInOrder);
            this.Controls.Add(this.radioButtonPreOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BSTForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSTForm - Aldrin Navarro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMaximum;
        private System.Windows.Forms.Label labelMinimum;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelPre;
        private System.Windows.Forms.Label labelSuc;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNodeHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelNodeMaximum;
        private System.Windows.Forms.Label labelNodeMinimum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonPreOrder;
        private System.Windows.Forms.RadioButton radioButtonInOrder;
        private System.Windows.Forms.RadioButton radioButtonPostOrder;
        private System.Windows.Forms.RadioButton radioButtonBFS;
        private System.Windows.Forms.Button buttonTraverse;
    }
}