using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button3.Visible)
            {
                button3.Visible = false;
            }
            else
            {
                button3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.Enabled)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }
    }
}
