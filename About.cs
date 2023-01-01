using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AdamAsmaca
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void About_SizeChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 10;
            if (label1.Top < -500)
            {
                label1.Top = this.Height - 10;
            }  
        }
        private void About_Load(object sender, EventArgs e)
        {         
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
