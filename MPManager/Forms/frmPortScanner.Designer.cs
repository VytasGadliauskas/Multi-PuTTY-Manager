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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPortScanner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBoxEnd = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonScann = new System.Windows.Forms.Button();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewScanTable = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddSession = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScanTable)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maskedTextBoxEnd);
            this.panel1.Controls.Add(this.maskedTextBox7);
            this.panel1.Controls.Add(this.maskedTextBox6);
            this.panel1.Controls.Add(this.maskedTextBox5);
            this.panel1.Controls.Add(this.maskedTextBox4);
            this.panel1.Controls.Add(this.maskedTextBox3);
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.buttonScann);
            this.panel1.Controls.Add(this.numericUpDownPort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 92);
            this.panel1.TabIndex = 0;
            // 
            // maskedTextBoxEnd
            // 
            this.maskedTextBoxEnd.Location = new System.Drawing.Point(219, 51);
            this.maskedTextBoxEnd.Mask = "000";
            this.maskedTextBoxEnd.Name = "maskedTextBoxEnd";
            this.maskedTextBoxEnd.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBoxEnd.TabIndex = 5;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(183, 51);
            this.maskedTextBox7.Mask = "000";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.ReadOnly = true;
            this.maskedTextBox7.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox7.TabIndex = 15;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(147, 51);
            this.maskedTextBox6.Mask = "000";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.ReadOnly = true;
            this.maskedTextBox6.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox6.TabIndex = 14;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(111, 51);
            this.maskedTextBox5.Mask = "000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.ReadOnly = true;
            this.maskedTextBox5.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox5.TabIndex = 13;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(219, 19);
            this.maskedTextBox4.Mask = "000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox4.TabIndex = 4;
            this.maskedTextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox4_KeyDown);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(183, 19);
            this.maskedTextBox3.Mask = "000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox3.TabIndex = 3;
            this.maskedTextBox3.TextChanged += new System.EventHandler(this.maskedTextBox3_TextChanged);
            this.maskedTextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox3_KeyDown);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(147, 19);
            this.maskedTextBox2.Mask = "000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.TextChanged += new System.EventHandler(this.maskedTextBox2_TextChanged);
            this.maskedTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox2_KeyDown);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(111, 19);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(30, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // buttonScann
            // 
            this.buttonScann.Location = new System.Drawing.Point(463, 22);
            this.buttonScann.Name = "buttonScann";
            this.buttonScann.Size = new System.Drawing.Size(75, 48);
            this.buttonScann.TabIndex = 7;
            this.buttonScann.Text = "Scann";
            this.buttonScann.UseVisualStyleBackColor = true;
            this.buttonScann.Click += new System.EventHandler(this.buttonScann_Click);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(368, 19);
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownPort.TabIndex = 6;
            this.numericUpDownPort.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Port To Scann :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Stop IP Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Start IP Address :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(567, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(0, 17);
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
            this.Port});
            this.dataGridViewScanTable.ContextMenuStrip = this.contextMenuStrip;
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
            this.dataGridViewScanTable.Size = new System.Drawing.Size(567, 314);
            this.dataGridViewScanTable.TabIndex = 8;
            // 
            // Name
            // 
            this.Name.HeaderText = "IP";
            this.Name.Name = "Name";
            // 
            // Host
            // 
            this.Host.HeaderText = "Host";
            this.Host.Name = "Host";
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddSession});
            this.contextMenuStrip.Name = "contextMenuStripAddSession";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 26);
            this.contextMenuStrip.Text = "Add session";
            // 
            // toolStripMenuItemAddSession
            // 
            this.toolStripMenuItemAddSession.Name = "toolStripMenuItemAddSession";
            this.toolStripMenuItemAddSession.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItemAddSession.Text = "Add Session";
            this.toolStripMenuItemAddSession.Click += new System.EventHandler(this.toolStripMenuItemAddSession_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 310);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(567, 96);
            this.richTextBoxLog.TabIndex = 9;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // 
            // frmPortScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 428);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.dataGridViewScanTable);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PortScanner";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScanTable)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private StatusStrip statusStrip1;
        private Label label3;
        private NumericUpDown numericUpDownPort;
        private DataGridView dataGridViewScanTable;
        private Button buttonScann;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Host;
        private DataGridViewTextBoxColumn Port;
        private MaskedTextBox maskedTextBoxEnd;
        private MaskedTextBox maskedTextBox7;
        private MaskedTextBox maskedTextBox6;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelStatus;
        private RichTextBox richTextBoxLog;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem toolStripMenuItemAddSession;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}