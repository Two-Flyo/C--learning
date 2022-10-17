using ProgressBarAndTimer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarAndTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value - 10 < progressBar1.Minimum)
            {
                progressBar1.Value = progressBar1.Minimum;
            }
            else
            {
                progressBar1.Value -= 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value + 10 > progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
            }
            else
            {
                progressBar1.Value += 10;
            }
        }



        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if(timer1.Enabled == true)
            {
                btnTimer.Image = Resources.QQ图片20221016204634;
            }
            else
            {
                btnTimer.Image = Resources.QQ图片20221016210813;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value + 5 > progressBar2.Maximum)
            {
                progressBar2.Value = progressBar2.Minimum;
            }
            else
            {
                progressBar2.Value += 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
