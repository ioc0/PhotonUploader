using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotonUploader
{
    public partial class Form1 : Form
    {
        private string pathName;
        
        public Form1()
        {
            InitializeComponent();
            Youtube ytb = new Youtube();
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathName = ofd.FileName;
                txtBoxPath.Text = pathName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Youtube ytb = new Youtube();
            try
            {
                ytb.UploadVideo(pathName, txtBoxLogin.Text, txtBoxPassw.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }
    }
}
