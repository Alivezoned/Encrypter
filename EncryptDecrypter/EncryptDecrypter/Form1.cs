using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            String text = textBox_encrypt.Text;
            Cryptography c = new Cryptography();
            String output = c.encrypt(text);
            textBox_decrypt.Text = output;
            
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            String text = textBox_decrypt.Text;
            Cryptography c = new Cryptography();
            String output = c.decrypt(text);
            textBox_encrypt.Text = output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailTest mt = new MailTest();
            mt.ShowDialog();
        }
    }
}
