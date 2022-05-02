using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseMon
{
    public partial class MainForm : Form
    {
        const int tickDurationms = 100;
        const int ticksPerSecond = (1000 / tickDurationms);
        const int progressBarSpeedUpms = 500;

        bool currentlyRunning = false;
        int ticks = 0;
        Random RNG = new Random();

        private int ticksPerMove
        {
            get
            {
                return trackBarMoveDelay.Value * ticksPerSecond;
            }
        }

        private int progressBarMax
        {
            get
            {
                // Intentionally make it a little low so it looks nice
                return (int)(ticksPerMove - (progressBarSpeedUpms/tickDurationms));
            }
        }

        public MainForm()
        {
            InitializeComponent();

            this.Height = 190;

            labelSlideMin.Text = trackBarMoveDelay.Minimum.ToString();
            labelSlideMax.Text = trackBarMoveDelay.Maximum.ToString();

            numericInputDelay.Minimum = trackBarMoveDelay.Minimum;
            numericInputDelay.Maximum = trackBarMoveDelay.Maximum;
            numericInputDelay.Value = trackBarMoveDelay.Value;

            trackBarMoveDelay.ValueChanged += trackBarMoveDelay_ValueChanged;

            progressBarMove.Value = 0;
            progressBarMove.Step = 1;

            timerMoveMouse.Enabled = false;
            timerMoveMouse.Interval = tickDurationms;

            groupBoxCover.Location = groupBoxControls.Location;
        }

        /// <summary>
        /// Moves the mouse to a random point on the screen
        /// </summary>
        private void MoveMe()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width / 2;
            int y = Screen.PrimaryScreen.WorkingArea.Height / 2;

            x = RNG.Next(0, x);
            y = RNG.Next(0, y);

            Win32.POINT p = new Win32.POINT();

            p.x = x;
            p.y = y;

            Win32.ClientToScreen(this.Handle, ref p);
            Win32.SetCursorPos(p.x, p.y);
        }

        /// <summary>
        /// Tells the thread to be in a certain state
        /// See: https://docs.microsoft.com/en-us/windows/win32/api/winbase/nf-winbase-setthreadexecutionstate
        /// </summary>
        /// <param name="flags">Per the documentation</param>
        private void setThreadExecutionState(Win32.EXECUTION_STATE flags)
        {
            Win32.SetThreadExecutionState(flags);
        }

        /// <summary>
        /// Class to hold unmanaged functions
        /// 
        /// </summary>
        public class Win32
        {
            [DllImport("User32.Dll")]
            public static extern long SetCursorPos(int x, int y);

            [DllImport("User32.Dll")]
            public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;
            }

            [FlagsAttribute]
            public enum EXECUTION_STATE : uint
            {
                ES_AWAYMODE_REQUIRED = 0x00000040,
                ES_CONTINUOUS = 0x80000000,
                ES_DISPLAY_REQUIRED = 0x00000002,
                ES_SYSTEM_REQUIRED = 0x00000001
                // Legacy flag, should not be used.
                // ES_USER_PRESENT = 0x00000004
            }
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (currentlyRunning)
            {
                progressBarMove.Value = 0;
                labelStatus.Text = "Paused";
                buttonStartStop.Text = "Start";
                buttonStartStop.BackColor = Color.Green;
                currentlyRunning = false;

                //Idle
                setThreadExecutionState(Win32.EXECUTION_STATE.ES_CONTINUOUS);

                timerMoveMouse.Enabled = false;
            }
            else
            {
                ticks = 0;
                progressBarMove.Maximum = progressBarMax;
                labelStatus.Text = "Running...";
                buttonStartStop.Text = "Stop";
                buttonStartStop.BackColor = Color.Red;
                currentlyRunning = true;
                
                //Don't let the computer go to sleep
                setThreadExecutionState(Win32.EXECUTION_STATE.ES_CONTINUOUS | Win32.EXECUTION_STATE.ES_SYSTEM_REQUIRED | Win32.EXECUTION_STATE.ES_DISPLAY_REQUIRED);

                timerMoveMouse.Enabled = true;
            }
        }

        private void timerMoveMouse_Tick(object sender, EventArgs e)
        {
            ticks++;

            // If we waited long enough move and reset
            if (ticks >= ticksPerMove)
            {
                ticks = 0;

                if (!checkBoxDisableMouse.Checked)
                {
                    MoveMe();
                }

                labelDebug.Text = "Tick!";
                progressBarMove.Value = 0;

                if (checkBoxRandom.Checked)
                {
                    int i = RNG.Next(trackBarMoveDelay.Minimum, trackBarMoveDelay.Maximum+1);
                    trackBarMoveDelay.Value = i;
                }

                // This can get out of sync between events if the user messes with the slider
                // but it is easier to just sync up each time vs. constantly
                progressBarMove.Maximum = progressBarMax;
            }
            // Increment the progress bar
            else
            {
                progressBarMove.PerformStep();

                if (labelDebug.Text != "." && ticks >= ticksPerSecond / 2)
                {
                    labelDebug.Text = ".";
                }
            }

            // If this window is open do something cool
            if (groupBoxCover.Visible)
            {
                labelCover.Text += (char)RNG.Next(32, 127);

                if (labelCover.Text.Length > 500)
                {
                    labelCover.Text = string.Empty;
                }
            }
        }

        private void numericInputTime_ValueChanged(object sender, EventArgs e)
        {
            numericInputDelay.Value = (int)numericInputDelay.Value;
            trackBarMoveDelay.Value = (int)numericInputDelay.Value;
        }

        private void trackBarMoveDelay_ValueChanged(object sender, EventArgs e)
        {
            numericInputDelay.Value = trackBarMoveDelay.Value;
        }

        private void toolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            toolStripMenuItemHide.Checked = !toolStripMenuItemHide.Checked;

            if (toolStripMenuItemHide.Checked)
            {
                groupBoxControls.Visible = false;
                groupBoxCover.Visible = true;
            }
            else
            {
                groupBoxControls.Visible = true;
                groupBoxCover.Visible = false;
            }
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            timerMoveMouse.Enabled = false;
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open a help menu
        }
    }
}
