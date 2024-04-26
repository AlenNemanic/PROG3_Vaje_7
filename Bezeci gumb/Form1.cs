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

        private void Klik()
        {
            string[] niz_in_st_klikov = stevec_klikov.Text.Split(new string[] {": "}, StringSplitOptions.None);
            stevec_klikov.Text = niz_in_st_klikov[0] + ": " + (int.Parse(niz_in_st_klikov[1]) + 1);
        }

        private void button_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            Klik();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            button.Top = random.Next(0, Height);
            button.Left = random.Next(0, Width);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           Klik();
        }

        private void stevec_klikov_Click(object sender, EventArgs e)
        {
            Klik();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Klik();
        }
    }
}