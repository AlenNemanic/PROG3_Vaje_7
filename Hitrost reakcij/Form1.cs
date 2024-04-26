using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hitrost_reakcij
{
    public partial class Form1: Form
    {
        int stevec_pravilnih = 0, stevec_vseh = 0;
        Random random = new Random();
        Color barva;
        Color[] tab_barve = new Color[] { Color.Red, Color.Green, Color.Blue};
        string ime_barve;
        string[] tab_ime_barve = new string[] {"Rdeča", "Zelena", "Modra"};

        public Form1()
        {
            InitializeComponent();
            zapis.ForeColor = tab_barve[random.Next(3)];
            zapis.Text = tab_ime_barve[random.Next(3)];
        }

        private void Odstotek()
        {
            stevec_vseh++;
            odstotek.Text = $"Odstotek pravilnih: {100 * stevec_pravilnih / stevec_vseh}%";
            zapis.ForeColor = tab_barve[random.Next(3)];
            zapis.Text = tab_ime_barve[random.Next(3)];
            timer.Enabled = false;
            timer.Enabled = true;
        }

        private bool Ali_se_ujema()
        {
            barva = zapis.ForeColor;
            ime_barve = zapis.Text;
            if (barva == Color.Red && ime_barve == "Rdeča" || barva == Color.Green && ime_barve == "Zelena" || barva == Color.Blue && ime_barve == "Modra")
                return true;
            return false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Odstotek();
        }

        private void Gumb_se_ujemata_Click(object sender, EventArgs e)
        {
            if (Ali_se_ujema())
                stevec_pravilnih++;
            Odstotek();
        }

        private void Gumb_se_ne_ujemata_Click(object sender, EventArgs e)
        {
            if (!Ali_se_ujema())
                stevec_pravilnih++;
            Odstotek();
        }
    }
}