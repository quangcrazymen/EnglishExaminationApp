
namespace TH02
{
    partial class Account
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
            this.Quang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.AccountImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AccountImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Quang
            // 
            this.Quang.AutoSize = true;
            this.Quang.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Quang.Location = new System.Drawing.Point(197, 184);
            this.Quang.Name = "Quang";
            this.Quang.Size = new System.Drawing.Size(67, 24);
            this.Quang.TabIndex = 1;
            this.Quang.Text = "Quang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address: ";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(198, 276);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(177, 17);
            this.Address.TabIndex = 3;
            this.Address.Text = "1 Nguyễn Du, Q1, Tp.HCM";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close.Location = new System.Drawing.Point(751, 22);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(94, 33);
            this.Close.TabIndex = 4;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AccountImage
            // 
            this.AccountImage.Image = global::TH02.Properties.Resources.Logo;
            this.AccountImage.Location = new System.Drawing.Point(148, 16);
            this.AccountImage.Name = "AccountImage";
            this.AccountImage.Size = new System.Drawing.Size(171, 165);
            this.AccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccountImage.TabIndex = 0;
            this.AccountImage.TabStop = false;
            this.AccountImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AccountImage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.Quang);
            this.panel1.Location = new System.Drawing.Point(211, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 458);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(73, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "20520720";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Close);
            this.Name = "Account";
            this.Text = "Account";
            ((System.ComponentModel.ISupportInitialize)(this.AccountImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AccountImage;
        private System.Windows.Forms.Label Quang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}