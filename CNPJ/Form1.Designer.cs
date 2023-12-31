
namespace CNPJ
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
            this.mtbCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnValidaCnpj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbCnpj
            // 
            this.mtbCnpj.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCnpj.Location = new System.Drawing.Point(59, 134);
            this.mtbCnpj.Mask = "00.000.000/0000-00";
            this.mtbCnpj.Name = "mtbCnpj";
            this.mtbCnpj.Size = new System.Drawing.Size(253, 32);
            this.mtbCnpj.TabIndex = 0;
            this.mtbCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnValidaCnpj
            // 
            this.btnValidaCnpj.Location = new System.Drawing.Point(237, 243);
            this.btnValidaCnpj.Name = "btnValidaCnpj";
            this.btnValidaCnpj.Size = new System.Drawing.Size(75, 23);
            this.btnValidaCnpj.TabIndex = 1;
            this.btnValidaCnpj.Text = "Validar";
            this.btnValidaCnpj.UseVisualStyleBackColor = true;
            this.btnValidaCnpj.Click += new System.EventHandler(this.btnValidaCnpj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 360);
            this.Controls.Add(this.btnValidaCnpj);
            this.Controls.Add(this.mtbCnpj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCnpj;
        private System.Windows.Forms.Button btnValidaCnpj;
    }
}

