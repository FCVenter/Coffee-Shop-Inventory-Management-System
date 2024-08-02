using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Venter_FC_42468000_Motara_Yaaseen_40925846_Assignment_1
{
    public class ControlAnimation
    {
        private Control control;
        private Color targetColor;
        private int animationProgress;
        private Timer timer;

        public ControlAnimation(Control control, int timerInterval = 20)
        {
            this.control = control;
            this.animationProgress = 0;
            this.timer = new Timer();
            this.timer.Interval = timerInterval;
            this.timer.Tick += Timer_Tick;
        }

        public void AnimateToColor(Color color)
        {
            this.targetColor = color;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int redDifference = targetColor.R - control.BackColor.R;
            int greenDifference = targetColor.G - control.BackColor.G;
            int blueDifference = targetColor.B - control.BackColor.B;

            control.BackColor = Color.FromArgb(
                control.BackColor.R + redDifference / (10 - animationProgress),
                control.BackColor.G + greenDifference / (10 - animationProgress),
                control.BackColor.B + blueDifference / (10 - animationProgress));

            animationProgress++;

            if (animationProgress > 9)
            {
                timer.Stop();
                animationProgress = 0;
            }
        }
    }

}
