using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual03_Propuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // private void textBox2_VisibleChanged(object sender, EventArgs e) { }
        //private void textBox3_VisibleChanged(object sender, EventArgs e) { }
        //private void radioButton1_CheckedChanged(object sender, EventArgs e){ }
        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Visible = false;
                checkBox3.Enabled = true;
                checkBox4.Enabled = false;
                checkBox4.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox2.Visible == true)
                textBox2.Visible = false;
            
            if (textBox3.Visible == true)
                textBox3.Visible = false;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox3.Visible = false;
                checkBox4.Enabled = true;
                checkBox3.Enabled = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                textBox3.Clear();
            }
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox2.Visible = true;
                
            }
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.Visible = false;
                textBox2.Clear();
            }
        }

        private void checkBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Visible = true;
                
            }

            else
            {
                textBox3.Visible = false;
                textBox3.Clear();
            }
        }
    }
}
