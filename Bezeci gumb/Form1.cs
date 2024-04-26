using System;
using System.Windows.Forms;

namespace Bezeci_gumb
{
    public partial class Form1: Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            button.Top = random.Next(0, Height);
            button.Left = random.Next(0, Width);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            st_klikov.Text = int.Parse(st_klikov.Text) + 1 + "";
        }
    }
}