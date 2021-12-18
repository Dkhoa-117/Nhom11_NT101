using System;
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
using System.Drawing;

namespace RSA
{
    public partial class RSACryptosystem : Form
    {
        private delegate void btnEncryptDecrypt();

        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private string KeyFolder; //Duong dan cho public va private key.
        private string KeyPath = "";
        private string PublicKeyPath = "";
        private bool isFile; //Ma hoa File hay Folder !
        private string EncryptedPath = "";
        private string DecryptedPath = "";
        bool isValidated = true;

        public RSACryptosystem()
        {
            InitializeComponent();
        }

        private void RSACryptoSystem_FormLoad(object sender, EventArgs e)
        {
            this.cbbKeyLength.Items.Add("512 bits");
            this.cbbKeyLength.Items.Add("1024 bits");
            this.cbbKeyLength.Items.Add("2048 bits");
            this.cbbKeyLength.Items.Add("4096 bits");
            this.cbbKeyLength.Items.Add("8192 bits");

            this.tbPublicKey.ReadOnly = true;
            this.tbPublicKey.BackColor = System.Drawing.SystemColors.Window;
            this.tbPrivateKey.ReadOnly = true;
            this.tbPrivateKey.BackColor = System.Drawing.SystemColors.Window;
            this.tbKeyPath.ReadOnly = true;
            this.tbKeyPath.BackColor = System.Drawing.SystemColors.Window;
            this.cbbKeyLength.Text = "512 bits";
            Control.CheckForIllegalCrossThreadCalls = false;
            this.btShowResult.Enabled = false;
        }

        private void btGenerate_Key(object sender, EventArgs e)
        {

            // Tạo file chứa key
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int KeyLength = 0;
            
            if (this.cbbKeyLength.Text == "512 bits") KeyLength = 512;
            else if (this.cbbKeyLength.Text == "1024 bits") KeyLength = 1024;
            else if (this.cbbKeyLength.Text == "2048 bits") KeyLength = 2048;
            else if (this.cbbKeyLength.Text == "4096 bits") KeyLength = 4096;
            else if (this.cbbKeyLength.Text == "8192 bits") KeyLength = 8192;

            Stopwatch SW = Stopwatch.StartNew();
            SW.Start();

            KeyFolder = fbd.SelectedPath;
            KeyPath = KeyFolder + "\\Key.xml";

            //tạo key có độ dài lengthKey
            RSA = new RSACryptoServiceProvider(KeyLength); //tạo public key va private key có độ dài lengtheKey



            File.WriteAllText(KeyPath, RSA.ToXmlString(true));  // Private Key va Public Key

            tbKeyPath.Text = KeyPath; //Hiển thị đường dẫn key


            XmlDocument xml = new XmlDocument();
            xml.LoadXml(File.ReadAllText(KeyPath)); //đọc RSA Key (public && private)    

            try
            {
                //Public Key

                RSAParameters PublicKey = RSA.ExportParameters(false); //Public Key
                var sw = new StringWriter();
                var xs = new XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, PublicKey);
                string PublicKeyXmlFile = sw.ToString(); // xuat ra file xml vao tbPublicKey 

                PublicKeyPath = KeyFolder + "\\PublicKey.xml";
                File.WriteAllText(PublicKeyPath, PublicKeyXmlFile);//Tu dong luu public key vao 1 file.
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(File.ReadAllText(PublicKeyPath)); //doc public key
                XmlNode xmlNodeE = xmlDoc.SelectSingleNode("/RSAParameters/Exponent"); //E
                XmlNode xmlNodeN = xmlDoc.SelectSingleNode("/RSAParameters/Modulus"); //N
                string StringPublicKey = xmlNodeE.InnerText + xmlNodeN.InnerText;


                byte[] bytes = Encoding.Default.GetBytes(StringPublicKey);
                string HexStringPublicKey = BitConverter.ToString(bytes);
                HexStringPublicKey = HexStringPublicKey.Replace("-", " ");
                tbPublicKey.Text = HexStringPublicKey;

                //Private Key

                XmlDocument xmlDoc_Key = new XmlDocument();
                xmlDoc_Key.LoadXml(File.ReadAllText(KeyPath));
                XmlNode xmlNodeD = xmlDoc_Key.SelectSingleNode("/RSAKeyValue/D");
                bytes = Encoding.Default.GetBytes(xmlNodeD.InnerText);
                string HexStringPrivateKey = BitConverter.ToString(bytes);
                HexStringPrivateKey = HexStringPrivateKey.Replace("-", " ");
                tbPrivateKey.Text = HexStringPrivateKey;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            SW.Stop();
            double elapsedMs = SW.Elapsed.TotalMilliseconds / 1000;
            MessageBox.Show(
                KeyLength.ToString() + " bits key generated\n" 
                + "Time to generate key: " + elapsedMs.ToString(), "SUCCESSFUL", MessageBoxButtons.OK);

        }

