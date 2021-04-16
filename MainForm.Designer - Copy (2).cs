﻿namespace MelonLoader
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ThemeManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.InstallerVersion = new MetroFramework.Controls.MetroLabel();
            this.PageManager = new MetroFramework.Controls.MetroTabControl();
            this.Tab_Automated = new MetroFramework.Controls.MetroTabPage();
            this.Automated_TmpDivider = new MetroFramework.Controls.MetroLabel();
            this.Automated_Text = new MetroFramework.Controls.MetroLabel();
            this.Automated_Text_Failure = new MetroFramework.Controls.MetroLabel();
            this.Tab_SelfUpdate = new MetroFramework.Controls.MetroTabPage();
            this.SelfUpdate_Text = new MetroFramework.Controls.MetroLabel();
            this.Tab_Settings = new MetroFramework.Controls.MetroTabPage();
            this.Settings_AutoUpdateInstaller = new MetroFramework.Controls.MetroCheckBox();
            this.Settings_Theme_Selection = new MetroFramework.Controls.MetroComboBox();
            this.Settings_HighlightLogFileLocation = new MetroFramework.Controls.MetroCheckBox();
            this.Settings_CloseAfterCompletion = new MetroFramework.Controls.MetroCheckBox();
            this.Settings_Theme_Text = new MetroFramework.Controls.MetroLabel();
            this.Settings_RememberLastSelectedGame = new MetroFramework.Controls.MetroCheckBox();
            this.Settings_ShowAlphaPreReleases = new MetroFramework.Controls.MetroCheckBox();
            this.Tab_Output = new MetroFramework.Controls.MetroTabPage();
            this.Output_TmpDivider = new MetroFramework.Controls.MetroLabel();
            this.Output_Current_Operation = new MetroFramework.Controls.MetroLabel();
            this.Output_Total_Progress_Text_Label = new MetroFramework.Controls.MetroLabel();
            this.Output_Current_Progress_Text_Label = new MetroFramework.Controls.MetroLabel();
            this.Output_Current_Progress_Display = new MetroFramework.Controls.MetroProgressBar();
            this.Output_Current_Text = new MetroFramework.Controls.MetroLabel();
            this.Output_Total_Progress_Display = new MetroFramework.Controls.MetroProgressBar();
            this.Output_Total_Text = new MetroFramework.Controls.MetroLabel();
            this.Output_Total_Progress_Text = new MetroFramework.Controls.MetroLabel();
            this.Output_Current_Progress_Text = new MetroFramework.Controls.MetroLabel();
            this.Tab_ManualZip = new MetroFramework.Controls.MetroTabPage();
            this.ManualZip_TmpDivider = new MetroFramework.Controls.MetroLabel();
            this.Divider = new MetroFramework.Controls.MetroLabel();
            this.InstallerUpdateNotice = new MetroFramework.Controls.MetroLabel();
            this.Link_Wiki = new System.Windows.Forms.PictureBox();
            this.Link_GitHub = new System.Windows.Forms.PictureBox();
            this.Link_Twitter = new System.Windows.Forms.PictureBox();
            this.Link_Discord = new System.Windows.Forms.PictureBox();
            this.ML_Text = new System.Windows.Forms.PictureBox();
            this.ML_Logo = new System.Windows.Forms.PictureBox();
            this.Automated_Retry = new MetroFramework.Controls.MetroButton();
#if DEBUG
            this.Tab_Debug = new MetroFramework.Controls.MetroTabPage();
            this.Debug_AutomatedState = new MetroFramework.Controls.MetroComboBox();
            this.Debug_LatestInstallerRelease = new MetroFramework.Controls.MetroLabel();
            this.Debug_LatestInstallerRelease_Text = new MetroFramework.Controls.MetroLabel();
            this.Debug_AutomatedState_Text = new MetroFramework.Controls.MetroLabel();
            this.Debug_OutputTest = new MetroFramework.Controls.MetroButton();
            this.Debug_OutputFailureTest = new MetroFramework.Controls.MetroButton();
            this.Debug_OutputSuccessTest = new MetroFramework.Controls.MetroButton();
#endif
            ((System.ComponentModel.ISupportInitialize)(this.ThemeManager)).BeginInit();
            this.PageManager.SuspendLayout();
#if DEBUG
            this.Tab_Debug.SuspendLayout();
#endif
            this.Tab_Automated.SuspendLayout();
            this.Tab_SelfUpdate.SuspendLayout();
            this.Tab_Settings.SuspendLayout();
            this.Tab_Output.SuspendLayout();
            this.Tab_ManualZip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Link_Wiki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link_GitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link_Twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link_Discord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemeManager
            // 
            this.ThemeManager.Owner = this;
            this.ThemeManager.Style = MetroFramework.MetroColorStyle.Red;
            this.ThemeManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // InstallerVersion
            // 
            this.InstallerVersion.BackColor = System.Drawing.Color.Transparent;
            this.InstallerVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallerVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.InstallerVersion.Location = new System.Drawing.Point(7, 42);
            this.InstallerVersion.Name = "InstallerVersion";
            this.InstallerVersion.Size = new System.Drawing.Size(115, 23);
            this.InstallerVersion.TabIndex = 8;
            this.InstallerVersion.Text = "Installer v0.0.0";
            this.InstallerVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstallerVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InstallerVersion.Click += new System.EventHandler(this.InstallerVersion_Click);
            // 
            // PageManager
            // 
            this.PageManager.Appearance = System.Windows.Forms.TabAppearance.Buttons;
#if DEBUG
            this.PageManager.Controls.Add(this.Tab_Debug);
