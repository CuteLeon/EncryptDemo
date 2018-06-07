using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EncryptDemo.Interfaces;
using EncryptDemo.Controller;
using EncryptDemo.Models;

namespace EncryptDemo
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MD5Result = string.Empty;
            MD5Controller md5Controller = new MD5Controller();
            MD5Result = md5Controller.Encypt(
                new MD5Package(Encoding.UTF8),
                textBox1.Text
            );
            textBox2.Text = MD5Result;
        }
    }
}
