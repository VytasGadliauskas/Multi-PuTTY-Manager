namespace SessionManagement
{
	// Token: 0x02000003 RID: 3
	public partial class frmDatabaseProperties : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007A RID: 122 RVA: 0x000070C0 File Offset: 0x000052C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000070F8 File Offset: 0x000052F8
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDBPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.btRename = new System.Windows.Forms.Button();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDBPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbLocation);
            this.groupBox1.Controls.Add(this.btRename);
            this.groupBox1.Controls.Add(this.txtDatabaseName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBoxDBPassword
            // 
            this.textBoxDBPassword.Location = new System.Drawing.Point(119, 103);
            this.textBoxDBPassword.Name = "textBoxDBPassword";
            this.textBoxDBPassword.PasswordChar = '*';
            this.textBoxDBPassword.Size = new System.Drawing.Size(261, 25);
            this.textBoxDBPassword.TabIndex = 5;
            this.textBoxDBPassword.TextChanged += new System.EventHandler(this.textBoxDBPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(102, 73);
            this.lbLocation.MaximumSize = new System.Drawing.Size(355, 50);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(68, 17);
            this.lbLocation.TabIndex = 3;
            this.lbLocation.Text = "lbLocation";
            // 
            // btRename
            // 
            this.btRename.Location = new System.Drawing.Point(386, 30);
            this.btRename.Name = "btRename";
            this.btRename.Size = new System.Drawing.Size(68, 27);
            this.btRename.TabIndex = 2;
            this.btRename.Text = "Rename";
            this.btRename.UseVisualStyleBackColor = true;
            this.btRename.Click += new System.EventHandler(this.btRename_Click);
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(119, 31);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(261, 25);
            this.txtDatabaseName.TabIndex = 1;
            this.txtDatabaseName.TextChanged += new System.EventHandler(this.txtDatabaseName_TextChanged);
            this.txtDatabaseName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatabaseName_KeyPress);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(411, 157);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(89, 27);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(316, 157);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(89, 27);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // frmDatabaseProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 196);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabaseProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000065 RID: 101
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.TextBox txtDatabaseName;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Button btOK;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Button btRename;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDBPassword;
    }
}
