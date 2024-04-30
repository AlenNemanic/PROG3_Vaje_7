using System;
using System.Windows.Forms;

namespace Vozeca_ploscad
{
    public partial class Form1: Form
    {
        private bool se_giblje = false;
        private bool giblje_desno = true;
        private const int PREMIK = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Gumb_Click(object sender, EventArgs e)
        {
            se_giblje = !se_giblje;
            if (se_giblje)
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
            if (giblje_desno && ploscad.Right + PREMIK < 300)
                ploscad.Left += PREMIK;
            else if (!giblje_desno && ploscad.Left - PREMIK > 10)
                ploscad.Left -= PREMIK;
            else if ((giblje_desno && ploscad.Right + PREMIK >= 300) || (!giblje_desno && ploscad.Left - PREMIK <= 10))
                giblje_desno = !giblje_desno;
        }
    }
}