namespace SessionManagement
{
	// Token: 0x0200000C RID: 12
	public partial class frmPuttySessions : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0000AE9C File Offset: 0x0000909C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000AED4 File Offset: 0x000090D4
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuttySessions));
            this.btCancel = new System.Windows.Forms.Button();
            this.btCreateDatabase = new System.Windows.Forms.Button();
            this.dataGridPuttySession = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuttySession)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(344, 295);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(104, 26);
            this.btCancel.TabIndex = 22;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCreateDatabase
            // 
            this.btCreateDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateDatabase.Location = new System.Drawing.Point(224, 295);
            this.btCreateDatabase.Name = "btCreateDatabase";
            this.btCreateDatabase.Size = new System.Drawing.Size(116, 26);
            this.btCreateDatabase.TabIndex = 21;
            this.btCreateDatabase.Text = "Create Database";
            this.btCreateDatabase.UseVisualStyleBackColor = true;
            this.btCreateDatabase.Click += new System.EventHandler(this.btCreateDatabase_Click);
            // 
            // dataGridPuttySession
            // 
            this.dataGridPuttySession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPuttySession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colHost});
            this.dataGridPuttySession.Location = new System.Drawing.Point(5, 38);
            this.dataGridPuttySession.Name = "dataGridPuttySession";
            this.dataGridPuttySession.ReadOnly = true;
            this.dataGridPuttySession.Size = new System.Drawing.Size(443, 251);
            this.dataGridPuttySession.TabIndex = 23;
            // 
            // colName
            // 
            this.colName.HeaderText = "Session Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 200;
            // 
            // colHost
            // 
            this.colHost.HeaderText = "Session Host/IP Address";
            this.colHost.Name = "colHost";
            this.colHost.ReadOnly = true;
            this.colHost.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "PuTTY Sessions";
            // 
            // frmPuttySessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPuttySession);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCreateDatabase);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPuttySessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PuTTY Sessions";
            this.Load += new System.EventHandler(this.frmPuttySessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPuttySession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040000AD RID: 173
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Button btCreateDatabase;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.DataGridView dataGridPuttySession;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colName;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colHost;
	}
}
