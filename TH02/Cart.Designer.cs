
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
            this.CartClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YourCart = new System.Windows.Forms.PictureBox();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.CartClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.YourCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 58);
            this.panel1.TabIndex = 1;
            // 
            // CartClose
            // 
            this.CartClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CartClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CartClose.Location = new System.Drawing.Point(736, 15);
            this.CartClose.Name = "CartClose";
            this.CartClose.Size = new System.Drawing.Size(76, 31);
            this.CartClose.TabIndex = 5;
            this.CartClose.Text = "Close";
            this.CartClose.UseVisualStyleBackColor = false;
            this.CartClose.Click += new System.EventHandler(this.CartClose_Click);
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 64);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 448);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
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
            this.panel2.Location = new System.Drawing.Point(442, 108);
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
            this.Twenty.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Twenty.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Twenty.Location = new System.Drawing.Point(316, 178);
            this.Twenty.Name = "Twenty";
            this.Twenty.Size = new System.Drawing.Size(94, 66);
            this.Twenty.TabIndex = 5;
            this.Twenty.Text = "20% off";
            this.Twenty.UseVisualStyleBackColor = false;
            this.Twenty.Click += new System.EventHandler(this.Twenty_Click);
            // 
            // Fifthteen
            // 
            this.Fifthteen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Fifthteen.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fifthteen.Location = new System.Drawing.Point(176, 178);
            this.Fifthteen.Name = "Fifthteen";
            this.Fifthteen.Size = new System.Drawing.Size(94, 66);
            this.Fifthteen.TabIndex = 4;
            this.Fifthteen.Text = "15% off";
            this.Fifthteen.UseVisualStyleBackColor = false;
            this.Fifthteen.Click += new System.EventHandler(this.Fifthteen_Click);
            // 
            // Ten
            // 
            this.Ten.BackColor = System.Drawing.Color.SkyBlue;
            this.Ten.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(36, 178);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(94, 66);
            this.Ten.TabIndex = 3;
            this.Ten.Text = "10% off";
            this.Ten.UseVisualStyleBackColor = false;
            this.Ten.Click += new System.EventHandler(this.Ten_Click);
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Checked = true;
            this.Normal.Location = new System.Drawing.Point(24, 56);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(201, 21);
            this.Normal.TabIndex = 2;
            this.Normal.TabStop = true;
            this.Normal.Text = "Normal Transtport - $15.00";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.CheckedChanged += new System.EventHandler(this.Normal_CheckedChanged);
            // 
            // Express
            // 
            this.Express.AutoSize = true;
            this.Express.Location = new System.Drawing.Point(24, 93);
            this.Express.Name = "Express";
            this.Express.Size = new System.Drawing.Size(202, 21);
            this.Express.TabIndex = 1;
            this.Express.Text = "Express Transport - $30.00";
            this.Express.UseVisualStyleBackColor = true;
            this.Express.CheckedChanged += new System.EventHandler(this.Express_CheckedChanged);
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
            this.panel3.Location = new System.Drawing.Point(442, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 112);
            this.panel3.TabIndex = 4;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(311, 15);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(24, 25);
            this.Total.TabIndex = 2;
            this.Total.Text = "0";
            // 
            // AcceptPayment
            // 
            this.AcceptPayment.BackColor = System.Drawing.Color.DodgerBlue;
            this.AcceptPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptPayment.Location = new System.Drawing.Point(21, 65);
            this.AcceptPayment.Name = "AcceptPayment";
            this.AcceptPayment.Size = new System.Drawing.Size(389, 38);
            this.AcceptPayment.TabIndex = 1;
            this.AcceptPayment.Text = "Accept Payment";
            this.AcceptPayment.UseVisualStyleBackColor = false;
            this.AcceptPayment.Click += new System.EventHandler(this.AcceptPayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Quantity);
            this.panel4.Location = new System.Drawing.Point(442, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(438, 38);
            this.panel4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quantity: ";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(234, 9);
            this.Quantity.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(120, 22);
            this.Quantity.TabIndex = 2;
            this.Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YourCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.Button CartClose;
    }
}