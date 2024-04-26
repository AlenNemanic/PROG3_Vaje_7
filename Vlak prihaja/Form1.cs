using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vlak_prihaja
{
    public partial class Form1: Form
    {
        bool leva_je_rdeca = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void zacni_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            desna_luc.BackColor = Color.Red;
        }

        private void ustavi_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            leva_je_rdeca = false;
            leva_luc.BackColor = Color.White;
            desna_luc.BackColor = Color.White;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (leva_je_rdeca)
            {
                leva_luc.BackColor = Color.Red;
                desna_luc.BackColor = Color.White;
            }
            else
            {
                leva_luc.BackColor = Color.White;
                desna_luc.BackColor = Color.Red;
            }
            leva_je_rdeca = !leva_je_rdeca;
        }
    }
}