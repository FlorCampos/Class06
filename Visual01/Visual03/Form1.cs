using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = "Marcados: ";
            if (checkBox1.Checked)
            {
                msg += checkBox1.Text + ", ";
            }
            if (checkBox2.Checked)
            {
                msg += checkBox2.Text + ", ";
            }
            if (checkBox3.Checked)
            {
                msg += checkBox3.Text + ", ";
            }
            if (checkBox4.Checked)
            {
                msg += checkBox4.Text + ", ";
            }
            if (msg.Length > 10)
            {
                msg = msg.Substring(0, msg.Length - 2); 
                //porque sería menos la coma y el espacio en blanco
                //El cero es la posición inicial
            }
            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String msg = "Marcado: ";
            if (radioButton1.Checked)
            {
                msg += radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                msg += radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                msg += radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                msg += radioButton4.Text;
            }
            MessageBox.Show(msg);
        }
    }
}
