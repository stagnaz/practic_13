
namespace practic_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.choseFolderForArchive = new System.Windows.Forms.Button();
            this.choseFolderToSaveArchive = new System.Windows.Forms.Button();
            this.createArchiveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.RadioButton();
            this.unzip = new System.Windows.Forms.RadioButton();
            this.folderPath = new System.Windows.Forms.Label();
            this.zipPath = new System.Windows.Forms.Label();
            this.archiveName = new System.Windows.Forms.TextBox();
            this.archiveNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choseFolderForArchive
            // 
            this.choseFolderForArchive.Location = new System.Drawing.Point(418, 38);
            this.choseFolderForArchive.Name = "choseFolderForArchive";
            this.choseFolderForArchive.Size = new System.Drawing.Size(75, 23);
            this.choseFolderForArchive.TabIndex = 0;
            this.choseFolderForArchive.Text = "Path to folder";
            this.choseFolderForArchive.UseVisualStyleBackColor = true;
            this.choseFolderForArchive.Click += new System.EventHandler(this.choseFolderForArchive_Click);
            // 
            // choseFolderToSaveArchive
            // 
            this.choseFolderToSaveArchive.Location = new System.Drawing.Point(418, 88);
            this.choseFolderToSaveArchive.Name = "choseFolderToSaveArchive";
            this.choseFolderToSaveArchive.Size = new System.Drawing.Size(75, 23);
            this.choseFolderToSaveArchive.TabIndex = 1;
            this.choseFolderToSaveArchive.Text = "ZIP path";
            this.choseFolderToSaveArchive.UseVisualStyleBackColor = true;
            this.choseFolderToSaveArchive.Click += new System.EventHandler(this.choseFolderToSaveArchive_Click);
            // 
            // createArchiveButton
            // 
            this.createArchiveButton.Location = new System.Drawing.Point(318, 171);
            this.createArchiveButton.Name = "createArchiveButton";
            this.createArchiveButton.Size = new System.Drawing.Size(175, 23);
            this.createArchiveButton.TabIndex = 2;
            this.createArchiveButton.Text = "Create ZIP";
            this.createArchiveButton.UseVisualStyleBackColor = true;
            this.createArchiveButton.Click += new System.EventHandler(this.createArchiveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path to folder...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path to ZIP...";
            // 
            // zip
            // 
            this.zip.AutoSize = true;
            this.zip.Checked = true;
            this.zip.Location = new System.Drawing.Point(31, 177);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(74, 17);
            this.zip.TabIndex = 5;
            this.zip.TabStop = true;
            this.zip.Text = "Create Zip";
            this.zip.UseVisualStyleBackColor = true;
            this.zip.CheckedChanged += new System.EventHandler(this.zip_CheckedChanged);
            // 
            // unzip
            // 
            this.unzip.AutoSize = true;
            this.unzip.Location = new System.Drawing.Point(133, 177);
            this.unzip.Name = "unzip";
            this.unzip.Size = new System.Drawing.Size(90, 17);
            this.unzip.TabIndex = 7;
            this.unzip.Text = "Unzip archive";
            this.unzip.UseVisualStyleBackColor = true;
            // 
            // folderPath
            // 
            this.folderPath.AutoSize = true;
            this.folderPath.Location = new System.Drawing.Point(33, 48);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(0, 13);
            this.folderPath.TabIndex = 8;
            // 
            // zipPath
            // 
            this.zipPath.AutoSize = true;
            this.zipPath.Location = new System.Drawing.Point(31, 105);
            this.zipPath.Name = "zipPath";
            this.zipPath.Size = new System.Drawing.Size(0, 13);
            this.zipPath.TabIndex = 9;
            // 
            // archiveName
            // 
            this.archiveName.Location = new System.Drawing.Point(31, 121);
            this.archiveName.Name = "archiveName";
            this.archiveName.Size = new System.Drawing.Size(187, 20);
            this.archiveName.TabIndex = 10;
            // 
            // archiveNameLabel
            // 
            this.archiveNameLabel.AutoSize = true;
            this.archiveNameLabel.Location = new System.Drawing.Point(258, 124);
            this.archiveNameLabel.Name = "archiveNameLabel";
            this.archiveNameLabel.Size = new System.Drawing.Size(131, 13);
            this.archiveNameLabel.TabIndex = 11;
            this.archiveNameLabel.Text = "Archive name(without .zip)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 206);
            this.Controls.Add(this.archiveNameLabel);
            this.Controls.Add(this.archiveName);
            this.Controls.Add(this.zipPath);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.unzip);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createArchiveButton);
            this.Controls.Add(this.choseFolderToSaveArchive);
            this.Controls.Add(this.choseFolderForArchive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choseFolderForArchive;
        private System.Windows.Forms.Button choseFolderToSaveArchive;
        private System.Windows.Forms.Button createArchiveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton zip;
        private System.Windows.Forms.RadioButton unzip;
        private System.Windows.Forms.Label folderPath;
        private System.Windows.Forms.Label zipPath;
        private System.Windows.Forms.TextBox archiveName;
        private System.Windows.Forms.Label archiveNameLabel;
    }
}

