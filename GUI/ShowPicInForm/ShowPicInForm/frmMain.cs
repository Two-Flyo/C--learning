using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowPicInForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            LoadPicture();
        }
        private void LoadPicture()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog1.FileName);
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("User canceled.");
            }
        }
    }
}
