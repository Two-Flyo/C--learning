using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            lblInfo.Text = String.Format(" I 'm clicked {0} times", counter);
        }
    }
}
