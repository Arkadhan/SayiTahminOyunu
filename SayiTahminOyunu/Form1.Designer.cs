
namespace SayiTahminOyunu
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
            this.btnTahmin = new System.Windows.Forms.Button();
            this.tbTahmin = new System.Windows.Forms.TextBox();
            this.lblHak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(189, 178);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(199, 76);
            this.btnTahmin.TabIndex = 0;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // tbTahmin
            // 
            this.tbTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTahmin.Location = new System.Drawing.Point(189, 119);
            this.tbTahmin.Name = "tbTahmin";
            this.tbTahmin.Size = new System.Drawing.Size(199, 26);
            this.tbTahmin.TabIndex = 1;
            this.tbTahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.Location = new System.Drawing.Point(219, 277);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(129, 25);
            this.lblHak.TabIndex = 2;
            this.lblHak.Text = "Kalan Hak:3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "1-10 arasında tahmini kutuya yazınız";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.tbTahmin);
            this.Controls.Add(this.btnTahmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox tbTahmin;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label label2;
    }
}

