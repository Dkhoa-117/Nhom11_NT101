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
using System.IO;

namespace RSA
{
    public partial class HashCheck : Form
    {
        public HashCheck()
        {
            InitializeComponent();
        }

        private void HashCheck_Load(object sender, EventArgs e)
        {
            txtMD5.ReadOnly = true;
            txtSHA1.ReadOnly = true;
            txtSHA256.ReadOnly = true;
            txtMD5.BackColor = System.Drawing.SystemColors.Window;
            txtSHA1.BackColor = System.Drawing.SystemColors.Window;
            txtSHA256.BackColor = System.Drawing.SystemColors.Window;
            txtInput.Clear();
        }

        private void btCheckSum_Click(object sender, EventArgs e)
        {
            txtMD5.Text = MD5(txtInput.Text);
            txtSHA1.Text = SHA1(txtInput.Text);
            txtSHA256.Text = SHA256(txtInput.Text);
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = dialog.FileName;
                }
            }
        }

        public static string MD5(string path)
        {
            try
            {
                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    using (var stream = File.OpenRead(path))
                    {
                        return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

        public static string SHA1(string path)
        {
            try
            {
                using (var cryptoProvider = new SHA1CryptoServiceProvider())
                {
                    var stream = File.OpenRead(path);
                    string hash = BitConverter
                        .ToString(cryptoProvider.ComputeHash(stream)).Replace("-", "");
                    return hash.ToLower();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

        public static string SHA256(string path)
        {
            try
            {
                using (FileStream stream = File.OpenRead(path))
                {
                    SHA256Managed sha = new SHA256Managed();
                    byte[] hash = sha.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", String.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtInput.Text = null;
            txtMD5.Text = null;
            txtSHA1.Text = null;
            txtSHA256.Text = null;
        }
    }
}
