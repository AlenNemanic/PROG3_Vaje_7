using System;
using System.Windows.Forms;

namespace Stevec_klikov
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Povecaj_st_klikov()
        {
            string[] niz_in_st_klikov = stevec_klikov.Text.Split(new string[] {": "}, StringSplitOptions.None);
            stevec_klikov.Text = niz_in_st_klikov[0] + ": " + (int.Parse(niz_in_st_klikov[1]) + 1);
        }

        private void stevec_klikov_Click(object sender, EventArgs e)
        {
            Povecaj_st_klikov();
        }

        private void st_klikov_Click(object sender, EventArgs e)
        {
            Povecaj_st_klikov();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Povecaj_st_klikov();
        }
    }
}