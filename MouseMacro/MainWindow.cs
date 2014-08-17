using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Timers;

namespace MouseMacro
{
    public partial class MainWindow : Form
    {
        public static Thread tGetMousePosition;
        public MainWindow()
        {
            InitializeComponent();
        }

        int MouseX = -1;
        int MouseY = -1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick(uint X, uint Y)
        {
            Cursor.Position = new Point((int)X, (int)Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
        }

        protected void GetMousePosition()
        {
            while (true)
            {
                MethodInvoker mi = delegate() {

                    MouseX = Cursor.Position.X;
                    MouseY = Cursor.Position.Y;
                    this.mouseX_label.Text = "Mouse X: " + MouseX.ToString();
                    this.mouseY_label.Text = "Mouse Y: " + MouseY.ToString();

                };
                this.Invoke(mi); 
            }
        }


        private void CaptureMouse(object sender, EventArgs e)
        {
            tGetMousePosition = new Thread(new ThreadStart(GetMousePosition));
            tGetMousePosition.Start();
            Form airForm = new MouseArea();
            airForm.ShowDialog();
        }
        Thread thClicking;

        private void StartClicker(object sender, MouseEventArgs e)
        {
            if (MouseX != -1 && MouseY != -1)
            {
                thClicking = new Thread(new ThreadStart(Clicking));
                thClicking.Start();
            }
        }
        System.Timers.Timer aTimer;

        protected void Clicking()
        {
            MethodInvoker mi = delegate()
            {
                aTimer = new System.Timers.Timer(Convert.ToInt32(IntervalTextBox.Text));
                aTimer.Elapsed += new ElapsedEventHandler(Timing);
                aTimer.Enabled = true;
            };
            this.Invoke(mi);
            
        }
        int i = 0;
        protected void Timing(object source, ElapsedEventArgs e)
        { 
            
            DoMouseClick((uint)MouseX, (uint)MouseY);
            i++;
            if (i >= Convert.ToInt32(CountsTextBox.Text))
            {
                i = 0;
                aTimer.Enabled = false;
                thClicking.Abort();
            }
        }


        private void FormClosed1(object sender, FormClosedEventArgs e)
        {
            if (tGetMousePosition is Thread)
                tGetMousePosition.Abort();
            if (thClicking is Thread)
                thClicking.Abort();
        }

    }
}
