using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void button_ingresar_MouseClick(object sender, MouseEventArgs e)
        {

            string text1 = textBox_login.Text;
            string text2 = textBox_password.Text;

            if (textBox_login.Text == "Alberto" && textBox_password.Text == "123")
            {
                MessageBox.Show("Benvingut al sistema :D");
            }
            else MessageBox.Show("Error Dades Incorrectes");
        }

        private void button_salir_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();     
                
        }
    }
}
