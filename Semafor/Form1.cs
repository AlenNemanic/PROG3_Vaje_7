using System;
using System.Drawing;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Spremeni_barvo_okna(Color barva)
        {
            pictureBox.BackColor = barva;
        }

        private void Rdeca_Click(object sender, EventArgs e)
        {
            Spremeni_barvo_okna(Color.Red);
        }

        private void Rumena_Click(object sender, EventArgs e)
        {
            Spremeni_barvo_okna(Color.Yellow);
        }

        private void Zelena_Click(object sender, EventArgs e)
        {
            Spremeni_barvo_okna(Color.Green);
        }
    }
}