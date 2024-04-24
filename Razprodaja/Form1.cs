using System.Windows.Forms;

namespace Razprodaja
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Izracunaj_ceno(object sender)
        {
            Button gm = (Button)sender;
            string[] napis = gm.Text.Split(' ');
            int popust = int.Parse(napis[0]);
            nova_cena.Text = (int.Parse(cena.Text) - int.Parse(cena.Text) * popust / 100) + "";
        }

        private void popust10_Click(object sender, System.EventArgs e)
        {
            Izracunaj_ceno(sender);
        }

        private void popust20_Click(object sender, System.EventArgs e)
        {
            Izracunaj_ceno(sender);
        }

        private void popust30_Click(object sender, System.EventArgs e)
        {
            Izracunaj_ceno(sender);
        }

        private void popust50_Click(object sender, System.EventArgs e)
        {
            Izracunaj_ceno(sender);
        }

        private void popust100_Click(object sender, System.EventArgs e)
        {
            Izracunaj_ceno(sender);
        }
    }
}