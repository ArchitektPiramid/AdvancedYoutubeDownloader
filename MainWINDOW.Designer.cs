﻿namespace AdvancedYoutubeDownloader
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtBoxLog = new System.Windows.Forms.RichTextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxRes = new System.Windows.Forms.ComboBox();
            this.btnCheckURL = new System.Windows.Forms.Button();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL link:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(165, 53);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(300, 22);
            this.txtURL.TabIndex = 2;
            this.txtURL.Text = "ENTER LINK HERE";
            this.txtURL.Click += new System.EventHandler(this.txtURL_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(171, 172);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(235, 22);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "enter Path";
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.Location = new System.Drawing.Point(171, 399);
            this.txtBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxLog.Name = "txtBoxLog";
            this.txtBoxLog.Size = new System.Drawing.Size(617, 101);
            this.txtBoxLog.TabIndex = 4;
            this.txtBoxLog.Text = "";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(171, 245);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(159, 46);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Resolution";
            // 
            // comBoxRes
            // 
            this.comBoxRes.FormattingEnabled = true;
            this.comBoxRes.Location = new System.Drawing.Point(165, 97);
            this.comBoxRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comBoxRes.Name = "comBoxRes";
            this.comBoxRes.Size = new System.Drawing.Size(160, 24);
            this.comBoxRes.TabIndex = 7;
            // 
            // btnCheckURL
            // 
            this.btnCheckURL.Location = new System.Drawing.Point(473, 43);
            this.btnCheckURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckURL.Name = "btnCheckURL";
            this.btnCheckURL.Size = new System.Drawing.Size(130, 44);
            this.btnCheckURL.TabIndex = 8;
            this.btnCheckURL.Text = "Check URL";
            this.btnCheckURL.UseVisualStyleBackColor = true;
            this.btnCheckURL.Click += new System.EventHandler(this.btnCheckURL_Click);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(171, 314);
            this.progBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(619, 28);
            this.progBar.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 538);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.btnCheckURL);
            this.Controls.Add(this.comBoxRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtBoxLog);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Advanced Youtube to MP3 downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.RichTextBox txtBoxLog;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoxRes;
        private System.Windows.Forms.Button btnCheckURL;
        private System.Windows.Forms.ProgressBar progBar;
    }
}

