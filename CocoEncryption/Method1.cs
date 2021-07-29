using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CocoEncryption
{
    public partial class Method1 : Form
    {
        public Method1()
        {
            InitializeComponent();
        }

        static string Encrypt (string value) //the encryption driver code
        {
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        private void encryptButton_Click(object sender, EventArgs e)
        {
            //will provide error message if button is clicked but no text entered by user

            if (string.IsNullOrEmpty(textreg.Text))
            {
                MessageBox.Show("Please enter some text to be encrypted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            textnew.Text = Encrypt(textreg.Text);
        }
    }
}
