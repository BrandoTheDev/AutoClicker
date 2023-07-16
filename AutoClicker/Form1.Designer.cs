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
            mousePositionYUpDown = new NumericUpDown();
            mousePositionXUpDown = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            resetTotalClicks = new Button();
            amountToClickUpDown = new NumericUpDown();
            startAutoClickButton = new Button();
            timeBetweenClicksUpDown = new NumericUpDown();
            labelClickAmount = new Label();
            lblClickSpeedMS = new Label();
            updateInfoLabelsTimer = new System.Windows.Forms.Timer(components);
            ttClickSpeed = new ToolTip(components);
            ttClickAmount = new ToolTip(components);
            ttTimer = new ToolTip(components);
            ttTotalClicks = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mousePositionYUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mousePositionXUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountToClickUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeBetweenClicksUpDown).BeginInit();
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
            lblTotalClicks.Click += lblTotalClicks_Click;
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
            lblTimer.Click += lblTimer_Click;
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
            groupBox2.Controls.Add(mousePositionYUpDown);
            groupBox2.Controls.Add(mousePositionXUpDown);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(resetTotalClicks);
            groupBox2.Controls.Add(amountToClickUpDown);
            groupBox2.Controls.Add(startAutoClickButton);
            groupBox2.Controls.Add(timeBetweenClicksUpDown);
            groupBox2.Controls.Add(labelClickAmount);
            groupBox2.Controls.Add(lblClickSpeedMS);
            groupBox2.Location = new Point(224, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options";
            // 
            // mousePositionYUpDown
            // 
            mousePositionYUpDown.Location = new Point(113, 69);
            mousePositionYUpDown.Name = "mousePositionYUpDown";
            mousePositionYUpDown.Size = new Size(72, 23);
            mousePositionYUpDown.TabIndex = 4;
            mousePositionYUpDown.ValueChanged += mousePositionYUpDown_ValueChanged;
            // 
            // mousePositionXUpDown
            // 
            mousePositionXUpDown.Location = new Point(18, 69);
            mousePositionXUpDown.Name = "mousePositionXUpDown";
            mousePositionXUpDown.Size = new Size(60, 23);
            mousePositionXUpDown.TabIndex = 3;
            mousePositionXUpDown.ValueChanged += mousePositionXUpDown_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(93, 71);
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
            // resetTotalClicks
            // 
            resetTotalClicks.Location = new Point(6, 96);
            resetTotalClicks.Name = "resetTotalClicks";
            resetTotalClicks.Size = new Size(179, 23);
            resetTotalClicks.TabIndex = 5;
            resetTotalClicks.Text = "Clear Total Clicks";
            resetTotalClicks.UseVisualStyleBackColor = true;
            resetTotalClicks.Click += resetTotalClicks_Click;
            // 
            // amountToClickUpDown
            // 
            amountToClickUpDown.Location = new Point(113, 42);
            amountToClickUpDown.Name = "amountToClickUpDown";
            amountToClickUpDown.Size = new Size(72, 23);
            amountToClickUpDown.TabIndex = 2;
            amountToClickUpDown.ValueChanged += amountToClickUpDown_ValueChanged;
            // 
            // startAutoClickButton
            // 
            startAutoClickButton.Location = new Point(6, 119);
            startAutoClickButton.Name = "startAutoClickButton";
            startAutoClickButton.Size = new Size(179, 44);
            startAutoClickButton.TabIndex = 6;
            startAutoClickButton.Text = "FIRE!";
            startAutoClickButton.UseVisualStyleBackColor = true;
            startAutoClickButton.Click += startAutoClickButton_Click;
            // 
            // timeBetweenClicksUpDown
            // 
            timeBetweenClicksUpDown.Location = new Point(113, 17);
            timeBetweenClicksUpDown.Name = "timeBetweenClicksUpDown";
            timeBetweenClicksUpDown.Size = new Size(72, 23);
            timeBetweenClicksUpDown.TabIndex = 1;
            timeBetweenClicksUpDown.ValueChanged += timeBetweenClicksUpDown_ValueChanged;
            // 
            // labelClickAmount
            // 
            labelClickAmount.AutoSize = true;
            labelClickAmount.Location = new Point(6, 44);
            labelClickAmount.Name = "labelClickAmount";
            labelClickAmount.Size = new Size(80, 15);
            labelClickAmount.TabIndex = 1;
            labelClickAmount.Text = "Click Amount";
            labelClickAmount.Click += labelClickAmount_Click;
            // 
            // lblClickSpeedMS
            // 
            lblClickSpeedMS.AutoSize = true;
            lblClickSpeedMS.Location = new Point(6, 19);
            lblClickSpeedMS.Name = "lblClickSpeedMS";
            lblClickSpeedMS.Size = new Size(92, 15);
            lblClickSpeedMS.TabIndex = 0;
            lblClickSpeedMS.Text = "Click Speed(ms)";
            lblClickSpeedMS.Click += lblClickSpeedMS_Click;
            // 
            // updateInfoLabelsTimer
            // 
            updateInfoLabelsTimer.Tick += updateInfoLabelsTimer_Tick;
            // 
            // AutoClickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(432, 189);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AutoClickerForm";
            Text = "Auto Clicker";
            Load += AutoClickerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mousePositionYUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)mousePositionXUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountToClickUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeBetweenClicksUpDown).EndInit();
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
        private Label lblClickSpeedMS;
        private Label lblLockedY;
        private Label lblLockedX;
        private Label labelClickAmount;
        private Button resetTotalClicks;
        private NumericUpDown amountToClickUpDown;
        private NumericUpDown timeBetweenClicksUpDown;
        private Button startAutoClickButton;
        private Label label12;
        private Label label11;
        private NumericUpDown mousePositionYUpDown;
        private NumericUpDown mousePositionXUpDown;
        private System.Windows.Forms.Timer updateInfoLabelsTimer;
        private ToolTip ttClickSpeed;
        private ToolTip ttClickAmount;
        private ToolTip ttTimer;
        private ToolTip ttTotalClicks;
    }
}