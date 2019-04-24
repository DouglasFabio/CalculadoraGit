using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float N1 = float.Parse(txtN1.Text);
            float N2 = float.Parse(txtN2.Text);
            float R = 0;

            switch (comboBoxOperador.Text)
            {
                case "Adição":
                    R = N1 + N2;
                    break;

                case "Subtração":
                    R = N1 - N2;
                    break;

                case "Multiplicação":
                    R = N1 * N2;
                    break;

                case "Divisão":
                    R = N1 / N2;
                    break;
            }
            MessageBox.Show(R.ToString());
        }
    }
}
