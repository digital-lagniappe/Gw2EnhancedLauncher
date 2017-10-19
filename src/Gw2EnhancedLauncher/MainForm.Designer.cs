namespace Gw2EnhancedLauncher
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
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.buttonFolderSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxArcDpsTemplates = new System.Windows.Forms.CheckBox();
            this.checkBoxArcDps = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBmpScreenshots = new System.Windows.Forms.CheckBox();
            this.buttonRemoveArc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Location = new System.Drawing.Point(752, 421);
            this.buttonLaunch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(172, 44);
            this.buttonLaunch.TabIndex = 0;
            this.buttonLaunch.Text = "Launch GW2";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "GW2 Folder";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(166, 19);
            this.textBoxFolderPath.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(592, 31);
            this.textBoxFolderPath.TabIndex = 2;
            // 
            // buttonFolderSelect
            // 
            this.buttonFolderSelect.Location = new System.Drawing.Point(774, 15);
            this.buttonFolderSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonFolderSelect.Name = "buttonFolderSelect";
            this.buttonFolderSelect.Size = new System.Drawing.Size(150, 44);
            this.buttonFolderSelect.TabIndex = 3;
            this.buttonFolderSelect.Text = "Select";
            this.buttonFolderSelect.UseVisualStyleBackColor = true;
            this.buttonFolderSelect.Click += new System.EventHandler(this.buttonFolderSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRemoveArc);
            this.groupBox1.Controls.Add(this.checkBoxArcDpsTemplates);
            this.groupBox1.Controls.Add(this.checkBoxArcDps);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(892, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARC DPS";
            // 
            // checkBoxArcDpsTemplates
            // 
            this.checkBoxArcDpsTemplates.AutoSize = true;
            this.checkBoxArcDpsTemplates.Location = new System.Drawing.Point(246, 119);
            this.checkBoxArcDpsTemplates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxArcDpsTemplates.Name = "checkBoxArcDpsTemplates";
            this.checkBoxArcDpsTemplates.Size = new System.Drawing.Size(259, 29);
            this.checkBoxArcDpsTemplates.TabIndex = 2;
            this.checkBoxArcDpsTemplates.Text = "User arcdps templates";
            this.checkBoxArcDpsTemplates.UseVisualStyleBackColor = true;
            // 
            // checkBoxArcDps
            // 
            this.checkBoxArcDps.AutoSize = true;
            this.checkBoxArcDps.Location = new System.Drawing.Point(20, 119);
            this.checkBoxArcDps.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxArcDps.Name = "checkBoxArcDps";
            this.checkBoxArcDps.Size = new System.Drawing.Size(153, 29);
            this.checkBoxArcDps.TabIndex = 1;
            this.checkBoxArcDps.Text = "Use arcdps";
            this.checkBoxArcDps.UseVisualStyleBackColor = true;
            this.checkBoxArcDps.CheckedChanged += new System.EventHandler(this.checkBoxArcDps_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.MaximumSize = new System.Drawing.Size(850, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(726, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "This controls installation and update of \'arcdps\'.  If selected, arcdps will be a" +
    "uto-installed and/or auto-updated.";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(26, 431);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(104, 25);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Starting...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxBmpScreenshots);
            this.groupBox2.Location = new System.Drawing.Point(32, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(892, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command Line Arguments";
            // 
            // checkBoxBmpScreenshots
            // 
            this.checkBoxBmpScreenshots.AutoSize = true;
            this.checkBoxBmpScreenshots.Location = new System.Drawing.Point(20, 58);
            this.checkBoxBmpScreenshots.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxBmpScreenshots.Name = "checkBoxBmpScreenshots";
            this.checkBoxBmpScreenshots.Size = new System.Drawing.Size(378, 29);
            this.checkBoxBmpScreenshots.TabIndex = 0;
            this.checkBoxBmpScreenshots.Text = "Use bmp screenshots (default: jpg)";
            this.checkBoxBmpScreenshots.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveArc
            // 
            this.buttonRemoveArc.Location = new System.Drawing.Point(694, 110);
            this.buttonRemoveArc.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRemoveArc.Name = "buttonRemoveArc";
            this.buttonRemoveArc.Size = new System.Drawing.Size(176, 44);
            this.buttonRemoveArc.TabIndex = 7;
            this.buttonRemoveArc.Text = "Remove ARC";
            this.buttonRemoveArc.UseVisualStyleBackColor = true;
            this.buttonRemoveArc.Click += new System.EventHandler(this.buttonRemoveArc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFolderSelect);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLaunch);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GW2 Enhanced Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonFolderSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxArcDpsTemplates;
        private System.Windows.Forms.CheckBox checkBoxArcDps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxBmpScreenshots;
        private System.Windows.Forms.Button buttonRemoveArc;
    }
}

