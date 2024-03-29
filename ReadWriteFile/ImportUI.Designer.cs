﻿
namespace ReadWriteFile
{
    partial class ImportUI
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
            this.QuestionDisplay = new System.Windows.Forms.RichTextBox();
            this.AnswerDisplay = new System.Windows.Forms.RichTextBox();
            this.Import = new System.Windows.Forms.PictureBox();
            this.Key = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionDisplay
            // 
            this.QuestionDisplay.Location = new System.Drawing.Point(112, 12);
            this.QuestionDisplay.Name = "QuestionDisplay";
            this.QuestionDisplay.Size = new System.Drawing.Size(489, 307);
            this.QuestionDisplay.TabIndex = 1;
            this.QuestionDisplay.Text = "";
            // 
            // AnswerDisplay
            // 
            this.AnswerDisplay.Location = new System.Drawing.Point(112, 325);
            this.AnswerDisplay.Name = "AnswerDisplay";
            this.AnswerDisplay.Size = new System.Drawing.Size(489, 184);
            this.AnswerDisplay.TabIndex = 3;
            this.AnswerDisplay.Text = "";
            // 
            // Import
            // 
            this.Import.Image = global::ReadWriteFile.Properties.Resources.ImportQuestion;
            this.Import.Location = new System.Drawing.Point(12, 12);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(94, 96);
            this.Import.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Import.TabIndex = 4;
            this.Import.TabStop = false;
            this.Import.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Key
            // 
            this.Key.Image = global::ReadWriteFile.Properties.Resources.ImportKey;
            this.Key.Location = new System.Drawing.Point(12, 325);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(94, 96);
            this.Key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Key.TabIndex = 5;
            this.Key.TabStop = false;
            this.Key.Click += new System.EventHandler(this.Key_Click);
            // 
            // ImportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 521);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.AnswerDisplay);
            this.Controls.Add(this.QuestionDisplay);
            this.Name = "ImportUI";
            this.Text = "ImportUI";
            ((System.ComponentModel.ISupportInitialize)(this.Import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Key)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox QuestionDisplay;
        private System.Windows.Forms.RichTextBox AnswerDisplay;
        private System.Windows.Forms.PictureBox Import;
        private System.Windows.Forms.PictureBox Key;
    }
}