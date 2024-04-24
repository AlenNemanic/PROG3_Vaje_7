using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bezeci_gumb
{
    public partial class Form1: Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.Text = "Au, boli...";
        }
    }
}