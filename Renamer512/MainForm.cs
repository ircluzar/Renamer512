using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Renamer512
{
    public partial class MainForm : Form
    {

        int nbOperationsTotal = 0;
        int nbOperationsDone = 0;
        int percentage = 0;
        string targetDir;
        int nbFiles;
        string[] allFiles;
        List<Control> lockableControls = new List<Control>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

            if (tbTarget.Text == "")
            {
                MessageBox.Show("You must select a folder for the operations");
                return;
            }

            if(!Directory.Exists(tbTarget.Text))
            {
                MessageBox.Show("The selected folder path is invalid");
                return;
            }

            targetDir = tbTarget.Text;
            nbFiles = getFilesFiltered(targetDir).Length;

            if(nbFiles == 0)
            {
                MessageBox.Show("The folder doesn't contain any files for the operations");
                return;
            }

            nbOperationsTotal = 0;
            nbOperationsDone = 0;

            if (cbRandomizeFiles.Checked)
                nbOperationsTotal += nbFiles;

            if (cbFileNumbering.Checked)
                nbOperationsTotal += nbFiles;

            if (cbSplitFiles.Checked)
                nbOperationsTotal += nbFiles;

            lockControls();

            bgWorker.RunWorkerAsync();

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbTarget.Text = fbd.SelectedPath;
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            #region Randomize Files

            allFiles = getFilesFiltered(targetDir);

            if (cbRandomizeFiles.Checked)
            {

                foreach (string currentFile in allFiles)
                {

                    Guid filenameGuid = Guid.NewGuid();

                    string nakedGuid = filenameGuid.ToString().Replace("{", "").Replace("}", "").Replace("-", "");
                    string extension = currentFile.Substring(currentFile.LastIndexOf(@"."));
                    try
                    {
                        File.Move(currentFile, targetDir + @"\" + nakedGuid + extension);
                    }
                    catch
                    {
                        new Object();
                    }
                    operationDone();
                }

            }
            #endregion

            #region File numbering

            allFiles = getFilesFiltered(targetDir);

            if (cbFileNumbering.Checked)
            {

                for (int i = 0; i < allFiles.Length; i++)
                {
                    string currentFile = allFiles[i];
                    string filenamePrefix = tbRenamePrefix.Text;
                    string filenameSuffix = paddingFromQuantityAndNumber(allFiles.Length, i);
                    string fileExtension = currentFile.Substring(currentFile.LastIndexOf(@"."));

                    try
                    {
                        File.Move(currentFile, targetDir + @"\" + filenamePrefix + filenameSuffix + fileExtension);
                    }
                    catch
                    {
                        new Object();
                    }
                    operationDone();
                }

            }
            #endregion

            #region Sub-Folder Organizing


            allFiles = getFilesFiltered(targetDir);

            if (cbSplitFiles.Checked)
            {

                int nbSplitFiles = Convert.ToInt32(nbNumberFilesSplit.Value);
                int nbFolders = (allFiles.Length / nbSplitFiles) + 1;

                for (int i = 0; i < nbFolders; i++)
                {
                    string folderNamePrefix = tbFolderPrefix.Text;
                    string folderNameSuffix = paddingFromQuantityAndNumber(nbFolders, i);
                    string fullFolderName = tbFolderPrefix.Text + folderNameSuffix;

                    if (Directory.Exists(targetDir + @"\" + fullFolderName))
                        DeleteDirectory(targetDir + @"\" + fullFolderName);

                    Directory.CreateDirectory(targetDir + @"\" + fullFolderName);

                    for (int j = 0; j < nbSplitFiles; j++)
                    {
                        if ((i * nbSplitFiles) + j >= allFiles.Length && j == 0)
                            Directory.Delete(targetDir + @"\" + fullFolderName);

                        if ((i * nbSplitFiles) + j >= allFiles.Length)
                            break;

                        try
                        {

                            string currentFile = allFiles[(i * nbSplitFiles) + j];
                            string filename = currentFile.Substring(currentFile.LastIndexOf(@"\") + 1);
                            File.Move(currentFile, targetDir + @"\" + fullFolderName + @"\" + filename);
                        }
                        catch (Exception ex)
                        {
                            new Object();
                        }
                        operationDone();
                    }
                }

            }

            #endregion
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            unlockControls();
            MessageBox.Show("All done !");
            progressBar.Value = 0;
        }

        private void operationDone()
        {
            nbOperationsDone++;
            percentage = (nbOperationsDone + 1) * 100 / (nbOperationsTotal + 1);
            bgWorker.ReportProgress(percentage);
        }

        private void lockControls()
        {
            foreach (Control ctrl in lockableControls)
                ctrl.Enabled = false;
        }

        private void unlockControls()
        {
            foreach (Control ctrl in lockableControls)
                ctrl.Enabled = true;
        }

        private string[] getFilesFiltered(string input)
        {
            string[] files = Directory.GetFiles(input);


            List<string> filteredFiles = new List<string>();

            foreach (string item in files)
            {
                if (item.EndsWith(".db"))
                    continue;

                filteredFiles.Add(item);

            }

            return filteredFiles.ToArray();

        }

        private string paddingFromQuantityAndNumber(int quantity, int number)
        {
            int length;

            // MINIMUM 2 CHAR
            if (quantity < 10)
                length = 2;
            else if (quantity < 100)
                length = 2;
            else if (quantity < 1000)
                length = 3;
            else if (quantity < 10000)
                length = 4;
            else if (quantity < 100000)
                length = 5;
            else if (quantity < 1000000)
                length = 7;
            else if (quantity < 10000000)
                length = 8;
            else if (quantity < 100000000)
                length = 9;
            else
                length = 10;

            return (number + 1).ToString().PadLeft(length, '0');

        }

        private static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lockableControls.Add(btnExecute);
            lockableControls.Add(tbTarget);
            lockableControls.Add(btnBrowse);
            lockableControls.Add(cbRandomizeFiles);
            lockableControls.Add(cbFileNumbering);
            lockableControls.Add(tbRenamePrefix);
            lockableControls.Add(cbSplitFiles);
            lockableControls.Add(nbNumberFilesSplit);
            lockableControls.Add(tbFolderPrefix);
        }
    }
}
