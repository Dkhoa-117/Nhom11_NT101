﻿using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Security;
using System.Xml;
using System.Security.Cryptography; 
//using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Text;

namespace RSA1710900
{
    public partial class RSACryptosystem : Form
    {
        private delegate void btnEncryptDecrypt();

        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private string pathKeysXML;
        private bool isFile; //Ma hoa File hay Folder !


        public RSACryptosystem()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxLengKey.Items.Add("512 bits");
            this.comboBoxLengKey.Items.Add("1024 bits");
            this.comboBoxLengKey.Items.Add("2048 bits");
            this.comboBoxLengKey.Items.Add("4096 bits");
            this.comboBoxLengKey.Items.Add("8192 bits");
            this.tbN.Enabled = false;
            this.tbD.Enabled = false;
            this.tbE.Enabled = false;
            lbl_md5.Enabled = false;
            lbl_sha1.Enabled = false;
            lbl_sha256.Enabled = false;
            this.comboBoxLengKey.Text = "1024 bits";
            Control.CheckForIllegalCrossThreadCalls = false; //dang suy ngam
        }

        private void enabledOrDisableButtons(bool isEnable)
        {
            this.btnReset.Enabled = isEnable;
            this.btnOutOpen.Enabled = isEnable;
            this.tbOutput.Enabled = isEnable;
            this.btnEncrypt.Enabled = isEnable;
            this.btnDecrypt.Enabled = isEnable;
            this.btnGenerateKey.Enabled = isEnable;
            this.btnOpenFileIn.Enabled = isEnable;
            this.btnOpenFileKeys.Enabled = isEnable;
            this.btnOpenFolderIn.Enabled = isEnable;
            this.selectOutput.Enabled = isEnable;
        }


        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            
            // Tạo file chứa key
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "Xml File|*.xml|All File|*.*";
            saveFileDialog1.Title = "Chọn tên file";
            //saveFileDialog1.InitialDirectory = "";

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            
            int lengthKey = 0;

            if (this.comboBoxLengKey.Text == "1024 bits") lengthKey = 1024;
            else if (this.comboBoxLengKey.Text == "512 bits") lengthKey = 512;
            else if (this.comboBoxLengKey.Text == "2048 bits") lengthKey = 2048;
            else if (this.comboBoxLengKey.Text == "4096 bits") lengthKey = 4096;
            else if (this.comboBoxLengKey.Text == "8192 bits") lengthKey = 8192;

            //saveFileDialog1.RestoreDirectory = false;
            String pathPrivateKey = saveFileDialog1.FileName;
           

            //tạo key có độ dài lengthKey
            RSA = new RSACryptoServiceProvider(lengthKey); //tạo public key va private key có độ dài lengtheKey

                             
            File.WriteAllText(pathPrivateKey, RSA.ToXmlString(true));  // Private Key

            pathKeysXML = pathPrivateKey;
            tbPathKeys.Text = pathPrivateKey; //Hiển thị đường dẫn key

