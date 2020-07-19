namespace Crypt_Form
{
    partial class CrypForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.raBtnEncrypt = new System.Windows.Forms.RadioButton();
            this.raBtnDecrypt = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // raBtnEncrypt
            // 
            this.raBtnEncrypt.AutoSize = true;
            this.raBtnEncrypt.Location = new System.Drawing.Point(202, 19);
            this.raBtnEncrypt.Name = "raBtnEncrypt";
            this.raBtnEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.raBtnEncrypt.Size = new System.Drawing.Size(76, 24);
            this.raBtnEncrypt.TabIndex = 2;
            this.raBtnEncrypt.TabStop = true;
            this.raBtnEncrypt.Text = "Encrypt";
            this.raBtnEncrypt.UseVisualStyleBackColor = true;
            this.raBtnEncrypt.CheckedChanged += new System.EventHandler(this.raBtnEncrypt_CheckedChanged);
            // 
            // raBtnDecrypt
            // 
            this.raBtnDecrypt.AutoSize = true;
            this.raBtnDecrypt.Location = new System.Drawing.Point(338, 19);
            this.raBtnDecrypt.Name = "raBtnDecrypt";
            this.raBtnDecrypt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.raBtnDecrypt.Size = new System.Drawing.Size(79, 24);
            this.raBtnDecrypt.TabIndex = 3;
            this.raBtnDecrypt.TabStop = true;
            this.raBtnDecrypt.Text = "Decrypt";
            this.raBtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(99, 49);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(353, 109);
            this.txtInput.TabIndex = 4;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(99, 164);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(353, 109);
            this.txtOutput.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(99, 288);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(353, 43);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // CrypForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 353);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.raBtnDecrypt);
            this.Controls.Add(this.raBtnEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrypForm";
            this.Text = "Crypt Form";
            this.Load += new System.EventHandler(this.CrypForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton raBtnEncrypt;
        private System.Windows.Forms.RadioButton raBtnDecrypt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnConvert;
    }
}

