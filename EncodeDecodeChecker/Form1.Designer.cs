namespace EncodeDecodeChecker
{
    partial class Form1
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
            this.originalText = new System.Windows.Forms.TextBox();
            this.cipherText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.algorithmSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originalText
            // 
            this.originalText.Location = new System.Drawing.Point(114, 76);
            this.originalText.Name = "originalText";
            this.originalText.Size = new System.Drawing.Size(256, 20);
            this.originalText.TabIndex = 0;
            // 
            // cipherText
            // 
            this.cipherText.Location = new System.Drawing.Point(114, 119);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(256, 20);
            this.cipherText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cipher Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orignal Text";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(37, 233);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(148, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(222, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // algorithmSelector
            // 
            this.algorithmSelector.FormattingEnabled = true;
            this.algorithmSelector.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.algorithmSelector.Location = new System.Drawing.Point(114, 31);
            this.algorithmSelector.Name = "algorithmSelector";
            this.algorithmSelector.Size = new System.Drawing.Size(256, 21);
            this.algorithmSelector.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Algorithm";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(37, 170);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 290);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.algorithmSelector);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.originalText);
            this.Name = "Form1";
            this.Text = "Cipher Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox originalText;
        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox algorithmSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
    }
}

