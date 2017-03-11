namespace EncryptDecrypter
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
            this.textBox_encrypt = new System.Windows.Forms.TextBox();
            this.textBox_decrypt = new System.Windows.Forms.TextBox();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_encrypt
            // 
            this.textBox_encrypt.Location = new System.Drawing.Point(12, 12);
            this.textBox_encrypt.Multiline = true;
            this.textBox_encrypt.Name = "textBox_encrypt";
            this.textBox_encrypt.Size = new System.Drawing.Size(390, 146);
            this.textBox_encrypt.TabIndex = 0;
            // 
            // textBox_decrypt
            // 
            this.textBox_decrypt.Location = new System.Drawing.Point(12, 209);
            this.textBox_decrypt.Multiline = true;
            this.textBox_decrypt.Name = "textBox_decrypt";
            this.textBox_decrypt.Size = new System.Drawing.Size(390, 146);
            this.textBox_decrypt.TabIndex = 1;
            // 
            // button_encrypt
            // 
            this.button_encrypt.Location = new System.Drawing.Point(12, 164);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(390, 23);
            this.button_encrypt.TabIndex = 2;
            this.button_encrypt.Text = "Encrypt";
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Location = new System.Drawing.Point(12, 361);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(390, 23);
            this.button_decrypt.TabIndex = 3;
            this.button_decrypt.Text = "Decrypt";
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mail Test Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.Controls.Add(this.textBox_decrypt);
            this.Controls.Add(this.textBox_encrypt);
            this.Name = "Form1";
            this.Text = "Encrypt And Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_encrypt;
        private System.Windows.Forms.TextBox textBox_decrypt;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.Button button_decrypt;
        private System.Windows.Forms.Button button1;
    }
}