#endif
            this.PageManager.Controls.Add(this.Tab_Automated);
            this.PageManager.Controls.Add(this.Tab_SelfUpdate);
            this.PageManager.Controls.Add(this.Tab_Settings);
            this.PageManager.Controls.Add(this.Tab_Output);
            this.PageManager.Controls.Add(this.Tab_ManualZip);
            this.PageManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PageManager.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.PageManager.ItemSize = new System.Drawing.Size(141, 34);
            this.PageManager.Location = new System.Drawing.Point(21, 203);
            this.PageManager.Name = "PageManager";
            this.PageManager.SelectedIndex = 1;
            this.PageManager.Size = new System.Drawing.Size(439, 222);
            this.PageManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.PageManager.Style = MetroFramework.MetroColorStyle.Red;
            this.PageManager.TabIndex = 10;
            this.PageManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PageManager.SelectedIndexChanged += new System.EventHandler(this.PageManager_SelectedIndexChanged);
#if DEBUG
            // 
            // Tab_Debug
            // 
            this.Tab_Debug.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Debug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Debug.Controls.Add(this.Debug_OutputSuccessTest);
            this.Tab_Debug.Controls.Add(this.Debug_OutputFailureTest);
            this.Tab_Debug.Controls.Add(this.Debug_OutputTest);
            this.Tab_Debug.Controls.Add(this.Debug_AutomatedState);
            this.Tab_Debug.Controls.Add(this.Debug_LatestInstallerRelease);
            this.Tab_Debug.Controls.Add(this.Debug_LatestInstallerRelease_Text);
            this.Tab_Debug.Controls.Add(this.Debug_AutomatedState_Text);
            this.Tab_Debug.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tab_Debug.HorizontalScrollbarBarColor = true;
            this.Tab_Debug.Location = new System.Drawing.Point(4, 38);
            this.Tab_Debug.Name = "Tab_Debug";
            this.Tab_Debug.Size = new System.Drawing.Size(431, 180);
            this.Tab_Debug.TabIndex = 9;
            this.Tab_Debug.Text = "Debug   ";
            this.Tab_Debug.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tab_Debug.VerticalScrollbarBarColor = true;
            // 
            // Debug_AutomatedState
            // 
            this.Debug_AutomatedState.FormattingEnabled = true;
            this.Debug_AutomatedState.ItemHeight = 23;
            this.Debug_AutomatedState.Items.AddRange(new object[] {
            "Pending",
            "Failure",
            "Success"});
            this.Debug_AutomatedState.Location = new System.Drawing.Point(137, 87);
            this.Debug_AutomatedState.Name = "Debug_AutomatedState";
            this.Debug_AutomatedState.Size = new System.Drawing.Size(131, 29);
            this.Debug_AutomatedState.TabIndex = 19;
            this.Debug_AutomatedState.SelectedIndexChanged += new System.EventHandler(this.Debug_AutomatedState_SelectedIndexChanged);
            // 
            // Debug_LatestInstallerRelease
            // 
            this.Debug_LatestInstallerRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Debug_LatestInstallerRelease.BackColor = System.Drawing.Color.Transparent;
            this.Debug_LatestInstallerRelease.CustomForeColor = true;
            this.Debug_LatestInstallerRelease.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Debug_LatestInstallerRelease.ForeColor = System.Drawing.Color.Lime;
            this.Debug_LatestInstallerRelease.Location = new System.Drawing.Point(172, 50);
            this.Debug_LatestInstallerRelease.Name = "Debug_LatestInstallerRelease";
            this.Debug_LatestInstallerRelease.Size = new System.Drawing.Size(96, 33);
            this.Debug_LatestInstallerRelease.TabIndex = 16;
            this.Debug_LatestInstallerRelease.Text = "Pending...";
            this.Debug_LatestInstallerRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Debug_LatestInstallerRelease.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Debug_LatestInstallerRelease_Text
            // 
            this.Debug_LatestInstallerRelease_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Debug_LatestInstallerRelease_Text.BackColor = System.Drawing.Color.Transparent;
            this.Debug_LatestInstallerRelease_Text.CustomForeColor = true;
            this.Debug_LatestInstallerRelease_Text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Debug_LatestInstallerRelease_Text.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Debug_LatestInstallerRelease_Text.Location = new System.Drawing.Point(13, 50);
            this.Debug_LatestInstallerRelease_Text.Name = "Debug_LatestInstallerRelease_Text";
            this.Debug_LatestInstallerRelease_Text.Size = new System.Drawing.Size(165, 33);
            this.Debug_LatestInstallerRelease_Text.TabIndex = 15;
            this.Debug_LatestInstallerRelease_Text.Text = "Latest Installer Release:";
            this.Debug_LatestInstallerRelease_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Debug_LatestInstallerRelease_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Debug_AutomatedState_Text
            // 
            this.Debug_AutomatedState_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Debug_AutomatedState_Text.BackColor = System.Drawing.Color.Transparent;
            this.Debug_AutomatedState_Text.CustomForeColor = true;
            this.Debug_AutomatedState_Text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Debug_AutomatedState_Text.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Debug_AutomatedState_Text.Location = new System.Drawing.Point(13, 83);
            this.Debug_AutomatedState_Text.Name = "Debug_AutomatedState_Text";
            this.Debug_AutomatedState_Text.Size = new System.Drawing.Size(132, 33);
            this.Debug_AutomatedState_Text.TabIndex = 14;
            this.Debug_AutomatedState_Text.Text = "Automated State:";
            this.Debug_AutomatedState_Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Debug_AutomatedState_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Debug_OutputTest
            // 
            this.Debug_OutputTest.Location = new System.Drawing.Point(296, 35);
            this.Debug_OutputTest.Name = "Debug_OutputTest";
            this.Debug_OutputTest.Size = new System.Drawing.Size(113, 23);
            this.Debug_OutputTest.Style = MetroFramework.MetroColorStyle.Green;
            this.Debug_OutputTest.TabIndex = 20;
            this.Debug_OutputTest.Text = "Output Test";
            this.Debug_OutputTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Debug_OutputTest.Click += new System.EventHandler(this.Debug_OutputTest_Click);
            // 
            // Debug_OutputFailureTest
            // 
            this.Debug_OutputFailureTest.Location = new System.Drawing.Point(296, 71);
            this.Debug_OutputFailureTest.Name = "Debug_OutputFailureTest";
            this.Debug_OutputFailureTest.Size = new System.Drawing.Size(113, 23);
            this.Debug_OutputFailureTest.Style = MetroFramework.MetroColorStyle.Green;
            this.Debug_OutputFailureTest.TabIndex = 21;
            this.Debug_OutputFailureTest.Text = "Output Failure Test";
            this.Debug_OutputFailureTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Debug_OutputFailureTest.Click += new System.EventHandler(this.Debug_OutputFailureTest_Click);
            // 
            // Debug_OutputSuccessTest
            // 
            this.Debug_OutputSuccessTest.Location = new System.Drawing.Point(297, 106);
            this.Debug_OutputSuccessTest.Name = "Debug_OutputSuccessTest";
            this.Debug_OutputSuccessTest.Size = new System.Drawing.Size(113, 23);
            this.Debug_OutputSuccessTest.Style = MetroFramework.MetroColorStyle.Green;
            this.Debug_OutputSuccessTest.TabIndex = 22;
            this.Debug_OutputSuccessTest.Text = "Output Success Test";
            this.Debug_OutputSuccessTest.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Debug_OutputSuccessTest.Click += new System.EventHandler(this.Debug_OutputSuccessTest_Click);
