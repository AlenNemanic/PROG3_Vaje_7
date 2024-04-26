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
            st_klikov.Text = int.Parse(st_klikov.Text) + 1 + "";
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