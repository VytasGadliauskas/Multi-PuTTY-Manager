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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNewMacros = new System.Windows.Forms.ToolStripButton();
            this.listBoxMacorsList = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.richTextBoxMacroItemEdit = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUseMacros = new System.Windows.Forms.Button();
            this.buttonSaveMacros = new System.Windows.Forms.Button();
            this.buttonDeleteMacros = new System.Windows.Forms.Button();
            this.textBoxMacrosName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripMacrosList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItemMacrosDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.useMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStripMacrosList.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNewMacros});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(881, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNewMacros
            // 
            this.toolStripButtonNewMacros.Image = global::SessionManagement.Properties.Resources.NewWorkItem;
            this.toolStripButtonNewMacros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonNewMacros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewMacros.Name = "toolStripButtonNewMacros";
            this.toolStripButtonNewMacros.Size = new System.Drawing.Size(93, 22);
            this.toolStripButtonNewMacros.Text = "New Macros";
            this.toolStripButtonNewMacros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxMacorsList
            // 
            this.listBoxMacorsList.ContextMenuStrip = this.contextMenuStripMacrosList;
            this.listBoxMacorsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxMacorsList.FormattingEnabled = true;
            this.listBoxMacorsList.Items.AddRange(new object[] {
            "ExampleMacrosAptPatch",
            "asdfasfd",
            "asdfsadsa",
            "sadsadasdsa"});
            this.listBoxMacorsList.Location = new System.Drawing.Point(0, 25);
            this.listBoxMacorsList.Name = "listBoxMacorsList";
            this.listBoxMacorsList.Size = new System.Drawing.Size(174, 434);
            this.listBoxMacorsList.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(174, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 434);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // richTextBoxMacroItemEdit
            // 
            this.richTextBoxMacroItemEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxMacroItemEdit.Location = new System.Drawing.Point(177, 25);
            this.richTextBoxMacroItemEdit.Name = "richTextBoxMacroItemEdit";
            this.richTextBoxMacroItemEdit.Size = new System.Drawing.Size(704, 434);
            this.richTextBoxMacroItemEdit.TabIndex = 4;
            this.richTextBoxMacroItemEdit.Text = "apt update; apt upgrade";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonUseMacros);
            this.panel1.Controls.Add(this.buttonSaveMacros);
            this.panel1.Controls.Add(this.buttonDeleteMacros);
            this.panel1.Controls.Add(this.textBoxMacrosName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(177, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 80);
            this.panel1.TabIndex = 5;
            // 
            // buttonUseMacros
            // 
            this.buttonUseMacros.Image = global::SessionManagement.Properties.Resources.UpdateScript;
            this.buttonUseMacros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUseMacros.Location = new System.Drawing.Point(572, 24);
            this.buttonUseMacros.Name = "buttonUseMacros";
            this.buttonUseMacros.Size = new System.Drawing.Size(100, 23);
            this.buttonUseMacros.TabIndex = 4;
            this.buttonUseMacros.Text = "Use Macros";
            this.buttonUseMacros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUseMacros.UseVisualStyleBackColor = true;
            // 
            // buttonSaveMacros
            // 
            this.buttonSaveMacros.Image = global::SessionManagement.Properties.Resources.Save;
            this.buttonSaveMacros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveMacros.Location = new System.Drawing.Point(445, 24);
            this.buttonSaveMacros.Name = "buttonSaveMacros";
            this.buttonSaveMacros.Size = new System.Drawing.Size(103, 23);
            this.buttonSaveMacros.TabIndex = 3;
            this.buttonSaveMacros.Text = "Save Macros";
            this.buttonSaveMacros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSaveMacros.UseVisualStyleBackColor = true;
            this.buttonSaveMacros.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDeleteMacros
            // 
            this.buttonDeleteMacros.Image = global::SessionManagement.Properties.Resources.DeleteTaskList;
            this.buttonDeleteMacros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteMacros.Location = new System.Drawing.Point(310, 23);
            this.buttonDeleteMacros.Name = "buttonDeleteMacros";
            this.buttonDeleteMacros.Size = new System.Drawing.Size(104, 23);
            this.buttonDeleteMacros.TabIndex = 2;
            this.buttonDeleteMacros.Text = "Delete Macros";
            this.buttonDeleteMacros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteMacros.UseVisualStyleBackColor = true;
            this.buttonDeleteMacros.Click += new System.EventHandler(this.buttonDeleteMacros_Click);
            // 
            // textBoxMacrosName
            // 
            this.textBoxMacrosName.Location = new System.Drawing.Point(97, 26);
            this.textBoxMacrosName.Name = "textBoxMacrosName";
            this.textBoxMacrosName.Size = new System.Drawing.Size(186, 20);
            this.textBoxMacrosName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Macros name";
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
            // deleteToolStripMenuItemMacrosDelete
            // 
            this.deleteToolStripMenuItemMacrosDelete.Image = global::SessionManagement.Properties.Resources.DeleteTaskList;
            this.deleteToolStripMenuItemMacrosDelete.Name = "deleteToolStripMenuItemMacrosDelete";
            this.deleteToolStripMenuItemMacrosDelete.Size = new System.Drawing.Size(140, 22);
            this.deleteToolStripMenuItemMacrosDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
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
            // newMacrosToolStripMenuItem
            // 
            this.newMacrosToolStripMenuItem.Image = global::SessionManagement.Properties.Resources.NewWorkItem;
            this.newMacrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newMacrosToolStripMenuItem.Name = "newMacrosToolStripMenuItem";
            this.newMacrosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newMacrosToolStripMenuItem.Text = "New Macros";
            this.newMacrosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMacros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBoxMacroItemEdit);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listBoxMacorsList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMacros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macros";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStripMacrosList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox listBoxMacorsList;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox richTextBoxMacroItemEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewMacros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSaveMacros;
        private System.Windows.Forms.Button buttonDeleteMacros;
        private System.Windows.Forms.TextBox textBoxMacrosName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTotalMacrosNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMacrosList;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItemMacrosDelete;
        private System.Windows.Forms.Button buttonUseMacros;
        private System.Windows.Forms.ToolStripMenuItem useMacrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newMacrosToolStripMenuItem;
    }
}