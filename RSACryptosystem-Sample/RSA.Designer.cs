﻿namespace RSA
{
    partial class RSACryptosystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSACryptosystem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbKeyLength = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btGenerateKey = new System.Windows.Forms.Button();
            this.btOpenFileKeys = new System.Windows.Forms.Button();
            this.tbKeyPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbProcess = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCheckFile = new System.Windows.Forms.Button();
            this.btFolderOut = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btOpenFolderIn = new System.Windows.Forms.Button();
            this.pgbProcess = new System.Windows.Forms.ProgressBar();
            this.btShowResult = new System.Windows.Forms.Button();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btOpenFileIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.tbPrivateKey);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbPublicKey);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbbKeyLength);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btGenerateKey);
            this.panel1.Controls.Add(this.btOpenFileKeys);
            this.panel1.Controls.Add(this.tbKeyPath);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 469);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(481, 184);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 110);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrivateKey.ForeColor = System.Drawing.Color.Black;
            this.tbPrivateKey.Location = new System.Drawing.Point(145, 353);
            this.tbPrivateKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.Size = new System.Drawing.Size(447, 26);
            this.tbPrivateKey.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label13.Location = new System.Drawing.Point(240, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 28);
            this.label13.TabIndex = 10;
            this.label13.Text = "Generate Key";
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPublicKey.ForeColor = System.Drawing.Color.Black;
            this.tbPublicKey.Location = new System.Drawing.Point(145, 307);
            this.tbPublicKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(447, 26);
            this.tbPublicKey.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(24, 355);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 24);
            this.label16.TabIndex = 12;
            this.label16.Text = "Private Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Key File (XML)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(24, 309);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 24);
            this.label15.TabIndex = 11;
            this.label15.Text = "Public Key ";
            // 
            // cbbKeyLength
            // 
            this.cbbKeyLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKeyLength.ForeColor = System.Drawing.Color.Black;
            this.cbbKeyLength.FormattingEnabled = true;
            this.cbbKeyLength.Location = new System.Drawing.Point(145, 76);
            this.cbbKeyLength.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKeyLength.Name = "cbbKeyLength";
            this.cbbKeyLength.Size = new System.Drawing.Size(160, 30);
            this.cbbKeyLength.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Key Length";
            // 
            // btGenerateKey
            // 
            this.btGenerateKey.BackColor = System.Drawing.Color.ForestGreen;
            this.btGenerateKey.FlatAppearance.BorderSize = 0;
            this.btGenerateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGenerateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerateKey.ForeColor = System.Drawing.Color.FloralWhite;
            this.btGenerateKey.Location = new System.Drawing.Point(313, 74);
            this.btGenerateKey.Margin = new System.Windows.Forms.Padding(4);
            this.btGenerateKey.Name = "btGenerateKey";
            this.btGenerateKey.Size = new System.Drawing.Size(171, 35);
            this.btGenerateKey.TabIndex = 3;
            this.btGenerateKey.Text = "Generate";
            this.btGenerateKey.UseVisualStyleBackColor = false;
            this.btGenerateKey.Click += new System.EventHandler(this.btGenerate_Key);
            // 
            // btOpenFileKeys
            // 
            this.btOpenFileKeys.BackColor = System.Drawing.Color.ForestGreen;
            this.btOpenFileKeys.FlatAppearance.BorderSize = 0;
            this.btOpenFileKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenFileKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFileKeys.ForeColor = System.Drawing.Color.FloralWhite;
            this.btOpenFileKeys.Location = new System.Drawing.Point(513, 143);
            this.btOpenFileKeys.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenFileKeys.Name = "btOpenFileKeys";
            this.btOpenFileKeys.Size = new System.Drawing.Size(108, 35);
            this.btOpenFileKeys.TabIndex = 2;
            this.btOpenFileKeys.Text = "Open";
            this.btOpenFileKeys.UseVisualStyleBackColor = false;
            this.btOpenFileKeys.Click += new System.EventHandler(this.btOpenFileKeys_Click);
            // 
            // tbKeyPath
            // 
            this.tbKeyPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeyPath.ForeColor = System.Drawing.Color.Black;
            this.tbKeyPath.Location = new System.Drawing.Point(145, 146);
            this.tbKeyPath.Margin = new System.Windows.Forms.Padding(4);
            this.tbKeyPath.Name = "tbKeyPath";
            this.tbKeyPath.Size = new System.Drawing.Size(360, 28);
            this.tbKeyPath.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(240, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Key Infomation";
            // 
            // lbProcess
            // 
            this.lbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcess.Location = new System.Drawing.Point(23, 309);
            this.lbProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(587, 70);
            this.lbProcess.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btCheckFile);
            this.panel2.Controls.Add(this.btFolderOut);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btOpenFolderIn);
            this.panel2.Controls.Add(this.pgbProcess);
            this.panel2.Controls.Add(this.lbProcess);
            this.panel2.Controls.Add(this.btShowResult);
            this.panel2.Controls.Add(this.btDecrypt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btEncrypt);
            this.panel2.Controls.Add(this.tbOutput);
            this.panel2.Controls.Add(this.tbInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btOpenFileIn);
            this.panel2.Location = new System.Drawing.Point(670, 101);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 469);
            this.panel2.TabIndex = 1;
            // 
            // btCheckFile
            // 
            this.btCheckFile.BackColor = System.Drawing.Color.ForestGreen;
            this.btCheckFile.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btCheckFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckFile.ForeColor = System.Drawing.Color.White;
            this.btCheckFile.Location = new System.Drawing.Point(43, 396);
            this.btCheckFile.Name = "btCheckFile";
            this.btCheckFile.Size = new System.Drawing.Size(268, 44);
            this.btCheckFile.TabIndex = 16;
            this.btCheckFile.Text = "Check Hash Value";
            this.btCheckFile.UseVisualStyleBackColor = false;
            this.btCheckFile.Click += new System.EventHandler(this.btCheckFile_Click);
            // 
            // btFolderOut
            // 
            this.btFolderOut.BackColor = System.Drawing.Color.ForestGreen;
            this.btFolderOut.FlatAppearance.BorderSize = 0;
            this.btFolderOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFolderOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFolderOut.ForeColor = System.Drawing.Color.FloralWhite;
            this.btFolderOut.Location = new System.Drawing.Point(472, 143);
            this.btFolderOut.Margin = new System.Windows.Forms.Padding(4);
            this.btFolderOut.Name = "btFolderOut";
            this.btFolderOut.Size = new System.Drawing.Size(129, 28);
            this.btFolderOut.TabIndex = 15;
            this.btFolderOut.Text = "Select Folder";
            this.btFolderOut.UseVisualStyleBackColor = false;
            this.btFolderOut.Click += new System.EventHandler(this.btFolderOut_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label14.Location = new System.Drawing.Point(214, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 28);
            this.label14.TabIndex = 14;
            this.label14.Text = "Encrypt and Decrypt";
            // 
            // btOpenFolderIn
            // 
            this.btOpenFolderIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btOpenFolderIn.FlatAppearance.BorderSize = 0;
            this.btOpenFolderIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenFolderIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFolderIn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btOpenFolderIn.Location = new System.Drawing.Point(472, 90);
            this.btOpenFolderIn.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenFolderIn.Name = "btOpenFolderIn";
            this.btOpenFolderIn.Size = new System.Drawing.Size(129, 28);
            this.btOpenFolderIn.TabIndex = 12;
            this.btOpenFolderIn.Text = "Select Folder";
            this.btOpenFolderIn.UseVisualStyleBackColor = false;
            this.btOpenFolderIn.Click += new System.EventHandler(this.btOpenFolderIn_Click);
            // 
            // pgbProcess
            // 
            this.pgbProcess.BackColor = System.Drawing.SystemColors.Window;
            this.pgbProcess.ForeColor = System.Drawing.Color.Black;
            this.pgbProcess.Location = new System.Drawing.Point(68, 271);
            this.pgbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.Size = new System.Drawing.Size(497, 28);
            this.pgbProcess.TabIndex = 9;
            // 
            // btShowResult
            // 
            this.btShowResult.BackColor = System.Drawing.Color.ForestGreen;
            this.btShowResult.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btShowResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowResult.ForeColor = System.Drawing.Color.White;
            this.btShowResult.Location = new System.Drawing.Point(333, 396);
            this.btShowResult.Margin = new System.Windows.Forms.Padding(4);
            this.btShowResult.Name = "btShowResult";
            this.btShowResult.Size = new System.Drawing.Size(257, 44);
            this.btShowResult.TabIndex = 9;
            this.btShowResult.Text = "Show Result";
            this.btShowResult.UseVisualStyleBackColor = false;
            this.btShowResult.EnabledChanged += new System.EventHandler(this.btShowResult_EnabledChanged);
            this.btShowResult.Click += new System.EventHandler(this.btShowResult_Click);
            this.btShowResult.Paint += new System.Windows.Forms.PaintEventHandler(this.btShowResult_Paint);
            // 
            // btDecrypt
            // 
            this.btDecrypt.BackColor = System.Drawing.Color.ForestGreen;
            this.btDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecrypt.ForeColor = System.Drawing.Color.White;
            this.btDecrypt.Location = new System.Drawing.Point(363, 221);
            this.btDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(120, 43);
            this.btDecrypt.TabIndex = 11;
            this.btDecrypt.Text = "Decrypt";
            this.btDecrypt.UseVisualStyleBackColor = false;
            this.btDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output";
            // 
            // btEncrypt
            // 
            this.btEncrypt.BackColor = System.Drawing.Color.ForestGreen;
            this.btEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncrypt.ForeColor = System.Drawing.Color.White;
            this.btEncrypt.Location = new System.Drawing.Point(151, 221);
            this.btEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(122, 42);
            this.btEncrypt.TabIndex = 10;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.UseVisualStyleBackColor = false;
            this.btEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.ForeColor = System.Drawing.Color.Black;
            this.tbOutput.Location = new System.Drawing.Point(104, 143);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(360, 28);
            this.tbOutput.TabIndex = 7;
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.ForeColor = System.Drawing.Color.Black;
            this.tbInput.Location = new System.Drawing.Point(104, 75);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(360, 28);
            this.tbInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input";
            // 
            // btOpenFileIn
            // 
            this.btOpenFileIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btOpenFileIn.FlatAppearance.BorderSize = 0;
            this.btOpenFileIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenFileIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFileIn.ForeColor = System.Drawing.Color.FloralWhite;
            this.btOpenFileIn.Location = new System.Drawing.Point(472, 54);
            this.btOpenFileIn.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenFileIn.Name = "btOpenFileIn";
            this.btOpenFileIn.Size = new System.Drawing.Size(129, 28);
            this.btOpenFileIn.TabIndex = 0;
            this.btOpenFileIn.Text = "Select File";
            this.btOpenFileIn.UseVisualStyleBackColor = false;
            this.btOpenFileIn.Click += new System.EventHandler(this.btOpenFileIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1105, 50);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(199, 43);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.Location = new System.Drawing.Point(13, 13);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(328, 80);
            this.panel5.TabIndex = 13;
            // 
            // RSACryptosystem
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1320, 579);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RSACryptosystem";
            this.Text = "RSA Cryptosystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RSACryptoSystem_FormClosing);
            this.Load += new System.EventHandler(this.RSACryptoSystem_FormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbKeyPath;
        private System.Windows.Forms.Label lbProcess;
        private System.Windows.Forms.Button btOpenFileKeys;
        private System.Windows.Forms.ComboBox cbbKeyLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGenerateKey;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOpenFileIn;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btShowResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.ProgressBar pgbProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btOpenFolderIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btFolderOut;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.Button btCheckFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

