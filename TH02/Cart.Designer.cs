
namespace TH02
{
    partial class Cart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Twenty = new System.Windows.Forms.Button();
            this.Fifthteen = new System.Windows.Forms.Button();
            this.Ten = new System.Windows.Forms.Button();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.Express = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Total = new System.Windows.Forms.Label();
            this.AcceptPayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.YourCart = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.YourCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 58);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cart";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 448);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Twenty);
            this.panel2.Controls.Add(this.Fifthteen);
            this.panel2.Controls.Add(this.Ten);
            this.panel2.Controls.Add(this.Normal);
            this.panel2.Controls.Add(this.Express);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(442, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 274);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Choose Your Coupon";
            // 
            // Twenty
            // 
            this.Twenty.Location = new System.Drawing.Point(316, 178);
            this.Twenty.Name = "Twenty";
            this.Twenty.Size = new System.Drawing.Size(94, 66);
            this.Twenty.TabIndex = 5;
            this.Twenty.Text = "20% off";
            this.Twenty.UseVisualStyleBackColor = true;
            // 
            // Fifthteen
            // 
            this.Fifthteen.Location = new System.Drawing.Point(176, 178);
            this.Fifthteen.Name = "Fifthteen";
            this.Fifthteen.Size = new System.Drawing.Size(94, 66);
            this.Fifthteen.TabIndex = 4;
            this.Fifthteen.Text = "15% off";
            this.Fifthteen.UseVisualStyleBackColor = true;
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(36, 178);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(94, 66);
            this.Ten.TabIndex = 3;
            this.Ten.Text = "10% off";
            this.Ten.UseVisualStyleBackColor = true;
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Location = new System.Drawing.Point(24, 93);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(201, 21);
            this.Normal.TabIndex = 2;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal Transtport - $15.00";
            this.Normal.UseVisualStyleBackColor = true;
            // 
            // Express
            // 
            this.Express.AutoSize = true;
            this.Express.Location = new System.Drawing.Point(24, 56);
            this.Express.Name = "Express";
            this.Express.Size = new System.Drawing.Size(202, 21);
            this.Express.TabIndex = 1;
            this.Express.TabStop = true;
            this.Express.Text = "Express Transport - $30.00";
            this.Express.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transportation Fee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.Total);
            this.panel3.Controls.Add(this.AcceptPayment);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(442, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 154);
            this.panel3.TabIndex = 4;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(311, 52);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(70, 25);
            this.Total.TabIndex = 2;
            this.Total.Text = "label5";
            // 
            // AcceptPayment
            // 
            this.AcceptPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.AcceptPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptPayment.Location = new System.Drawing.Point(21, 99);
            this.AcceptPayment.Name = "AcceptPayment";
            this.AcceptPayment.Size = new System.Drawing.Size(389, 38);
            this.AcceptPayment.TabIndex = 1;
            this.AcceptPayment.Text = "Accept Payment";
            this.AcceptPayment.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total: ";
            // 
            // YourCart
            // 
            this.YourCart.Image = global::TH02.Properties.Resources.Cart;
            this.YourCart.Location = new System.Drawing.Point(833, 8);
            this.YourCart.Name = "YourCart";
            this.YourCart.Size = new System.Drawing.Size(43, 44);
            this.YourCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YourCart.TabIndex = 3;
            this.YourCart.TabStop = false;
            this.YourCart.Click += new System.EventHandler(this.YourCart_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Express;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Twenty;
        private System.Windows.Forms.Button Fifthteen;
        private System.Windows.Forms.Button Ten;
        private System.Windows.Forms.Button AcceptPayment;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.PictureBox YourCart;
    }
}