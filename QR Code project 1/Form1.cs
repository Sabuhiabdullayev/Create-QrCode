using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;



namespace QR_Code_project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder qrns = new QRCodeEncoder();
            pictureBox1.Image = qrns.Encode(textBox1.Text);
            label2.Visible = true;
             
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
