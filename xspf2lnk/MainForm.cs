using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using IWshRuntimeLibrary;

namespace xspf2lnk
{
    public partial class MainForm : Form
    {
        // Used for creating links
        private readonly WshShell _shell;
        // Defines operation button actions
        private OperationButtonState _operationButtonState;

        public MainForm()
        {
            InitializeComponent();
            _shell = new WshShell();

            _operationButtonState = OperationButtonState.Start;
        }

        private void _selectPlaylistButton_Click(object sender, EventArgs e)
        {
            if (_selectPlaylistDialog.ShowDialog() == DialogResult.OK)
                _selectPlaylistTextBox.Text = _selectPlaylistDialog.FileName;
        }

        private void _selectFolderButton_Click(object sender, EventArgs e)
        {
            if (_selectFolderDialog.ShowDialog() == DialogResult.OK)
                _selectFolderTextBox.Text = _selectFolderDialog.SelectedPath;
        }

        private void _operationButton_Click(object sender, EventArgs e)
        {
            if (_operationButtonState == OperationButtonState.Start)
            {
                if (_selectPlaylistTextBox.Text.Length == 0)
                {
                    MessageBox.Show(@"You must select a playlist first!", @"Error");
                    return;
                }

                if (_selectFolderTextBox.Text.Length == 0)
                {
                    MessageBox.Show(@"You must select a folder first!", @"Error");
                    return;
                }

                // Changing button to "STOP"
                _operationButton.Text = @"STOP";
                _operationButtonState = OperationButtonState.Stop;

                SetInputControlsEnabledState(false);

                _playlistWorker.RunWorkerAsync();
            }
            else if (_operationButtonState == OperationButtonState.Stop)
            {
                _playlistWorker.CancelAsync();
            }
        }

        private void SetInputControlsEnabledState(bool areEnabled)
        {
            _selectPlaylistTextBox.Enabled = areEnabled;
            _selectPlaylistButton.Enabled = areEnabled;
            _selectFolderTextBox.Enabled = areEnabled;
            _selectFolderButton.Enabled = areEnabled;
        }

        private enum OperationButtonState
        {
            Start,
            Stop
        }

        #region PlaylistWorker event handlers

        private void _playlistWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Creating and loading an .xspf playlist
            var playlist = new XmlDocument();
            playlist.Load(_selectPlaylistTextBox.Text);

            // Adding .xspf namespace
            var nsManager = new XmlNamespaceManager(playlist.NameTable);
            nsManager.AddNamespace("xspf", "http://xspf.org/ns/0/");

            // Getting all tracks as a collection
            var trackList = playlist.SelectNodes("//xspf:track", nsManager);

            // Setting the progress bar value to correspond to the track count
            _operationProgressBar.Invoke((MethodInvoker) delegate { _operationProgressBar.Maximum = trackList.Count; });

            foreach (XmlNode track in trackList)
            {
                // Checking, if the operation is cancelled
                if (_playlistWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                var filePath = new Uri(track["location"].InnerText).LocalPath;
                var fileName = Path.GetFileName(filePath);
                var linkAddress = new StringBuilder(_selectFolderTextBox.Text);

                Directory.CreateDirectory(linkAddress.ToString());

                linkAddress.Append('\\').Append(fileName).Append(".lnk");

                // Creating the shortcut itself
                var shortcut = (IWshShortcut) _shell.CreateShortcut(linkAddress.ToString());
                shortcut.TargetPath = filePath;
                shortcut.Save();

                _playlistWorker.ReportProgress(0, fileName);
            }
        }

        private void _playlistWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _currentFileLabel.Text = (string) e.UserState;
            _operationProgressBar.PerformStep();
        }

        private void _playlistWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show(e.Error.Message, @"Error");
            else if (e.Cancelled)
                MessageBox.Show(@"Operation was cancelled!", @"Cancellation");
            else
                MessageBox.Show(@"Everything is done!", @"Done");

            // Reset progress indicators
            _operationProgressBar.Value = 0;
            _currentFileLabel.Text = "";

            // Changing button to "START"
            _operationButton.Text = @"START";
            _operationButtonState = OperationButtonState.Start;

            SetInputControlsEnabledState(true);
        }

        #endregion
    }
}