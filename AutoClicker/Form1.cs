namespace AutoClicker
{
    /* TODO:
     * add tooltips to options?
     */

    public partial class AutoClickerForm : Form
    {
        public AutoClickerForm()
        {
            InitializeComponent();
        }

        MouseManager? mouseManager = new MouseManager();

        private void AutoClickerForm_Load(object sender, EventArgs e)
        {
            timeBetweenClicksUpDown.Minimum = 100;
            timeBetweenClicksUpDown.Maximum = 60000;

            amountToClickUpDown.Minimum = 1;
            amountToClickUpDown.Maximum = 999999999;

            mousePositionXUpDown.Minimum = 0;
            mousePositionXUpDown.Maximum = 9999;

            mousePositionYUpDown.Minimum = 0;
            mousePositionYUpDown.Maximum = 9999;

            updateInfoLabelsTimer.Enabled = true;
            updateInfoLabelsTimer.Start();
        }

        // Click Speed
        private void timeBetweenClicksUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (mouseManager is not null)
                mouseManager.clickSpeed = (int)timeBetweenClicksUpDown.Value;
        }

        //Amount of clicks
        private void amountToClickUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (mouseManager is not null)
                mouseManager.clicksAmountToHit = (int)amountToClickUpDown.Value;
        }

        // reset total clicks stats info
        private void resetTotalClicks_Click(object sender, EventArgs e)
        {
            if (mouseManager is not null)
                mouseManager.clearTotalClicks();
        }

        // FIRE! (Play the mouse events)
        private void startAutoClickButton_Click(object sender, EventArgs e)
        {
            if (mouseManager is not null)
            {
                mouseManager.fire();
            }
        }

        private void mousePositionXUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (mouseManager is not null)
            {
                mouseManager.targetX = (int)mousePositionXUpDown.Value;
            }
        }

        private void mousePositionYUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (mouseManager is not null)
            {
                mouseManager.targetY = (int)mousePositionYUpDown.Value;
            }
        }

        private void updateInfoLabelsTimer_Tick(object sender, EventArgs e)
        {
            if (mouseManager is not null)
            {
                mouseManager.CurrentMousePosition();
                lblCurrentX.Text = "Current X: " + mouseManager.currentX;
                lblCurrentY.Text = "Current Y: " + mouseManager.currentY;
                lblLockedX.Text = "Target X: " + mouseManager.targetX;
                lblLockedY.Text = "Target Y: " + mouseManager.targetY;
                lblTimer.Text = "Running Time: " + mouseManager.activeTimer;
                lblClicks.Text = "Clicked " + mouseManager.totalClicksCountedThisSession + " times";
                lblTotalClicks.Text = "Total Session Clicks: " + mouseManager.totalClicksCounted;

                if (mouseManager.mouseActive)
                {
                    lblActive.Text = "AUTO CLICKER RUNNING";
                }
                else
                {
                    lblActive.Text = "AUTO CLICKER IDLE";
                }
            }
        }

        private void lblClickSpeedMS_Click(object sender, EventArgs e)
        {
            ttClickSpeed.Show("Time between each click done in milliseconds", lblClickSpeedMS);
        }

        private void labelClickAmount_Click(object sender, EventArgs e)
        {
            ttClickAmount.Show("Amount of clicks you would like to perform", labelClickAmount);
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
            ttTimer.Show("How long it took to complete all the clicks", lblTimer);
        }

        private void lblTotalClicks_Click(object sender, EventArgs e)
        {
            ttTotalClicks.Show("Total amount of clicks since the program started", lblTotalClicks);
        }
    }
}