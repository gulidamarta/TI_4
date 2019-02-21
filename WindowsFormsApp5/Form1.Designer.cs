namespace WindowsFormsApp5
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.rtbPlainText = new System.Windows.Forms.RichTextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.tbMessageHash = new System.Windows.Forms.TextBox();
            this.lbDigitalSignature = new System.Windows.Forms.Label();
            this.tbDigitalSignature = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.OpenFiledlg = new System.Windows.Forms.OpenFileDialog();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbD = new System.Windows.Forms.TextBox();
            this.lblD = new System.Windows.Forms.Label();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.cbHashAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblHashAlgorithm = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.lblGeneratedE = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TextBox();
            this.lblGeneratedR = new System.Windows.Forms.Label();
            this.tbNewMessageHash = new System.Windows.Forms.TextBox();
            this.lbNewMessageHash = new System.Windows.Forms.Label();
            this.lblPlaintext = new System.Windows.Forms.Label();
            this.tbMessageHash_hec = new System.Windows.Forms.TextBox();
            this.lblMessageHash_hex = new System.Windows.Forms.Label();
            this.tnNewMessageHashHec = new System.Windows.Forms.TextBox();
            this.lblNewMessageHashhex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbPlainText
            // 
            this.rtbPlainText.Location = new System.Drawing.Point(7, 30);
            this.rtbPlainText.Name = "rtbPlainText";
            this.rtbPlainText.ReadOnly = true;
            this.rtbPlainText.Size = new System.Drawing.Size(390, 409);
            this.rtbPlainText.TabIndex = 0;
            this.rtbPlainText.Text = "";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(411, 34);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(87, 13);
            this.lblP.TabIndex = 4;
            this.lblP.Text = "Prime number P :";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(412, 52);
            this.tbP.MaxLength = 100;
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(200, 20);
            this.tbP.TabIndex = 5;
            this.tbP.TextChanged += new System.EventHandler(this.tbP_TextChanged);
            this.tbP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbP_KeyPress);
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(412, 96);
            this.tbQ.MaxLength = 100;
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(200, 20);
            this.tbQ.TabIndex = 7;
            this.tbQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQ_KeyPress);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(410, 80);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(88, 13);
            this.lblQ.TabIndex = 6;
            this.lblQ.Text = "Prime number Q :";
            this.lblQ.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(411, 303);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(204, 13);
            this.lblHash.TabIndex = 8;
            this.lblHash.Text = "Message Hash (decimal numeric system) :";
            // 
            // tbMessageHash
            // 
            this.tbMessageHash.Location = new System.Drawing.Point(414, 319);
            this.tbMessageHash.MaxLength = 100;
            this.tbMessageHash.Name = "tbMessageHash";
            this.tbMessageHash.ReadOnly = true;
            this.tbMessageHash.Size = new System.Drawing.Size(200, 20);
            this.tbMessageHash.TabIndex = 9;
            // 
            // lbDigitalSignature
            // 
            this.lbDigitalSignature.AutoSize = true;
            this.lbDigitalSignature.Location = new System.Drawing.Point(411, 396);
            this.lbDigitalSignature.Name = "lbDigitalSignature";
            this.lbDigitalSignature.Size = new System.Drawing.Size(88, 13);
            this.lbDigitalSignature.TabIndex = 10;
            this.lbDigitalSignature.Text = "Digital signature :";
            // 
            // tbDigitalSignature
            // 
            this.tbDigitalSignature.Location = new System.Drawing.Point(414, 412);
            this.tbDigitalSignature.MaxLength = 100;
            this.tbDigitalSignature.Name = "tbDigitalSignature";
            this.tbDigitalSignature.ReadOnly = true;
            this.tbDigitalSignature.Size = new System.Drawing.Size(200, 20);
            this.tbDigitalSignature.TabIndex = 11;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(411, 264);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(201, 23);
            this.btnCheck.TabIndex = 12;
            this.btnCheck.Text = "<< Check Signature";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // OpenFiledlg
            // 
            this.OpenFiledlg.FileName = "openFileDialog1";
            this.OpenFiledlg.RestoreDirectory = true;
            this.OpenFiledlg.ShowHelp = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(412, 224);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(200, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Sign >>";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(412, 140);
            this.tbD.MaxLength = 100;
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(200, 20);
            this.tbD.TabIndex = 15;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(413, 122);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(80, 13);
            this.lblD.TabIndex = 14;
            this.lblD.Text = "Private exp. D :";
            this.lblD.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbHashAlgorithm
            // 
            this.cbHashAlgorithm.FormattingEnabled = true;
            this.cbHashAlgorithm.Items.AddRange(new object[] {
            "Standart(Erud)",
            "SHA-1"});
            this.cbHashAlgorithm.Location = new System.Drawing.Point(412, 185);
            this.cbHashAlgorithm.Name = "cbHashAlgorithm";
            this.cbHashAlgorithm.Size = new System.Drawing.Size(200, 21);
            this.cbHashAlgorithm.TabIndex = 16;
            // 
            // lblHashAlgorithm
            // 
            this.lblHashAlgorithm.AutoSize = true;
            this.lblHashAlgorithm.Location = new System.Drawing.Point(413, 169);
            this.lblHashAlgorithm.Name = "lblHashAlgorithm";
            this.lblHashAlgorithm.Size = new System.Drawing.Size(114, 13);
            this.lblHashAlgorithm.TabIndex = 17;
            this.lblHashAlgorithm.Text = "Choose hash algoritm: ";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(634, 52);
            this.tbE.MaxLength = 100;
            this.tbE.Name = "tbE";
            this.tbE.ReadOnly = true;
            this.tbE.Size = new System.Drawing.Size(200, 20);
            this.tbE.TabIndex = 19;
            // 
            // lblGeneratedE
            // 
            this.lblGeneratedE.AutoSize = true;
            this.lblGeneratedE.Location = new System.Drawing.Point(633, 34);
            this.lblGeneratedE.Name = "lblGeneratedE";
            this.lblGeneratedE.Size = new System.Drawing.Size(73, 13);
            this.lblGeneratedE.TabIndex = 18;
            this.lblGeneratedE.Text = "Generated E :";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(634, 98);
            this.tbR.MaxLength = 100;
            this.tbR.Name = "tbR";
            this.tbR.ReadOnly = true;
            this.tbR.Size = new System.Drawing.Size(200, 20);
            this.tbR.TabIndex = 21;
            // 
            // lblGeneratedR
            // 
            this.lblGeneratedR.AutoSize = true;
            this.lblGeneratedR.Location = new System.Drawing.Point(633, 80);
            this.lblGeneratedR.Name = "lblGeneratedR";
            this.lblGeneratedR.Size = new System.Drawing.Size(74, 13);
            this.lblGeneratedR.TabIndex = 20;
            this.lblGeneratedR.Text = "Generated R :";
            // 
            // tbNewMessageHash
            // 
            this.tbNewMessageHash.Location = new System.Drawing.Point(634, 319);
            this.tbNewMessageHash.MaxLength = 100;
            this.tbNewMessageHash.Name = "tbNewMessageHash";
            this.tbNewMessageHash.ReadOnly = true;
            this.tbNewMessageHash.Size = new System.Drawing.Size(200, 20);
            this.tbNewMessageHash.TabIndex = 24;
            this.tbNewMessageHash.Visible = false;
            // 
            // lbNewMessageHash
            // 
            this.lbNewMessageHash.AutoSize = true;
            this.lbNewMessageHash.Location = new System.Drawing.Point(633, 303);
            this.lbNewMessageHash.Name = "lbNewMessageHash";
            this.lbNewMessageHash.Size = new System.Drawing.Size(226, 13);
            this.lbNewMessageHash.TabIndex = 23;
            this.lbNewMessageHash.Text = "New Message Hash (decimal numeric system):";
            this.lbNewMessageHash.Visible = false;
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.AutoSize = true;
            this.lblPlaintext.Location = new System.Drawing.Point(165, 12);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(47, 13);
            this.lblPlaintext.TabIndex = 27;
            this.lblPlaintext.Text = "Plaintext";
            // 
            // tbMessageHash_hec
            // 
            this.tbMessageHash_hec.Location = new System.Drawing.Point(416, 364);
            this.tbMessageHash_hec.MaxLength = 100;
            this.tbMessageHash_hec.Name = "tbMessageHash_hec";
            this.tbMessageHash_hec.ReadOnly = true;
            this.tbMessageHash_hec.Size = new System.Drawing.Size(200, 20);
            this.tbMessageHash_hec.TabIndex = 29;
            // 
            // lblMessageHash_hex
            // 
            this.lblMessageHash_hex.AutoSize = true;
            this.lblMessageHash_hex.Location = new System.Drawing.Point(413, 348);
            this.lblMessageHash_hex.Name = "lblMessageHash_hex";
            this.lblMessageHash_hex.Size = new System.Drawing.Size(185, 13);
            this.lblMessageHash_hex.TabIndex = 28;
            this.lblMessageHash_hex.Text = "Message Hash (hex numeric system) :";
            // 
            // tnNewMessageHashHec
            // 
            this.tnNewMessageHashHec.Location = new System.Drawing.Point(634, 364);
            this.tnNewMessageHashHec.MaxLength = 100;
            this.tnNewMessageHashHec.Name = "tnNewMessageHashHec";
            this.tnNewMessageHashHec.ReadOnly = true;
            this.tnNewMessageHashHec.Size = new System.Drawing.Size(200, 20);
            this.tnNewMessageHashHec.TabIndex = 31;
            this.tnNewMessageHashHec.Visible = false;
            // 
            // lblNewMessageHashhex
            // 
            this.lblNewMessageHashhex.AutoSize = true;
            this.lblNewMessageHashhex.Location = new System.Drawing.Point(633, 348);
            this.lblNewMessageHashhex.Name = "lblNewMessageHashhex";
            this.lblNewMessageHashhex.Size = new System.Drawing.Size(210, 13);
            this.lblNewMessageHashhex.TabIndex = 30;
            this.lblNewMessageHashhex.Text = "New Message Hash (hex numeric system) :";
            this.lblNewMessageHashhex.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 444);
            this.Controls.Add(this.tnNewMessageHashHec);
            this.Controls.Add(this.lblNewMessageHashhex);
            this.Controls.Add(this.tbMessageHash_hec);
            this.Controls.Add(this.lblMessageHash_hex);
            this.Controls.Add(this.lblPlaintext);
            this.Controls.Add(this.tbNewMessageHash);
            this.Controls.Add(this.lbNewMessageHash);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.lblGeneratedR);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.lblGeneratedE);
            this.Controls.Add(this.lblHashAlgorithm);
            this.Controls.Add(this.cbHashAlgorithm);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbDigitalSignature);
            this.Controls.Add(this.lbDigitalSignature);
            this.Controls.Add(this.tbMessageHash);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.rtbPlainText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронная цифровая подпись на основе RSA, Гулида Марта, 751001";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPlainText;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox tbMessageHash;
        private System.Windows.Forms.Label lbDigitalSignature;
        private System.Windows.Forms.TextBox tbDigitalSignature;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.OpenFileDialog OpenFiledlg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.ComboBox cbHashAlgorithm;
        private System.Windows.Forms.Label lblHashAlgorithm;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Label lblGeneratedE;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.Label lblGeneratedR;
        private System.Windows.Forms.TextBox tbNewMessageHash;
        private System.Windows.Forms.Label lbNewMessageHash;
        private System.Windows.Forms.Label lblPlaintext;
        private System.Windows.Forms.TextBox tbMessageHash_hec;
        private System.Windows.Forms.Label lblMessageHash_hex;
        private System.Windows.Forms.TextBox tnNewMessageHashHec;
        private System.Windows.Forms.Label lblNewMessageHashhex;
    }
}

