namespace SessionManagement.Forms
{
    partial class frmImportCsv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportCsv));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenCsvFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonImportCsvToNodeTree = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarImport = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxCsvFile = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenCsvFile,
            this.toolStripSeparator1,
            this.toolStripButtonImportCsvToNodeTree,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(942, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpenCsvFile
            // 
            this.toolStripButtonOpenCsvFile.Image = global::SessionManagement.Properties.Resources.OpenFile;
            this.toolStripButtonOpenCsvFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonOpenCsvFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenCsvFile.Name = "toolStripButtonOpenCsvFile";
            this.toolStripButtonOpenCsvFile.Size = new System.Drawing.Size(102, 22);
            this.toolStripButtonOpenCsvFile.Text = "Open CSV  file";
            this.toolStripButtonOpenCsvFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonOpenCsvFile.Click += new System.EventHandler(this.toolStripButtonOpenCsvFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonImportCsvToNodeTree
            // 
            this.toolStripButtonImportCsvToNodeTree.Image = global::SessionManagement.Properties.Resources.Import;
            this.toolStripButtonImportCsvToNodeTree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonImportCsvToNodeTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImportCsvToNodeTree.Name = "toolStripButtonImportCsvToNodeTree";
            this.toolStripButtonImportCsvToNodeTree.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonImportCsvToNodeTree.Text = "Import";
            this.toolStripButtonImportCsvToNodeTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonImportCsvToNodeTree.Click += new System.EventHandler(this.toolStripButtonImportCsvToNodeTree_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBarImport});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "Import status : ";
            // 
            // toolStripProgressBarImport
            // 
            this.toolStripProgressBarImport.Name = "toolStripProgressBarImport";
            this.toolStripProgressBarImport.Size = new System.Drawing.Size(100, 16);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxCsvFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 444);
            this.panel1.TabIndex = 2;
            // 
            // richTextBoxCsvFile
            // 
            this.richTextBoxCsvFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCsvFile.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCsvFile.Name = "richTextBoxCsvFile";
            this.richTextBoxCsvFile.ReadOnly = true;
            this.richTextBoxCsvFile.Size = new System.Drawing.Size(942, 444);
            this.richTextBoxCsvFile.TabIndex = 0;
            this.richTextBoxCsvFile.Text = resources.GetString("richTextBoxCsvFile.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmImportCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportCsv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import from CSV file";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenCsvFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonImportCsvToNodeTree;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxCsvFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}