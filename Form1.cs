using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace greenpass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String qr = "MEQCIGn2DSyLKmhRF9sxgqQCUcFEG1rJdMURimpqK20Xqb02AiBA2d8k87dLQ3yHMPK0gfu0pj37BngOVgF6lgWVkL79mw==#{id:01/IL/91C13A97FB33A7B6EABFBC08AFF20C77#A7E8F3CC,et:3,ct:4,c:IL MOHEC_FAST,g:";
            String x = "https://api.qrserver.com/v1/create-qr-code/?data=" + qr  + ",f:"  + ",idl:" + ",idp:null" + ",b:"  + ",e:" + textBox2.Text + "T18:12:48Z" + ",a:" + textBox3.Text + "T18:12:48Z/";
            pictureBox1.ImageLocation = x+"";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
            label3.Text = textBox3.Text;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}

