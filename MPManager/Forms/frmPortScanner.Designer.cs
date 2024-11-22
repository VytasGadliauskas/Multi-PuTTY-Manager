using System.Windows.Forms;

namespace SessionManagement
{
    partial class frmPortScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortScanner));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxIPAddress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripDropDownButtonSubnetMask = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemSingleIp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSubnetMask24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSubnetMask16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxIPAddress,
            this.toolStripDropDownButtonSubnetMask,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(593, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "IP Range:";
            // 
            // toolStripTextBoxIPAddress
            // 
            this.toolStripTextBoxIPAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxIPAddress.Name = "toolStripTextBoxIPAddress";
            this.toolStripTextBoxIPAddress.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxIPAddress.ToolTipText = "Ip address";
            // 
            // toolStripDropDownButtonSubnetMask
            // 
            this.toolStripDropDownButtonSubnetMask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonSubnetMask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSingleIp,
            this.toolStripMenuItemSubnetMask24,
            this.toolStripMenuItemSubnetMask16});
            this.toolStripDropDownButtonSubnetMask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonSubnetMask.Image")));
            this.toolStripDropDownButtonSubnetMask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonSubnetMask.Name = "toolStripDropDownButtonSubnetMask";
            this.toolStripDropDownButtonSubnetMask.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButtonSubnetMask.Text = "SubnetMask";
            // 
            // toolStripMenuItemSingleIp
            // 
            this.toolStripMenuItemSingleIp.Name = "toolStripMenuItemSingleIp";
            this.toolStripMenuItemSingleIp.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItemSingleIp.Text = "Single IP";
            // 
            // toolStripMenuItemSubnetMask24
            // 
            this.toolStripMenuItemSubnetMask24.Name = "toolStripMenuItemSubnetMask24";
            this.toolStripMenuItemSubnetMask24.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItemSubnetMask24.Text = "/24";
            // 
            // toolStripMenuItemSubnetMask16
            // 
            this.toolStripMenuItemSubnetMask16.Name = "toolStripMenuItemSubnetMask16";
            this.toolStripMenuItemSubnetMask16.Size = new System.Drawing.Size(119, 22);
            this.toolStripMenuItemSubnetMask16.Text = "/16";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SessionManagement.Properties.Resources.Search;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 356);
            this.panel1.TabIndex = 1;
            // 
            // PortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PortScanner";
            this.Text = "PortScanner";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxIPAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonSubnetMask;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSingleIp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSubnetMask24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSubnetMask16;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}