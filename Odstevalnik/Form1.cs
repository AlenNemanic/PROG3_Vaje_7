using System;
using System.Windows.Forms;

namespace Odstevalnik
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            Gumb_ponastavi.Click -= Gumb_ponastavi_Click;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (int.Parse(stevilo.Text) > 0)
                stevilo.Text = int.Parse(stevilo.Text) - 1 + "";
            if (int.Parse(stevilo.Text) == 0)
            {
                Gumb_zacni.Click -= Gumb_zacni_Click;
                timer.Enabled = false;
            }
        }

        private void Gumb_ponastavi_Click(object sender, EventArgs e)
        {
            stevilo.Text = "9";
            Gumb_zacni.Click += Gumb_zacni_Click;
        }

        private void Gumb_ustavi_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Gumb_ponastavi.Click += Gumb_ponastavi_Click;
        }

        private void Gumb_zacni_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            Gumb_ponastavi.Click -= Gumb_ponastavi_Click;
        }
    }
}