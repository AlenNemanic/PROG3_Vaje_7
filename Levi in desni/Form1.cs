using System;
using System.Windows.Forms;

namespace Levi_in_desni
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Levi_MouseDown(object sender, MouseEventArgs e)
        {
            label.Text = "<- pritisnjen";
        }

        private void Levi_MouseUp(object sender, MouseEventArgs e)
        {
            label.Text = "";
        }

        private void Desno_MouseDown(object sender, MouseEventArgs e)
        {
            label.Text = "pritisnjen ->";
        }

        private void Desno_MouseUp(object sender, MouseEventArgs e)
        {
            label.Text = "";
        }
    }
}