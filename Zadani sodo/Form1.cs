using System;
using System.Windows.Forms;

namespace Zadani_sodo
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] niz_in_st_klikov = st_klikov.Text.Split(new string[] {": "}, StringSplitOptions.None);
            st_klikov.Text = niz_in_st_klikov[0] + ": " + (int.Parse(niz_in_st_klikov[1]) + 1);
            string[] niz_in_st_tock = st_tock.Text.Split(new string[] {": "}, StringSplitOptions.None);
            if (int.Parse(Gumb.Text) % 2 == 0)
                st_tock.Text = niz_in_st_tock[0] + ": " + (int.Parse(niz_in_st_tock[1]) + 1);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Gumb.Text = int.Parse(Gumb.Text) + 1 + "";
        }
    }
}