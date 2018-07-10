namespace SimpleCalculator
{
    partial class frmCalculator
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
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulitply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqrRoot = new System.Windows.Forms.Button();
            this.btnByTwo = new System.Windows.Forms.Button();
            this.btnByFour = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 57);
            this.txtInput.MaxLength = 30;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(286, 35);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "0";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(27, 258);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(47, 34);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(79, 258);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(47, 34);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(132, 258);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(47, 34);
            this.btnThree.TabIndex = 3;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(26, 218);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(47, 34);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(79, 218);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(47, 34);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(132, 218);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(47, 34);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(26, 178);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(47, 34);
            this.btnSeven.TabIndex = 7;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(79, 178);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(47, 34);
            this.btnEight.TabIndex = 8;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(132, 178);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(47, 34);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(26, 298);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(100, 34);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(132, 298);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(47, 34);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(237, 258);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(47, 74);
            this.btnEqual.TabIndex = 12;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(184, 298);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(47, 34);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(185, 258);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(47, 34);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulitply
            // 
            this.btnMulitply.Location = new System.Drawing.Point(185, 218);
            this.btnMulitply.Name = "btnMulitply";
            this.btnMulitply.Size = new System.Drawing.Size(47, 34);
            this.btnMulitply.TabIndex = 15;
            this.btnMulitply.Text = "*";
            this.btnMulitply.UseVisualStyleBackColor = true;
            this.btnMulitply.Click += new System.EventHandler(this.btnMulitply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(184, 178);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(47, 34);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(132, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 34);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSqrRoot
            // 
            this.btnSqrRoot.Location = new System.Drawing.Point(237, 138);
            this.btnSqrRoot.Name = "btnSqrRoot";
            this.btnSqrRoot.Size = new System.Drawing.Size(47, 34);
            this.btnSqrRoot.TabIndex = 18;
            this.btnSqrRoot.Text = "√";
            this.btnSqrRoot.UseVisualStyleBackColor = true;
            this.btnSqrRoot.Click += new System.EventHandler(this.btnSqrRoot_Click);
            // 
            // btnByTwo
            // 
            this.btnByTwo.Location = new System.Drawing.Point(237, 218);
            this.btnByTwo.Name = "btnByTwo";
            this.btnByTwo.Size = new System.Drawing.Size(47, 34);
            this.btnByTwo.TabIndex = 19;
            this.btnByTwo.Text = "1/x";
            this.btnByTwo.UseVisualStyleBackColor = true;
            this.btnByTwo.Click += new System.EventHandler(this.btnByTwo_Click);
            // 
            // btnByFour
            // 
            this.btnByFour.Location = new System.Drawing.Point(237, 178);
            this.btnByFour.Name = "btnByFour";
            this.btnByFour.Size = new System.Drawing.Size(47, 34);
            this.btnByFour.TabIndex = 20;
            this.btnByFour.Text = "%";
            this.btnByFour.UseVisualStyleBackColor = true;
            this.btnByFour.Click += new System.EventHandler(this.btnByFour_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 34);
            this.button4.TabIndex = 25;
            this.button4.Text = "±";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(237, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 34);
            this.button5.TabIndex = 26;
            this.button5.Text = "M-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 34);
            this.button6.TabIndex = 27;
            this.button6.Text = "M+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(132, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 34);
            this.button7.TabIndex = 28;
            this.button7.Text = "MS";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(79, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 34);
            this.button8.TabIndex = 29;
            this.button8.Text = "MR";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "© Copyright Gonzalo Alfonso Perogil";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.edicionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(36, 20);
            this.toolStripMenuItem2.Text = "Ver";
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 355);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnByFour);
            this.Controls.Add(this.btnByTwo);
            this.Controls.Add(this.btnSqrRoot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMulitply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculator";
            this.Text = "CalculadoraPRO";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculator_KeyPress);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulitply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSqrRoot;
        private System.Windows.Forms.Button btnByTwo;
        private System.Windows.Forms.Button btnByFour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

