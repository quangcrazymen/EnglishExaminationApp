
namespace TH02
{
    partial class DetailPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productInfo = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ImageTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureSlider = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.productInfo);
            this.panel1.Controls.Add(this.AddToCart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Location = new System.Drawing.Point(447, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 487);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TH02.Properties.Resources._return;
            this.pictureBox2.Location = new System.Drawing.Point(74, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TH02.Properties.Resources.sun;
            this.pictureBox1.Location = new System.Drawing.Point(74, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Free 30-day return window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sold and shipped by Walmart.com";
            // 
            // productInfo
            // 
            this.productInfo.AutoSize = true;
            this.productInfo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInfo.Location = new System.Drawing.Point(45, 18);
            this.productInfo.Name = "productInfo";
            this.productInfo.Size = new System.Drawing.Size(238, 95);
            this.productInfo.TabIndex = 3;
            this.productInfo.Text = "Lenovo Ideapad Slim 7i Pro, 14.0\r\nPrice: $999.00\r\nRating: 3.5\r\nShipping Date: 2 d" +
    "ays\r\nGuarentee: 1 years\r\n";
            // 
            // AddToCart
            // 
            this.AddToCart.BackColor = System.Drawing.SystemColors.HotTrack;
            this.AddToCart.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddToCart.Location = new System.Drawing.Point(58, 358);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(304, 91);
            this.AddToCart.TabIndex = 2;
            this.AddToCart.Text = "Add to cart";
            this.AddToCart.UseVisualStyleBackColor = false;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity: ";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(210, 309);
            this.Quantity.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(120, 22);
            this.Quantity.TabIndex = 0;
            this.Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(410, 239);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(12, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 249);
            this.panel2.TabIndex = 2;
            // 
            // ImageTimer
            // 
            this.ImageTimer.Enabled = true;
            this.ImageTimer.Interval = 1000;
            this.ImageTimer.Tick += new System.EventHandler(this.ImageTimer_Tick);
            // 
            // pictureSlider
            // 
            this.pictureSlider.Image = global::TH02.Properties.Resources._1;
            this.pictureSlider.Location = new System.Drawing.Point(88, 25);
            this.pictureSlider.Name = "pictureSlider";
            this.pictureSlider.Size = new System.Drawing.Size(276, 232);
            this.pictureSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSlider.TabIndex = 3;
            this.pictureSlider.TabStop = false;
            // 
            // DetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 524);
            this.Controls.Add(this.pictureSlider);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailPage";
            this.Text = "DetailPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Label productInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureSlider;
        private System.Windows.Forms.Timer ImageTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}