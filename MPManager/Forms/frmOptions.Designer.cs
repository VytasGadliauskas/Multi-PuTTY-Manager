namespace SessionManagement
{
	// Token: 0x02000008 RID: 8
	public partial class frmOptions : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000092B4 File Offset: 0x000074B4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000092EC File Offset: 0x000074EC
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabpageGeneral = new System.Windows.Forms.TabPage();
            this.groupBoxVcXsrv = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonVcXsrvBrowser = new System.Windows.Forms.Button();
            this.textBoxVcXsrvlocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupSessionManagerPosition = new System.Windows.Forms.GroupBox();
            this.radRight = new System.Windows.Forms.RadioButton();
            this.radLeft = new System.Windows.Forms.RadioButton();
            this.groupWinSCP = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btWinSCPBrowser = new System.Windows.Forms.Button();
            this.txtWinSCPLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupPutty = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btPuttyBrowser = new System.Windows.Forms.Button();
            this.txtPuttyLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupDatabase = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDatabaseBrowser = new System.Windows.Forms.Button();
            this.txtDatabaseLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabpageGeneral.SuspendLayout();
            this.groupBoxVcXsrv.SuspendLayout();
            this.groupSessionManagerPosition.SuspendLayout();
            this.groupWinSCP.SuspendLayout();
            this.groupPutty.SuspendLayout();
            this.groupDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabpageGeneral);
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(3, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(547, 511);
            this.tabMain.TabIndex = 0;
            // 
            // tabpageGeneral
            // 
            this.tabpageGeneral.Controls.Add(this.groupBoxVcXsrv);
            this.tabpageGeneral.Controls.Add(this.groupSessionManagerPosition);
            this.tabpageGeneral.Controls.Add(this.groupWinSCP);
            this.tabpageGeneral.Controls.Add(this.groupPutty);
            this.tabpageGeneral.Controls.Add(this.groupDatabase);
            this.tabpageGeneral.Location = new System.Drawing.Point(4, 26);
            this.tabpageGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.tabpageGeneral.Name = "tabpageGeneral";
            this.tabpageGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.tabpageGeneral.Size = new System.Drawing.Size(539, 481);
            this.tabpageGeneral.TabIndex = 0;
            this.tabpageGeneral.Text = "General";
            this.tabpageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBoxVcXsrv
            // 
            this.groupBoxVcXsrv.Controls.Add(this.label7);
            this.groupBoxVcXsrv.Controls.Add(this.buttonVcXsrvBrowser);
            this.groupBoxVcXsrv.Controls.Add(this.textBoxVcXsrvlocation);
            this.groupBoxVcXsrv.Controls.Add(this.label8);
            this.groupBoxVcXsrv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVcXsrv.Location = new System.Drawing.Point(18, 297);
            this.groupBoxVcXsrv.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxVcXsrv.Name = "groupBoxVcXsrv";
            this.groupBoxVcXsrv.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxVcXsrv.Size = new System.Drawing.Size(505, 79);
            this.groupBoxVcXsrv.TabIndex = 4;
            this.groupBoxVcXsrv.TabStop = false;
            this.groupBoxVcXsrv.Text = "XWindows";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "(For example: C:\\Program Files\\VcXsrv\\xlaunch.exe)";
            // 
            // buttonVcXsrvBrowser
            // 
            this.buttonVcXsrvBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVcXsrvBrowser.Image = ((System.Drawing.Image)(resources.GetObject("buttonVcXsrvBrowser.Image")));
            this.buttonVcXsrvBrowser.Location = new System.Drawing.Point(468, 25);
            this.buttonVcXsrvBrowser.Name = "buttonVcXsrvBrowser";
            this.buttonVcXsrvBrowser.Size = new System.Drawing.Size(26, 26);
            this.buttonVcXsrvBrowser.TabIndex = 2;
            this.buttonVcXsrvBrowser.UseVisualStyleBackColor = true;
            this.buttonVcXsrvBrowser.Click += new System.EventHandler(this.buttonVcXsrvBrowser_Click);
            // 
            // textBoxVcXsrvlocation
            // 
            this.textBoxVcXsrvlocation.Location = new System.Drawing.Point(81, 25);
            this.textBoxVcXsrvlocation.Name = "textBoxVcXsrvlocation";
            this.textBoxVcXsrvlocation.Size = new System.Drawing.Size(381, 23);
            this.textBoxVcXsrvlocation.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Location";
            // 
            // groupSessionManagerPosition
            // 
            this.groupSessionManagerPosition.Controls.Add(this.radRight);
            this.groupSessionManagerPosition.Controls.Add(this.radLeft);
            this.groupSessionManagerPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSessionManagerPosition.Location = new System.Drawing.Point(17, 397);
            this.groupSessionManagerPosition.Margin = new System.Windows.Forms.Padding(4);
            this.groupSessionManagerPosition.Name = "groupSessionManagerPosition";
            this.groupSessionManagerPosition.Padding = new System.Windows.Forms.Padding(4);
            this.groupSessionManagerPosition.Size = new System.Drawing.Size(505, 64);
            this.groupSessionManagerPosition.TabIndex = 3;
            this.groupSessionManagerPosition.TabStop = false;
            this.groupSessionManagerPosition.Text = "Sessions Manager Position";
            // 
            // radRight
            // 
            this.radRight.AutoSize = true;
            this.radRight.Location = new System.Drawing.Point(363, 27);
            this.radRight.Name = "radRight";
            this.radRight.Size = new System.Drawing.Size(78, 19);
            this.radRight.TabIndex = 1;
            this.radRight.TabStop = true;
            this.radRight.Text = "Right Side";
            this.radRight.UseVisualStyleBackColor = true;
            // 
            // radLeft
            // 
            this.radLeft.AutoSize = true;
            this.radLeft.Location = new System.Drawing.Point(81, 27);
            this.radLeft.Name = "radLeft";
            this.radLeft.Size = new System.Drawing.Size(70, 19);
            this.radLeft.TabIndex = 0;
            this.radLeft.TabStop = true;
            this.radLeft.Text = "Left Side";
            this.radLeft.UseVisualStyleBackColor = true;
            // 
            // groupWinSCP
            // 
            this.groupWinSCP.Controls.Add(this.label5);
            this.groupWinSCP.Controls.Add(this.btWinSCPBrowser);
            this.groupWinSCP.Controls.Add(this.txtWinSCPLocation);
            this.groupWinSCP.Controls.Add(this.label6);
            this.groupWinSCP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupWinSCP.Location = new System.Drawing.Point(17, 199);
            this.groupWinSCP.Margin = new System.Windows.Forms.Padding(4);
            this.groupWinSCP.Name = "groupWinSCP";
            this.groupWinSCP.Padding = new System.Windows.Forms.Padding(4);
            this.groupWinSCP.Size = new System.Drawing.Size(505, 79);
            this.groupWinSCP.TabIndex = 2;
            this.groupWinSCP.TabStop = false;
            this.groupWinSCP.Text = "WinSCP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "(For example: C:\\WinSCP\\WinSCP.exe)";
            // 
            // btWinSCPBrowser
            // 
            this.btWinSCPBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btWinSCPBrowser.Image = ((System.Drawing.Image)(resources.GetObject("btWinSCPBrowser.Image")));
            this.btWinSCPBrowser.Location = new System.Drawing.Point(468, 25);
            this.btWinSCPBrowser.Name = "btWinSCPBrowser";
            this.btWinSCPBrowser.Size = new System.Drawing.Size(26, 26);
            this.btWinSCPBrowser.TabIndex = 2;
            this.btWinSCPBrowser.UseVisualStyleBackColor = true;
            this.btWinSCPBrowser.Click += new System.EventHandler(this.btWinSCPBrowser_Click);
            // 
            // txtWinSCPLocation
            // 
            this.txtWinSCPLocation.Location = new System.Drawing.Point(81, 25);
            this.txtWinSCPLocation.Name = "txtWinSCPLocation";
            this.txtWinSCPLocation.Size = new System.Drawing.Size(381, 23);
            this.txtWinSCPLocation.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Location";
            // 
            // groupPutty
            // 
            this.groupPutty.Controls.Add(this.label3);
            this.groupPutty.Controls.Add(this.btPuttyBrowser);
            this.groupPutty.Controls.Add(this.txtPuttyLocation);
            this.groupPutty.Controls.Add(this.label4);
            this.groupPutty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPutty.Location = new System.Drawing.Point(17, 101);
            this.groupPutty.Margin = new System.Windows.Forms.Padding(4);
            this.groupPutty.Name = "groupPutty";
            this.groupPutty.Padding = new System.Windows.Forms.Padding(4);
            this.groupPutty.Size = new System.Drawing.Size(505, 83);
            this.groupPutty.TabIndex = 1;
            this.groupPutty.TabStop = false;
            this.groupPutty.Text = "PuTTY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "(For example: C:\\Putty\\Putty.exe)";
            // 
            // btPuttyBrowser
            // 
            this.btPuttyBrowser.Image = ((System.Drawing.Image)(resources.GetObject("btPuttyBrowser.Image")));
            this.btPuttyBrowser.Location = new System.Drawing.Point(468, 25);
            this.btPuttyBrowser.Name = "btPuttyBrowser";
            this.btPuttyBrowser.Size = new System.Drawing.Size(26, 26);
            this.btPuttyBrowser.TabIndex = 2;
            this.btPuttyBrowser.UseVisualStyleBackColor = true;
            this.btPuttyBrowser.Click += new System.EventHandler(this.btPuttyBrowser_Click);
            // 
            // txtPuttyLocation
            // 
            this.txtPuttyLocation.Location = new System.Drawing.Point(81, 25);
            this.txtPuttyLocation.Name = "txtPuttyLocation";
            this.txtPuttyLocation.Size = new System.Drawing.Size(381, 23);
            this.txtPuttyLocation.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Location";
            // 
            // groupDatabase
            // 
            this.groupDatabase.Controls.Add(this.label2);
            this.groupDatabase.Controls.Add(this.btDatabaseBrowser);
            this.groupDatabase.Controls.Add(this.txtDatabaseLocation);
            this.groupDatabase.Controls.Add(this.label1);
            this.groupDatabase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatabase.Location = new System.Drawing.Point(18, 11);
            this.groupDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.groupDatabase.Name = "groupDatabase";
            this.groupDatabase.Padding = new System.Windows.Forms.Padding(4);
            this.groupDatabase.Size = new System.Drawing.Size(505, 75);
            this.groupDatabase.TabIndex = 0;
            this.groupDatabase.TabStop = false;
            this.groupDatabase.Text = "Default database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "(For example: C:\\Database.dat)";
            // 
            // btDatabaseBrowser
            // 
            this.btDatabaseBrowser.Image = ((System.Drawing.Image)(resources.GetObject("btDatabaseBrowser.Image")));
            this.btDatabaseBrowser.Location = new System.Drawing.Point(468, 23);
            this.btDatabaseBrowser.Name = "btDatabaseBrowser";
            this.btDatabaseBrowser.Size = new System.Drawing.Size(26, 26);
            this.btDatabaseBrowser.TabIndex = 2;
            this.btDatabaseBrowser.UseVisualStyleBackColor = true;
            this.btDatabaseBrowser.Click += new System.EventHandler(this.btDatabaseBrowser_Click);
            // 
            // txtDatabaseLocation
            // 
            this.txtDatabaseLocation.Location = new System.Drawing.Point(81, 23);
            this.txtDatabaseLocation.Name = "txtDatabaseLocation";
            this.txtDatabaseLocation.Size = new System.Drawing.Size(381, 23);
            this.txtDatabaseLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(344, 518);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(88, 27);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(451, 518);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(88, 27);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 557);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options...";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.tabMain.ResumeLayout(false);
            this.tabpageGeneral.ResumeLayout(false);
            this.groupBoxVcXsrv.ResumeLayout(false);
            this.groupBoxVcXsrv.PerformLayout();
            this.groupSessionManagerPosition.ResumeLayout(false);
            this.groupSessionManagerPosition.PerformLayout();
            this.groupWinSCP.ResumeLayout(false);
            this.groupWinSCP.PerformLayout();
            this.groupPutty.ResumeLayout(false);
            this.groupPutty.PerformLayout();
            this.groupDatabase.ResumeLayout(false);
            this.groupDatabase.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x0400008B RID: 139
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.TabControl tabMain;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.TabPage tabpageGeneral;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.GroupBox groupDatabase;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Button btDatabaseBrowser;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.TextBox txtDatabaseLocation;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.GroupBox groupWinSCP;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Button btWinSCPBrowser;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.TextBox txtWinSCPLocation;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.GroupBox groupPutty;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Button btPuttyBrowser;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.TextBox txtPuttyLocation;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Button btOK;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.GroupBox groupSessionManagerPosition;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.RadioButton radRight;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.RadioButton radLeft;
        private System.Windows.Forms.GroupBox groupBoxVcXsrv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonVcXsrvBrowser;
        private System.Windows.Forms.TextBox textBoxVcXsrvlocation;
        private System.Windows.Forms.Label label8;
    }
}
