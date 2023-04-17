namespace Encrypt_Decrypt_File_Using_RSA_AES
{
    partial class btn_browser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_DecryptAes = new System.Windows.Forms.Button();
            this.btn_EncryptAes = new System.Windows.Forms.Button();
            this.btn_BrowserSecretKey = new System.Windows.Forms.Button();
            this.txt_SecretKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_BrowerPlainFileAes = new System.Windows.Forms.Button();
            this.txt_BrowerPlainFileAes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_KeySizeAes = new System.Windows.Forms.ComboBox();
            this.btn_GenerateKeyAes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ccb_KeySizeRsa = new System.Windows.Forms.ComboBox();
            this.btn_GenerateKeysRsa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_DecryptRsa = new System.Windows.Forms.Button();
            this.btn_BrowserPrivateKey = new System.Windows.Forms.Button();
            this.btn_EncryptRsa = new System.Windows.Forms.Button();
            this.txt_BrowserPrivateKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_BrowserPublicKey = new System.Windows.Forms.Button();
            this.txt_BrowserPublicKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_BrowserPlainFileRsa = new System.Windows.Forms.Button();
            this.txt_BrowserPlainFileRsa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DecryptAes);
            this.groupBox1.Controls.Add(this.btn_EncryptAes);
            this.groupBox1.Controls.Add(this.btn_BrowserSecretKey);
            this.groupBox1.Controls.Add(this.txt_SecretKey);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_BrowerPlainFileAes);
            this.groupBox1.Controls.Add(this.txt_BrowerPlainFileAes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(420, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(804, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AES";
            // 
            // btn_DecryptAes
            // 
            this.btn_DecryptAes.Location = new System.Drawing.Point(440, 175);
            this.btn_DecryptAes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DecryptAes.Name = "btn_DecryptAes";
            this.btn_DecryptAes.Size = new System.Drawing.Size(212, 34);
            this.btn_DecryptAes.TabIndex = 7;
            this.btn_DecryptAes.Text = "Decrypt";
            this.btn_DecryptAes.UseVisualStyleBackColor = true;
            this.btn_DecryptAes.Click += new System.EventHandler(this.btn_DecryptAes_Click);
            // 
            // btn_EncryptAes
            // 
            this.btn_EncryptAes.Location = new System.Drawing.Point(153, 175);
            this.btn_EncryptAes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EncryptAes.Name = "btn_EncryptAes";
            this.btn_EncryptAes.Size = new System.Drawing.Size(212, 34);
            this.btn_EncryptAes.TabIndex = 6;
            this.btn_EncryptAes.Text = "Encrypt";
            this.btn_EncryptAes.UseVisualStyleBackColor = true;
            this.btn_EncryptAes.Click += new System.EventHandler(this.btn_EncryptAes_Click);
            // 
            // btn_BrowserSecretKey
            // 
            this.btn_BrowserSecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowserSecretKey.Location = new System.Drawing.Point(672, 124);
            this.btn_BrowserSecretKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BrowserSecretKey.Name = "btn_BrowserSecretKey";
            this.btn_BrowserSecretKey.Size = new System.Drawing.Size(111, 32);
            this.btn_BrowserSecretKey.TabIndex = 5;
            this.btn_BrowserSecretKey.Text = "browser...";
            this.btn_BrowserSecretKey.UseVisualStyleBackColor = true;
            this.btn_BrowserSecretKey.Click += new System.EventHandler(this.btn_BrowserSecretKey_Click);
            // 
            // txt_SecretKey
            // 
            this.txt_SecretKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SecretKey.Location = new System.Drawing.Point(153, 127);
            this.txt_SecretKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SecretKey.Name = "txt_SecretKey";
            this.txt_SecretKey.Size = new System.Drawing.Size(497, 22);
            this.txt_SecretKey.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Secret key:";
            // 
            // btn_BrowerPlainFileAes
            // 
            this.btn_BrowerPlainFileAes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowerPlainFileAes.Location = new System.Drawing.Point(672, 59);
            this.btn_BrowerPlainFileAes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BrowerPlainFileAes.Name = "btn_BrowerPlainFileAes";
            this.btn_BrowerPlainFileAes.Size = new System.Drawing.Size(111, 32);
            this.btn_BrowerPlainFileAes.TabIndex = 2;
            this.btn_BrowerPlainFileAes.Text = "browser...";
            this.btn_BrowerPlainFileAes.UseVisualStyleBackColor = true;
            this.btn_BrowerPlainFileAes.Click += new System.EventHandler(this.btn_BrowerPlainFileAes_Click);
            // 
            // txt_BrowerPlainFileAes
            // 
            this.txt_BrowerPlainFileAes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BrowerPlainFileAes.Location = new System.Drawing.Point(153, 62);
            this.txt_BrowerPlainFileAes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BrowerPlainFileAes.Name = "txt_BrowerPlainFileAes";
            this.txt_BrowerPlainFileAes.Size = new System.Drawing.Size(497, 22);
            this.txt_BrowerPlainFileAes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose File:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_KeySizeAes);
            this.groupBox2.Controls.Add(this.btn_GenerateKeyAes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(40, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(323, 231);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Key AES";
            // 
            // cbb_KeySizeAes
            // 
            this.cbb_KeySizeAes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_KeySizeAes.FormattingEnabled = true;
            this.cbb_KeySizeAes.Location = new System.Drawing.Point(25, 76);
            this.cbb_KeySizeAes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_KeySizeAes.Name = "cbb_KeySizeAes";
            this.cbb_KeySizeAes.Size = new System.Drawing.Size(196, 26);
            this.cbb_KeySizeAes.TabIndex = 3;
            // 
            // btn_GenerateKeyAes
            // 
            this.btn_GenerateKeyAes.Location = new System.Drawing.Point(25, 132);
            this.btn_GenerateKeyAes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GenerateKeyAes.Name = "btn_GenerateKeyAes";
            this.btn_GenerateKeyAes.Size = new System.Drawing.Size(197, 41);
            this.btn_GenerateKeyAes.TabIndex = 2;
            this.btn_GenerateKeyAes.Text = "Generate Key";
            this.btn_GenerateKeyAes.UseVisualStyleBackColor = true;
            this.btn_GenerateKeyAes.Click += new System.EventHandler(this.btn_GenerateKeyAes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Key Size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ccb_KeySizeRsa);
            this.groupBox3.Controls.Add(this.btn_GenerateKeysRsa);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Orange;
            this.groupBox3.Location = new System.Drawing.Point(40, 316);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(323, 263);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate Keys RSA";
            // 
            // ccb_KeySizeRsa
            // 
            this.ccb_KeySizeRsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccb_KeySizeRsa.FormattingEnabled = true;
            this.ccb_KeySizeRsa.Location = new System.Drawing.Point(27, 80);
            this.ccb_KeySizeRsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ccb_KeySizeRsa.Name = "ccb_KeySizeRsa";
            this.ccb_KeySizeRsa.Size = new System.Drawing.Size(191, 26);
            this.ccb_KeySizeRsa.TabIndex = 4;
            // 
            // btn_GenerateKeysRsa
            // 
            this.btn_GenerateKeysRsa.Location = new System.Drawing.Point(25, 132);
            this.btn_GenerateKeysRsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GenerateKeysRsa.Name = "btn_GenerateKeysRsa";
            this.btn_GenerateKeysRsa.Size = new System.Drawing.Size(197, 41);
            this.btn_GenerateKeysRsa.TabIndex = 2;
            this.btn_GenerateKeysRsa.Text = "Generate Keys";
            this.btn_GenerateKeysRsa.UseVisualStyleBackColor = true;
            this.btn_GenerateKeysRsa.Click += new System.EventHandler(this.btn_GenerateKeysRsa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Key Size";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_DecryptRsa);
            this.groupBox4.Controls.Add(this.btn_BrowserPrivateKey);
            this.groupBox4.Controls.Add(this.btn_EncryptRsa);
            this.groupBox4.Controls.Add(this.txt_BrowserPrivateKey);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btn_BrowserPublicKey);
            this.groupBox4.Controls.Add(this.txt_BrowserPublicKey);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btn_BrowserPlainFileRsa);
            this.groupBox4.Controls.Add(this.txt_BrowserPlainFileRsa);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Orange;
            this.groupBox4.Location = new System.Drawing.Point(420, 316);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(804, 263);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RSA";
            // 
            // btn_DecryptRsa
            // 
            this.btn_DecryptRsa.Location = new System.Drawing.Point(440, 208);
            this.btn_DecryptRsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DecryptRsa.Name = "btn_DecryptRsa";
            this.btn_DecryptRsa.Size = new System.Drawing.Size(212, 34);
            this.btn_DecryptRsa.TabIndex = 9;
            this.btn_DecryptRsa.Text = "Decrypt";
            this.btn_DecryptRsa.UseVisualStyleBackColor = true;
            this.btn_DecryptRsa.Click += new System.EventHandler(this.btn_DecryptRsa_Click);
            // 
            // btn_BrowserPrivateKey
            // 
            this.btn_BrowserPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowserPrivateKey.Location = new System.Drawing.Point(672, 151);
            this.btn_BrowserPrivateKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BrowserPrivateKey.Name = "btn_BrowserPrivateKey";
            this.btn_BrowserPrivateKey.Size = new System.Drawing.Size(111, 32);
            this.btn_BrowserPrivateKey.TabIndex = 7;
            this.btn_BrowserPrivateKey.Text = "browser...";
            this.btn_BrowserPrivateKey.UseVisualStyleBackColor = true;
            this.btn_BrowserPrivateKey.Click += new System.EventHandler(this.btn_BrowserPrivateKey_Click);
            // 
            // btn_EncryptRsa
            // 
            this.btn_EncryptRsa.Location = new System.Drawing.Point(153, 208);
            this.btn_EncryptRsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EncryptRsa.Name = "btn_EncryptRsa";
            this.btn_EncryptRsa.Size = new System.Drawing.Size(212, 34);
            this.btn_EncryptRsa.TabIndex = 8;
            this.btn_EncryptRsa.Text = "Encrypt";
            this.btn_EncryptRsa.UseVisualStyleBackColor = true;
            this.btn_EncryptRsa.Click += new System.EventHandler(this.btn_EncryptRsa_Click);
            // 
            // txt_BrowserPrivateKey
            // 
            this.txt_BrowserPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BrowserPrivateKey.Location = new System.Drawing.Point(153, 151);
            this.txt_BrowserPrivateKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BrowserPrivateKey.Name = "txt_BrowserPrivateKey";
            this.txt_BrowserPrivateKey.Size = new System.Drawing.Size(497, 26);
            this.txt_BrowserPrivateKey.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Private Key:";
            // 
            // btn_BrowserPublicKey
            // 
            this.btn_BrowserPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowserPublicKey.Location = new System.Drawing.Point(672, 92);
            this.btn_BrowserPublicKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BrowserPublicKey.Name = "btn_BrowserPublicKey";
            this.btn_BrowserPublicKey.Size = new System.Drawing.Size(111, 32);
            this.btn_BrowserPublicKey.TabIndex = 4;
            this.btn_BrowserPublicKey.Text = "browser...";
            this.btn_BrowserPublicKey.UseVisualStyleBackColor = true;
            this.btn_BrowserPublicKey.Click += new System.EventHandler(this.btn_BrowserPublicKey_Click);
            // 
            // txt_BrowserPublicKey
            // 
            this.txt_BrowserPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BrowserPublicKey.Location = new System.Drawing.Point(153, 92);
            this.txt_BrowserPublicKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BrowserPublicKey.Name = "txt_BrowserPublicKey";
            this.txt_BrowserPublicKey.Size = new System.Drawing.Size(497, 26);
            this.txt_BrowserPublicKey.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Public Key:";
            // 
            // btn_BrowserPlainFileRsa
            // 
            this.btn_BrowserPlainFileRsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowserPlainFileRsa.Location = new System.Drawing.Point(672, 38);
            this.btn_BrowserPlainFileRsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BrowserPlainFileRsa.Name = "btn_BrowserPlainFileRsa";
            this.btn_BrowserPlainFileRsa.Size = new System.Drawing.Size(111, 32);
            this.btn_BrowserPlainFileRsa.TabIndex = 3;
            this.btn_BrowserPlainFileRsa.Text = "browser...";
            this.btn_BrowserPlainFileRsa.UseVisualStyleBackColor = true;
            this.btn_BrowserPlainFileRsa.Click += new System.EventHandler(this.btn_BrowserPlainFileRsa_Click);
            // 
            // txt_BrowserPlainFileRsa
            // 
            this.txt_BrowserPlainFileRsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BrowserPlainFileRsa.Location = new System.Drawing.Point(153, 38);
            this.txt_BrowserPlainFileRsa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BrowserPlainFileRsa.Name = "txt_BrowserPlainFileRsa";
            this.txt_BrowserPlainFileRsa.Size = new System.Drawing.Size(497, 26);
            this.txt_BrowserPlainFileRsa.TabIndex = 3;
            this.txt_BrowserPlainFileRsa.TextChanged += new System.EventHandler(this.txtPlainFileRsa);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choose File:";
            // 
            // btn_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 622);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "btn_browser";
            this.Text = "Encryption/ Decryption File by RSA combine AES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_BrowerPlainFileAes;
        private System.Windows.Forms.TextBox txt_BrowerPlainFileAes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_GenerateKeyAes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_GenerateKeysRsa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_BrowserPlainFileRsa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_BrowserSecretKey;
        private System.Windows.Forms.TextBox txt_SecretKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_BrowserPlainFileRsa;
        private System.Windows.Forms.Button btn_DecryptAes;
        private System.Windows.Forms.Button btn_EncryptAes;
        private System.Windows.Forms.Button btn_BrowserPrivateKey;
        private System.Windows.Forms.TextBox txt_BrowserPrivateKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_BrowserPublicKey;
        private System.Windows.Forms.TextBox txt_BrowserPublicKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DecryptRsa;
        private System.Windows.Forms.Button btn_EncryptRsa;
        private System.Windows.Forms.ComboBox cbb_KeySizeAes;
        private System.Windows.Forms.ComboBox ccb_KeySizeRsa;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

