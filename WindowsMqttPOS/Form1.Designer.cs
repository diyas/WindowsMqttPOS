namespace WindowsMqttPOS
{
    partial class FormPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.gbPaymentMethod = new System.Windows.Forms.GroupBox();
            this.rbEwallet = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCreditDebet = new System.Windows.Forms.RadioButton();
            this.gbEwallet = new System.Windows.Forms.GroupBox();
            this.rbLinkAja = new System.Windows.Forms.RadioButton();
            this.rbDana = new System.Windows.Forms.RadioButton();
            this.rbOvo = new System.Windows.Forms.RadioButton();
            this.rbGopay = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pbPayment = new System.Windows.Forms.ProgressBar();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.txtPosId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrxNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdcId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckDir = new System.Windows.Forms.Button();
            this.btnGenerateToken = new System.Windows.Forms.Button();
            this.gbPaymentMethod.SuspendLayout();
            this.gbEwallet.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(205, 302);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 33);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(80, 93);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 2;
            // 
            // gbPaymentMethod
            // 
            this.gbPaymentMethod.Controls.Add(this.rbEwallet);
            this.gbPaymentMethod.Controls.Add(this.rbCreditCard);
            this.gbPaymentMethod.Controls.Add(this.rbCreditDebet);
            this.gbPaymentMethod.Location = new System.Drawing.Point(80, 129);
            this.gbPaymentMethod.Name = "gbPaymentMethod";
            this.gbPaymentMethod.Size = new System.Drawing.Size(200, 107);
            this.gbPaymentMethod.TabIndex = 3;
            this.gbPaymentMethod.TabStop = false;
            this.gbPaymentMethod.Text = "Payment Method";
            // 
            // rbEwallet
            // 
            this.rbEwallet.AutoSize = true;
            this.rbEwallet.Location = new System.Drawing.Point(6, 75);
            this.rbEwallet.Name = "rbEwallet";
            this.rbEwallet.Size = new System.Drawing.Size(77, 21);
            this.rbEwallet.TabIndex = 2;
            this.rbEwallet.TabStop = true;
            this.rbEwallet.Text = "EWallet";
            this.rbEwallet.UseVisualStyleBackColor = true;
            this.rbEwallet.CheckedChanged += new System.EventHandler(this.RbEwallet_CheckedChanged);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(6, 48);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(100, 21);
            this.rbCreditCard.TabIndex = 1;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.RbCreditCard_CheckedChanged);
            // 
            // rbCreditDebet
            // 
            this.rbCreditDebet.AutoSize = true;
            this.rbCreditDebet.Location = new System.Drawing.Point(6, 21);
            this.rbCreditDebet.Name = "rbCreditDebet";
            this.rbCreditDebet.Size = new System.Drawing.Size(108, 21);
            this.rbCreditDebet.TabIndex = 0;
            this.rbCreditDebet.TabStop = true;
            this.rbCreditDebet.Text = "Credit Debet";
            this.rbCreditDebet.UseVisualStyleBackColor = true;
            this.rbCreditDebet.CheckedChanged += new System.EventHandler(this.RbCreditDebet_CheckedChanged);
            // 
            // gbEwallet
            // 
            this.gbEwallet.Controls.Add(this.rbLinkAja);
            this.gbEwallet.Controls.Add(this.rbDana);
            this.gbEwallet.Controls.Add(this.rbOvo);
            this.gbEwallet.Controls.Add(this.rbGopay);
            this.gbEwallet.Location = new System.Drawing.Point(302, 138);
            this.gbEwallet.Name = "gbEwallet";
            this.gbEwallet.Size = new System.Drawing.Size(200, 132);
            this.gbEwallet.TabIndex = 4;
            this.gbEwallet.TabStop = false;
            this.gbEwallet.Text = "EWallet";
            this.gbEwallet.Visible = false;
            this.gbEwallet.Enter += new System.EventHandler(this.GbEwallet_Enter);
            // 
            // rbLinkAja
            // 
            this.rbLinkAja.AutoSize = true;
            this.rbLinkAja.Location = new System.Drawing.Point(6, 103);
            this.rbLinkAja.Name = "rbLinkAja";
            this.rbLinkAja.Size = new System.Drawing.Size(79, 21);
            this.rbLinkAja.TabIndex = 3;
            this.rbLinkAja.TabStop = true;
            this.rbLinkAja.Text = "Link Aja";
            this.rbLinkAja.UseVisualStyleBackColor = true;
            // 
            // rbDana
            // 
            this.rbDana.AutoSize = true;
            this.rbDana.Location = new System.Drawing.Point(6, 75);
            this.rbDana.Name = "rbDana";
            this.rbDana.Size = new System.Drawing.Size(63, 21);
            this.rbDana.TabIndex = 2;
            this.rbDana.TabStop = true;
            this.rbDana.Text = "Dana";
            this.rbDana.UseVisualStyleBackColor = true;
            // 
            // rbOvo
            // 
            this.rbOvo.AutoSize = true;
            this.rbOvo.Location = new System.Drawing.Point(6, 48);
            this.rbOvo.Name = "rbOvo";
            this.rbOvo.Size = new System.Drawing.Size(55, 21);
            this.rbOvo.TabIndex = 1;
            this.rbOvo.TabStop = true;
            this.rbOvo.Text = "Ovo";
            this.rbOvo.UseVisualStyleBackColor = true;
            // 
            // rbGopay
            // 
            this.rbGopay.AutoSize = true;
            this.rbGopay.Location = new System.Drawing.Point(6, 21);
            this.rbGopay.Name = "rbGopay";
            this.rbGopay.Size = new System.Drawing.Size(71, 21);
            this.rbGopay.TabIndex = 0;
            this.rbGopay.TabStop = true;
            this.rbGopay.Text = "Gopay";
            this.rbGopay.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 397);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(695, 148);
            this.listBox1.TabIndex = 5;
            // 
            // pbPayment
            // 
            this.pbPayment.Location = new System.Drawing.Point(286, 312);
            this.pbPayment.Name = "pbPayment";
            this.pbPayment.Size = new System.Drawing.Size(420, 23);
            this.pbPayment.TabIndex = 6;
            this.pbPayment.Visible = false;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(12, 358);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 33);
            this.btnClearLog.TabIndex = 7;
            this.btnClearLog.Text = "Clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // txtPosId
            // 
            this.txtPosId.Enabled = false;
            this.txtPosId.Location = new System.Drawing.Point(80, 37);
            this.txtPosId.Name = "txtPosId";
            this.txtPosId.Size = new System.Drawing.Size(100, 22);
            this.txtPosId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "POS ID";
            // 
            // txtTrxNo
            // 
            this.txtTrxNo.Location = new System.Drawing.Point(80, 65);
            this.txtTrxNo.Name = "txtTrxNo";
            this.txtTrxNo.Size = new System.Drawing.Size(200, 22);
            this.txtTrxNo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Trx No.";
            // 
            // txtEdcId
            // 
            this.txtEdcId.Enabled = false;
            this.txtEdcId.Location = new System.Drawing.Point(80, 9);
            this.txtEdcId.Name = "txtEdcId";
            this.txtEdcId.Size = new System.Drawing.Size(100, 22);
            this.txtEdcId.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Edc ID";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(302, 29);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(305, 86);
            this.txtToken.TabIndex = 14;
            this.txtToken.TextChanged += new System.EventHandler(this.TxtToken_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Token";
            // 
            // btnCheckDir
            // 
            this.btnCheckDir.Location = new System.Drawing.Point(93, 358);
            this.btnCheckDir.Name = "btnCheckDir";
            this.btnCheckDir.Size = new System.Drawing.Size(135, 33);
            this.btnCheckDir.TabIndex = 16;
            this.btnCheckDir.Text = "Check Directory";
            this.btnCheckDir.UseVisualStyleBackColor = true;
            this.btnCheckDir.Visible = false;
            this.btnCheckDir.Click += new System.EventHandler(this.BtnCheckDir_Click);
            // 
            // btnGenerateToken
            // 
            this.btnGenerateToken.Location = new System.Drawing.Point(613, 29);
            this.btnGenerateToken.Name = "btnGenerateToken";
            this.btnGenerateToken.Size = new System.Drawing.Size(94, 50);
            this.btnGenerateToken.TabIndex = 17;
            this.btnGenerateToken.Text = "Generate Token";
            this.btnGenerateToken.UseVisualStyleBackColor = true;
            this.btnGenerateToken.Click += new System.EventHandler(this.BtnGenerateToken_Click);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 557);
            this.Controls.Add(this.btnGenerateToken);
            this.Controls.Add(this.btnCheckDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdcId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrxNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPosId);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.pbPayment);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbEwallet);
            this.Controls.Add(this.gbPaymentMethod);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.label1);
            this.Name = "FormPayment";
            this.Text = "POS Payment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPaymentMethod.ResumeLayout(false);
            this.gbPaymentMethod.PerformLayout();
            this.gbEwallet.ResumeLayout(false);
            this.gbEwallet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox gbPaymentMethod;
        private System.Windows.Forms.RadioButton rbEwallet;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCreditDebet;
        private System.Windows.Forms.GroupBox gbEwallet;
        private System.Windows.Forms.RadioButton rbLinkAja;
        private System.Windows.Forms.RadioButton rbDana;
        private System.Windows.Forms.RadioButton rbOvo;
        private System.Windows.Forms.RadioButton rbGopay;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ProgressBar pbPayment;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.TextBox txtPosId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrxNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdcId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheckDir;
        private System.Windows.Forms.Button btnGenerateToken;
    }
}

