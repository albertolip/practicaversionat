using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void button_calcular_MouseClick(object sender, MouseEventArgs e)
        {

            listBox_valors.Items.Clear();

            try
            {
                int total = 0;
                int sumaparcials = Int32.Parse(textBox_suma.Text);

                for (int i = 1; i <= sumaparcials; i++)
                {
                    if (checkBox_resultatsparcials.Checked)
                    {
                        total += i;
                        listBox_valors.Items.Add("Sumando: " + i + " Suma Parcial: " + total);
                    }

                    else total += i;
                }
                listBox_valors.Items.Add("La suma TOTAL es: " + total);
            }
            catch
            {
                MessageBox.Show("Entra un valor numeric");
            }
        }
    }
}
