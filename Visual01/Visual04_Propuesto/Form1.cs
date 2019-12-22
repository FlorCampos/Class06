using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual04_Propuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                label1.Text = listBox1.Items.Count.ToString();
                label5.Text = " ";
            }

           else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                label5.Text = listBox1.SelectedItem.ToString();
                
            }
            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 9; i <= 999; ++i)
            {
                comboBox1.Items.Add("" + i); //no permite agregar números                
            }

            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String texto = textBox2.Text.Trim(); //Toma lo que hay en la caja de texto y limpia los espacios en blanco
            String textoDeCombo = comboBox1.Text;
            if (texto.Length > 0 && comboBox1.SelectedIndex > 0)
            {
                listBox2.Items.Add(texto);//Need 1---item es una colección
                textBox2.Text = "";
                label3.Text = listBox2.Items.Count.ToString(); //Need 2--actualizo el contador y lo convierto a string

                listBox3.Items.Add(textoDeCombo);

                int sumaValoresListBox3 = 0;

                foreach(object item in listBox3.Items)
                {
                    sumaValoresListBox3 += Convert.ToInt32(item);
                }

                int minutos, segundos;

                minutos = sumaValoresListBox3 / 60;
                segundos = sumaValoresListBox3 % 60;
                //label4.Text = sumaValoresListBox3.ToString();
                label4.Text = minutos.ToString() +"'" + " : " + segundos.ToString() + "''";
            }
            else
            {
                MessageBox.Show("Digite el nombre del tema y seleccione cantidad de segundos");
            }

            comboBox1.SelectedIndex = 0;
            textBox2.Focus(); //el cursor se coloca sobre el textbox 1 para seguir digitando
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                label3.Text = listBox2.Items.Count.ToString();

                listBox3.Items.RemoveAt(listBox3.SelectedIndex);              

                int sumaValoresListBox3 = 0;

                foreach (object item in listBox3.Items)
                {
                    sumaValoresListBox3 += Convert.ToInt32(item);
                }

                int minutos, segundos;

                minutos = sumaValoresListBox3 / 60;
                segundos = sumaValoresListBox3 % 60;
                //label4.Text = sumaValoresListBox3.ToString();
                label4.Text = minutos.ToString() + "'" + " : " + segundos.ToString() + "''";

            }

            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox3.SetSelected(listBox2.SelectedIndex, true);
                
            }

            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }

          
        }

        private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                listBox2.SetSelected(listBox3.SelectedIndex, true);
            }
            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

            }

            else
            {
                MessageBox.Show("Seleccione elemento de Lista de CD's");
            }
        }
    }
}