#endif
            // 
            // Tab_Automated
            // 
            this.Tab_Automated.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Automated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Automated.Controls.Add(this.Automated_Text_Failure);
            this.Tab_Automated.Controls.Add(this.Automated_TmpDivider);
            this.Tab_Automated.Controls.Add(this.Automated_Retry);
            this.Tab_Automated.Controls.Add(this.Automated_Text);
            this.Tab_Automated.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tab_Automated.HorizontalScrollbarBarColor = true;
            this.Tab_Automated.Location = new System.Drawing.Point(4, 38);
            this.Tab_Automated.Name = "Tab_Automated";
            this.Tab_Automated.Size = new System.Drawing.Size(431, 180);
            this.Tab_Automated.TabIndex = 7;
            this.Tab_Automated.Text = "Automated   ";
            this.Tab_Automated.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tab_Automated.VerticalScrollbarBarColor = true;
            // 
            // Automated_TmpDivider
            // 
            this.Automated_TmpDivider.AutoSize = true;
            this.Automated_TmpDivider.BackColor = System.Drawing.Color.Transparent;
            this.Automated_TmpDivider.Location = new System.Drawing.Point(3, 80);
            this.Automated_TmpDivider.Name = "Automated_TmpDivider";
            this.Automated_TmpDivider.Size = new System.Drawing.Size(423, 19);
            this.Automated_TmpDivider.TabIndex = 17;
            this.Automated_TmpDivider.Text = "_____________________________________________________________________";
            this.Automated_TmpDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Automated_TmpDivider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Automated_TmpDivider.Visible = false;
            // 
            // Automated_Text
            // 
            this.Automated_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Automated_Text.BackColor = System.Drawing.Color.Transparent;
            this.Automated_Text.CustomForeColor = true;
            this.Automated_Text.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Automated_Text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Automated_Text.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Automated_Text.Location = new System.Drawing.Point(-1, 0);
            this.Automated_Text.Name = "Automated_Text";
            this.Automated_Text.Size = new System.Drawing.Size(431, 179);
            this.Automated_Text.TabIndex = 14;
            this.Automated_Text.Text = "Getting Releases from GitHub...";
            this.Automated_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Automated_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Automated_Text_Failure
            // 
            this.Automated_Text_Failure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Automated_Text_Failure.BackColor = System.Drawing.Color.Transparent;
            this.Automated_Text_Failure.CustomForeColor = true;
            this.Automated_Text_Failure.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Automated_Text_Failure.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Automated_Text_Failure.ForeColor = System.Drawing.Color.Red;
            this.Automated_Text_Failure.Location = new System.Drawing.Point(-1, 54);
            this.Automated_Text_Failure.Name = "Automated_Text_Failure";
            this.Automated_Text_Failure.Size = new System.Drawing.Size(431, 27);
            this.Automated_Text_Failure.TabIndex = 16;
            this.Automated_Text_Failure.Text = "Failed to Get Releases from GitHub!";
            this.Automated_Text_Failure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Automated_Text_Failure.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Automated_Text_Failure.Visible = false;
            // 
            // Tab_SelfUpdate
            // 
            this.Tab_SelfUpdate.BackColor = System.Drawing.Color.Transparent;
            this.Tab_SelfUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_SelfUpdate.Controls.Add(this.SelfUpdate_Text);
            this.Tab_SelfUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tab_SelfUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.Tab_SelfUpdate.HorizontalScrollbarBarColor = true;
            this.Tab_SelfUpdate.Location = new System.Drawing.Point(4, 38);
            this.Tab_SelfUpdate.Name = "Tab_SelfUpdate";
            this.Tab_SelfUpdate.Size = new System.Drawing.Size(431, 180);
            this.Tab_SelfUpdate.TabIndex = 6;
            this.Tab_SelfUpdate.Text = "Please Wait    ";
            this.Tab_SelfUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tab_SelfUpdate.VerticalScrollbarBarColor = true;
            // 
            // SelfUpdate_Text
            // 
            this.SelfUpdate_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelfUpdate_Text.BackColor = System.Drawing.Color.Transparent;
            this.SelfUpdate_Text.CustomForeColor = true;
            this.SelfUpdate_Text.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SelfUpdate_Text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SelfUpdate_Text.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SelfUpdate_Text.Location = new System.Drawing.Point(-1, -1);
            this.SelfUpdate_Text.Name = "SelfUpdate_Text";
            this.SelfUpdate_Text.Size = new System.Drawing.Size(431, 179);
            this.SelfUpdate_Text.TabIndex = 13;
            this.SelfUpdate_Text.Text = "Checking for Installer Updates...";
            this.SelfUpdate_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelfUpdate_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Tab_Settings
            // 
            this.Tab_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Settings.Controls.Add(this.Settings_AutoUpdateInstaller);
            this.Tab_Settings.Controls.Add(this.Settings_Theme_Selection);
            this.Tab_Settings.Controls.Add(this.Settings_HighlightLogFileLocation);
            this.Tab_Settings.Controls.Add(this.Settings_CloseAfterCompletion);
            this.Tab_Settings.Controls.Add(this.Settings_Theme_Text);
            this.Tab_Settings.Controls.Add(this.Settings_RememberLastSelectedGame);
            this.Tab_Settings.Controls.Add(this.Settings_ShowAlphaPreReleases);
            this.Tab_Settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tab_Settings.HorizontalScrollbarBarColor = true;
            this.Tab_Settings.Location = new System.Drawing.Point(4, 38);
            this.Tab_Settings.Name = "Tab_Settings";
            this.Tab_Settings.Size = new System.Drawing.Size(431, 180);
            this.Tab_Settings.TabIndex = 2;
            this.Tab_Settings.Text = "Settings  ";
            this.Tab_Settings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tab_Settings.VerticalScrollbarBarColor = true;
            // 
            // Settings_AutoUpdateInstaller
            // 
            this.Settings_AutoUpdateInstaller.AutoSize = true;
            this.Settings_AutoUpdateInstaller.Checked = true;
            this.Settings_AutoUpdateInstaller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Settings_AutoUpdateInstaller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_AutoUpdateInstaller.CustomForeColor = true;
            this.Settings_AutoUpdateInstaller.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Settings_AutoUpdateInstaller.Location = new System.Drawing.Point(158, 71);
            this.Settings_AutoUpdateInstaller.Name = "Settings_AutoUpdateInstaller";
            this.Settings_AutoUpdateInstaller.Size = new System.Drawing.Size(136, 15);
            this.Settings_AutoUpdateInstaller.Style = MetroFramework.MetroColorStyle.Green;
            this.Settings_AutoUpdateInstaller.TabIndex = 4;
            this.Settings_AutoUpdateInstaller.Text = "Auto-Update Installer";
            this.Settings_AutoUpdateInstaller.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Settings_AutoUpdateInstaller.UseVisualStyleBackColor = true;
            this.Settings_AutoUpdateInstaller.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseLeave);
            this.Settings_AutoUpdateInstaller.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.Settings_AutoUpdateInstaller.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.Settings_AutoUpdateInstaller.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseEnter);
            // 
            // Settings_Theme_Selection
            // 
            this.Settings_Theme_Selection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_Theme_Selection.FormattingEnabled = true;
            this.Settings_Theme_Selection.ItemHeight = 23;
            this.Settings_Theme_Selection.Items.AddRange(new object[] {
            "Dark",
            "Light",
            "Lemon",
            "DarkLemon"});
            this.Settings_Theme_Selection.Location = new System.Drawing.Point(199, 21);
            this.Settings_Theme_Selection.Name = "Settings_Theme_Selection";
            this.Settings_Theme_Selection.Size = new System.Drawing.Size(108, 29);
            this.Settings_Theme_Selection.Style = MetroFramework.MetroColorStyle.Green;
            this.Settings_Theme_Selection.TabIndex = 3;
            this.Settings_Theme_Selection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Settings_Theme_Selection.SelectedIndexChanged += new System.EventHandler(this.Settings_Theme_Selection_SelectedIndexChanged);
            // 
            // Settings_HighlightLogFileLocation
            // 
            this.Settings_HighlightLogFileLocation.AutoSize = true;
            this.Settings_HighlightLogFileLocation.Checked = true;
            this.Settings_HighlightLogFileLocation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Settings_HighlightLogFileLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_HighlightLogFileLocation.Location = new System.Drawing.Point(226, 109);
            this.Settings_HighlightLogFileLocation.Name = "Settings_HighlightLogFileLocation";
            this.Settings_HighlightLogFileLocation.Size = new System.Drawing.Size(166, 15);
            this.Settings_HighlightLogFileLocation.Style = MetroFramework.MetroColorStyle.Green;
            this.Settings_HighlightLogFileLocation.TabIndex = 8;
            this.Settings_HighlightLogFileLocation.Text = "Highlight Log File Location";
            this.Settings_HighlightLogFileLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Settings_HighlightLogFileLocation.UseVisualStyleBackColor = true;
            this.Settings_HighlightLogFileLocation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseLeave);
            this.Settings_HighlightLogFileLocation.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.Settings_HighlightLogFileLocation.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.Settings_HighlightLogFileLocation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseEnter);
            // 
            // Settings_CloseAfterCompletion
            // 
            this.Settings_CloseAfterCompletion.AutoSize = true;
            this.Settings_CloseAfterCompletion.Checked = true;
            this.Settings_CloseAfterCompletion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Settings_CloseAfterCompletion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_CloseAfterCompletion.CustomForeColor = true;
            this.Settings_CloseAfterCompletion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Settings_CloseAfterCompletion.Location = new System.Drawing.Point(29, 109);
            this.Settings_CloseAfterCompletion.Name = "Settings_CloseAfterCompletion";
            this.Settings_CloseAfterCompletion.Size = new System.Drawing.Size(147, 15);
            this.Settings_CloseAfterCompletion.Style = MetroFramework.MetroColorStyle.Green;
            this.Settings_CloseAfterCompletion.TabIndex = 5;
            this.Settings_CloseAfterCompletion.Text = "Close After Completion";
            this.Settings_CloseAfterCompletion.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Settings_CloseAfterCompletion.UseVisualStyleBackColor = true;
            this.Settings_CloseAfterCompletion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseLeave);
            this.Settings_CloseAfterCompletion.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.Settings_CloseAfterCompletion.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.Settings_CloseAfterCompletion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseEnter);
            // 
            // Settings_Theme_Text
            // 
            this.Settings_Theme_Text.AutoSize = true;
            this.Settings_Theme_Text.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Settings_Theme_Text.Location = new System.Drawing.Point(140, 24);
            this.Settings_Theme_Text.Name = "Settings_Theme_Text";
            this.Settings_Theme_Text.Size = new System.Drawing.Size(53, 19);
            this.Settings_Theme_Text.TabIndex = 2;
            this.Settings_Theme_Text.Text = "Theme:";
            this.Settings_Theme_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Settings_RememberLastSelectedGame
            // 
            this.Settings_RememberLastSelectedGame.AutoSize = true;
            this.Settings_RememberLastSelectedGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_RememberLastSelectedGame.Location = new System.Drawing.Point(226, 145);
            this.Settings_RememberLastSelectedGame.Name = "Settings_RememberLastSelectedGame";
            this.Settings_RememberLastSelectedGame.Size = new System.Drawing.Size(186, 15);
            this.Settings_RememberLastSelectedGame.Style = MetroFramework.MetroColorStyle.Green;
            this.Settings_RememberLastSelectedGame.TabIndex = 7;
            this.Settings_RememberLastSelectedGame.Text = "Remember Last Selected Game";
            this.Settings_RememberLastSelectedGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Settings_RememberLastSelectedGame.UseVisualStyleBackColor = false;
            this.Settings_RememberLastSelectedGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseLeave);
            this.Settings_RememberLastSelectedGame.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.Settings_RememberLastSelectedGame.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.Settings_RememberLastSelectedGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseEnter);
            // 
            // Settings_ShowAlphaPreReleases
            // 
            this.Settings_ShowAlphaPreReleases.AutoSize = true;
            this.Settings_ShowAlphaPreReleases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_ShowAlphaPreReleases.Location = new System.Drawing.Point(29, 145);
            this.Settings_ShowAlphaPreReleases.Name = "Settings_ShowAlphaPreReleases";
            this.Settings_ShowAlphaPreReleases.Size = new System.Drawing.Size(162, 15);
            this.Settings_ShowAlphaPreReleases.Style = MetroFramework.MetroColorStyle.Green;
            this.Settings_ShowAlphaPreReleases.TabIndex = 6;
            this.Settings_ShowAlphaPreReleases.Text = "Show ALPHA Pre-Releases";
            this.Settings_ShowAlphaPreReleases.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Settings_ShowAlphaPreReleases.UseVisualStyleBackColor = true;
            this.Settings_ShowAlphaPreReleases.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseLeave);
            this.Settings_ShowAlphaPreReleases.MouseEnter += new System.EventHandler(this.CheckBox_MouseEnter);
            this.Settings_ShowAlphaPreReleases.MouseLeave += new System.EventHandler(this.CheckBox_MouseLeave);
            this.Settings_ShowAlphaPreReleases.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckBox_MouseEnter);
            // 
            // Tab_Output
            // 
            this.Tab_Output.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_Output.Controls.Add(this.Output_TmpDivider);
            this.Tab_Output.Controls.Add(this.Output_Current_Operation);
            this.Tab_Output.Controls.Add(this.Output_Total_Progress_Text_Label);
            this.Tab_Output.Controls.Add(this.Output_Current_Progress_Text_Label);
            this.Tab_Output.Controls.Add(this.Output_Current_Progress_Display);
            this.Tab_Output.Controls.Add(this.Output_Current_Text);
            this.Tab_Output.Controls.Add(this.Output_Total_Progress_Display);
            this.Tab_Output.Controls.Add(this.Output_Total_Text);
            this.Tab_Output.Controls.Add(this.Output_Total_Progress_Text);
            this.Tab_Output.Controls.Add(this.Output_Current_Progress_Text);
            this.Tab_Output.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tab_Output.HorizontalScrollbarBarColor = true;
            this.Tab_Output.Location = new System.Drawing.Point(4, 38);
            this.Tab_Output.Name = "Tab_Output";
            this.Tab_Output.Size = new System.Drawing.Size(431, 180);
            this.Tab_Output.TabIndex = 4;
            this.Tab_Output.Text = "Output   ";
            this.Tab_Output.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tab_Output.VerticalScrollbarBarColor = true;
            // 
            // Output_TmpDivider
            // 
            this.Output_TmpDivider.AutoSize = true;
            this.Output_TmpDivider.BackColor = System.Drawing.Color.Transparent;
            this.Output_TmpDivider.Location = new System.Drawing.Point(3, 80);
            this.Output_TmpDivider.Name = "Output_TmpDivider";
            this.Output_TmpDivider.Size = new System.Drawing.Size(423, 19);
            this.Output_TmpDivider.TabIndex = 18;
            this.Output_TmpDivider.Text = "_____________________________________________________________________";
            this.Output_TmpDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output_TmpDivider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Output_TmpDivider.Visible = false;
            // 
            // Output_Current_Operation
            // 
            this.Output_Current_Operation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_Current_Operation.BackColor = System.Drawing.Color.Transparent;
            this.Output_Current_Operation.CustomForeColor = true;
            this.Output_Current_Operation.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Output_Current_Operation.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Output_Current_Operation.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Output_Current_Operation.Location = new System.Drawing.Point(-1, 0);
            this.Output_Current_Operation.Name = "Output_Current_Operation";
            this.Output_Current_Operation.Size = new System.Drawing.Size(431, 97);
            this.Output_Current_Operation.TabIndex = 13;
            this.Output_Current_Operation.Text = "Current Operation";
            this.Output_Current_Operation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output_Current_Operation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Output_Total_Progress_Text_Label
            // 
            this.Output_Total_Progress_Text_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_Total_Progress_Text_Label.AutoSize = true;
            this.Output_Total_Progress_Text_Label.BackColor = System.Drawing.Color.Transparent;
            this.Output_Total_Progress_Text_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Output_Total_Progress_Text_Label.Location = new System.Drawing.Point(405, 147);
            this.Output_Total_Progress_Text_Label.Name = "Output_Total_Progress_Text_Label";
            this.Output_Total_Progress_Text_Label.Size = new System.Drawing.Size(20, 19);
            this.Output_Total_Progress_Text_Label.TabIndex = 9;
            this.Output_Total_Progress_Text_Label.Text = "%";
            this.Output_Total_Progress_Text_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output_Total_Progress_Text_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Output_Current_Progress_Text_Label
            // 
            this.Output_Current_Progress_Text_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_Current_Progress_Text_Label.AutoSize = true;
            this.Output_Current_Progress_Text_Label.BackColor = System.Drawing.Color.Transparent;
            this.Output_Current_Progress_Text_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Output_Current_Progress_Text_Label.Location = new System.Drawing.Point(405, 110);
            this.Output_Current_Progress_Text_Label.Name = "Output_Current_Progress_Text_Label";
            this.Output_Current_Progress_Text_Label.Size = new System.Drawing.Size(20, 19);
            this.Output_Current_Progress_Text_Label.TabIndex = 6;
            this.Output_Current_Progress_Text_Label.Text = "%";
            this.Output_Current_Progress_Text_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output_Current_Progress_Text_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Output_Current_Progress_Display
            // 
            this.Output_Current_Progress_Display.Location = new System.Drawing.Point(64, 108);
            this.Output_Current_Progress_Display.Name = "Output_Current_Progress_Display";
            this.Output_Current_Progress_Display.Size = new System.Drawing.Size(312, 23);
            this.Output_Current_Progress_Display.Style = MetroFramework.MetroColorStyle.Green;
            this.Output_Current_Progress_Display.TabIndex = 5;
            this.Output_Current_Progress_Display.Value = 100;
            // 
            // Output_Current_Text
            // 
            this.Output_Current_Text.BackColor = System.Drawing.Color.Transparent;
            this.Output_Current_Text.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Output_Current_Text.Location = new System.Drawing.Point(3, 110);
            this.Output_Current_Text.Name = "Output_Current_Text";
            this.Output_Current_Text.Size = new System.Drawing.Size(61, 23);
            this.Output_Current_Text.TabIndex = 4;
            this.Output_Current_Text.Text = "Current:";
            this.Output_Current_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Output_Total_Progress_Display
            // 
            this.Output_Total_Progress_Display.Location = new System.Drawing.Point(64, 145);
            this.Output_Total_Progress_Display.Name = "Output_Total_Progress_Display";
            this.Output_Total_Progress_Display.Size = new System.Drawing.Size(312, 23);
            this.Output_Total_Progress_Display.Style = MetroFramework.MetroColorStyle.Green;
            this.Output_Total_Progress_Display.TabIndex = 2;
            this.Output_Total_Progress_Display.Value = 100;
            // 
            // Output_Total_Text
            // 
            this.Output_Total_Text.BackColor = System.Drawing.Color.Transparent;
            this.Output_Total_Text.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Output_Total_Text.Location = new System.Drawing.Point(20, 147);
            this.Output_Total_Text.Name = "Output_Total_Text";
            this.Output_Total_Text.Size = new System.Drawing.Size(50, 20);
            this.Output_Total_Text.TabIndex = 3;
            this.Output_Total_Text.Text = "Total:";
            this.Output_Total_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Output_Total_Progress_Text
            // 
            this.Output_Total_Progress_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_Total_Progress_Text.BackColor = System.Drawing.Color.Transparent;
            this.Output_Total_Progress_Text.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Output_Total_Progress_Text.Location = new System.Drawing.Point(374, 147);
            this.Output_Total_Progress_Text.Name = "Output_Total_Progress_Text";
            this.Output_Total_Progress_Text.Size = new System.Drawing.Size(40, 19);
            this.Output_Total_Progress_Text.TabIndex = 10;
            this.Output_Total_Progress_Text.Text = "100";
            this.Output_Total_Progress_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output_Total_Progress_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Output_Current_Progress_Text
            // 
            this.Output_Current_Progress_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_Current_Progress_Text.BackColor = System.Drawing.Color.Transparent;
            this.Output_Current_Progress_Text.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Output_Current_Progress_Text.Location = new System.Drawing.Point(374, 110);
            this.Output_Current_Progress_Text.Name = "Output_Current_Progress_Text";
            this.Output_Current_Progress_Text.Size = new System.Drawing.Size(40, 19);
            this.Output_Current_Progress_Text.TabIndex = 14;
            this.Output_Current_Progress_Text.Text = "100";
            this.Output_Current_Progress_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Output_Current_Progress_Text.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Tab_ManualZip
            // 
            this.Tab_ManualZip.BackColor = System.Drawing.Color.Transparent;
            this.Tab_ManualZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tab_ManualZip.Controls.Add(this.ManualZip_TmpDivider);
            this.Tab_ManualZip.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tab_ManualZip.HorizontalScrollbarBarColor = true;
            this.Tab_ManualZip.Location = new System.Drawing.Point(4, 38);
            this.Tab_ManualZip.Name = "Tab_ManualZip";
            this.Tab_ManualZip.Size = new System.Drawing.Size(431, 180);
            this.Tab_ManualZip.TabIndex = 8;
            this.Tab_ManualZip.Text = "Manual Zip   ";
            this.Tab_ManualZip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Tab_ManualZip.VerticalScrollbarBarColor = true;
            // 
            // ManualZip_TmpDivider
            // 
            this.ManualZip_TmpDivider.AutoSize = true;
            this.ManualZip_TmpDivider.BackColor = System.Drawing.Color.Transparent;
            this.ManualZip_TmpDivider.Location = new System.Drawing.Point(3, 80);
            this.ManualZip_TmpDivider.Name = "ManualZip_TmpDivider";
            this.ManualZip_TmpDivider.Size = new System.Drawing.Size(423, 19);
            this.ManualZip_TmpDivider.TabIndex = 18;
            this.ManualZip_TmpDivider.Text = "_____________________________________________________________________";
            this.ManualZip_TmpDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManualZip_TmpDivider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ManualZip_TmpDivider.Visible = false;
            // 
            // Divider
            // 
            this.Divider.AutoSize = true;
            this.Divider.BackColor = System.Drawing.Color.Transparent;
            this.Divider.Location = new System.Drawing.Point(29, 320);
            this.Divider.Name = "Divider";
            this.Divider.Size = new System.Drawing.Size(423, 19);
            this.Divider.TabIndex = 12;
            this.Divider.Text = "_____________________________________________________________________";
            this.Divider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Divider.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Divider.Visible = false;
            // 
            // InstallerUpdateNotice
            // 
            this.InstallerUpdateNotice.BackColor = System.Drawing.Color.Transparent;
            this.InstallerUpdateNotice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstallerUpdateNotice.CustomForeColor = true;
            this.InstallerUpdateNotice.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.InstallerUpdateNotice.ForeColor = System.Drawing.Color.Lime;
            this.InstallerUpdateNotice.Location = new System.Drawing.Point(21, 65);
            this.InstallerUpdateNotice.Name = "InstallerUpdateNotice";
            this.InstallerUpdateNotice.Size = new System.Drawing.Size(85, 41);
            this.InstallerUpdateNotice.Style = MetroFramework.MetroColorStyle.Green;
            this.InstallerUpdateNotice.TabIndex = 11;
            this.InstallerUpdateNotice.Text = "New Update\r\nAvailable!";
            this.InstallerUpdateNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InstallerUpdateNotice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InstallerUpdateNotice.Visible = false;
            this.InstallerUpdateNotice.Click += new System.EventHandler(this.InstallerUpdateNotice_Click);
            // 
            // Link_Wiki
            // 
            this.Link_Wiki.BackColor = System.Drawing.Color.Transparent;
            this.Link_Wiki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_Wiki.Image = global::MelonLoader.Properties.Resources.Wiki;
            this.Link_Wiki.Location = new System.Drawing.Point(97, 14);
            this.Link_Wiki.Name = "Link_Wiki";
            this.Link_Wiki.Size = new System.Drawing.Size(25, 25);
            this.Link_Wiki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Link_Wiki.TabIndex = 9;
            this.Link_Wiki.TabStop = false;
            this.Link_Wiki.Click += new System.EventHandler(this.Link_Wiki_Click);
            // 
            // Link_GitHub
            // 
            this.Link_GitHub.BackColor = System.Drawing.Color.Transparent;
            this.Link_GitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_GitHub.Image = global::MelonLoader.Properties.Resources.GitHub_Dark;
            this.Link_GitHub.Location = new System.Drawing.Point(67, 14);
            this.Link_GitHub.Name = "Link_GitHub";
            this.Link_GitHub.Size = new System.Drawing.Size(25, 25);
            this.Link_GitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Link_GitHub.TabIndex = 7;
            this.Link_GitHub.TabStop = false;
            this.Link_GitHub.Click += new System.EventHandler(this.Link_GitHub_Click);
            // 
            // Link_Twitter
            // 
            this.Link_Twitter.BackColor = System.Drawing.Color.Transparent;
            this.Link_Twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_Twitter.Image = global::MelonLoader.Properties.Resources.Twitter;
            this.Link_Twitter.Location = new System.Drawing.Point(37, 14);
            this.Link_Twitter.Name = "Link_Twitter";
            this.Link_Twitter.Size = new System.Drawing.Size(25, 25);
            this.Link_Twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Link_Twitter.TabIndex = 6;
            this.Link_Twitter.TabStop = false;
            this.Link_Twitter.Click += new System.EventHandler(this.Link_Twitter_Click);
            // 
            // Link_Discord
            // 
            this.Link_Discord.BackColor = System.Drawing.Color.Transparent;
            this.Link_Discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link_Discord.Image = global::MelonLoader.Properties.Resources.Discord;
            this.Link_Discord.Location = new System.Drawing.Point(7, 14);
            this.Link_Discord.Name = "Link_Discord";
            this.Link_Discord.Size = new System.Drawing.Size(25, 25);
            this.Link_Discord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Link_Discord.TabIndex = 5;
            this.Link_Discord.TabStop = false;
            this.Link_Discord.Click += new System.EventHandler(this.Link_Discord_Click);
            // 
            // ML_Text
            // 
            this.ML_Text.BackColor = System.Drawing.Color.Transparent;
            this.ML_Text.Image = global::MelonLoader.Properties.Resources.ML_Text;
            this.ML_Text.Location = new System.Drawing.Point(23, 134);
            this.ML_Text.Name = "ML_Text";
            this.ML_Text.Size = new System.Drawing.Size(437, 63);
            this.ML_Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ML_Text.TabIndex = 1;
            this.ML_Text.TabStop = false;
            // 
            // ML_Logo
            // 
            this.ML_Logo.BackColor = System.Drawing.Color.Transparent;
            this.ML_Logo.Image = global::MelonLoader.Properties.Resources.ML_Logo;
            this.ML_Logo.Location = new System.Drawing.Point(184, 20);
            this.ML_Logo.Name = "ML_Logo";
            this.ML_Logo.Size = new System.Drawing.Size(120, 109);
            this.ML_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ML_Logo.TabIndex = 0;
            this.ML_Logo.TabStop = false;
            // 
            // Automated_Retry
            // 
            this.Automated_Retry.Location = new System.Drawing.Point(154, 97);
            this.Automated_Retry.Name = "Automated_Retry";
            this.Automated_Retry.Size = new System.Drawing.Size(120, 23);
            this.Automated_Retry.Style = MetroFramework.MetroColorStyle.Green;
            this.Automated_Retry.TabIndex = 18;
            this.Automated_Retry.Text = "RETRY";
            this.Automated_Retry.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Automated_Retry.Visible = false;
            this.Automated_Retry.Click += new System.EventHandler(this.Automated_Retry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 441);
            this.Controls.Add(this.InstallerUpdateNotice);
            this.Controls.Add(this.PageManager);
            this.Controls.Add(this.Link_Wiki);
            this.Controls.Add(this.InstallerVersion);
            this.Controls.Add(this.Link_GitHub);
            this.Controls.Add(this.Link_Twitter);
            this.Controls.Add(this.Link_Discord);
            this.Controls.Add(this.ML_Text);
            this.Controls.Add(this.ML_Logo);
            this.Controls.Add(this.Divider);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThemeManager)).EndInit();
            this.PageManager.ResumeLayout(false);
