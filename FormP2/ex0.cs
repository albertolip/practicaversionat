using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormP2
{
    /// <summary>
    /// Exercici 0 de la practica Form2 a
    /// </summary>
    public partial class ex0 : Form
    {
        public ex0()
        {
            InitializeComponent();
        }

        private void button_suma_MouseClick(object sender, MouseEventArgs e)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = int.Parse(textBox_valor1.Text);
                b = int.Parse(textBox_valor2.Text);
            }
            catch 
            {
                MessageBox.Show("Entra un valor numeric");
                
            }
            textBox_resultat.Text = (a + b).ToString();
        }
    }
}
