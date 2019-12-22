using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1; // this representa al formulario-útil al hacer enter
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = textBox1.Text.Trim(); //Toma lo que hay en la caja de texto y limpia los espacios en blanco
            if (texto.Length > 0)
            {
                listBox1.Items.Add(texto);//Need 1---item es una colección
                textBox1.Text = "";
                label1.Text = listBox1.Items.Count.ToString(); //Need 2--actualizo el contador y lo convierto a string
            }
            else
            {
                MessageBox.Show("Digite texto");
            }
            textBox1.Focus(); //el cursor se coloca sobre el textbox 1 para seguir digitando
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                //Selected index -- si devuelve -1 : significa que no hay ninguno seleccionado
                //Need 3 ---RemoveAt --elimina el elemento que está seleccionado
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); 
                label1.Text = listBox1.Items.Count.ToString(); // actualizo el contador
                
}
            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = listBox1.SelectedItem.ToString();// need 4 --- más importante
                // hasta el selecteditem develve un objeto y luego lo convierto a string
            }
            else
            {
                MessageBox.Show("Seleccione elemento de Lista");
            }
        }
    }
}
