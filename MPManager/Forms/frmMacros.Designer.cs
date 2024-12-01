namespace SessionManagement.Forms
{
    partial class frmMacros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMacros));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTotalMacrosNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripMacrosList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItemMacrosDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxMacrosName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveMacros = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteMacros = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUseMacros = new System.Windows.Forms.ToolStripButton();
            this.listBoxMacrosNames = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.richTextBoxMacrosCommands = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripMacrosList.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelTotalMacrosNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Total macros :";
            // 
            // toolStripStatusLabelTotalMacrosNumber
            // 
            this.toolStripStatusLabelTotalMacrosNumber.Name = "toolStripStatusLabelTotalMacrosNumber";
            this.toolStripStatusLabelTotalMacrosNumber.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelTotalMacrosNumber.Text = "0";
            // 
            // contextMenuStripMacrosList
            // 
            this.contextMenuStripMacrosList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMacrosToolStripMenuItem,
            this.useMacrosToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItemMacrosDelete});
            this.contextMenuStripMacrosList.Name = "contextMenuStripMacrosList";
            this.contextMenuStripMacrosList.Size = new System.Drawing.Size(141, 76);
            // 
            // newMacrosToolStripMenuItem
            // 
            this.newMacrosToolStripMenuItem.Image = global::SessionManagement.Properties.Resources.NewWorkItem;
            this.newMacrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newMacrosToolStripMenuItem.Name = "newMacrosToolStripMenuItem";
            this.newMacrosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newMacrosToolStripMenuItem.Text = "New Macros";
            this.newMacrosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // useMacrosToolStripMenuItem
            // 
            this.useMacrosToolStripMenuItem.Image = global::SessionManagement.Properties.Resources.UpdateScript;
            this.useMacrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.useMacrosToolStripMenuItem.Name = "useMacrosToolStripMenuItem";
            this.useMacrosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.useMacrosToolStripMenuItem.Text = "Use Macros";
            this.useMacrosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // deleteToolStripMenuItemMacrosDelete
            // 
            this.deleteToolStripMenuItemMacrosDelete.Image = global::SessionManagement.Properties.Resources.DeleteTaskList;
            this.deleteToolStripMenuItemMacrosDelete.Name = "deleteToolStripMenuItemMacrosDelete";
            this.deleteToolStripMenuItemMacrosDelete.Size = new System.Drawing.Size(140, 22);
            this.deleteToolStripMenuItemMacrosDelete.Text = "Delete";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripTextBoxMacrosName,
            this.toolStripSeparator2,
            this.toolStripButtonSaveMacros,
            this.toolStripButtonDeleteMacros,
            this.toolStripButtonUseMacros});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(881, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SessionManagement.Properties.Resources.NewWorkItem;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripButton1.Text = "New Macros";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel1.Text = "Macros name: ";
            // 
            // toolStripTextBoxMacrosName
            // 
            this.toolStripTextBoxMacrosName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxMacrosName.Name = "toolStripTextBoxMacrosName";
            this.toolStripTextBoxMacrosName.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSaveMacros
            // 
            this.toolStripButtonSaveMacros.Image = global::SessionManagement.Properties.Resources.Save;
            this.toolStripButtonSaveMacros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonSaveMacros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveMacros.Name = "toolStripButtonSaveMacros";
            this.toolStripButtonSaveMacros.Size = new System.Drawing.Size(93, 22);
            this.toolStripButtonSaveMacros.Text = "Save Macros";
            this.toolStripButtonSaveMacros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonSaveMacros.Click += new System.EventHandler(this.toolStripButtonSaveMacros_Click);
            // 
            // toolStripButtonDeleteMacros
            // 
            this.toolStripButtonDeleteMacros.Image = global::SessionManagement.Properties.Resources.DeleteTaskList;
            this.toolStripButtonDeleteMacros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonDeleteMacros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteMacros.Name = "toolStripButtonDeleteMacros";
            this.toolStripButtonDeleteMacros.Size = new System.Drawing.Size(102, 22);
            this.toolStripButtonDeleteMacros.Text = "Delete Macros";
            this.toolStripButtonDeleteMacros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonDeleteMacros.Click += new System.EventHandler(this.toolStripButtonDeleteMacros_Click);
            // 
            // toolStripButtonUseMacros
            // 
            this.toolStripButtonUseMacros.Image = global::SessionManagement.Properties.Resources.MacroShortcut;
            this.toolStripButtonUseMacros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUseMacros.Name = "toolStripButtonUseMacros";
            this.toolStripButtonUseMacros.Size = new System.Drawing.Size(88, 22);
            this.toolStripButtonUseMacros.Text = "Use Macros";
            this.toolStripButtonUseMacros.Click += new System.EventHandler(this.toolStripButtonUseMacros_Click);
            // 
            // listBoxMacrosNames
            // 
            this.listBoxMacrosNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxMacrosNames.FormattingEnabled = true;
            this.listBoxMacrosNames.Location = new System.Drawing.Point(0, 25);
            this.listBoxMacrosNames.Name = "listBoxMacrosNames";
            this.listBoxMacrosNames.Size = new System.Drawing.Size(145, 434);
            this.listBoxMacrosNames.TabIndex = 6;
            this.listBoxMacrosNames.Click += new System.EventHandler(this.listBoxMacrosNames_Click);
            this.listBoxMacrosNames.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxMacrosNames_MouseDoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(145, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 434);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // richTextBoxMacrosCommands
            // 
            this.richTextBoxMacrosCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMacrosCommands.Location = new System.Drawing.Point(148, 25);
            this.richTextBoxMacrosCommands.Name = "richTextBoxMacrosCommands";
            this.richTextBoxMacrosCommands.Size = new System.Drawing.Size(733, 434);
            this.richTextBoxMacrosCommands.TabIndex = 8;
            this.richTextBoxMacrosCommands.Text = "";
            // 
            // frmMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 481);
            this.Controls.Add(this.richTextBoxMacrosCommands);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listBoxMacrosNames);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMacros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMacros_FormClosing);
            this.Load += new System.EventHandler(this.frmMacros_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripMacrosList.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalMacrosNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMacrosList;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItemMacrosDelete;
        private System.Windows.Forms.ToolStripMenuItem useMacrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newMacrosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMacrosName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveMacros;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteMacros;
        private System.Windows.Forms.ToolStripButton toolStripButtonUseMacros;
        private System.Windows.Forms.ListBox listBoxMacrosNames;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox richTextBoxMacrosCommands;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}