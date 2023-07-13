using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace practic_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void unzipArchive(string pathToFolder, string pathToZip) 
        {
            ZipFile.ExtractToDirectory(pathToZip, pathToFolder);
            MessageBox.Show("Archive unziped sucsessful.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static void createArchive(string pathToFolder, string pathToSaveZip)
        {
            ZipFile.CreateFromDirectory(pathToFolder, pathToSaveZip, CompressionLevel.Fastest, false);
            MessageBox.Show("Archive created sucsessful.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createArchiveButton_Click(object sender, EventArgs e)
        {
            if (!zip.Checked)
            {
                if (folderPath.Text.Length == 0 && zipPath.Text.Length == 0)
                {
                    MessageBox.Show("Select folder for unzip archive and path where saved zip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (folderPath.Text.Length == 0)
                {
                    MessageBox.Show("Select folder for unzip archive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (zipPath.Text.Length == 0)
                {
                    MessageBox.Show("Select path where saved zip. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                unzipArchive(folderPath.Text, zipPath.Text);
            }
            else
            {
                if (folderPath.Text.Length == 0 && zipPath.Text.Length == 0 && archiveName.Text.Length == 0)
                {
                    MessageBox.Show("Select folder for create archive, archive name and path where save zip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (folderPath.Text.Length == 0 && zipPath.Text.Length == 0)
                {
                    MessageBox.Show("Select folder for create archive and path where save zip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (folderPath.Text.Length == 0)
                {
                    MessageBox.Show("Select folder for create archive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (zipPath.Text.Length == 0)
                {
                    MessageBox.Show("Select path where save zip. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (archiveName.Text.Length == 0)
                {
                    MessageBox.Show("Write archive name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string fullZipPath = zipPath.Text + "\\" + archiveName.Text + ".zip";
                createArchive(folderPath.Text, fullZipPath);
            }
        }

        
        private void choseFolderToSaveArchive_Click(object sender, EventArgs e)
        {
            if (!zip.Checked)
            {
                using (var opnDlg = new OpenFileDialog())
                {
                    opnDlg.Filter = "ZIP file | *.zip";
                    if (opnDlg.ShowDialog() == DialogResult.OK)
                        zipPath.Text = opnDlg.FileName;
                }
            }
            else
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select a folder";
                    if (dlg.ShowDialog() == DialogResult.OK)
                        zipPath.Text = dlg.SelectedPath;

                }
            }
        }

        private void choseFolderForArchive_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select a folder";
                if (dlg.ShowDialog() == DialogResult.OK)
                    folderPath.Text = dlg.SelectedPath;

            }
        }

        private void zip_CheckedChanged(object sender, EventArgs e)
        {
            if (!zip.Checked)
            {
                archiveName.Visible = false;
                archiveNameLabel.Visible = false;
                createArchiveButton.Text = "Unzip archive";
            }
            else
            {
                archiveName.Visible = true;
                archiveNameLabel.Visible = true;
                createArchiveButton.Text = "Create ZIP";
            }
        }
    }
}