#if DEBUG
            this.Tab_Debug.ResumeLayout(false);
#endif
            this.Tab_Automated.ResumeLayout(false);
            this.Tab_Automated.PerformLayout();
            this.Tab_SelfUpdate.ResumeLayout(false);
            this.Tab_Settings.ResumeLayout(false);
            this.Tab_Settings.PerformLayout();
            this.Tab_Output.ResumeLayout(false);
            this.Tab_Output.PerformLayout();
            this.Tab_ManualZip.ResumeLayout(false);
            this.Tab_ManualZip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Link_Wiki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link_GitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link_Twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link_Discord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox ML_Logo;
        internal System.Windows.Forms.PictureBox ML_Text;
        internal MetroFramework.Components.MetroStyleManager ThemeManager;
        internal System.Windows.Forms.PictureBox Link_Discord;
        internal System.Windows.Forms.PictureBox Link_Twitter;
        internal System.Windows.Forms.PictureBox Link_GitHub;
        internal MetroFramework.Controls.MetroLabel InstallerVersion;
        internal System.Windows.Forms.PictureBox Link_Wiki;
        internal MetroFramework.Controls.MetroTabControl PageManager;
        internal MetroFramework.Controls.MetroTabPage Tab_Settings;
        internal MetroFramework.Controls.MetroComboBox Settings_Theme_Selection;
        internal MetroFramework.Controls.MetroLabel Settings_Theme_Text;
        internal MetroFramework.Controls.MetroCheckBox Settings_AutoUpdateInstaller;
        internal MetroFramework.Controls.MetroCheckBox Settings_CloseAfterCompletion;
        internal MetroFramework.Controls.MetroTabPage Tab_Output;
        internal MetroFramework.Controls.MetroLabel InstallerUpdateNotice;
        internal MetroFramework.Controls.MetroLabel Output_Total_Progress_Text_Label;
        internal MetroFramework.Controls.MetroLabel Output_Total_Progress_Text;
        internal MetroFramework.Controls.MetroLabel Output_Current_Progress_Text_Label;
        internal MetroFramework.Controls.MetroProgressBar Output_Current_Progress_Display;
        internal MetroFramework.Controls.MetroLabel Output_Current_Text;
        internal MetroFramework.Controls.MetroLabel Output_Total_Text;
        internal MetroFramework.Controls.MetroProgressBar Output_Total_Progress_Display;
        internal MetroFramework.Controls.MetroLabel Divider;
        internal MetroFramework.Controls.MetroLabel Output_Current_Operation;
        internal MetroFramework.Controls.MetroLabel Output_Current_Progress_Text;
        internal MetroFramework.Controls.MetroCheckBox Settings_ShowAlphaPreReleases;
        internal MetroFramework.Controls.MetroCheckBox Settings_RememberLastSelectedGame;
        internal MetroFramework.Controls.MetroCheckBox Settings_HighlightLogFileLocation;
        internal MetroFramework.Controls.MetroTabPage Tab_SelfUpdate;
        internal MetroFramework.Controls.MetroLabel SelfUpdate_Text;
        internal MetroFramework.Controls.MetroTabPage Tab_Automated;
        internal MetroFramework.Controls.MetroTabPage Tab_ManualZip;
        internal MetroFramework.Controls.MetroLabel Automated_Text;
        internal MetroFramework.Controls.MetroLabel Automated_Text_Failure;
        internal MetroFramework.Controls.MetroLabel Automated_TmpDivider;
        internal MetroFramework.Controls.MetroLabel Output_TmpDivider;
        internal MetroFramework.Controls.MetroLabel ManualZip_TmpDivider;
        internal MetroFramework.Controls.MetroButton Automated_Retry;
#if DEBUG
        internal MetroFramework.Controls.MetroTabPage Tab_Debug;
        internal MetroFramework.Controls.MetroLabel Debug_LatestInstallerRelease;
        internal MetroFramework.Controls.MetroLabel Debug_LatestInstallerRelease_Text;
        internal MetroFramework.Controls.MetroLabel Debug_AutomatedState_Text;
        internal MetroFramework.Controls.MetroComboBox Debug_AutomatedState;
        internal MetroFramework.Controls.MetroButton Debug_OutputTest;
        internal MetroFramework.Controls.MetroButton Debug_OutputFailureTest;
        internal MetroFramework.Controls.MetroButton Debug_OutputSuccessTest;
#endif
    }
}