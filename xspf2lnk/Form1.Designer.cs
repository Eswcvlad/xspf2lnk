namespace xspf2lnk
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
            this._selectPlaylistDialog = new System.Windows.Forms.OpenFileDialog();
            this._selectFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._playlistWorker = new System.ComponentModel.BackgroundWorker();
            this._selectPlaylistTextBox = new System.Windows.Forms.TextBox();
            this._selectFolderTextBox = new System.Windows.Forms.TextBox();
            this._selectPlaylistButton = new System.Windows.Forms.Button();
            this._selectFolderButton = new System.Windows.Forms.Button();
            this._selectPlaylistLabel = new System.Windows.Forms.Label();
            this._selectFolderLabel = new System.Windows.Forms.Label();
            this._currentFileLabel = new System.Windows.Forms.Label();
            this._operationButton = new System.Windows.Forms.Button();
            this._operationProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // _selectPlaylistDialog
            // 
            this._selectPlaylistDialog.DefaultExt = "xspf";
            this._selectPlaylistDialog.Filter = "XSPF Playlist|*.xspf";
            this._selectPlaylistDialog.Title = "Select playlist";
            // 
            // _selectFolderDialog
            // 
            this._selectFolderDialog.Description = "Select a folder for .lnk files";
            // 
            // _playlistWorker
            // 
            this._playlistWorker.WorkerReportsProgress = true;
            this._playlistWorker.WorkerSupportsCancellation = true;
            this._playlistWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this._playlistWorker_DoWork);
            this._playlistWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this._playlistWorker_ProgressChanged);
            this._playlistWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._playlistWorker_RunWorkerCompleted);
            // 
            // _selectPlaylistTextBox
            // 
            this._selectPlaylistTextBox.Location = new System.Drawing.Point(12, 29);
            this._selectPlaylistTextBox.Name = "_selectPlaylistTextBox";
            this._selectPlaylistTextBox.Size = new System.Drawing.Size(240, 20);
            this._selectPlaylistTextBox.TabIndex = 0;
            // 
            // _selectFolderTextBox
            // 
            this._selectFolderTextBox.Location = new System.Drawing.Point(12, 68);
            this._selectFolderTextBox.Name = "_selectFolderTextBox";
            this._selectFolderTextBox.Size = new System.Drawing.Size(240, 20);
            this._selectFolderTextBox.TabIndex = 2;
            // 
            // _selectPlaylistButton
            // 
            this._selectPlaylistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._selectPlaylistButton.Location = new System.Drawing.Point(258, 26);
            this._selectPlaylistButton.Name = "_selectPlaylistButton";
            this._selectPlaylistButton.Size = new System.Drawing.Size(24, 24);
            this._selectPlaylistButton.TabIndex = 1;
            this._selectPlaylistButton.Text = "...";
            this._selectPlaylistButton.UseVisualStyleBackColor = true;
            this._selectPlaylistButton.Click += new System.EventHandler(this._selectPlaylistButton_Click);
            // 
            // _selectFolderButton
            // 
            this._selectFolderButton.Location = new System.Drawing.Point(258, 65);
            this._selectFolderButton.Name = "_selectFolderButton";
            this._selectFolderButton.Size = new System.Drawing.Size(24, 24);
            this._selectFolderButton.TabIndex = 3;
            this._selectFolderButton.Text = "...";
            this._selectFolderButton.UseVisualStyleBackColor = true;
            this._selectFolderButton.Click += new System.EventHandler(this._selectFolderButton_Click);
            // 
            // _selectPlaylistLabel
            // 
            this._selectPlaylistLabel.AutoSize = true;
            this._selectPlaylistLabel.Location = new System.Drawing.Point(9, 13);
            this._selectPlaylistLabel.Name = "_selectPlaylistLabel";
            this._selectPlaylistLabel.Size = new System.Drawing.Size(108, 13);
            this._selectPlaylistLabel.TabIndex = 4;
            this._selectPlaylistLabel.Text = "Select a .xspf playlist:";
            // 
            // _selectFolderLabel
            // 
            this._selectFolderLabel.AutoSize = true;
            this._selectFolderLabel.Location = new System.Drawing.Point(9, 52);
            this._selectFolderLabel.Name = "_selectFolderLabel";
            this._selectFolderLabel.Size = new System.Drawing.Size(134, 13);
            this._selectFolderLabel.TabIndex = 5;
            this._selectFolderLabel.Text = "Select a folder for .lnk files:";
            // 
            // _currentFileLabel
            // 
            this._currentFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._currentFileLabel.AutoSize = true;
            this._currentFileLabel.Location = new System.Drawing.Point(9, 137);
            this._currentFileLabel.Name = "_currentFileLabel";
            this._currentFileLabel.Size = new System.Drawing.Size(0, 13);
            this._currentFileLabel.TabIndex = 6;
            // 
            // _operationButton
            // 
            this._operationButton.Location = new System.Drawing.Point(12, 95);
            this._operationButton.Name = "_operationButton";
            this._operationButton.Size = new System.Drawing.Size(270, 23);
            this._operationButton.TabIndex = 4;
            this._operationButton.Text = "START";
            this._operationButton.UseVisualStyleBackColor = true;
            this._operationButton.Click += new System.EventHandler(this._operationButton_Click);
            // 
            // _operationProgressBar
            // 
            this._operationProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._operationProgressBar.Location = new System.Drawing.Point(12, 124);
            this._operationProgressBar.Name = "_operationProgressBar";
            this._operationProgressBar.Size = new System.Drawing.Size(270, 10);
            this._operationProgressBar.Step = 1;
            this._operationProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._operationProgressBar.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AcceptButton = this._operationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 159);
            this.Controls.Add(this._operationProgressBar);
            this.Controls.Add(this._operationButton);
            this.Controls.Add(this._currentFileLabel);
            this.Controls.Add(this._selectFolderLabel);
            this.Controls.Add(this._selectPlaylistLabel);
            this.Controls.Add(this._selectFolderButton);
            this.Controls.Add(this._selectPlaylistButton);
            this.Controls.Add(this._selectFolderTextBox);
            this.Controls.Add(this._selectPlaylistTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "xspf2lnk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog _selectPlaylistDialog;
        private System.Windows.Forms.FolderBrowserDialog _selectFolderDialog;
        private System.ComponentModel.BackgroundWorker _playlistWorker;
        private System.Windows.Forms.TextBox _selectPlaylistTextBox;
        private System.Windows.Forms.TextBox _selectFolderTextBox;
        private System.Windows.Forms.Button _selectPlaylistButton;
        private System.Windows.Forms.Button _selectFolderButton;
        private System.Windows.Forms.Label _selectPlaylistLabel;
        private System.Windows.Forms.Label _selectFolderLabel;
        private System.Windows.Forms.Label _currentFileLabel;
        private System.Windows.Forms.Button _operationButton;
        private System.Windows.Forms.ProgressBar _operationProgressBar;
    }
}

