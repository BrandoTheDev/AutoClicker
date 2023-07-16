namespace AutoClicker
{
    public partial class AutoClickerForm : Form
    {
        public AutoClickerForm()
        {
            InitializeComponent();
        }

        MouseManager? mouseManager = new MouseManager();

        private void AutoClickerForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 100;
            numericUpDown1.Maximum = 60000;

            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = 999999999;

            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 9999;

            numericUpDown4.Minimum = 0;
            numericUpDown4.Maximum = 9999;

            timer1.Enabled = true;
            timer1.Start();
        }

        // Click Speed
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (mouseManager is not null)
                mouseManager.clickSpeed = (int)numericUpDown1.Value;
        }

        //Amount of clicks
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (mouseManager is not null)
                mouseManager.clicksAmountToHit = (int)numericUpDown2.Value;
        }

        // reset total clicks stats info
        private void button4_Click(object sender, EventArgs e)
        {
            if (mouseManager is not null)
                mouseManager.clearTotalClicks();
        }

        // Lock Mouse Position
        private void button1_Click(object sender, EventArgs e)
        {
            if (mouseManager is not null)
            {
                mouseManager.targetX = mouseManager.currentX;
            }
        }

        // FIRE! (Play the mouse events)
        private void button3_Click(object sender, EventArgs e)
        {
            if (mouseManager is not null)
            {
                mouseManager.fire();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (mouseManager is not null)
            {
                mouseManager.targetX = (int)numericUpDown3.Value;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (mouseManager is not null)
            {
                mouseManager.targetY = (int)numericUpDown4.Value;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(mouseManager is not null)
            {
                mouseManager.CurrentMousePosition();
                lblCurrentX.Text = "Current X: " + mouseManager.currentX;
                lblCurrentY.Text = "Current Y: " + mouseManager.currentY;
                lblLockedX.Text = "Locked X: " + mouseManager.targetX;
                lblLockedY.Text = "Locked Y: " + mouseManager.targetY;
                lblTimer.Text = "Uptime: " + mouseManager.activeTimer;
                lblClicks.Text = "Session Clicks: " + mouseManager.totalClicksCountedThisSession;
                lblTotalClicks.Text = "Total Clicks: " + mouseManager.totalClicksCounted;

                if (mouseManager.mouseActive) 
                    { lblActive.Text = "AUTO CLICK ENABLED"; } 
                else 
                    { lblActive.Text = "AUTO CLICK DISABLED"; }
            }
        }
    }
}