        private void btOpenFileKeys_Click(object sender, EventArgs e)
        {
            string KeyFile = "";
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Xml File|*.xml";
            if (op.ShowDialog() == DialogResult.OK)
            {
                KeyFile = op.FileName;
                tbKeyPath.Text = op.FileName;
            }

            if (File.Exists(KeyFile))
            {

                if (Path.GetFileName(KeyFile) == "Key.xml")
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(KeyFile));
                    try
                    {
                        KeyPath = KeyFile;
                        //PublicKeyPath = null;

                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(File.ReadAllText(KeyFile));
                        XmlNode xmlNode_1 = xmlDoc.SelectSingleNode("/RSAKeyValue/Exponent"); //e 
                        XmlNode xmlNode_2 = xmlDoc.SelectSingleNode("/RSAKeyValue/Modulus"); // n 
                        string publicKey = xmlNode_1.InnerText + xmlNode_2.InnerText;


                        byte[] bytes = Encoding.Default.GetBytes(publicKey);
                        string hexStringPublicKey = BitConverter.ToString(bytes);
                        hexStringPublicKey = hexStringPublicKey.Replace("-", " ");
                        tbPublicKey.Text = hexStringPublicKey;

                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        bytes = Encoding.Default.GetBytes(xnList.InnerText);
                        string hexStringPrivateKey = BitConverter.ToString(bytes);
                        hexStringPrivateKey = hexStringPrivateKey.Replace("-", " ");
                        tbPrivateKey.Text = hexStringPrivateKey;
                    }
                    catch
                    {
                        MessageBox.Show("Please select Key.xml NOT PublicKey.xml");
                    }
                }

                if (Path.GetFileName(KeyFile) == "PublicKey.xml")
                {
                    PublicKeyPath = KeyFile;
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(KeyFile));
                    try
                    {
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.LoadXml(File.ReadAllText(KeyFile));
                        XmlNode xmlNode_1 = xmlDoc.SelectSingleNode("/RSAParameters/Exponent"); //e 
                        XmlNode xmlNode_2 = xmlDoc.SelectSingleNode("/RSAParameters/Modulus"); // n 
                        string publicKey = xmlNode_1.InnerText + xmlNode_2.InnerText;


                        byte[] bytes = Encoding.Default.GetBytes(publicKey);
                        string hexStringPublicKey = BitConverter.ToString(bytes);
                        hexStringPublicKey = hexStringPublicKey.Replace("-", " ");
                        tbPublicKey.Text = hexStringPublicKey;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btOpenFileIn_Click(object sender, EventArgs e)
        {
            isFile = true;
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
                tbInput.Text = op.FileName;
        }

        private void btOpenFolderIn_Click(object sender, EventArgs e)
        {
            isFile = false; //Xac dinh file hay folder
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.tbInput.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btFolderOut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                this.tbOutput.Text = f1.SelectedPath;
            }
        }    

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == 0)
            {
                MessageBox.Show("Please select path to folder Output");
                return;
            }
            if (tbKeyPath.Text.Length == 0)
            {
                MessageBox.Show("Please select path to Key File!");
                return;
            }

