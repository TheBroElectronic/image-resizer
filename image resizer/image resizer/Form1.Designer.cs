namespace image_resizer
{
    partial class Form1
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.X = new System.Windows.Forms.TextBox();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.folderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.SystemColors.HotTrack;
            this.X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X.Location = new System.Drawing.Point(188, 76);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 20);
            this.X.TabIndex = 1;
            // 
            // resizeBtn
            // 
            this.resizeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.resizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeBtn.Location = new System.Drawing.Point(128, 118);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(160, 51);
            this.resizeBtn.TabIndex = 3;
            this.resizeBtn.Text = "Resize";
            this.resizeBtn.UseVisualStyleBackColor = false;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // folderBtn
            // 
            this.folderBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.folderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.folderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderBtn.Location = new System.Drawing.Point(160, 12);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(75, 23);
            this.folderBtn.TabIndex = 4;
            this.folderBtn.Text = "Folder";
            this.folderBtn.UseVisualStyleBackColor = false;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(124, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "max size";
            // 
            // FolderDir
            // 
            this.FolderDir.AutoSize = true;
            this.FolderDir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FolderDir.Location = new System.Drawing.Point(12, 52);
            this.FolderDir.Name = "FolderDir";
            this.FolderDir.Size = new System.Drawing.Size(28, 13);
            this.FolderDir.TabIndex = 7;
            this.FolderDir.Text = "-------";
            this.FolderDir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(417, 181);
            this.Controls.Add(this.FolderDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.resizeBtn);
            this.Controls.Add(this.X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "image resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FolderDir;
    }
}