            if (File.Exists(pathKeysXML))
            {
                if (Path.GetExtension(pathKeysXML) == ".xml") //kiểm tra định dạng
                {
                    XmlDocument xml = new XmlDocument();
                        xml.LoadXml(File.ReadAllText(pathKeysXML)); //đọc RSA Key (public && private)

                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus"); //n
                        tbN.Text = xnList.InnerText;    
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent"); // e
                        tbE.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        tbD.Text = xnList.InnerText;
                        tbN.Enabled = true;
                        tbE.Enabled = true;
                        tbD.Enabled = true;


                       
                        
                        RSAParameters _publicKey = RSA.ExportParameters(false);
                        var sw = new StringWriter();
                        var xs = new XmlSerializer(typeof(RSAParameters));
                        xs.Serialize(sw, _publicKey);
                        string XmlFileOfPublicKey = sw.ToString(); // xuat ra file xml vao tbPublicKey 


                        string pathPublicKey = "C:\\Users\\Admin\\Downloads\\pathPublicKey.xml"; //Can than :))))
                        File.WriteAllText(pathPublicKey, XmlFileOfPublicKey);
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(File.ReadAllText(pathPublicKey)); //doc public key
                        XmlNode xmlNode_1 = xmlDoc.SelectSingleNode("/RSAParameters/Exponent"); //e 
                        XmlNode xmlNode_2 = xmlDoc.SelectSingleNode("/RSAParameters/Modulus"); // n 
                        string publicKey = xmlNode_1.InnerText + xmlNode_2.InnerText;

                        byte[] bytes = Encoding.Default.GetBytes(publicKey);
                        string hexStringPublicKey = BitConverter.ToString(bytes);
                        hexStringPublicKey = hexStringPublicKey.Replace("-", " ");
                        tbPublicKey.Text = hexStringPublicKey;

                        bytes = Encoding.Default.GetBytes(xnList.InnerText);
                        string hexStringPrivateKey = BitConverter.ToString(bytes);
                        hexStringPrivateKey = hexStringPrivateKey.Replace("-", " ");
                        tbPrivateKey.Text = hexStringPrivateKey;
                    }
                    catch (Exception ix)
                    {
                        MessageBox.Show(ix.Message);
                    }
                }
            }
            MessageBox.Show("Tạo key có độ dài " + lengthKey.ToString() + " bits thành công.");

        }

        private void btnOpenFileKeys_Click(object sender, EventArgs e)
        {
            this.tbD.Clear(); this.tbE.Clear(); this.tbN.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pathKeysXML = op.FileName;
                tbPathKeys.Text = op.FileName;
            }

            if (File.Exists(pathKeysXML))
            {

                if (Path.GetExtension(pathKeysXML) == ".xml")
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeysXML));
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        tbN.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        tbE.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        tbD.Text = xnList.InnerText;
                        tbN.Enabled = true;
                        tbE.Enabled = true;
                        tbD.Enabled = true;

                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed: " + ex.Message);
                    }
                }
            }
        }

        private void btnOpenFileIn_Click(object sender, EventArgs e)
        {           
            isFile = true;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                tbInput.Text = op.FileName;
        }

        private void btnOutOpen_Click(object sender, EventArgs e) //Mở thư mục Output
        {
            if (tbOutput.Text.Length > 0)
            {
                try
                {
                    Process prc = new System.Diagnostics.Process(); 
                    prc.StartInfo.FileName = tbOutput.Text;
                    prc.Start();
                }
                catch (Exception ioex)
                {
                    MessageBox.Show("Failed: " + ioex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đường dẫn !");
            }
        }

        private void RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
        {
            try
            {
                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read); //Đọc file input
                FileStream fsCiperText = new FileStream(outputFile, FileMode.Create, FileAccess.Write); //Tạo file output
                //fsCiperText.SetLength(0); 
                byte[] bin, encryptedData;
                long rdlen = 0; //readlength
                long totlen = fsInput.Length; // totallength
                int len;

                this.progressBar1.Minimum = 0;
                this.progressBar1.Maximum = 100;

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(); 
                RSA.ImportParameters(RSAKeyInfo); //Nhập thông tin khoá RSA (public va private)

                int maxBytesCanEncrypted;

                
                //RSA chỉ có thể mã hóa các khối dữ liệu ngắn hơn độ dài khóa, chia dữ liệu cho một số khối và sau đó mã hóa từng khối và sau đó hợp nhất chúng
                
                if (isEncrypt) // Ma hoa  //Buffer
                        
                    maxBytesCanEncrypted = RSA.KeySize / 8 - 11; //ma hoa 245 bytes du lieu thanh 256 bytes
                
                else  //Giai ma
                    maxBytesCanEncrypted = RSA.KeySize / 8 ; //256 bytes



                //Read from the input file, then encrypt and write to the output file.
                

                while (rdlen < totlen) // 0  64 128 192 224 
                {
                    if (totlen - rdlen < maxBytesCanEncrypted) 
                        maxBytesCanEncrypted = (int)(totlen - rdlen); //Block cuoi: totlen - rdlen < (RSA.KeySize - 384) / 8) + 37

                    bin = new byte[maxBytesCanEncrypted];
                    len = fsInput.Read(bin, 0, maxBytesCanEncrypted); // o maxbyte -1

                    if (isEncrypt) 
                        encryptedData = RSA.Encrypt(bin, false); //Mã Hoá false = ko dem OAEP
                    else 
                        encryptedData = RSA.Decrypt(bin, false); //Giải mã false = ko dem OAEP
                    //
                    fsCiperText.Write(encryptedData, 0, encryptedData.Length);

                    rdlen = rdlen + len; //trong truong hop block cuoi co the thieu byte! (ko thi + bin.Length !)

                    this.label1f.Text = "Tên tệp xử lý : " + Path.GetFileName(inputFile) + "\n Thành công: " + ((long)(rdlen * 100) / totlen).ToString() + " %";
                    this.label1f.Update();
                    this.label1f.Refresh();

                    this.progressBar1.Value = (int)((rdlen * 100) / totlen);  //thanh tiến trình
                }
                

                fsCiperText.Close(); //save file
                fsInput.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }

        }


        private void btnEncryptClick()
        {
            enabledOrDisableButtons(false);

            if (this.tbPathKeys.Text.Length == 0 || this.tbN.Text.Length == 0 || this.tbD.Text.Length == 0 || this.tbE.Text.Length == 0)
            {                                               // N                       //D                         //E
                MessageBox.Show("Key không hợp lệ!");
                enabledOrDisableButtons(true);
                return;
            }

            try
            {
                if (tbInput.Text.Length != 0 /*&&
                tbPathKeys.Text.Length != 0 &&
                tbN.Text.Length != 0 */ )
                {

                    //Calculator time execution
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();

                    string inputFileName = tbInput.Text, outputFileName = "";
                    

                    if (isFile)
                    {
                        outputFileName = tbOutput.Text +"\\"+ Path.GetFileName(tbInput.Text) + ".nhom11";
                    }


                    //get Keys.
                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.pathKeysXML));


                    if (isFile)
                    {
                        RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), true);
                    }

                    else
                    {

                        string[] filePaths = Directory.GetFiles(inputFileName, "*"); //Lay file trorng folder.

                        if (filePaths.Length == 0 /*|| (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db"))*/)
                        {
                            MessageBox.Show("Thư mục rỗng!");
                            enabledOrDisableButtons(true);
                            return;
                        }


                        for (int i = 0; i < filePaths.Length; i++) //Ma hoa tung file.
                        {
                            outputFileName = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i]) + ".nhom11";
                            //if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                            RSA_Algorithm(filePaths[i], outputFileName, RSA.ExportParameters(true), true);
                            //SaveFile(outputFileName, Encrypt(inputFileName));

                        }
                    }


                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Thời gian thực thi " + elapsedMs.ToString() + "s");


                }
                else
                {
                    enabledOrDisableButtons(true);
                    MessageBox.Show("Dữ liệu không đủ để mã hóa!"); // Ko co du 1 trong 3: N, D, E
                }
            }
            catch (Exception ex)
            {
                enabledOrDisableButtons(true);
                MessageBox.Show("Failed: " + ex.Message);
            }

            enabledOrDisableButtons(true);


        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output");
                return;
            }
            if (tbPathKeys.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến Key!");
                return;
            }

            btnEncryptDecrypt s = new btnEncryptDecrypt(btnEncryptClick);
            s.BeginInvoke(null, null); //ko block UI Thread 

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbl_md5.Enabled = false;
            lbl_sha1.Enabled = false;
            lbl_sha256.Enabled = false;
            this.isFile = true;
            this.tbPathKeys.Clear();
            this.tbInput.Clear();
            this.tbN.Clear();
            this.tbD.Clear();
            this.tbE.Clear();
            tbN.Enabled = false;
            tbE.Enabled = false;
            tbD.Enabled = false;
            txt_input.Clear();
            lbl_md5.Clear();
            lbl_sha1.Clear();
            lbl_sha256.Clear();

            this.tbOutput.Clear();
            this.pathKeysXML = "";
            this.comboBoxLengKey.Text = "1024 bits";
            this.label1f.Text = "";
            this.label1f.Update();
            RSA = new RSACryptoServiceProvider();
            if (this.progressBar1.Value > 0)
                this.progressBar1.Value = 0;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output");
                return;
            }
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnDecryptClick);
            s.BeginInvoke(null, null); //Ko block UI Thread

        }
        private void btnDecryptClick()
        {
            enabledOrDisableButtons(false);

            try
            {
                if (tbInput.Text.Length != 0 &&
                   tbPathKeys.Text.Length != 0 &&
                   tbN.Text.Length != 0)
                {
                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();

                    string inputFileName = tbInput.Text, outputFileName = "";

                    if (isFile && Path.GetExtension(inputFileName) != ".nhom11")
                    {
                        MessageBox.Show("Tệp tin này không được hỗ trợ đển giải mã!");
                        enabledOrDisableButtons(true);
                        return;
                    }

                    if (isFile)
                    {

                        outputFileName = tbOutput.Text + "\\" + Path.GetFileName(inputFileName.Substring(0, inputFileName.Length - 7));


                    }

                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.pathKeysXML));

                    if (isFile)
                        RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), false);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*.nhom11", SearchOption.AllDirectories);
                        if (filePaths.Length == 0 || (filePaths.Length == 1))
                        {
                            MessageBox.Show("Thư mục rỗng!");
                            enabledOrDisableButtons(true);
                            return;
                        }

                        for (int i = 0; i < filePaths.Length; i++)
                        { 
                            outputFileName = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i].Substring(0, filePaths[i].Length - 7));
                            RSA_Algorithm(filePaths[i], outputFileName, RSA.ExportParameters(true), false);
                        }

                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Tổng thời gian thực thi: " + elapsedMs.ToString() + "s");
                }
                else
                {
                    MessageBox.Show("Không đủ điều kiện để giải mã !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
            enabledOrDisableButtons(true);
        }

  
        private void btnOpenFolderIn_Click(object sender, EventArgs e)
        {
            isFile = false; //Xac dinh file hay folder
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.tbInput.Text = folderBrowserDialog1.SelectedPath;
        }

        public static string MD5(string path)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

        public static string SHA1(string path)
        {
            using (var cryptoProvider = new SHA1CryptoServiceProvider())
            {
                var stream = File.OpenRead(path);
                string hash = BitConverter
                    .ToString(cryptoProvider.ComputeHash(stream)).Replace("-", "");
                return hash.ToLower();
            }
        }

        public static string SHA256(string path)
        {
            using (FileStream stream = File.OpenRead(path))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] hash = sha.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        private void btn_checksum_Click(object sender, EventArgs e)
        {
            lbl_md5.Text = MD5(txt_input.Text);
            lbl_sha1.Text = SHA1(txt_input.Text);
            lbl_sha256.Text = SHA256(txt_input.Text);
            lbl_md5.Enabled = true;
            lbl_sha1.Enabled = true;
            lbl_sha256.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Xml File|*.xml|All File|*.*";
            saveFileDialog1.Title = "Save an Xml File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
            }    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                this.tbOutput.Text = f1.SelectedPath;
            }    
        }

      
    }
    
}
