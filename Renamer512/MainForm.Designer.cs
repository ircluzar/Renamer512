namespace Renamer512
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSplitFiles = new System.Windows.Forms.CheckBox();
            this.cbRandomizeFiles = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nbNumberFilesSplit = new System.Windows.Forms.NumericUpDown();
            this.tbFolderPrefix = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFileNumbering = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRenamePrefix = new System.Windows.Forms.TextBox();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumberFilesSplit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 269);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(222, 38);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Files per folder:";
            // 
            // cbSplitFiles
            // 
            this.cbSplitFiles.AutoSize = true;
            this.cbSplitFiles.Location = new System.Drawing.Point(14, 19);
            this.cbSplitFiles.Name = "cbSplitFiles";
            this.cbSplitFiles.Size = new System.Drawing.Size(190, 17);
            this.cbSplitFiles.TabIndex = 3;
            this.cbSplitFiles.Text = "Reorganize files in separate folders";
            this.cbSplitFiles.UseVisualStyleBackColor = true;
            // 
            // cbRandomizeFiles
            // 
            this.cbRandomizeFiles.AutoSize = true;
            this.cbRandomizeFiles.Location = new System.Drawing.Point(26, 57);
            this.cbRandomizeFiles.Name = "cbRandomizeFiles";
            this.cbRandomizeFiles.Size = new System.Drawing.Size(100, 17);
            this.cbRandomizeFiles.TabIndex = 4;
            this.cbRandomizeFiles.Text = "Randomize files";
            this.cbRandomizeFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nbNumberFilesSplit);
            this.groupBox1.Controls.Add(this.tbFolderPrefix);
            this.groupBox1.Controls.Add(this.cbSplitFiles);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sub-folder organizing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prefix:";
            // 
            // nbNumberFilesSplit
            // 
            this.nbNumberFilesSplit.Location = new System.Drawing.Point(94, 42);
            this.nbNumberFilesSplit.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nbNumberFilesSplit.Name = "nbNumberFilesSplit";
            this.nbNumberFilesSplit.Size = new System.Drawing.Size(64, 20);
            this.nbNumberFilesSplit.TabIndex = 4;
            this.nbNumberFilesSplit.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // tbFolderPrefix
            // 
            this.tbFolderPrefix.Location = new System.Drawing.Point(53, 68);
            this.tbFolderPrefix.Name = "tbFolderPrefix";
            this.tbFolderPrefix.Size = new System.Drawing.Size(149, 20);
            this.tbFolderPrefix.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFileNumbering);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbRenamePrefix);
            this.groupBox2.Location = new System.Drawing.Point(14, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 75);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filename organizing";
            // 
            // cbFileNumbering
            // 
            this.cbFileNumbering.AutoSize = true;
            this.cbFileNumbering.Location = new System.Drawing.Point(12, 19);
            this.cbFileNumbering.Name = "cbFileNumbering";
            this.cbFileNumbering.Size = new System.Drawing.Size(197, 17);
            this.cbFileNumbering.TabIndex = 10;
            this.cbFileNumbering.Text = "Rename files with a numbering order";
            this.cbFileNumbering.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prefix:";
            // 
            // tbRenamePrefix
            // 
            this.tbRenamePrefix.Location = new System.Drawing.Point(51, 42);
            this.tbRenamePrefix.Name = "tbRenamePrefix";
            this.tbRenamePrefix.Size = new System.Drawing.Size(149, 20);
            this.tbRenamePrefix.TabIndex = 9;
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(14, 27);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(158, 20);
            this.tbTarget.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(178, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select a target folder:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 316);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(222, 23);
            this.progressBar.TabIndex = 10;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 351);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cbRandomizeFiles);
            this.Controls.Add(this.tbTarget);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExecute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Renamer512";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumberFilesSplit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSplitFiles;
        private System.Windows.Forms.CheckBox cbRandomizeFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nbNumberFilesSplit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRenamePrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbFileNumbering;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFolderPrefix;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

