
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Import = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Question = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.A = new System.Windows.Forms.RadioButton();
            this.QuestionDisplay = new System.Windows.Forms.RichTextBox();
            this.AnswerDisplay = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.Question);
            this.panel2.Controls.Add(this.C);
            this.panel2.Controls.Add(this.B);
            this.panel2.Controls.Add(this.D);
            this.panel2.Controls.Add(this.A);
            this.panel2.Controls.Add(this.QuestionDisplay);
            this.panel2.Controls.Add(this.AnswerDisplay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 568);
            this.panel2.TabIndex = 2;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(92, 65);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(46, 17);
            this.Question.TabIndex = 7;
            this.Question.Text = "label1";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(129, 233);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(110, 21);
            this.C.TabIndex = 6;
            this.C.TabStop = true;
            this.C.Text = "radioButton4";
            this.C.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(326, 147);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(110, 21);
            this.B.TabIndex = 5;
            this.B.TabStop = true;
            this.B.Text = "radioButton3";
            this.B.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(326, 233);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(110, 21);
            this.D.TabIndex = 4;
            this.D.TabStop = true;
            this.D.Text = "radioButton2";
            this.D.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(129, 147);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(110, 21);
            this.A.TabIndex = 3;
            this.A.TabStop = true;
            this.A.Text = "radioButton1";
            this.A.UseVisualStyleBackColor = true;
            // 
            // QuestionDisplay
            // 
            this.QuestionDisplay.Location = new System.Drawing.Point(25, 349);
            this.QuestionDisplay.Name = "QuestionDisplay";
            this.QuestionDisplay.Size = new System.Drawing.Size(257, 198);
            this.QuestionDisplay.TabIndex = 0;
            this.QuestionDisplay.Text = "";
            // 
            // AnswerDisplay
            // 
            this.AnswerDisplay.Location = new System.Drawing.Point(288, 349);
            this.AnswerDisplay.Name = "AnswerDisplay";
            this.AnswerDisplay.Size = new System.Drawing.Size(331, 187);
            this.AnswerDisplay.TabIndex = 2;
            this.AnswerDisplay.Text = "";
            // 
            // Exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Exam";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox QuestionDisplay;
        private System.Windows.Forms.RichTextBox AnswerDisplay;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.Label Question;
    }
}

