﻿namespace WindowsFormsApplication1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.StartButton = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.InputEncodingDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FileTypeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScanSubfolderCheckbox = new System.Windows.Forms.CheckBox();
            this.OutputEncodingDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveOutputDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.NulTerminatedFixCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BgWorker
            // 
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkerClean_DoWork);
            this.BgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(70, 280);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 32);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FolderBrowser.ShowNewFolderButton = false;
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoEllipsis = true;
            this.FilenameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilenameLabel.Location = new System.Drawing.Point(12, 322);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(260, 15);
            this.FilenameLabel.TabIndex = 6;
            this.FilenameLabel.Text = "Waiting to process texts...";
            this.FilenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputEncodingDropdown
            // 
            this.InputEncodingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputEncodingDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputEncodingDropdown.FormattingEnabled = true;
            this.InputEncodingDropdown.Location = new System.Drawing.Point(6, 53);
            this.InputEncodingDropdown.Name = "InputEncodingDropdown";
            this.InputEncodingDropdown.Size = new System.Drawing.Size(248, 23);
            this.InputEncodingDropdown.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Input File Encoding:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NulTerminatedFixCheckbox);
            this.groupBox2.Controls.Add(this.FileTypeTextbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ScanSubfolderCheckbox);
            this.groupBox2.Controls.Add(this.OutputEncodingDropdown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.InputEncodingDropdown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 249);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encoding Selection";
            // 
            // FileTypeTextbox
            // 
            this.FileTypeTextbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTypeTextbox.Location = new System.Drawing.Point(6, 162);
            this.FileTypeTextbox.Name = "FileTypeTextbox";
            this.FileTypeTextbox.Size = new System.Drawing.Size(100, 26);
            this.FileTypeTextbox.TabIndex = 16;
            this.FileTypeTextbox.Text = "*.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Input File Type:";
            // 
            // ScanSubfolderCheckbox
            // 
            this.ScanSubfolderCheckbox.AutoSize = true;
            this.ScanSubfolderCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanSubfolderCheckbox.Location = new System.Drawing.Point(128, 166);
            this.ScanSubfolderCheckbox.Name = "ScanSubfolderCheckbox";
            this.ScanSubfolderCheckbox.Size = new System.Drawing.Size(126, 20);
            this.ScanSubfolderCheckbox.TabIndex = 13;
            this.ScanSubfolderCheckbox.Text = "Scan Subfolders";
            this.ScanSubfolderCheckbox.UseVisualStyleBackColor = true;
            // 
            // OutputEncodingDropdown
            // 
            this.OutputEncodingDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputEncodingDropdown.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputEncodingDropdown.FormattingEnabled = true;
            this.OutputEncodingDropdown.Location = new System.Drawing.Point(6, 106);
            this.OutputEncodingDropdown.Name = "OutputEncodingDropdown";
            this.OutputEncodingDropdown.Size = new System.Drawing.Size(248, 23);
            this.OutputEncodingDropdown.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Output File Encoding:";
            // 
            // NulTerminatedFixCheckbox
            // 
            this.NulTerminatedFixCheckbox.AutoSize = true;
            this.NulTerminatedFixCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NulTerminatedFixCheckbox.Location = new System.Drawing.Point(6, 210);
            this.NulTerminatedFixCheckbox.Name = "NulTerminatedFixCheckbox";
            this.NulTerminatedFixCheckbox.Size = new System.Drawing.Size(201, 20);
            this.NulTerminatedFixCheckbox.TabIndex = 17;
            this.NulTerminatedFixCheckbox.Text = "Fix Null Termination in Strings";
            this.NulTerminatedFixCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(284, 346);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.StartButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 385);
            this.MinimumSize = new System.Drawing.Size(300, 385);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranscodeTXT";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BgWorker;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.ComboBox InputEncodingDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog saveOutputDialog;
        private System.Windows.Forms.ComboBox OutputEncodingDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ScanSubfolderCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileTypeTextbox;
        private System.Windows.Forms.CheckBox NulTerminatedFixCheckbox;
    }
}