            btnEncryptDecrypt s = new btnEncryptDecrypt(Encrypt);
            s.BeginInvoke(null, null); //ko block UI Thread 
        }

        private void Encrypt()
        {
            ChangeButtonState(false);

            if (this.PublicKeyPath.Length == 0 && this.KeyPath.Length == 0)
            {
                MessageBox.Show("Missing public key");
                ChangeButtonState(true);
                return;
            }

            try
            {
                if (this.PublicKeyPath.Length != 0 || this.KeyPath.Length != 0)
            {
                if (tbInput.Text.Length != 0)
                {

                    //Calculator time execution
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();

                    string inputFileName = tbInput.Text, outputFileName = "";


                    if (isFile)
                    {
                        outputFileName = tbOutput.Text + "\\" + Path.GetFileName(tbInput.Text) + ".nhom11";
                        EncryptedPath = outputFileName;
                    }


                    //get Keys.
                    RSA = new RSACryptoServiceProvider();
                    if (PublicKeyPath.Length != 0)
                        RSA.FromXmlString(File.ReadAllText(PublicKeyPath));
                    else
                        RSA.FromXmlString(File.ReadAllText(KeyPath));

                    if (isFile)
                    {
                        if(!RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(false), true))
                            isValidated = false; 
                    }

                    else
                    {

                        string[] filePaths = Directory.GetFiles(inputFileName, "*"); //Lay file trorng folder.

                        if (filePaths.Length == 0)
                        {
                            MessageBox.Show("Empty folder!");
                            ChangeButtonState(true);
                            return;
                        }


                        for (int i = 0; i < filePaths.Length; i++) //Ma hoa tung file.
                        {
                            outputFileName = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i]) + ".nhom11";
                            if(!RSA_Algorithm(filePaths[i], outputFileName, RSA.ExportParameters(false), true))
                                isValidated = false;

                        }
                    }


                    ChangeButtonState(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                        if (isValidated)
                        {
                            MessageBox.Show("Encrypting time: " + elapsedMs.ToString() + "s");
                            btShowResult.Enabled = true;
                        }
                    ChangeButtonState(true);
                }
                else
                {
                    ChangeButtonState(true);
                    MessageBox.Show("Not enough information to encrypt!");
                }
            }
            }
            catch (Exception ex)
            {
                ChangeButtonState(true);
                MessageBox.Show("Failed: " + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == 0)
            {
                MessageBox.Show("Please select path to folder Output");
                return;
            }
            btnEncryptDecrypt s = new btnEncryptDecrypt(Decrypt);
            s.BeginInvoke(null, null); //Ko block UI Thread
        }

        private void Decrypt()
        {
            ChangeButtonState(false);

            if (this.KeyPath.Length == 0)
            {
                MessageBox.Show("Missing private key!");
                ChangeButtonState(true);
                return;
            }

            try
            {
                if (tbInput.Text.Length != 0)
                {
                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();

                    string inputFileName = tbInput.Text, outputFileName = "";

                    if (isFile && Path.GetExtension(inputFileName) != ".nhom11")
                    {
                        MessageBox.Show("File extension is not supported!");
                        ChangeButtonState(true);
                        return;
                    }

                    if (isFile)
                    {
                        outputFileName = tbOutput.Text + "\\" + Path.GetFileName(inputFileName.Substring(0, inputFileName.Length - 7));
                        DecryptedPath = outputFileName;
                    }

                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.KeyPath));

                    if (isFile)
                    {
                        if (!RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), false))
                            isValidated = false;

                    }
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*.nhom11", SearchOption.AllDirectories);
                        if (filePaths.Length == 0)
                        {
                            MessageBox.Show("Empty folder!");
                            ChangeButtonState(true);
                            return;
                        }

                        for (int i = 0; i < filePaths.Length; i++)
                        {
                            outputFileName = tbOutput.Text + "\\" + Path.GetFileName(filePaths[i].Substring(0, filePaths[i].Length - 7));
                            if (!RSA_Algorithm(filePaths[i], outputFileName, RSA.ExportParameters(true), false))
                                isValidated = false;
                        }

                    }
                    ChangeButtonState(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    if (isValidated)
                    {
                        MessageBox.Show("Decrypting time: " + elapsedMs.ToString() + "s");
                        btShowResult.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Not enough information to decrypt!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
            ChangeButtonState(true);
        }

        private bool RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
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

                this.pgbProcess.Minimum = 0;
                this.pgbProcess.Maximum = 100;

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.ImportParameters(RSAKeyInfo); //Nhập thông tin khoá RSA (public va private)

                int maxBytesCanEncrypted;


                //RSA chỉ có thể mã hóa các khối dữ liệu ngắn hơn độ dài khóa, chia dữ liệu cho một số khối và sau đó mã hóa từng khối và sau đó hợp nhất chúng

                if (isEncrypt) // Ma hoa  //Buffer

                    maxBytesCanEncrypted = RSA.KeySize / 8 - 11; //ma hoa 245 bytes du lieu thanh 256 bytes

                else  //Giai ma
                    maxBytesCanEncrypted = RSA.KeySize / 8; //256 bytes



                //Read from the input file, then encrypt and write to the output file.


                while (rdlen < totlen) // 0  64 128 192 224 //4 1024 1 file 1024 x 4 4096
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

                    this.lbProcess.Text = "File name: " + Path.GetFileName(inputFile) + " \nSucceeded: " + ((int)(rdlen * 100) / totlen).ToString() + " %";
                    this.lbProcess.Refresh();

                    this.pgbProcess.Value = (int)((rdlen * 100) / totlen);  //thanh tiến trình
                }

                fsCiperText.Close(); //save file
                fsInput.Close();
                return true;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
            return false;
        }

        private void btCheckFile_Click(object sender, EventArgs e)
        {
            var CheckFile = new HashCheck();
            CheckFile.Show();
        }

        private void btShowResult_Click(object sender, EventArgs e)
        {
            if (!isFile)
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
            else if (isFile)
            {
                if (DecryptedPath == "") //encrypt
                {
                    try
                    {
                        System.Diagnostics.Process.Start("Notepad.exe", EncryptedPath);
                    }
                    catch (Exception ioex)
                    {
                        MessageBox.Show("Failed: " + ioex.Message);
                    }
                }

                else if (DecryptedPath != "")// decrypt
                {
                    try
                    {
                        Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = DecryptedPath;
                        prc.Start();
                    }
                    catch (Exception ioex)
                    {
                        MessageBox.Show("Failed: " + ioex.Message);
                    }
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            KeyPath = null;
            PublicKeyPath = null;

            this.isFile = true;
            this.tbKeyPath.Clear();
            this.tbInput.Clear();
            this.tbPublicKey.Clear();
            this.tbPrivateKey.Clear();

            this.btShowResult.Enabled = false;
            this.tbOutput.Clear();
            this.KeyFolder = "";
            this.cbbKeyLength.Text = "1024 bits";
            this.lbProcess.Text = "";
            this.lbProcess.Update();
            RSA = new RSACryptoServiceProvider();
            if (this.pgbProcess.Value > 0)
                this.pgbProcess.Value = 0;
        }

        private void ChangeButtonState(bool isEnable)
        {
            this.btnReset.Enabled = isEnable;
            this.btShowResult.Enabled = isEnable;
            this.tbOutput.Enabled = isEnable;
            this.btEncrypt.Enabled = isEnable;
            this.btDecrypt.Enabled = isEnable;
            this.btGenerateKey.Enabled = isEnable;
            this.btOpenFileIn.Enabled = isEnable;
            this.btOpenFileKeys.Enabled = isEnable;
            this.btOpenFolderIn.Enabled = isEnable;
            this.btFolderOut.Enabled = isEnable;
        }

        private void RSACryptoSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;    
            }
        }

        private void btShowResult_EnabledChanged(object sender, EventArgs e)
        {
            btShowResult.ForeColor = ((Button)sender).Enabled == true ? Color.White : Color.DarkGray;
            btShowResult.BackColor = ((Button)sender).Enabled == true ? Color.ForestGreen : SystemColors.ControlLight;
        }

        private void btShowResult_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            btShowResult.Text = string.Empty;
            e.Graphics.DrawString("Show Result", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }
    }
}

