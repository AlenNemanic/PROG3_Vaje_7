using System;
using System.Windows.Forms;

namespace Casovnik
{
    public partial class Form1: Form
    {
        private bool aktivno = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Gumb_Click(object sender, EventArgs e)
        {
            aktivno = !aktivno;
            if (aktivno)
            {
                Gumb.Text = "Ustavi";
                timer.Enabled = true;
            }
            else
            {
                Gumb.Text = "Začni";
                timer.Enabled = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string[] cas_in_niz = cas.Text.Split(' ');
            cas.Text = double.Parse(cas_in_niz[0]) + 0.1 + " s";
        }
    }
}