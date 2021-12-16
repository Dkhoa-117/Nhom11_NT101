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

        private void KiemTraFile_Load(object sender, EventArgs e)
        {
            txt_md5.ReadOnly = true;
            txt_sha1.ReadOnly = true;
            txt_sha256.ReadOnly = true;
            txt_md5.BackColor = System.Drawing.SystemColors.Window;
            txt_sha1.BackColor = System.Drawing.SystemColors.Window;
            txt_sha256.BackColor = System.Drawing.SystemColors.Window;
            txt_input.Clear();
        }

        private void btn_checksum_Click(object sender, EventArgs e)
        {
            txt_md5.Text = MD5(txt_input.Text);
            txt_sha1.Text = SHA1(txt_input.Text);
            txt_sha256.Text = SHA256(txt_input.Text);
        }

        private void btn_chonfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txt_input.Text = dialog.FileName;
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


    }
}
