using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void button_calcular_MouseClick(object sender, MouseEventArgs e)
        {
            int total = 0;


            if (radioButton_boto1.Checked)
            {
                total += 50;
            }
           

            if (radioButton_boto2.Checked)
            {
                total += 100;
            }
            

            if (radioButton_boto3.Checked)
            {
                total += 150;
            }
           

            if (checkBox_email.Checked)
            {
                total += 5;
            }
     

            if (checkBox_telefono.Checked)
            {
                total += 15;
            }

            if (checkBox_fax.Checked)
            {
                total += 20;
            }

            MessageBox.Show("El total de gastos de envio son: " + total + "€");



        }
    }
}
