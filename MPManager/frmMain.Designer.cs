﻿namespace SessionManagement
{
	// Token: 0x02000002 RID: 2
	public partial class frmMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000044C0 File Offset: 0x000026C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000044F8 File Offset: 0x000026F8
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            WeifenLuo.WinFormsUI.Docking.DockPanelSkin dockPanelSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPanelSkin();
            WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin autoHideStripSkin1 = new WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient1 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin dockPaneStripSkin1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient dockPaneStripGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient2 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient2 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient3 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient dockPaneStripToolWindowGradient1 = new WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient4 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient5 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.DockPanelGradient dockPanelGradient3 = new WeifenLuo.WinFormsUI.Docking.DockPanelGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient6 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            WeifenLuo.WinFormsUI.Docking.TabGradient tabGradient7 = new WeifenLuo.WinFormsUI.Docking.TabGradient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.contextForDocPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeAllButThis = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCloseSession = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDuplicateSession = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRestartSession = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRenameForDocPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.contextChangeSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextRunMultiCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAcceptGlobalCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.contextEventLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.contextFTPExternal = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSFTPExternal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.contextCopyClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.contextClearScollback = new System.Windows.Forms.ToolStripMenuItem();
            this.contextResetTerminal = new System.Windows.Forms.ToolStripMenuItem();
            this.contextResetAndClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAllDatabases = new System.Windows.Forms.ToolStripMenuItem();
            this.mnufileImportDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileCloseAllSessions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolbars = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolbarsStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolbarsQuickConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolbarsMSC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolbarsStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuViewSessionManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsPuTTYSessions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsPuttyConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuToolsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPortScanner = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportFromCsvFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemImportFromXmlFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpHomepage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGlobalCommand = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripGlobalCommandCommand = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripGlobalCommandSession = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripCheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUncheckAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGlobalCommandRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorStatus = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGlobalCommandStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripGlobalCommandStopMultiCommands = new System.Windows.Forms.ToolStripButton();
            this.toolStripQuickConnect = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripQuickConnectProtocol = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripQuickConnectHost = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripQuickConnetUserName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripQuickConnectPassword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripQuickConnecSessionConfig = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripQuickConnectConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripMenuNewDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuOpenDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuSaveDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuImportDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLock = new System.Windows.Forms.ToolStripButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanelMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.checkForNewVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextForDocPanel.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.toolStripGlobalCommand.SuspendLayout();
            this.toolStripQuickConnect.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextForDocPanel
            // 
            this.contextForDocPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextForDocPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextForDocPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllButThis,
            this.contextCloseSession,
            this.contextDuplicateSession,
            this.contextRestartSession,
            this.contextRenameForDocPanel,
            this.contextChangeSettings,
            this.toolStripSeparator3,
            this.contextRunMultiCommands,
            this.contextAcceptGlobalCommand,
            this.toolStripSeparator9,
            this.contextEventLog,
            this.toolStripSeparator6,
            this.contextFTPExternal,
            this.contextSFTPExternal,
            this.toolStripSeparator7,
            this.contextCopyClipboard,
            this.contextClearScollback,
            this.contextResetTerminal,
            this.contextResetAndClear,
            this.toolStripSeparator8});
            this.contextForDocPanel.Name = "contextForDocPanel";
            this.contextForDocPanel.Size = new System.Drawing.Size(261, 364);
            this.contextForDocPanel.Opening += new System.ComponentModel.CancelEventHandler(this.contextForDocPanel_Opening);
            // 
            // closeAllButThis
            // 
            this.closeAllButThis.Name = "closeAllButThis";
            this.closeAllButThis.Size = new System.Drawing.Size(260, 22);
            this.closeAllButThis.Text = "Close All But This";
            this.closeAllButThis.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // contextCloseSession
            // 
            this.contextCloseSession.Name = "contextCloseSession";
            this.contextCloseSession.Size = new System.Drawing.Size(260, 22);
            this.contextCloseSession.Text = "&Close";
            this.contextCloseSession.Click += new System.EventHandler(this.contextCloseSession_Click);
            // 
            // contextDuplicateSession
            // 
            this.contextDuplicateSession.Name = "contextDuplicateSession";
            this.contextDuplicateSession.Size = new System.Drawing.Size(260, 22);
            this.contextDuplicateSession.Text = "Clone Session";
            this.contextDuplicateSession.Click += new System.EventHandler(this.contextDuplicateSession_Click);
            // 
            // contextRestartSession
            // 
            this.contextRestartSession.Name = "contextRestartSession";
            this.contextRestartSession.Size = new System.Drawing.Size(260, 22);
            this.contextRestartSession.Text = "Restart Session";
            this.contextRestartSession.Click += new System.EventHandler(this.contextRestartSession_Click);
            // 
            // contextRenameForDocPanel
            // 
            this.contextRenameForDocPanel.Name = "contextRenameForDocPanel";
            this.contextRenameForDocPanel.Size = new System.Drawing.Size(260, 22);
            this.contextRenameForDocPanel.Text = "Rename Tab";
            this.contextRenameForDocPanel.Click += new System.EventHandler(this.contextRenameForDocPanel_Click);
            // 
            // contextChangeSettings
            // 
            this.contextChangeSettings.Name = "contextChangeSettings";
            this.contextChangeSettings.Size = new System.Drawing.Size(260, 22);
            this.contextChangeSettings.Text = "Change Settings...";
            this.contextChangeSettings.Click += new System.EventHandler(this.contextChangeSettings_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(257, 6);
            // 
            // contextRunMultiCommands
            // 
            this.contextRunMultiCommands.Name = "contextRunMultiCommands";
            this.contextRunMultiCommands.Size = new System.Drawing.Size(260, 22);
            this.contextRunMultiCommands.Text = "Run Multi Commands";
            this.contextRunMultiCommands.Click += new System.EventHandler(this.contextRunMultiCommands_Click);
            // 
            // contextAcceptGlobalCommand
            // 
            this.contextAcceptGlobalCommand.CheckOnClick = true;
            this.contextAcceptGlobalCommand.Name = "contextAcceptGlobalCommand";
            this.contextAcceptGlobalCommand.Size = new System.Drawing.Size(260, 22);
            this.contextAcceptGlobalCommand.Text = "Accept Multi Sessions Command";
            this.contextAcceptGlobalCommand.Click += new System.EventHandler(this.contextAcceptGlobalCommand_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(257, 6);
            // 
            // contextEventLog
            // 
            this.contextEventLog.Name = "contextEventLog";
            this.contextEventLog.Size = new System.Drawing.Size(260, 22);
            this.contextEventLog.Text = "PuTTY Event Log";
            this.contextEventLog.Click += new System.EventHandler(this.contextEventLog_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(257, 6);
            // 
            // contextFTPExternal
            // 
            this.contextFTPExternal.Name = "contextFTPExternal";
            this.contextFTPExternal.Size = new System.Drawing.Size(260, 22);
            this.contextFTPExternal.Text = "FTP Using WinSCP";
            this.contextFTPExternal.Click += new System.EventHandler(this.contextFTPExternal_Click);
            // 
            // contextSFTPExternal
            // 
            this.contextSFTPExternal.Name = "contextSFTPExternal";
            this.contextSFTPExternal.Size = new System.Drawing.Size(260, 22);
            this.contextSFTPExternal.Text = "SFTP Using WinSCP";
            this.contextSFTPExternal.Click += new System.EventHandler(this.contextSFTPExternal_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(257, 6);
            // 
            // contextCopyClipboard
            // 
            this.contextCopyClipboard.Name = "contextCopyClipboard";
            this.contextCopyClipboard.Size = new System.Drawing.Size(260, 22);
            this.contextCopyClipboard.Text = "Copy All to Clipboard";
            this.contextCopyClipboard.Click += new System.EventHandler(this.contextCopyClipboard_Click);
            // 
            // contextClearScollback
            // 
            this.contextClearScollback.Name = "contextClearScollback";
            this.contextClearScollback.Size = new System.Drawing.Size(260, 22);
            this.contextClearScollback.Text = "Clear Scrollback";
            this.contextClearScollback.Click += new System.EventHandler(this.contextClearScollback_Click);
            // 
            // contextResetTerminal
            // 
            this.contextResetTerminal.Name = "contextResetTerminal";
            this.contextResetTerminal.Size = new System.Drawing.Size(260, 22);
            this.contextResetTerminal.Text = "Reset Terminal";
            this.contextResetTerminal.Click += new System.EventHandler(this.contextResetTerminal_Click);
            // 
            // contextResetAndClear
            // 
            this.contextResetAndClear.Name = "contextResetAndClear";
            this.contextResetAndClear.Size = new System.Drawing.Size(260, 22);
            this.contextResetAndClear.Text = "Reset Terminal and Clear Scrollback";
            this.contextResetAndClear.Click += new System.EventHandler(this.contextResetAndClear_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(257, 6);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(1187, 25);
            this.mnuMain.TabIndex = 7;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewDatabase,
            this.mnuFileOpenDatabase,
            this.mnuSaveAllDatabases,
            this.mnufileImportDatabase,
            this.toolStripSeparator11,
            this.mnuFileCloseAllSessions,
            this.toolStripSeparator10,
            this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.MouseEnter += new System.EventHandler(this.fileToolStripMenuItem_MouseEnter);
            // 
            // mnuFileNewDatabase
            // 
            this.mnuFileNewDatabase.Name = "mnuFileNewDatabase";
            this.mnuFileNewDatabase.Size = new System.Drawing.Size(235, 22);
            this.mnuFileNewDatabase.Text = "New database";
            this.mnuFileNewDatabase.Click += new System.EventHandler(this.mnuFileNewDatabase_Click);
            // 
            // mnuFileOpenDatabase
            // 
            this.mnuFileOpenDatabase.Name = "mnuFileOpenDatabase";
            this.mnuFileOpenDatabase.Size = new System.Drawing.Size(235, 22);
            this.mnuFileOpenDatabase.Text = "Open database";
            this.mnuFileOpenDatabase.Click += new System.EventHandler(this.mnuFileOpenDatabase_Click);
            // 
            // mnuSaveAllDatabases
            // 
            this.mnuSaveAllDatabases.Name = "mnuSaveAllDatabases";
            this.mnuSaveAllDatabases.Size = new System.Drawing.Size(235, 22);
            this.mnuSaveAllDatabases.Text = "Save all databases";
            this.mnuSaveAllDatabases.Click += new System.EventHandler(this.mnuSaveAllDatabases_Click);
            // 
            // mnufileImportDatabase
            // 
            this.mnufileImportDatabase.Name = "mnufileImportDatabase";
            this.mnufileImportDatabase.Size = new System.Drawing.Size(235, 22);
            this.mnufileImportDatabase.Text = "Import database from XML file";
            this.mnufileImportDatabase.Click += new System.EventHandler(this.mnufileImportDatabase_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(232, 6);
            // 
            // mnuFileCloseAllSessions
            // 
            this.mnuFileCloseAllSessions.Name = "mnuFileCloseAllSessions";
            this.mnuFileCloseAllSessions.Size = new System.Drawing.Size(235, 22);
            this.mnuFileCloseAllSessions.Text = "Close all sessions";
            this.mnuFileCloseAllSessions.Click += new System.EventHandler(this.mnuFileCloseAllSessions_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(232, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(235, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewToolbars,
            this.toolStripSeparator5,
            this.mnuViewSessionManager});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.MouseEnter += new System.EventHandler(this.viewToolStripMenuItem_MouseEnter);
            // 
            // mnuViewToolbars
            // 
            this.mnuViewToolbars.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewToolbarsStandard,
            this.mnuViewToolbarsQuickConnection,
            this.mnuViewToolbarsMSC,
            this.mnuViewToolbarsStatus});
            this.mnuViewToolbars.Name = "mnuViewToolbars";
            this.mnuViewToolbars.Size = new System.Drawing.Size(168, 22);
            this.mnuViewToolbars.Text = "Toolbars";
            // 
            // mnuViewToolbarsStandard
            // 
            this.mnuViewToolbarsStandard.Checked = true;
            this.mnuViewToolbarsStandard.CheckOnClick = true;
            this.mnuViewToolbarsStandard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewToolbarsStandard.Name = "mnuViewToolbarsStandard";
            this.mnuViewToolbarsStandard.Size = new System.Drawing.Size(209, 22);
            this.mnuViewToolbarsStandard.Text = "Standard";
            this.mnuViewToolbarsStandard.Click += new System.EventHandler(this.mnuViewToolbarsStandard_Click);
            // 
            // mnuViewToolbarsQuickConnection
            // 
            this.mnuViewToolbarsQuickConnection.Checked = true;
            this.mnuViewToolbarsQuickConnection.CheckOnClick = true;
            this.mnuViewToolbarsQuickConnection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewToolbarsQuickConnection.Name = "mnuViewToolbarsQuickConnection";
            this.mnuViewToolbarsQuickConnection.Size = new System.Drawing.Size(209, 22);
            this.mnuViewToolbarsQuickConnection.Text = "Quick Session";
            this.mnuViewToolbarsQuickConnection.Click += new System.EventHandler(this.mnuViewToolbarsQuickConnection_Click);
            // 
            // mnuViewToolbarsMSC
            // 
            this.mnuViewToolbarsMSC.Checked = true;
            this.mnuViewToolbarsMSC.CheckOnClick = true;
            this.mnuViewToolbarsMSC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewToolbarsMSC.Name = "mnuViewToolbarsMSC";
            this.mnuViewToolbarsMSC.Size = new System.Drawing.Size(209, 22);
            this.mnuViewToolbarsMSC.Text = "Multi Sessions Command";
            this.mnuViewToolbarsMSC.Click += new System.EventHandler(this.mnuViewToolbarsMSC_Click);
            // 
            // mnuViewToolbarsStatus
            // 
            this.mnuViewToolbarsStatus.Checked = true;
            this.mnuViewToolbarsStatus.CheckOnClick = true;
            this.mnuViewToolbarsStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewToolbarsStatus.Name = "mnuViewToolbarsStatus";
            this.mnuViewToolbarsStatus.Size = new System.Drawing.Size(209, 22);
            this.mnuViewToolbarsStatus.Text = "Status";
            this.mnuViewToolbarsStatus.Visible = false;
            this.mnuViewToolbarsStatus.Click += new System.EventHandler(this.mnuViewToolbarsStatus_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuViewSessionManager
            // 
            this.mnuViewSessionManager.Checked = true;
            this.mnuViewSessionManager.CheckOnClick = true;
            this.mnuViewSessionManager.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewSessionManager.Name = "mnuViewSessionManager";
            this.mnuViewSessionManager.Size = new System.Drawing.Size(168, 22);
            this.mnuViewSessionManager.Text = "Sessions Manager";
            this.mnuViewSessionManager.Click += new System.EventHandler(this.mnuViewSessionManager_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsPuTTYSessions,
            this.mnuToolsPuttyConfiguration,
            this.toolStripSeparator1,
            this.mnuToolsOption,
            this.toolStripSeparator13,
            this.toolStripMenuItemPortScanner,
            this.toolStripSeparator14,
            this.toolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 19);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.MouseEnter += new System.EventHandler(this.toolsToolStripMenuItem_MouseEnter);
            // 
            // mnuToolsPuTTYSessions
            // 
            this.mnuToolsPuTTYSessions.Name = "mnuToolsPuTTYSessions";
            this.mnuToolsPuTTYSessions.Size = new System.Drawing.Size(184, 22);
            this.mnuToolsPuTTYSessions.Text = "PuTTY Sessions";
            this.mnuToolsPuTTYSessions.Click += new System.EventHandler(this.mnuToolsPuTTYSessions_Click);
            // 
            // mnuToolsPuttyConfiguration
            // 
            this.mnuToolsPuttyConfiguration.Name = "mnuToolsPuttyConfiguration";
            this.mnuToolsPuttyConfiguration.Size = new System.Drawing.Size(184, 22);
            this.mnuToolsPuttyConfiguration.Text = "PuTTY Configuration";
            this.mnuToolsPuttyConfiguration.Click += new System.EventHandler(this.mnuToolPuttyConfiguration_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuToolsOption
            // 
            this.mnuToolsOption.Name = "mnuToolsOption";
            this.mnuToolsOption.Size = new System.Drawing.Size(184, 22);
            this.mnuToolsOption.Text = "Options...";
            this.mnuToolsOption.Click += new System.EventHandler(this.mnuToolsOption_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItemPortScanner
            // 
            this.toolStripMenuItemPortScanner.Enabled = false;
            this.toolStripMenuItemPortScanner.Name = "toolStripMenuItemPortScanner";
            this.toolStripMenuItemPortScanner.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItemPortScanner.Text = "Port Scanner";
            this.toolStripMenuItemPortScanner.Click += new System.EventHandler(this.toolStripMenuItemPortScanner_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemImportFromCsvFile,
            this.toolStripMenuItemImportFromXmlFile});
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem1.Text = "Import";
            // 
            // toolStripMenuItemImportFromCsvFile
            // 
            this.toolStripMenuItemImportFromCsvFile.Enabled = false;
            this.toolStripMenuItemImportFromCsvFile.Name = "toolStripMenuItemImportFromCsvFile";
            this.toolStripMenuItemImportFromCsvFile.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemImportFromCsvFile.Text = "From CSV file";
            // 
            // toolStripMenuItemImportFromXmlFile
            // 
            this.toolStripMenuItemImportFromXmlFile.Enabled = false;
            this.toolStripMenuItemImportFromXmlFile.Name = "toolStripMenuItemImportFromXmlFile";
            this.toolStripMenuItemImportFromXmlFile.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemImportFromXmlFile.Text = "From MPManager XML file";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpHelp,
            this.mnuHelpHomepage,
            this.toolStripSeparator4,
            this.mnuHelpAbout,
            this.checkForNewVersionToolStripMenuItem});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 19);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.MouseEnter += new System.EventHandler(this.mnuHelp_MouseEnter);
            // 
            // mnuHelpHelp
            // 
            this.mnuHelpHelp.Name = "mnuHelpHelp";
            this.mnuHelpHelp.Size = new System.Drawing.Size(203, 22);
            this.mnuHelpHelp.Text = "Help";
            this.mnuHelpHelp.Click += new System.EventHandler(this.mnuHelpHelp_Click);
            // 
            // mnuHelpHomepage
            // 
            this.mnuHelpHomepage.Name = "mnuHelpHomepage";
            this.mnuHelpHomepage.Size = new System.Drawing.Size(203, 22);
            this.mnuHelpHomepage.Text = "Homepage";
            this.mnuHelpHomepage.Click += new System.EventHandler(this.mnuHelpHomepage_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(200, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(203, 22);
            this.mnuHelpAbout.Text = "About...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // toolStripGlobalCommand
            // 
            this.toolStripGlobalCommand.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripGlobalCommand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripGlobalCommand.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripGlobalCommand.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel7,
            this.toolStripGlobalCommandCommand,
            this.toolStripGlobalCommandSession,
            this.toolStripGlobalCommandRun,
            this.toolStripSeparatorStatus,
            this.toolStripGlobalCommandStatus,
            this.toolStripGlobalCommandStopMultiCommands});
            this.toolStripGlobalCommand.Location = new System.Drawing.Point(0, 77);
            this.toolStripGlobalCommand.Name = "toolStripGlobalCommand";
            this.toolStripGlobalCommand.Size = new System.Drawing.Size(1187, 25);
            this.toolStripGlobalCommand.TabIndex = 16;
            this.toolStripGlobalCommand.Text = "toolStrip1";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(142, 22);
            this.toolStripLabel7.Text = "Multi Sessions Command";
            // 
            // toolStripGlobalCommandCommand
            // 
            this.toolStripGlobalCommandCommand.Name = "toolStripGlobalCommandCommand";
            this.toolStripGlobalCommandCommand.Size = new System.Drawing.Size(400, 25);
            this.toolStripGlobalCommandCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripGlobalCommandCommand_KeyPress);
            this.toolStripGlobalCommandCommand.MouseEnter += new System.EventHandler(this.toolStripGlobalCommandCommand_MouseEnter);
            // 
            // toolStripGlobalCommandSession
            // 
            this.toolStripGlobalCommandSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripGlobalCommandSession.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCheckAll,
            this.toolStripUncheckAll,
            this.toolStripSeparator2});
            this.toolStripGlobalCommandSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGlobalCommandSession.Name = "toolStripGlobalCommandSession";
            this.toolStripGlobalCommandSession.Size = new System.Drawing.Size(67, 22);
            this.toolStripGlobalCommandSession.Text = "Sessions";
            this.toolStripGlobalCommandSession.ButtonClick += new System.EventHandler(this.toolStripGlobalCommandSession_ButtonClick);
            this.toolStripGlobalCommandSession.MouseEnter += new System.EventHandler(this.toolStripGlobalCommandSession_MouseEnter);
            // 
            // toolStripCheckAll
            // 
            this.toolStripCheckAll.Name = "toolStripCheckAll";
            this.toolStripCheckAll.Size = new System.Drawing.Size(135, 22);
            this.toolStripCheckAll.Text = "All Sessions";
            this.toolStripCheckAll.Click += new System.EventHandler(this.toolStripCheckAll_Click);
            // 
            // toolStripUncheckAll
            // 
            this.toolStripUncheckAll.Name = "toolStripUncheckAll";
            this.toolStripUncheckAll.Size = new System.Drawing.Size(135, 22);
            this.toolStripUncheckAll.Text = "None";
            this.toolStripUncheckAll.Click += new System.EventHandler(this.toolStripUncheckAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(132, 6);
            // 
            // toolStripGlobalCommandRun
            // 
            this.toolStripGlobalCommandRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripGlobalCommandRun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGlobalCommandRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGlobalCommandRun.Name = "toolStripGlobalCommandRun";
            this.toolStripGlobalCommandRun.Size = new System.Drawing.Size(23, 22);
            this.toolStripGlobalCommandRun.ToolTipText = "Run Command";
            this.toolStripGlobalCommandRun.Click += new System.EventHandler(this.toolStripGlobalCommandRun_Click);
            this.toolStripGlobalCommandRun.MouseEnter += new System.EventHandler(this.toolStripGlobalCommandRun_MouseEnter);
            // 
            // toolStripSeparatorStatus
            // 
            this.toolStripSeparatorStatus.Name = "toolStripSeparatorStatus";
            this.toolStripSeparatorStatus.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripGlobalCommandStatus
            // 
            this.toolStripGlobalCommandStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripGlobalCommandStatus.Name = "toolStripGlobalCommandStatus";
            this.toolStripGlobalCommandStatus.Size = new System.Drawing.Size(39, 22);
            this.toolStripGlobalCommandStatus.Text = "Status";
            // 
            // toolStripGlobalCommandStopMultiCommands
            // 
            this.toolStripGlobalCommandStopMultiCommands.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGlobalCommandStopMultiCommands.Name = "toolStripGlobalCommandStopMultiCommands";
            this.toolStripGlobalCommandStopMultiCommands.Size = new System.Drawing.Size(131, 22);
            this.toolStripGlobalCommandStopMultiCommands.Text = "Stop Multi Commands";
            this.toolStripGlobalCommandStopMultiCommands.Click += new System.EventHandler(this.toolStripGlobalCommandStopMultiCommands_Click);
            this.toolStripGlobalCommandStopMultiCommands.MouseEnter += new System.EventHandler(this.toolStripGlobalCommandStopMultiCommands_MouseEnter);
            // 
            // toolStripQuickConnect
            // 
            this.toolStripQuickConnect.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripQuickConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripQuickConnect.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripQuickConnect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripQuickConnectProtocol,
            this.toolStripLabel3,
            this.toolStripQuickConnectHost,
            this.toolStripLabel4,
            this.toolStripQuickConnetUserName,
            this.toolStripLabel5,
            this.toolStripQuickConnectPassword,
            this.toolStripLabel6,
            this.toolStripQuickConnecSessionConfig,
            this.toolStripQuickConnectConnect});
            this.toolStripQuickConnect.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripQuickConnect.Location = new System.Drawing.Point(0, 52);
            this.toolStripQuickConnect.Name = "toolStripQuickConnect";
            this.toolStripQuickConnect.Size = new System.Drawing.Size(1187, 25);
            this.toolStripQuickConnect.TabIndex = 15;
            this.toolStripQuickConnect.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel2.Text = "Protocol";
            // 
            // toolStripQuickConnectProtocol
            // 
            this.toolStripQuickConnectProtocol.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripQuickConnectProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripQuickConnectProtocol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripQuickConnectProtocol.Items.AddRange(new object[] {
            "Telnet",
            "SSH",
            "Raw",
            "RLogin"});
            this.toolStripQuickConnectProtocol.Name = "toolStripQuickConnectProtocol";
            this.toolStripQuickConnectProtocol.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel3.Text = "Host";
            // 
            // toolStripQuickConnectHost
            // 
            this.toolStripQuickConnectHost.Name = "toolStripQuickConnectHost";
            this.toolStripQuickConnectHost.Size = new System.Drawing.Size(140, 25);
            this.toolStripQuickConnectHost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripQuickConnectHost_KeyPress);
            this.toolStripQuickConnectHost.MouseEnter += new System.EventHandler(this.toolStripQuickConnectHost_MouseEnter);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel4.Text = "Login as";
            // 
            // toolStripQuickConnetUserName
            // 
            this.toolStripQuickConnetUserName.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripQuickConnetUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripQuickConnetUserName.Name = "toolStripQuickConnetUserName";
            this.toolStripQuickConnetUserName.Size = new System.Drawing.Size(100, 25);
            this.toolStripQuickConnetUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripQuickConnetUserName_KeyPress);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel5.Text = "Password";
            // 
            // toolStripQuickConnectPassword
            // 
            this.toolStripQuickConnectPassword.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripQuickConnectPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripQuickConnectPassword.Name = "toolStripQuickConnectPassword";
            this.toolStripQuickConnectPassword.Size = new System.Drawing.Size(100, 25);
            this.toolStripQuickConnectPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripQuickConnectPassword_KeyPress);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel6.Text = "PuTTY Setting";
            // 
            // toolStripQuickConnecSessionConfig
            // 
            this.toolStripQuickConnecSessionConfig.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripQuickConnecSessionConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripQuickConnecSessionConfig.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripQuickConnecSessionConfig.Items.AddRange(new object[] {
            "Default Settings"});
            this.toolStripQuickConnecSessionConfig.MaxDropDownItems = 100;
            this.toolStripQuickConnecSessionConfig.Name = "toolStripQuickConnecSessionConfig";
            this.toolStripQuickConnecSessionConfig.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripQuickConnectConnect
            // 
            this.toolStripQuickConnectConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripQuickConnectConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripQuickConnectConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripQuickConnectConnect.Name = "toolStripQuickConnectConnect";
            this.toolStripQuickConnectConnect.Size = new System.Drawing.Size(23, 22);
            this.toolStripQuickConnectConnect.ToolTipText = "Open Session";
            this.toolStripQuickConnectConnect.Click += new System.EventHandler(this.toolStripQuickConnectConnect_Click);
            this.toolStripQuickConnectConnect.MouseEnter += new System.EventHandler(this.toolStripQuickConnectConnect_MouseEnter);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuNewDatabase,
            this.toolStripMenuOpenDatabase,
            this.toolStripMenuSaveDatabase,
            this.toolStripSeparator,
            this.toolStripMenuImportDatabase,
            this.toolStripMenuDisconnect,
            this.toolStripSeparator12,
            this.toolStripButtonLock});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 25);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1187, 27);
            this.toolStripMenu.TabIndex = 14;
            this.toolStripMenu.Text = "Standard";
            this.toolStripMenu.MouseEnter += new System.EventHandler(this.toolStripMenu_MouseEnter);
            // 
            // toolStripMenuNewDatabase
            // 
            this.toolStripMenuNewDatabase.Image = global::SessionManagement.Properties.Resources.Database;
            this.toolStripMenuNewDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuNewDatabase.Name = "toolStripMenuNewDatabase";
            this.toolStripMenuNewDatabase.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuNewDatabase.Text = "&New";
            this.toolStripMenuNewDatabase.ToolTipText = "Create new database";
            this.toolStripMenuNewDatabase.Click += new System.EventHandler(this.toolStripMenuNewDatabase_Click);
            this.toolStripMenuNewDatabase.MouseEnter += new System.EventHandler(this.toolStripMenuNewDatabase_MouseEnter);
            // 
            // toolStripMenuOpenDatabase
            // 
            this.toolStripMenuOpenDatabase.Image = global::SessionManagement.Properties.Resources.OpenFile;
            this.toolStripMenuOpenDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuOpenDatabase.Name = "toolStripMenuOpenDatabase";
            this.toolStripMenuOpenDatabase.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuOpenDatabase.Text = "&Open";
            this.toolStripMenuOpenDatabase.ToolTipText = "Open database";
            this.toolStripMenuOpenDatabase.Click += new System.EventHandler(this.toolStripMenuOpenDatabase_Click);
            this.toolStripMenuOpenDatabase.MouseEnter += new System.EventHandler(this.toolStripMenuOpenDatabase_MouseEnter);
            // 
            // toolStripMenuSaveDatabase
            // 
            this.toolStripMenuSaveDatabase.Image = global::SessionManagement.Properties.Resources.Save;
            this.toolStripMenuSaveDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuSaveDatabase.Name = "toolStripMenuSaveDatabase";
            this.toolStripMenuSaveDatabase.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuSaveDatabase.Text = "&Save";
            this.toolStripMenuSaveDatabase.ToolTipText = "Save all databases";
            this.toolStripMenuSaveDatabase.Click += new System.EventHandler(this.toolStripMenuSaveDatabase_Click);
            this.toolStripMenuSaveDatabase.MouseEnter += new System.EventHandler(this.toolStripMenuSaveDatabase_MouseEnter);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripMenuImportDatabase
            // 
            this.toolStripMenuImportDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripMenuImportDatabase.Image = global::SessionManagement.Properties.Resources.Import;
            this.toolStripMenuImportDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuImportDatabase.Name = "toolStripMenuImportDatabase";
            this.toolStripMenuImportDatabase.Size = new System.Drawing.Size(118, 24);
            this.toolStripMenuImportDatabase.Text = "Import Database";
            this.toolStripMenuImportDatabase.ToolTipText = "Import database from XML file";
            this.toolStripMenuImportDatabase.Click += new System.EventHandler(this.toolStripMenuImportDatabase_Click);
            this.toolStripMenuImportDatabase.MouseEnter += new System.EventHandler(this.toolStripMenuImportDatabase_MouseEnter);
            // 
            // toolStripMenuDisconnect
            // 
            this.toolStripMenuDisconnect.Image = global::SessionManagement.Properties.Resources.CloseAll;
            this.toolStripMenuDisconnect.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuDisconnect.Name = "toolStripMenuDisconnect";
            this.toolStripMenuDisconnect.Size = new System.Drawing.Size(124, 24);
            this.toolStripMenuDisconnect.Text = "Close All Sessions";
            this.toolStripMenuDisconnect.ToolTipText = "Close all sessions";
            this.toolStripMenuDisconnect.Click += new System.EventHandler(this.toolStripMenuDisconnect_Click);
            this.toolStripMenuDisconnect.MouseEnter += new System.EventHandler(this.toolStripMenuDisconnect_MouseEnter);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonLock
            // 
            this.toolStripButtonLock.Image = global::SessionManagement.Properties.Resources.Lock;
            this.toolStripButtonLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLock.Name = "toolStripButtonLock";
            this.toolStripButtonLock.Size = new System.Drawing.Size(120, 24);
            this.toolStripButtonLock.Text = "Lock Application";
            this.toolStripButtonLock.ToolTipText = "Lock";
            this.toolStripButtonLock.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 529);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1187, 22);
            this.statusBar.TabIndex = 20;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarStatus
            // 
            this.statusBarStatus.Name = "statusBarStatus";
            this.statusBarStatus.Size = new System.Drawing.Size(39, 17);
            this.statusBarStatus.Text = "Status";
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.BackColor = System.Drawing.Color.Lavender;
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.DockBackColor = System.Drawing.SystemColors.ControlLight;
            this.dockPanelMain.DockLeftPortion = 0.22D;
            this.dockPanelMain.DockRightPortion = 0.22D;
            this.dockPanelMain.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 102);
            this.dockPanelMain.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.Size = new System.Drawing.Size(1187, 427);
            dockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient1.StartColor = System.Drawing.SystemColors.ControlLight;
            autoHideStripSkin1.DockStripGradient = dockPanelGradient1;
            tabGradient1.EndColor = System.Drawing.SystemColors.Control;
            tabGradient1.StartColor = System.Drawing.SystemColors.Control;
            tabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            autoHideStripSkin1.TabGradient = tabGradient1;
            autoHideStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            dockPanelSkin1.AutoHideStripSkin = autoHideStripSkin1;
            tabGradient2.EndColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.StartColor = System.Drawing.SystemColors.ControlLightLight;
            tabGradient2.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.ActiveTabGradient = tabGradient2;
            dockPanelGradient2.EndColor = System.Drawing.SystemColors.Control;
            dockPanelGradient2.StartColor = System.Drawing.SystemColors.Control;
            dockPaneStripGradient1.DockStripGradient = dockPanelGradient2;
            tabGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            tabGradient3.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripGradient1.InactiveTabGradient = tabGradient3;
            dockPaneStripSkin1.DocumentGradient = dockPaneStripGradient1;
            dockPaneStripSkin1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            tabGradient4.EndColor = System.Drawing.SystemColors.ActiveCaption;
            tabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient4.StartColor = System.Drawing.SystemColors.GradientActiveCaption;
            tabGradient4.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            dockPaneStripToolWindowGradient1.ActiveCaptionGradient = tabGradient4;
            tabGradient5.EndColor = System.Drawing.SystemColors.Control;
            tabGradient5.StartColor = System.Drawing.SystemColors.Control;
            tabGradient5.TextColor = System.Drawing.SystemColors.ControlText;
            dockPaneStripToolWindowGradient1.ActiveTabGradient = tabGradient5;
            dockPanelGradient3.EndColor = System.Drawing.SystemColors.ControlLight;
            dockPanelGradient3.StartColor = System.Drawing.SystemColors.ControlLight;
            dockPaneStripToolWindowGradient1.DockStripGradient = dockPanelGradient3;
            tabGradient6.EndColor = System.Drawing.SystemColors.InactiveCaption;
            tabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            tabGradient6.StartColor = System.Drawing.SystemColors.GradientInactiveCaption;
            tabGradient6.TextColor = System.Drawing.SystemColors.InactiveCaptionText;
            dockPaneStripToolWindowGradient1.InactiveCaptionGradient = tabGradient6;
            tabGradient7.EndColor = System.Drawing.Color.Transparent;
            tabGradient7.StartColor = System.Drawing.Color.Transparent;
            tabGradient7.TextColor = System.Drawing.SystemColors.ControlDarkDark;
            dockPaneStripToolWindowGradient1.InactiveTabGradient = tabGradient7;
            dockPaneStripSkin1.ToolWindowGradient = dockPaneStripToolWindowGradient1;
            dockPanelSkin1.DockPaneStripSkin = dockPaneStripSkin1;
            this.dockPanelMain.Skin = dockPanelSkin1;
            this.dockPanelMain.TabIndex = 21;
            this.dockPanelMain.ActiveDocumentChanged += new System.EventHandler(this.dockPanelMain_ActiveDocumentChanged);
            // 
            // checkForNewVersionToolStripMenuItem
            // 
            this.checkForNewVersionToolStripMenuItem.Name = "checkForNewVersionToolStripMenuItem";
            this.checkForNewVersionToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.checkForNewVersionToolStripMenuItem.Text = "Check for new version ...";
            this.checkForNewVersionToolStripMenuItem.Click += new System.EventHandler(this.checkForNewVersionToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1187, 551);
            this.Controls.Add(this.dockPanelMain);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolStripGlobalCommand);
            this.Controls.Add(this.toolStripQuickConnect);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Multi PuTTY Manager Secure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Deactivate += new System.EventHandler(this.frmMain_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextForDocPanel.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.toolStripGlobalCommand.ResumeLayout(false);
            this.toolStripGlobalCommand.PerformLayout();
            this.toolStripQuickConnect.ResumeLayout(false);
            this.toolStripQuickConnect.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.MenuStrip mnuMain;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ToolStripMenuItem mnuHelp;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ContextMenuStrip contextForDocPanel;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ToolStripMenuItem contextRenameForDocPanel;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ToolStripMenuItem contextSFTPExternal;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ToolStripMenuItem contextFTPExternal;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ToolStripMenuItem contextDuplicateSession;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ToolStrip toolStripGlobalCommand;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolStrip toolStripMenu;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel2;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripComboBox toolStripQuickConnectProtocol;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel3;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel4;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ToolStripTextBox toolStripQuickConnetUserName;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel5;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ToolStripTextBox toolStripQuickConnectPassword;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel6;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripComboBox toolStripQuickConnecSessionConfig;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripButton toolStripQuickConnectConnect;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel7;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ToolStripButton toolStripGlobalCommandRun;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ToolStripButton toolStripMenuNewDatabase;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ToolStripButton toolStripMenuOpenDatabase;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ToolStripButton toolStripMenuSaveDatabase;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ToolStrip toolStripQuickConnect;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.ToolStripMenuItem contextCloseSession;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ToolStripSplitButton toolStripGlobalCommandSession;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ToolStripMenuItem toolStripCheckAll;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ToolStripMenuItem toolStripUncheckAll;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewSessionManager;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.ToolStripButton toolStripMenuDisconnect;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem mnuToolsPuttyConfiguration;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ToolStripMenuItem mnuToolsOption;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.StatusStrip statusBar;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.ToolStripStatusLabel statusBarStatus;

		// Token: 0x0400003B RID: 59
		private global::WeifenLuo.WinFormsUI.Docking.DockPanel dockPanelMain;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbars;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbarsStandard;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbarsQuickConnection;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbarsMSC;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ToolStripMenuItem mnuViewToolbarsStatus;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ToolStripComboBox toolStripGlobalCommandCommand;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ToolStripComboBox toolStripQuickConnectHost;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.ToolStripMenuItem mnuFileExit;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ToolStripMenuItem contextChangeSettings;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator9;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.ToolStripMenuItem contextEventLog;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.ToolStripMenuItem contextCopyClipboard;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.ToolStripMenuItem contextClearScollback;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.ToolStripMenuItem contextResetTerminal;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.ToolStripMenuItem contextResetAndClear;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.ToolStripMenuItem mnuFileNewDatabase;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.ToolStripMenuItem mnuFileOpenDatabase;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.ToolStripMenuItem mnuSaveAllDatabases;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.ToolStripMenuItem mnufileImportDatabase;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator11;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.ToolStripMenuItem mnuFileCloseAllSessions;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.ToolStripButton toolStripMenuImportDatabase;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.ToolStripMenuItem mnuToolsPuTTYSessions;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparatorStatus;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.ToolStripLabel toolStripGlobalCommandStatus;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ToolStripMenuItem contextAcceptGlobalCommand;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ToolStripButton toolStripGlobalCommandStopMultiCommands;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ToolStripMenuItem contextRunMultiCommands;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.ToolStripMenuItem mnuHelpHelp;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.ToolStripMenuItem mnuHelpHomepage;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.ToolStripMenuItem contextRestartSession;
        private System.Windows.Forms.ToolStripMenuItem closeAllButThis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton toolStripButtonLock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPortScanner;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportFromCsvFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemImportFromXmlFile;
        private System.Windows.Forms.ToolStripMenuItem checkForNewVersionToolStripMenuItem;
    }
}
