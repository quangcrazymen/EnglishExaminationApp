
namespace Examination
{
    partial class Exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Import = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPane = new System.Windows.Forms.Panel();
            this.False = new System.Windows.Forms.Label();
            this.True = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.NextBtn = new System.Windows.Forms.PictureBox();
            this.ResultBoard = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ResultPanel = new System.Windows.Forms.ListView();
            this.Question = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.A = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examination.Properties.Resources.Exam;
            this.pictureBox1.Location = new System.Drawing.Point(60, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Import
            // 
            this.Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Import.Image = global::Examination.Properties.Resources.Import;
            this.Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Import.Location = new System.Drawing.Point(0, 193);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(210, 61);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Test
            // 
            this.Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Test.Image = global::Examination.Properties.Resources.Test;
            this.Test.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Test.Location = new System.Drawing.Point(0, 260);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(210, 65);
            this.Test.TabIndex = 2;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Goldenrod;
            this.Close.Image = global::Examination.Properties.Resources.Close;
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.Location = new System.Drawing.Point(0, 430);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(210, 72);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Test);
            this.panel1.Controls.Add(this.Import);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 568);
            this.panel1.TabIndex = 1;
            // 
            // panelPane
            // 
            this.panelPane.Controls.Add(this.False);
            this.panelPane.Controls.Add(this.True);
            this.panelPane.Controls.Add(this.BackBtn);
            this.panelPane.Controls.Add(this.NextBtn);
            this.panelPane.Controls.Add(this.ResultBoard);
            this.panelPane.Controls.Add(this.pictureBox3);
            this.panelPane.Controls.Add(this.ResultPanel);
            this.panelPane.Controls.Add(this.Question);
            this.panelPane.Controls.Add(this.C);
            this.panelPane.Controls.Add(this.B);
            this.panelPane.Controls.Add(this.D);
            this.panelPane.Controls.Add(this.A);
            this.panelPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPane.Location = new System.Drawing.Point(210, 0);
            this.panelPane.Name = "panelPane";
            this.panelPane.Size = new System.Drawing.Size(713, 568);
            this.panelPane.TabIndex = 2;
            // 
            // False
            // 
            this.False.AutoSize = true;
            this.False.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.False.ForeColor = System.Drawing.Color.Crimson;
            this.False.Location = new System.Drawing.Point(127, 533);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(68, 18);
            this.False.TabIndex = 16;
            this.False.Text = "False: 0";
            // 
            // True
            // 
            this.True.AutoSize = true;
            this.True.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.True.ForeColor = System.Drawing.Color.Blue;
            this.True.Location = new System.Drawing.Point(33, 533);
            this.True.Name = "True";
            this.True.Size = new System.Drawing.Size(61, 18);
            this.True.TabIndex = 15;
            this.True.Text = "True: 0";
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::Examination.Properties.Resources.Back;
            this.BackBtn.Location = new System.Drawing.Point(88, 243);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 85);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 14;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Image = global::Examination.Properties.Resources.Next;
            this.NextBtn.Location = new System.Drawing.Point(535, 243);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(101, 68);
            this.NextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextBtn.TabIndex = 13;
            this.NextBtn.TabStop = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // ResultBoard
            // 
            this.ResultBoard.BackColor = System.Drawing.Color.MediumBlue;
            this.ResultBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBoard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultBoard.Image = global::Examination.Properties.Resources.Result;
            this.ResultBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResultBoard.Location = new System.Drawing.Point(273, 260);
            this.ResultBoard.Name = "ResultBoard";
            this.ResultBoard.Size = new System.Drawing.Size(193, 68);
            this.ResultBoard.TabIndex = 12;
            this.ResultBoard.Text = "Result Board";
            this.ResultBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResultBoard.UseVisualStyleBackColor = false;
            this.ResultBoard.Click += new System.EventHandler(this.ResultBoard_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Examination.Properties.Resources.Question;
            this.pictureBox3.Location = new System.Drawing.Point(23, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // ResultPanel
            // 
            this.ResultPanel.HideSelection = false;
            this.ResultPanel.Location = new System.Drawing.Point(35, 334);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(649, 182);
            this.ResultPanel.TabIndex = 9;
            this.ResultPanel.UseCompatibleStateImageBehavior = false;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Question.Location = new System.Drawing.Point(126, 24);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(76, 18);
            this.Question.TabIndex = 7;
            this.Question.Text = "Question";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(138, 179);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(38, 21);
            this.C.TabIndex = 6;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.CheckedChanged += new System.EventHandler(this.C_CheckedChanged);
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(419, 106);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(38, 21);
            this.B.TabIndex = 5;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.CheckedChanged += new System.EventHandler(this.B_CheckedChanged);
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(418, 179);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(39, 21);
            this.D.TabIndex = 4;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.CheckedChanged += new System.EventHandler(this.D_CheckedChanged);
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Checked = true;
            this.A.Location = new System.Drawing.Point(138, 106);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(38, 21);
            this.A.TabIndex = 3;
            this.A.TabStop = true;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.CheckedChanged += new System.EventHandler(this.A_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "False.png");
            this.imageList1.Images.SetKeyName(1, "True.png");
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 568);
            this.Controls.Add(this.panelPane);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exam";
            this.ShowIcon = false;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelPane.ResumeLayout(false);
            this.panelPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Panel panelPane;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView ResultPanel;
        private System.Windows.Forms.Button ResultBoard;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.PictureBox NextBtn;
        private System.Windows.Forms.Label False;
        private System.Windows.Forms.Label True;
        private System.Windows.Forms.ImageList imageList1;
    }
}

