using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeSkin(object sender, EventArgs e)
        {
            var bt = sender as Button;
            bt.BackColor = Color.Aqua;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            var bt = sender as Button;
            bt.BackColor = Color.LightGray;
        }
    }
}
