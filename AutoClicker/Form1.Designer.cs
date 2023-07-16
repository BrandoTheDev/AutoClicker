namespace AutoClicker
{
    partial class AutoClickerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            lblLockedY = new Label();
            lblLockedX = new Label();
            lblTotalClicks = new Label();
            lblClicks = new Label();
            lblActive = new Label();
            lblTimer = new Label();
            lblCurrentY = new Label();
            lblCurrentX = new Label();
            groupBox2 = new GroupBox();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            button4 = new Button();
            numericUpDown2 = new NumericUpDown();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblLockedY);
            groupBox1.Controls.Add(lblLockedX);
            groupBox1.Controls.Add(lblTotalClicks);
            groupBox1.Controls.Add(lblClicks);
            groupBox1.Controls.Add(lblActive);
            groupBox1.Controls.Add(lblTimer);
            groupBox1.Controls.Add(lblCurrentY);
            groupBox1.Controls.Add(lblCurrentX);
            groupBox1.Location = new Point(7, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mouse Data";
            // 
            // lblLockedY
            // 
            lblLockedY.AutoSize = true;
            lblLockedY.Location = new Point(102, 44);
            lblLockedY.Name = "lblLockedY";
            lblLockedY.Size = new Size(58, 15);
            lblLockedY.TabIndex = 8;
            lblLockedY.Text = "Locked Y:";
            // 
            // lblLockedX
            // 
            lblLockedX.AutoSize = true;
            lblLockedX.Location = new Point(6, 44);
            lblLockedX.Name = "lblLockedX";
            lblLockedX.Size = new Size(58, 15);
            lblLockedX.TabIndex = 7;
            lblLockedX.Text = "Locked X:";
            // 
            // lblTotalClicks
            // 
            lblTotalClicks.AutoSize = true;
            lblTotalClicks.Location = new Point(6, 144);
            lblTotalClicks.Name = "lblTotalClicks";
            lblTotalClicks.Size = new Size(69, 15);
            lblTotalClicks.TabIndex = 6;
            lblTotalClicks.Text = "Total Clicks:";
            // 
            // lblClicks
            // 
            lblClicks.AutoSize = true;
            lblClicks.Location = new Point(6, 119);
            lblClicks.Name = "lblClicks";
            lblClicks.Size = new Size(41, 15);
            lblClicks.TabIndex = 5;
            lblClicks.Text = "Clicks:";
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(6, 94);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(46, 15);
            lblActive.TabIndex = 4;
            lblActive.Text = "Active: ";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(6, 69);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(43, 15);
            lblTimer.TabIndex = 2;
            lblTimer.Text = "Timer: ";
            // 
            // lblCurrentY
            // 
            lblCurrentY.AutoSize = true;
            lblCurrentY.Location = new Point(102, 19);
            lblCurrentY.Name = "lblCurrentY";
            lblCurrentY.Size = new Size(60, 15);
            lblCurrentY.TabIndex = 3;
            lblCurrentY.Text = "Current Y:";
            // 
            // lblCurrentX
            // 
            lblCurrentX.AutoSize = true;
            lblCurrentX.Location = new Point(6, 19);
            lblCurrentX.Name = "lblCurrentX";
            lblCurrentX.Size = new Size(60, 15);
            lblCurrentX.TabIndex = 2;
            lblCurrentX.Text = "Current X:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown4);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(224, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(112, 69);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(73, 23);
            numericUpDown4.TabIndex = 11;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(26, 69);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(60, 23);
            numericUpDown3.TabIndex = 10;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(92, 71);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 9;
            label12.Text = "Y";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 71);
            label11.Name = "label11";
            label11.Size = new Size(14, 15);
            label11.TabIndex = 8;
            label11.Text = "X";
            // 
            // button4
            // 
            button4.Location = new Point(6, 96);
            button4.Name = "button4";
            button4.Size = new Size(179, 23);
            button4.TabIndex = 7;
            button4.Text = "Clear Total Clicks";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(92, 42);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(93, 23);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(6, 119);
            button3.Name = "button3";
            button3.Size = new Size(179, 44);
            button3.TabIndex = 4;
            button3.Text = "FIRE!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(92, 17);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 44);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 1;
            label8.Text = "Click Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 0;
            label7.Text = "Click Speed";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // AutoClickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(432, 189);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AutoClickerForm";
            Text = "Auto Clicker";
            Load += AutoClickerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblCurrentX;
        private Label lblTimer;
        private Label lblCurrentY;
        private Label lblActive;
        private Label lblTotalClicks;
        private Label lblClicks;
        private Label label7;
        private Label lblLockedY;
        private Label lblLockedX;
        private Label label8;
        private Button button4;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Label label12;
        private Label label11;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private System.Windows.Forms.Timer timer1;
    }
}