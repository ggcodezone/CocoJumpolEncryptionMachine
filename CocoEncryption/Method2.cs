﻿using System;
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
    public partial class Method2 : Form
    {
        public Method2()
        {
            InitializeComponent();
        }

        string hash = "Requ!emC0C0Jumb0";
        private void EncryptButton_Click(object sender, EventArgs e) //encrypts text
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(textenter.Text);
            using(MD5CryptoServiceProvider md5= new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes= new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textencrypt.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e) //decrypts text
        {
            byte[] data = Convert.FromBase64String(textencrypt.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textdecrypt.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
