using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void button_suma_MouseClick(object sender, MouseEventArgs e)
        {

            int a = 0;
            int b = 0;

            a = int.Parse(textBox_valor1.Text);
            b = int.Parse(textBox_valor2.Text);

            textBox_resultat.Text = (a + b).ToString();
        }

        private void button_resta_MouseClick(object sender, MouseEventArgs e)
        {
            int a = 0;
            int b = 0;

            a = int.Parse(textBox_valor1.Text);
            b = int.Parse(textBox_valor2.Text);

            textBox_resultat.Text = (a - b).ToString();

        }

        private void button_divisio_MouseClick(object sender, MouseEventArgs e)
        {
            int a = 0;
            int b = 0;

            a = int.Parse(textBox_valor1.Text);
            b = int.Parse(textBox_valor2.Text);

            textBox_resultat.Text = (a / b).ToString();
        }

        private void button_multiplicacio_MouseClick(object sender, MouseEventArgs e)
        {
            int a = 0;
            int b = 0;

            a = int.Parse(textBox_valor1.Text);
            b = int.Parse(textBox_valor2.Text);

            textBox_resultat.Text = (a * b).ToString();
        }

        private void button_neteja_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_valor1.Clear();
            textBox_valor2.Clear();
            textBox_resultat.Clear();
        }
    }
}
