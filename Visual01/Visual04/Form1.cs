using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Poblando los 3 combos
            for (int i = 0; i <= 20; ++i)
            {
                comboBox1.Items.Add("" + i); //no permite agregar números
                comboBox2.Items.Add("" + i);
                comboBox3.Items.Add("" + i);
            }

            //selecciona elemento cuyo texto es el que se brinda
            comboBox1.SelectedIndex = 14;
            comboBox2.SelectedItem = "14";
            comboBox3.SelectedIndex = 14;
        }
    }
}
