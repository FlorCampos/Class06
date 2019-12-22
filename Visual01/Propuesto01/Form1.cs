using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propuesto01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){ }

        private void groupBox1_Enter(object sender, EventArgs e){ }

         private void textBox1_TextChanged_1(object sender, EventArgs e){ }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String texto = textBox1.Text.Trim(); 
                if (texto.Length > 0)
                {
                    listBox1.Items.Add(texto);
                    textBox1.Text = "";
                    label1.Text = listBox1.Items.Count.ToString(); 
                }
                else
                {
                    MessageBox.Show("Digite texto");
                }
                textBox1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
                 // actualizo el contador
                label2.Text = listBox2.Items.Count.ToString();

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                label1.Text = listBox1.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem.ToString());
                // actualizo el contador
                label1.Text = listBox1.Items.Count.ToString();

                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                label2.Text = listBox2.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {               
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);               
                label2.Text = listBox2.Items.Count.ToString();
            }

            else if (listBox1.SelectedIndex != -1)
            {                
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);               
                label1.Text = listBox1.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }
    }
}
