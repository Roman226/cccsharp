using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(800, 600);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new Size(1024, 720);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = 0; Screen.PrimaryScreen.WorkingArea.X != Screen.PrimaryScreen.WorkingArea.Width && Screen.PrimaryScreen.WorkingArea.Y != Screen.PrimaryScreen.WorkingArea.Height; i += 3, ++j, this.Location = new Point(i, j), Thread.Sleep(100)) ;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
