using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A01.WFA_01_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();//关闭文件
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value >=progressBar1.Maximum)
            {
                timer1.Enabled = false;
            }
            else
            {
                progressBar1.Value += 1;
            }
        }
    }
}
