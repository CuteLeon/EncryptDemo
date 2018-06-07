using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using EncryptDemo.Controller;

namespace EncryptDemo
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = new HashAlgorithmController<MD5CryptoServiceProvider>().Encypt(
                Encoding.UTF8,
                textBox1.Text
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = new SymmetricAlgorithmController<DESCryptoServiceProvider>().Encypt(
                "IamLeon.",
                "Mathilda",
                textBox1.Text
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = new SymmetricAlgorithmController<DESCryptoServiceProvider>().Decypt(
                "IamLeon.",
                "Mathilda",
                textBox2.Text
            );
        }
    }
}
