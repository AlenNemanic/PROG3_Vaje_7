using System;
using System.Drawing;
using System.Windows.Forms;

namespace Izmenjava_barv
{
    public partial class Form1: Form
    {
        bool aktivno = true;
        Random random = new Random();
        int ind_barve;
        Color barva;
        Color[] barve = new Color[] { Color.Orange, Color.Purple, Color.Green};
        Label[] stevci;
        Label stevec;

        public Form1()
        {
            InitializeComponent();
            stevci = new Label[] {stevec_oranzna, stevec_vijolicna, stevec_zelena};
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ind_barve = random.Next(3);
            barva = barve[ind_barve];
            stevec = stevci[ind_barve];
            string[] niz_in_st_klikov = stevec.Text.Split(new string[] {": "}, StringSplitOptions.None);
            stevec.Text = niz_in_st_klikov[0] + ": " + (int.Parse(niz_in_st_klikov[1]) + 1);
            pictureBox.BackColor = barva;
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
    }
}