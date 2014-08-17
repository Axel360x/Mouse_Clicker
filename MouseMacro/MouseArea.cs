using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseMacro
{
    public partial class MouseArea : Form
    {
        public MouseArea()
        {
            InitializeComponent();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //ShowInTaskbar = false;
            TopMost = true;
            Opacity = 0.1f;
            DesktopLocation = new Point(0, 0);
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;

            base.OnLoad(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MainWindow.tGetMousePosition.Abort();
                Close();
            }
            base.OnMouseClick(e);
        }
    }
}
