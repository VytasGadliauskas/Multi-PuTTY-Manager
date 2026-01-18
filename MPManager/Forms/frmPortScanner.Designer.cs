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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortScanner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxStopIP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxStartIP = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddSessions = new System.Windows.Forms.Button();
            this.buttonScann = new System.Windows.Forms.Button();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridViewScanTable = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseSshKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScanTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBoxStopIP);
            this.panel1.Controls.Add(this.maskedTextBoxStartIP);
            this.panel1.Controls.Add(this.buttonAddSessions);
            this.panel1.Controls.Add(this.buttonScann);
            this.panel1.Controls.Add(this.numericUpDownPort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 92);
            this.panel1.TabIndex = 0;
            // 
            // maskedTextBoxStopIP
            // 
            this.maskedTextBoxStopIP.Location = new System.Drawing.Point(111, 51);
            this.maskedTextBoxStopIP.Mask = "###.###.###.###";
            this.maskedTextBoxStopIP.Name = "maskedTextBoxStopIP";
            this.maskedTextBoxStopIP.Size = new System.Drawing.Size(102, 20);
            this.maskedTextBoxStopIP.TabIndex = 10;
            // 
            // maskedTextBoxStartIP
            // 
            this.maskedTextBoxStartIP.Location = new System.Drawing.Point(112, 18);
            this.maskedTextBoxStartIP.Mask = "###.###.###.###";
            this.maskedTextBoxStartIP.Name = "maskedTextBoxStartIP";
            this.maskedTextBoxStartIP.Size = new System.Drawing.Size(101, 20);
            this.maskedTextBoxStartIP.TabIndex = 9;
            // 
            // buttonAddSessions
            // 
            this.buttonAddSessions.Enabled = false;
            this.buttonAddSessions.Location = new System.Drawing.Point(531, 20);
            this.buttonAddSessions.Name = "buttonAddSessions";
            this.buttonAddSessions.Size = new System.Drawing.Size(75, 52);
            this.buttonAddSessions.TabIndex = 8;
            this.buttonAddSessions.Text = "Add sessions";
            this.buttonAddSessions.UseVisualStyleBackColor = true;
            // 
            // buttonScann
            // 
            this.buttonScann.Location = new System.Drawing.Point(423, 18);
            this.buttonScann.Name = "buttonScann";
            this.buttonScann.Size = new System.Drawing.Size(75, 56);
            this.buttonScann.TabIndex = 4;
            this.buttonScann.Text = "Scann";
            this.buttonScann.UseVisualStyleBackColor = true;
            this.buttonScann.Click += new System.EventHandler(this.buttonScann_Click);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(330, 20);
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownPort.TabIndex = 3;
            this.numericUpDownPort.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port To Scann :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop IP Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start IP Address :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 368);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1005, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // dataGridViewScanTable
            // 
            this.dataGridViewScanTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScanTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewScanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScanTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Host,
            this.Protocol,
            this.Port,
            this.Username,
            this.Password,
            this.UseSshKey,
            this.Description,
            this.Add});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScanTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewScanTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewScanTable.Location = new System.Drawing.Point(0, 92);
            this.dataGridViewScanTable.Name = "dataGridViewScanTable";
            this.dataGridViewScanTable.Size = new System.Drawing.Size(1005, 276);
            this.dataGridViewScanTable.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Host
            // 
            this.Host.HeaderText = "Host";
            this.Host.Name = "Host";
            // 
            // Protocol
            // 
            this.Protocol.HeaderText = "Protocol";
            this.Protocol.Name = "Protocol";
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // UseSshKey
            // 
            this.UseSshKey.HeaderText = "UseSshKey";
            this.UseSshKey.Name = "UseSshKey";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            // 
            // frmPortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 390);
            this.Controls.Add(this.dataGridViewScanTable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
           // this.Name = "frmPortScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PortScanner";
            this.Load += new System.EventHandler(this.frmPortScanner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScanTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Label label3;
        private NumericUpDown numericUpDownPort;
        private DataGridView dataGridViewScanTable;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Host;
        private DataGridViewTextBoxColumn Protocol;
        private DataGridViewTextBoxColumn Port;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewCheckBoxColumn UseSshKey;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewCheckBoxColumn Add;
        private Button buttonScann;
        private Button buttonAddSessions;
        private MaskedTextBox maskedTextBoxStopIP;
        private MaskedTextBox maskedTextBoxStartIP;
    }
}