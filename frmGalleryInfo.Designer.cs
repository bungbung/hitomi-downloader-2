﻿namespace Hitomi_Copy
{
    partial class frmGalleryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGalleryInfo));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lArtist = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lSeries = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(360, 446);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.lTitle.Location = new System.Drawing.Point(504, 37);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(52, 28);
            this.lTitle.TabIndex = 7;
            this.lTitle.Text = "제목";
            // 
            // lArtist
            // 
            this.lArtist.AutoSize = true;
            this.lArtist.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.lArtist.Location = new System.Drawing.Point(504, 65);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(48, 25);
            this.lArtist.TabIndex = 8;
            this.lArtist.Text = "작가";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.textBox1.Location = new System.Drawing.Point(509, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(674, 152);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGalleryInfo_KeyDown);
            // 
            // lSeries
            // 
            this.lSeries.AutoSize = true;
            this.lSeries.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.lSeries.Location = new System.Drawing.Point(504, 90);
            this.lSeries.Name = "lSeries";
            this.lSeries.Size = new System.Drawing.Size(66, 25);
            this.lSeries.TabIndex = 10;
            this.lSeries.Text = "시리즈";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.label2.Location = new System.Drawing.Point(428, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "제목 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.label3.Location = new System.Drawing.Point(434, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "작가 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.label4.Location = new System.Drawing.Point(416, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "시리즈 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.label5.Location = new System.Drawing.Point(434, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "태그 : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.button1.Location = new System.Drawing.Point(851, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "작가 찾기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.button2.Location = new System.Drawing.Point(682, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 41);
            this.button2.TabIndex = 16;
            this.button2.Text = "시리즈 찾기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.button3.Location = new System.Drawing.Point(1020, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "다운로드";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmGalleryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1286, 470);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lSeries);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lArtist);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pbImage);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGalleryInfo";
            this.Text = "정보";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGalleryInfo_FormClosed);
            this.Load += new System.EventHandler(this.frmGalleryInfo_LoadAsync);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGalleryInfo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}