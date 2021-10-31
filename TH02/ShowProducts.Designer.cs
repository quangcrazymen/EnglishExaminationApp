
namespace TH02
{
    partial class ShowProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProducts));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Fill = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.TextBox();
            this.panelPane = new System.Windows.Forms.Panel();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.panelPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(34, 153);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(795, 328);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpeg");
            this.imageList1.Images.SetKeyName(1, "2.jpeg");
            this.imageList1.Images.SetKeyName(2, "3.jpeg");
            // 
            // Fill
            // 
            this.Fill.Location = new System.Drawing.Point(528, 107);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(75, 23);
            this.Fill.TabIndex = 1;
            this.Fill.Text = "Fill";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(211, 22);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(100, 22);
            this.Test.TabIndex = 2;
            // 
            // panelPane
            // 
            this.panelPane.Controls.Add(this.TextBox1);
            this.panelPane.Controls.Add(this.listView1);
            this.panelPane.Controls.Add(this.Fill);
            this.panelPane.Controls.Add(this.Test);
            this.panelPane.Location = new System.Drawing.Point(2, 0);
            this.panelPane.Name = "panelPane";
            this.panelPane.Size = new System.Drawing.Size(887, 521);
            this.panelPane.TabIndex = 3;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(211, 85);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 22);
            this.TextBox1.TabIndex = 3;
            // 
            // ShowProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 524);
            this.Controls.Add(this.panelPane);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ShowProducts";
            this.Text = "ShowProducts";
            this.Load += new System.EventHandler(this.ShowProducts_Load);
            this.panelPane.ResumeLayout(false);
            this.panelPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.TextBox Test;
        private System.Windows.Forms.Panel panelPane;
        private System.Windows.Forms.TextBox TextBox1;
    }
}