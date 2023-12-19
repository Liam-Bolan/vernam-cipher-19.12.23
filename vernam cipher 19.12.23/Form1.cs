using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vernam_cipher_19._12._23
{
    public partial class Form1 : Form
    {
        int pos = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int k = int.Parse(textBox3.Text);
                char keypressed = e.KeyChar;
                int keycode = (int)keypressed;
                int EncryptedCode = keycode + k;
                char encryptedchar = (char)EncryptedCode;
                textBox2.Text = textBox2.Text + encryptedchar.ToString();    
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int result = e.KeyChar ^ textBox3.Text[pos];
                textBox2.Text += (char)result;
                pos = (pos + 1) % textBox3.Text.Length;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
