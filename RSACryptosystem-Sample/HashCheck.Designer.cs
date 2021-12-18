namespace RSA
{ 
    partial class HashCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashCheck));
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtSHA256 = new System.Windows.Forms.TextBox();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lable12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btCheckSum = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSHA1
            // 
            this.txtSHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSHA1.ForeColor = System.Drawing.Color.Black;
            this.txtSHA1.Location = new System.Drawing.Point(101, 156);
            this.txtSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(398, 26);
            this.txtSHA1.TabIndex = 38;
            // 
            // txtSHA256
            // 
            this.txtSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSHA256.ForeColor = System.Drawing.Color.Black;
            this.txtSHA256.Location = new System.Drawing.Point(101, 195);
            this.txtSHA256.Margin = new System.Windows.Forms.Padding(4);
            this.txtSHA256.Name = "txtSHA256";
            this.txtSHA256.Size = new System.Drawing.Size(398, 26);
            this.txtSHA256.TabIndex = 37;
            // 
            // txtMD5
            // 
            this.txtMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMD5.ForeColor = System.Drawing.Color.Black;
            this.txtMD5.Location = new System.Drawing.Point(101, 117);
            this.txtMD5.Margin = new System.Windows.Forms.Padding(4);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(398, 26);
            this.txtMD5.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(123, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 35;
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable12.ForeColor = System.Drawing.Color.Black;
            this.lable12.Location = new System.Drawing.Point(22, 197);
            this.lable12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(70, 20);
            this.lable12.TabIndex = 34;
            this.lable12.Text = "SHA256";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(22, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "SHA1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(22, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "MD5";
            // 
            // btCheckSum
            // 
            this.btCheckSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckSum.ForeColor = System.Drawing.Color.Black;
            this.btCheckSum.Location = new System.Drawing.Point(217, 81);
            this.btCheckSum.Margin = new System.Windows.Forms.Padding(4);
            this.btCheckSum.Name = "btCheckSum";
            this.btCheckSum.Size = new System.Drawing.Size(100, 28);
            this.btCheckSum.TabIndex = 31;
            this.btCheckSum.Text = "Check";
            this.btCheckSum.UseVisualStyleBackColor = true;
            this.btCheckSum.Click += new System.EventHandler(this.btCheckSum_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(101, 48);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(290, 26);
            this.txtInput.TabIndex = 30;
            // 
            // btOpenFile
            // 
            this.btOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFile.ForeColor = System.Drawing.Color.Black;
            this.btOpenFile.Location = new System.Drawing.Point(399, 48);
            this.btOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(100, 30);
            this.btOpenFile.TabIndex = 29;
            this.btOpenFile.Text = "Open";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "File";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(188, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "HASH Check";
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(193, 243);
            this.btReset.Margin = new System.Windows.Forms.Padding(4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(147, 42);
            this.btReset.TabIndex = 39;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // HashCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 298);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.txtSHA1);
            this.Controls.Add(this.txtSHA256);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lable12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btCheckSum);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HashCheck";
            this.Text = "HASH Check";
            this.Load += new System.EventHandler(this.HashCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtSHA256;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btCheckSum;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btReset;
    }
}