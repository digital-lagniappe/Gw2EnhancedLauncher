using System;
using System.Windows.Forms;
using Gw2EnhancedLauncher.Properties;

namespace Gw2EnhancedLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        protected string FolderPath
        {
            get => this.textBoxFolderPath.Text;
            set => this.textBoxFolderPath.Text = value;
        }

        protected string Status
        {
            set => this.labelStatus.Text = value;
        }

        protected bool UseArcDps
        {
            get => this.checkBoxArcDps.Checked;
            set => this.checkBoxArcDps.Checked = value;
        }

        protected bool UseArcDpsTemplates
        {
            get => this.checkBoxArcDpsTemplates.Checked;
            set => this.checkBoxArcDpsTemplates.Checked = value;
        }

        protected bool UseBmpScreenshots
        {
            get => this.checkBoxBmpScreenshots.Checked;
            set => this.checkBoxBmpScreenshots.Checked = value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Status = string.Empty;

            var settings = Settings.Default;
            this.FolderPath = settings.FolderPath;
            this.UseArcDps = settings.UseArcDps;
            this.UseArcDpsTemplates = settings.UseArcDpsTemplates;
            this.UseBmpScreenshots = settings.UseBmpScreenshots;

            if (!this.UseArcDps)
            {
                this.checkBoxArcDpsTemplates.Enabled = false;
            }
        }

        private void buttonFolderSelect_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                Description = @"Select your GW2 installation folder",
                ShowNewFolderButton = false
            };

            if (!string.IsNullOrWhiteSpace(this.FolderPath))
            {
                dialog.SelectedPath = this.FolderPath;
            }

            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                if (!string.IsNullOrWhiteSpace(path))
                {
                    this.FolderPath = path;
                }
            }
        }

        private void buttonRemoveArc_Click(object sender, EventArgs e)
        {
            this.Status = "Removing arc dps...";
            var arc = new ArcDpsUpdater(this.FolderPath, this.UseArcDpsTemplates);
            arc.Remove();
            this.Status = "arc dps removed";
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.FolderPath))
                {
                    MessageBox.Show(
                        @"Folder Path is required.",
                        @"Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.UseArcDps)
                    {
                        this.Status = "Updating arc dps...";
                        var arcUpdater = new ArcDpsUpdater(this.FolderPath, this.UseArcDpsTemplates);
                        arcUpdater.Update();
                    }

                    this.Status = "Launching game client...";
                    var launcher = new GameLauncher(this.FolderPath);
                    launcher.Launch(this.GetGameLauncherConfig());

                    this.Close();
                }
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(
                    @"An error occurred attempting to download arc dps files. Please try again.",
                    @"ARC DPS Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Status = string.Empty;
            }
        }

        private void checkBoxArcDps_CheckedChanged(object sender, EventArgs e)
        {
            var value = ((CheckBox)sender).Checked;

            if (!value)
            {
                this.UseArcDpsTemplates = false;
            }

            this.checkBoxArcDpsTemplates.Enabled = value;
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var settings = Settings.Default;
            settings.FolderPath = this.FolderPath;
            settings.UseArcDps = this.UseArcDps;
            settings.UseArcDpsTemplates = this.UseArcDpsTemplates;
            settings.UseBmpScreenshots = this.UseBmpScreenshots;
            settings.Save();
        }

        private GameLauncherConfig GetGameLauncherConfig()
        {
            return new GameLauncherConfig
            {
                UseBmpScreenshots = this.UseBmpScreenshots
            };
        }
    }
}
