using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace AutoClicker
{
    internal class MouseManager
    {
        internal bool mouseActive { get; set; } = false;
        internal int totalClicksCounted { get; set; } = 0;
        internal int totalClicksCountedThisSession { get; set; } = 0;
        internal int clickSpeed { get; set; } = 0;
        internal int clicksAmountToHit { get; set; } = 0;

        internal int targetX { get; set; } = 0;
        internal int targetY { get; set; } = 0;

        internal int currentX { get; set; } = 0;
        internal int currentY { get; set; } = 0;

        internal TimeSpan activeTimer { get; set; } = TimeSpan.Zero;

        private InputSimulator inputSimulator = new InputSimulator();


        internal void CurrentMousePosition()
        {
            currentX = Cursor.Position.X;
            currentY = Cursor.Position.Y;
        }

        internal void fire()
        {
            // Reset this session before starting
            totalClicksCountedThisSession = 0;
            mouseActive = true;

            // Start our timer
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            for(int i = 0; i < clicksAmountToHit; i++)
            {
                Cursor.Position = new Point(targetX, targetY);
                inputSimulator.Mouse.LeftButtonClick();
                inputSimulator.Mouse.Sleep(clickSpeed);
                totalClicksCounted++;
                totalClicksCountedThisSession++;
            }
            mouseActive = false;
            stopwatch.Stop();
            activeTimer = stopwatch.Elapsed;
        }

        internal void clearTotalClicks()
        {
            totalClicksCounted = 0;
        }

    }
}
