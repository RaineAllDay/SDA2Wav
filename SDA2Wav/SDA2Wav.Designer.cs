namespace SDA2Wav
{
    partial class SDA2Wav
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFolder = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // selectFolder
            // 
            this.selectFolder.Location = new System.Drawing.Point(12, 12);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(165, 29);
            this.selectFolder.TabIndex = 0;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(195, 12);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(165, 29);
            this.selectFile.TabIndex = 1;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(15, 49);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(165, 20);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "No File/Folder Selected";
            // 
            // convertButton
            // 
            this.convertButton.Enabled = false;
            this.convertButton.Location = new System.Drawing.Point(15, 88);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(223, 29);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Select File/Folder";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLog
            // 
            this.outputLog.FormattingEnabled = true;
            this.outputLog.HorizontalScrollbar = true;
            this.outputLog.ItemHeight = 20;
            this.outputLog.Location = new System.Drawing.Point(22, 129);
            this.outputLog.Name = "outputLog";
            this.outputLog.Size = new System.Drawing.Size(585, 164);
            this.outputLog.TabIndex = 4;
            // 
            // SDA2Wav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 310);
            this.Controls.Add(this.outputLog);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.selectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SDA2Wav";
            this.Text = "SDA2Wav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectFolder;
        private Button selectFile;
        private Label filePathLabel;
        private Button convertButton;
        private ListBox outputLog;
    }
}