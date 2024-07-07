﻿namespace SessionManagement
{
	// Token: 0x02000010 RID: 16
	public partial class frmSessionManager : global::WeifenLuo.WinFormsUI.Docking.DockContent
	{
		// Token: 0x06000136 RID: 310 RVA: 0x000113BC File Offset: 0x0000F5BC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000113F4 File Offset: 0x0000F5F4
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessionManager));
            this.contextForDatabase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextNewForDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSessionForDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFolderForDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPasteForDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSaveForDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.contextSetDefaultForDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPropertiesForDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextCloseDatabaseForDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextForTreeSession = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextCreateDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.contextOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListSessionManager = new System.Windows.Forms.ImageList(this.components);
            this.contextForFolder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextNewForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSessionForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFolderForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.contextConnectAllForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.contextCutForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCopyForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPasteForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDeleteForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRenameForFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextForSession = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.contextConnectExternal = new System.Windows.Forms.ToolStripMenuItem();
            this.contextFTPExternal = new System.Windows.Forms.ToolStripMenuItem();
            this.contextSFTPExternal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemXwindowsStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextCutForSession = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCopyForSession = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDeleteForSession = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRenameForSession = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextConfigForSession = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSessionSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSessionSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSearchReset = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeSessions = new System.Windows.Forms.TreeView();
            this.contextForDatabase.SuspendLayout();
            this.contextForTreeSession.SuspendLayout();
            this.contextForFolder.SuspendLayout();
            this.contextForSession.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextForDatabase
            // 
            this.contextForDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextForDatabase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextNewForDatabase,
            this.contextPasteForDatabase,
            this.contextSaveForDatabase,
            this.toolStripSeparator5,
            this.contextSetDefaultForDatabase,
            this.contextPropertiesForDatabase,
            this.toolStripSeparator3,
            this.contextCloseDatabaseForDatabase});
            this.contextForDatabase.Name = "contextForDatabase";
            this.contextForDatabase.Size = new System.Drawing.Size(195, 148);
            this.contextForDatabase.Opening += new System.ComponentModel.CancelEventHandler(this.contextForDatabase_Opening);
            // 
            // contextNewForDatabase
            // 
            this.contextNewForDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextSessionForDatabase,
            this.contextFolderForDatabase});
            this.contextNewForDatabase.Name = "contextNewForDatabase";
            this.contextNewForDatabase.Size = new System.Drawing.Size(194, 22);
            this.contextNewForDatabase.Text = "New";
            // 
            // contextSessionForDatabase
            // 
            this.contextSessionForDatabase.Name = "contextSessionForDatabase";
            this.contextSessionForDatabase.Size = new System.Drawing.Size(113, 22);
            this.contextSessionForDatabase.Text = "Session";
            this.contextSessionForDatabase.Click += new System.EventHandler(this.contextSessionForDatabase_Click);
            // 
            // contextFolderForDatabase
            // 
            this.contextFolderForDatabase.Name = "contextFolderForDatabase";
            this.contextFolderForDatabase.Size = new System.Drawing.Size(113, 22);
            this.contextFolderForDatabase.Text = "Folder";
            this.contextFolderForDatabase.Click += new System.EventHandler(this.contextFolderForDatabase_Click);
            // 
            // contextPasteForDatabase
            // 
            this.contextPasteForDatabase.Name = "contextPasteForDatabase";
            this.contextPasteForDatabase.Size = new System.Drawing.Size(194, 22);
            this.contextPasteForDatabase.Text = "Paste";
            this.contextPasteForDatabase.Click += new System.EventHandler(this.contextPasteForDatabase_Click);
            // 
            // contextSaveForDatabase
            // 
            this.contextSaveForDatabase.Name = "contextSaveForDatabase";
            this.contextSaveForDatabase.Size = new System.Drawing.Size(194, 22);
            this.contextSaveForDatabase.Text = "Save";
            this.contextSaveForDatabase.Click += new System.EventHandler(this.contextSaveForDatabase_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(191, 6);
            // 
            // contextSetDefaultForDatabase
            // 
            this.contextSetDefaultForDatabase.Name = "contextSetDefaultForDatabase";
            this.contextSetDefaultForDatabase.Size = new System.Drawing.Size(194, 22);
            this.contextSetDefaultForDatabase.Text = "Set as default database";
            this.contextSetDefaultForDatabase.Click += new System.EventHandler(this.contextSetDefaultForDatabase_Click);
            // 
            // contextPropertiesForDatabase
            // 
            this.contextPropertiesForDatabase.Name = "contextPropertiesForDatabase";
            this.contextPropertiesForDatabase.Size = new System.Drawing.Size(194, 22);
            this.contextPropertiesForDatabase.Text = "Properties";
            this.contextPropertiesForDatabase.Click += new System.EventHandler(this.contextPropertiesForDatabase_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // contextCloseDatabaseForDatabase
            // 
            this.contextCloseDatabaseForDatabase.Name = "contextCloseDatabaseForDatabase";
            this.contextCloseDatabaseForDatabase.Size = new System.Drawing.Size(194, 22);
            this.contextCloseDatabaseForDatabase.Text = "Close database";
            this.contextCloseDatabaseForDatabase.Click += new System.EventHandler(this.contextCloseDatabaseForDatabase_Click);
            // 
            // contextForTreeSession
            // 
            this.contextForTreeSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextForTreeSession.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextCreateDatabase,
            this.contextOpenDatabase});
            this.contextForTreeSession.Name = "contextForTreeSession";
            this.contextForTreeSession.Size = new System.Drawing.Size(159, 48);
            // 
            // contextCreateDatabase
            // 
            this.contextCreateDatabase.Name = "contextCreateDatabase";
            this.contextCreateDatabase.Size = new System.Drawing.Size(158, 22);
            this.contextCreateDatabase.Text = "Create database";
            this.contextCreateDatabase.Click += new System.EventHandler(this.contextCreateDatabase_Click);
            // 
            // contextOpenDatabase
            // 
            this.contextOpenDatabase.Name = "contextOpenDatabase";
            this.contextOpenDatabase.Size = new System.Drawing.Size(158, 22);
            this.contextOpenDatabase.Text = "Open database";
            this.contextOpenDatabase.Click += new System.EventHandler(this.contextOpenDatabase_Click);
            // 
            // imageListSessionManager
            // 
            this.imageListSessionManager.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSessionManager.ImageStream")));
            this.imageListSessionManager.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSessionManager.Images.SetKeyName(0, "Database.png");
            this.imageListSessionManager.Images.SetKeyName(1, "FolderOpened.png");
            this.imageListSessionManager.Images.SetKeyName(2, "Monitor.png");
            this.imageListSessionManager.Images.SetKeyName(3, "Cut.png");
            this.imageListSessionManager.Images.SetKeyName(4, "Cut.png");
            // 
            // contextForFolder
            // 
            this.contextForFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextForFolder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextNewForFolder,
            this.toolStripSeparator6,
            this.contextConnectAllForFolder,
            this.toolStripSeparator4,
            this.contextCutForFolder,
            this.contextCopyForFolder,
            this.contextPasteForFolder,
            this.contextDeleteForFolder,
            this.contextRenameForFolder});
            this.contextForFolder.Name = "contextForFolder";
            this.contextForFolder.Size = new System.Drawing.Size(168, 170);
            this.contextForFolder.Opening += new System.ComponentModel.CancelEventHandler(this.contextForFolder_Opening);
            // 
            // contextNewForFolder
            // 
            this.contextNewForFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextSessionForFolder,
            this.contextFolderForFolder});
            this.contextNewForFolder.Name = "contextNewForFolder";
            this.contextNewForFolder.Size = new System.Drawing.Size(167, 22);
            this.contextNewForFolder.Text = "New";
            // 
            // contextSessionForFolder
            // 
            this.contextSessionForFolder.Name = "contextSessionForFolder";
            this.contextSessionForFolder.Size = new System.Drawing.Size(113, 22);
            this.contextSessionForFolder.Text = "Session";
            this.contextSessionForFolder.Click += new System.EventHandler(this.contextSessionForFolder_Click);
            // 
            // contextFolderForFolder
            // 
            this.contextFolderForFolder.Name = "contextFolderForFolder";
            this.contextFolderForFolder.Size = new System.Drawing.Size(113, 22);
            this.contextFolderForFolder.Text = "Folder";
            this.contextFolderForFolder.Click += new System.EventHandler(this.contextFolderForFolder_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(164, 6);
            // 
            // contextConnectAllForFolder
            // 
            this.contextConnectAllForFolder.Name = "contextConnectAllForFolder";
            this.contextConnectAllForFolder.Size = new System.Drawing.Size(167, 22);
            this.contextConnectAllForFolder.Text = "Open All Sessions";
            this.contextConnectAllForFolder.Click += new System.EventHandler(this.contextConnectAllForFolder_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(164, 6);
            // 
            // contextCutForFolder
            // 
            this.contextCutForFolder.Name = "contextCutForFolder";
            this.contextCutForFolder.Size = new System.Drawing.Size(167, 22);
            this.contextCutForFolder.Text = "Cut";
            this.contextCutForFolder.Click += new System.EventHandler(this.contextCutForFolder_Click);
            // 
            // contextCopyForFolder
            // 
            this.contextCopyForFolder.Name = "contextCopyForFolder";
            this.contextCopyForFolder.Size = new System.Drawing.Size(167, 22);
            this.contextCopyForFolder.Text = "Copy";
            this.contextCopyForFolder.Click += new System.EventHandler(this.contextCopyForFolder_Click);
            // 
            // contextPasteForFolder
            // 
            this.contextPasteForFolder.Name = "contextPasteForFolder";
            this.contextPasteForFolder.Size = new System.Drawing.Size(167, 22);
            this.contextPasteForFolder.Text = "Paste";
            this.contextPasteForFolder.Click += new System.EventHandler(this.contextPasteForFolder_Click);
            // 
            // contextDeleteForFolder
            // 
            this.contextDeleteForFolder.Name = "contextDeleteForFolder";
            this.contextDeleteForFolder.Size = new System.Drawing.Size(167, 22);
            this.contextDeleteForFolder.Text = "Delete";
            this.contextDeleteForFolder.Click += new System.EventHandler(this.contextDeleteForFolder_Click);
            // 
            // contextRenameForFolder
            // 
            this.contextRenameForFolder.Name = "contextRenameForFolder";
            this.contextRenameForFolder.Size = new System.Drawing.Size(167, 22);
            this.contextRenameForFolder.Text = "Rename";
            this.contextRenameForFolder.Click += new System.EventHandler(this.contextRenameForFolder_Click);
            // 
            // contextForSession
            // 
            this.contextForSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextForSession.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextForSession.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextConnect,
            this.contextConnectExternal,
            this.contextFTPExternal,
            this.contextSFTPExternal,
            this.toolStripMenuItemXwindowsStart,
            this.toolStripSeparator1,
            this.contextCutForSession,
            this.contextCopyForSession,
            this.contextDeleteForSession,
            this.contextRenameForSession,
            this.toolStripSeparator2,
            this.contextConfigForSession});
            this.contextForSession.Name = "contextForSession";
            this.contextForSession.Size = new System.Drawing.Size(201, 236);
            // 
            // contextConnect
            // 
            this.contextConnect.Name = "contextConnect";
            this.contextConnect.Size = new System.Drawing.Size(200, 22);
            this.contextConnect.Text = "Open Session";
            this.contextConnect.Click += new System.EventHandler(this.contextConnect_Click);
            // 
            // contextConnectExternal
            // 
            this.contextConnectExternal.Name = "contextConnectExternal";
            this.contextConnectExternal.Size = new System.Drawing.Size(200, 22);
            this.contextConnectExternal.Text = "Open Session External";
            this.contextConnectExternal.Click += new System.EventHandler(this.contextConnectExternal_Click);
            // 
            // contextFTPExternal
            // 
            this.contextFTPExternal.Name = "contextFTPExternal";
            this.contextFTPExternal.Size = new System.Drawing.Size(200, 22);
            this.contextFTPExternal.Text = "FTP Using WinSCP";
            this.contextFTPExternal.Click += new System.EventHandler(this.contextFTPExternal_Click);
            // 
            // contextSFTPExternal
            // 
            this.contextSFTPExternal.Name = "contextSFTPExternal";
            this.contextSFTPExternal.Size = new System.Drawing.Size(200, 22);
            this.contextSFTPExternal.Text = "SFTP Using WinSCP";
            this.contextSFTPExternal.Click += new System.EventHandler(this.contextSFTPExternal_Click);
            // 
            // toolStripMenuItemXwindowsStart
            // 
            this.toolStripMenuItemXwindowsStart.Name = "toolStripMenuItemXwindowsStart";
            this.toolStripMenuItemXwindowsStart.Size = new System.Drawing.Size(200, 22);
            this.toolStripMenuItemXwindowsStart.Text = "XWindows Using VcXsrv";
            this.toolStripMenuItemXwindowsStart.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripMenuItemXwindowsStart.Click += new System.EventHandler(this.toolStripMenuItemXwindowsStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // contextCutForSession
            // 
            this.contextCutForSession.Name = "contextCutForSession";
            this.contextCutForSession.Size = new System.Drawing.Size(200, 22);
            this.contextCutForSession.Text = "Cut";
            this.contextCutForSession.Click += new System.EventHandler(this.contextCutForSession_Click);
            // 
            // contextCopyForSession
            // 
            this.contextCopyForSession.Name = "contextCopyForSession";
            this.contextCopyForSession.Size = new System.Drawing.Size(200, 22);
            this.contextCopyForSession.Text = "Copy";
            this.contextCopyForSession.Click += new System.EventHandler(this.contextCopyForSession_Click);
            // 
            // contextDeleteForSession
            // 
            this.contextDeleteForSession.Name = "contextDeleteForSession";
            this.contextDeleteForSession.Size = new System.Drawing.Size(200, 22);
            this.contextDeleteForSession.Text = "Delete";
            this.contextDeleteForSession.Click += new System.EventHandler(this.contextDeleteForSession_Click);
            // 
            // contextRenameForSession
            // 
            this.contextRenameForSession.Name = "contextRenameForSession";
            this.contextRenameForSession.Size = new System.Drawing.Size(200, 22);
            this.contextRenameForSession.Text = "Rename";
            this.contextRenameForSession.Click += new System.EventHandler(this.contextRenameForSession_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // contextConfigForSession
            // 
            this.contextConfigForSession.Name = "contextConfigForSession";
            this.contextConfigForSession.Size = new System.Drawing.Size(200, 22);
            this.contextConfigForSession.Text = "Configuration";
            this.contextConfigForSession.Click += new System.EventHandler(this.contextConfigForSession_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxSessionSearch,
            this.toolStripButtonSessionSearch,
            this.toolStripButtonSearchReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(238, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Search:";
            // 
            // toolStripTextBoxSessionSearch
            // 
            this.toolStripTextBoxSessionSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSessionSearch.Name = "toolStripTextBoxSessionSearch";
            this.toolStripTextBoxSessionSearch.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxSessionSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxSessionSearch_KeyPress);
            // 
            // toolStripButtonSessionSearch
            // 
            this.toolStripButtonSessionSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSessionSearch.DoubleClickEnabled = true;
            this.toolStripButtonSessionSearch.Image = global::SessionManagement.Properties.Resources.Search;
            this.toolStripButtonSessionSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSessionSearch.Name = "toolStripButtonSessionSearch";
            this.toolStripButtonSessionSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSessionSearch.Text = "Session Search";
            this.toolStripButtonSessionSearch.Click += new System.EventHandler(this.toolStripButtonSessionSearch_Click);
            // 
            // toolStripButtonSearchReset
            // 
            this.toolStripButtonSearchReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearchReset.Image = global::SessionManagement.Properties.Resources.ResetView;
            this.toolStripButtonSearchReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearchReset.Name = "toolStripButtonSearchReset";
            this.toolStripButtonSearchReset.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearchReset.Text = "Search Reset";
            this.toolStripButtonSearchReset.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.toolStripButtonSearchReset.Click += new System.EventHandler(this.toolStripButtonSearchReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeSessions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 435);
            this.panel1.TabIndex = 5;
            // 
            // treeSessions
            // 
            this.treeSessions.BackColor = System.Drawing.SystemColors.Window;
            this.treeSessions.ContextMenuStrip = this.contextForTreeSession;
            this.treeSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSessions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeSessions.ImageIndex = 0;
            this.treeSessions.ImageList = this.imageListSessionManager;
            this.treeSessions.LabelEdit = true;
            this.treeSessions.Location = new System.Drawing.Point(0, 0);
            this.treeSessions.Name = "treeSessions";
            this.treeSessions.SelectedImageIndex = 0;
            this.treeSessions.ShowNodeToolTips = true;
            this.treeSessions.Size = new System.Drawing.Size(238, 435);
            this.treeSessions.TabIndex = 1;
            this.treeSessions.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeSessions_AfterLabelEdit);
            this.treeSessions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSessions_AfterSelect);
            this.treeSessions.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSessions_NodeMouseClick);
            this.treeSessions.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSessions_NodeMouseDoubleClick);
            this.treeSessions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeSessions_KeyDown);
            this.treeSessions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeSessions_KeyPress);
            // 
            // frmSessionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(238, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSessionManager";
            this.ShowIcon = false;
            this.Text = "Sessions Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSessionManager_FormClosing);
            this.Load += new System.EventHandler(this.frmSessionManager_Load);
            this.contextForDatabase.ResumeLayout(false);
            this.contextForTreeSession.ResumeLayout(false);
            this.contextForFolder.ResumeLayout(false);
            this.contextForSession.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040000FC RID: 252
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.ContextMenuStrip contextForDatabase;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.ToolStripMenuItem contextNewForDatabase;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.ToolStripMenuItem contextSessionForDatabase;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.ToolStripMenuItem contextFolderForDatabase;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.ToolStripMenuItem contextPropertiesForDatabase;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.ToolStripMenuItem contextCloseDatabaseForDatabase;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.ContextMenuStrip contextForFolder;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Forms.ToolStripMenuItem contextNewForFolder;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Forms.ToolStripMenuItem contextSessionForFolder;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Forms.ToolStripMenuItem contextFolderForFolder;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Forms.ToolStripMenuItem contextRenameForFolder;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.ContextMenuStrip contextForSession;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.ToolStripMenuItem contextConnect;

		// Token: 0x0400010B RID: 267
		private global::System.Windows.Forms.ToolStripMenuItem contextConnectExternal;

		// Token: 0x0400010C RID: 268
		private global::System.Windows.Forms.ToolStripMenuItem contextFTPExternal;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.ToolStripMenuItem contextSFTPExternal;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.ToolStripMenuItem contextRenameForSession;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.ContextMenuStrip contextForTreeSession;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.ToolStripMenuItem contextOpenDatabase;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.ToolStripMenuItem contextConfigForSession;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.ImageList imageListSessionManager;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.ToolStripMenuItem contextCreateDatabase;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000116 RID: 278
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.ToolStripMenuItem contextCutForFolder;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.ToolStripMenuItem contextCopyForFolder;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.ToolStripMenuItem contextDeleteForFolder;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.ToolStripMenuItem contextCutForSession;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.ToolStripMenuItem contextCopyForSession;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.ToolStripMenuItem contextDeleteForSession;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.ToolStripMenuItem contextPasteForFolder;

		// Token: 0x0400011F RID: 287
		private global::System.Windows.Forms.ToolStripMenuItem contextPasteForDatabase;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.Forms.ToolStripMenuItem contextSaveForDatabase;

		// Token: 0x04000121 RID: 289
		private global::System.Windows.Forms.ToolStripMenuItem contextSetDefaultForDatabase;

		// Token: 0x04000122 RID: 290
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x04000123 RID: 291
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.ToolStripMenuItem contextConnectAllForFolder;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSessionSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonSessionSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeSessions;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearchReset;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemXwindowsStart;
    }
}
