namespace SessionManagement
{
	// Token: 0x0200000E RID: 14
	public partial class frmSession : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0000BF70 File Offset: 0x0000A170
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSession));
            this.btOK = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabpageSession = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxUsePublicKey = new System.Windows.Forms.CheckBox();
            this.btShowSessionPassword = new System.Windows.Forms.Button();
            this.txtSessionPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSessionUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richDescription = new System.Windows.Forms.RichTextBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.cmbPuttySession = new System.Windows.Forms.ComboBox();
            this.cmbProtocol = new System.Windows.Forms.ComboBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpageAdvancedSession = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numPasswordTimeout = new System.Windows.Forms.NumericUpDown();
            this.numConnectionTimeout = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numUsernameTimeout = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numCommandTimeout = new System.Windows.Forms.NumericUpDown();
            this.groupPostLoginCommand = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkPostLogin = new System.Windows.Forms.CheckBox();
            this.tabpageExtraConnect = new System.Windows.Forms.TabPage();
            this.groupBoxVcXsrv = new System.Windows.Forms.GroupBox();
            this.buttonShowVcXsrvPassword = new System.Windows.Forms.Button();
            this.textBoxVcXsrvPassword = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxVcXsrvUserName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btShowSFTPPassword = new System.Windows.Forms.Button();
            this.txtSFTPPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSFTPUserName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btShowFTPPassword = new System.Windows.Forms.Button();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFTPUserName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabpageSession.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.tabpageAdvancedSession.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConnectionTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsernameTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommandTimeout)).BeginInit();
            this.groupPostLoginCommand.SuspendLayout();
            this.tabpageExtraConnect.SuspendLayout();
            this.groupBoxVcXsrv.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(306, 458);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(89, 27);
            this.btOK.TabIndex = 19;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabpageSession);
            this.tabMain.Controls.Add(this.tabpageAdvancedSession);
            this.tabMain.Controls.Add(this.tabpageExtraConnect);
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(1, 6);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(494, 446);
            this.tabMain.TabIndex = 2;
            // 
            // tabpageSession
            // 
            this.tabpageSession.Controls.Add(this.groupBox1);
            this.tabpageSession.Location = new System.Drawing.Point(4, 24);
            this.tabpageSession.Name = "tabpageSession";
            this.tabpageSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageSession.Size = new System.Drawing.Size(486, 418);
            this.tabpageSession.TabIndex = 0;
            this.tabpageSession.Text = "Session";
            this.tabpageSession.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.richDescription);
            this.groupBox1.Controls.Add(this.numPort);
            this.groupBox1.Controls.Add(this.cmbPuttySession);
            this.groupBox1.Controls.Add(this.cmbProtocol);
            this.groupBox1.Controls.Add(this.txtHost);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(420, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxUsePublicKey);
            this.groupBox2.Controls.Add(this.btShowSessionPassword);
            this.groupBox2.Controls.Add(this.txtSessionPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSessionUserName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(30, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 145);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auto-login credentials";
            // 
            // checkBoxUsePublicKey
            // 
            this.checkBoxUsePublicKey.AutoSize = true;
            this.checkBoxUsePublicKey.Location = new System.Drawing.Point(22, 100);
            this.checkBoxUsePublicKey.Name = "checkBoxUsePublicKey";
            this.checkBoxUsePublicKey.Size = new System.Drawing.Size(289, 19);
            this.checkBoxUsePublicKey.TabIndex = 18;
            this.checkBoxUsePublicKey.Text = "Use Public Key (use Pageant.exe, set \"User name\")";
            this.checkBoxUsePublicKey.UseVisualStyleBackColor = true;
            // 
            // btShowSessionPassword
            // 
            this.btShowSessionPassword.Image = ((System.Drawing.Image)(resources.GetObject("btShowSessionPassword.Image")));
            this.btShowSessionPassword.Location = new System.Drawing.Point(301, 59);
            this.btShowSessionPassword.Name = "btShowSessionPassword";
            this.btShowSessionPassword.Size = new System.Drawing.Size(26, 26);
            this.btShowSessionPassword.TabIndex = 16;
            this.btShowSessionPassword.UseVisualStyleBackColor = true;
            this.btShowSessionPassword.Click += new System.EventHandler(this.btShowSessionPassword_Click);
            // 
            // txtSessionPassword
            // 
            this.txtSessionPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSessionPassword.Location = new System.Drawing.Point(103, 59);
            this.txtSessionPassword.Name = "txtSessionPassword";
            this.txtSessionPassword.PasswordChar = '*';
            this.txtSessionPassword.Size = new System.Drawing.Size(194, 24);
            this.txtSessionPassword.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // txtSessionUserName
            // 
            this.txtSessionUserName.Location = new System.Drawing.Point(103, 29);
            this.txtSessionUserName.Name = "txtSessionUserName";
            this.txtSessionUserName.Size = new System.Drawing.Size(194, 23);
            this.txtSessionUserName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "User name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description";
            // 
            // richDescription
            // 
            this.richDescription.Location = new System.Drawing.Point(138, 173);
            this.richDescription.Name = "richDescription";
            this.richDescription.Size = new System.Drawing.Size(242, 53);
            this.richDescription.TabIndex = 5;
            this.richDescription.Text = "";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(138, 113);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(83, 23);
            this.numPort.TabIndex = 3;
            // 
            // cmbPuttySession
            // 
            this.cmbPuttySession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuttySession.FormattingEnabled = true;
            this.cmbPuttySession.Items.AddRange(new object[] {
            "Default Settings"});
            this.cmbPuttySession.Location = new System.Drawing.Point(138, 143);
            this.cmbPuttySession.MaxDropDownItems = 100;
            this.cmbPuttySession.Name = "cmbPuttySession";
            this.cmbPuttySession.Size = new System.Drawing.Size(192, 23);
            this.cmbPuttySession.TabIndex = 4;
            // 
            // cmbProtocol
            // 
            this.cmbProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProtocol.FormattingEnabled = true;
            this.cmbProtocol.Items.AddRange(new object[] {
            "Telnet",
            "SSH",
            "Raw",
            "RLogin"});
            this.cmbProtocol.Location = new System.Drawing.Point(138, 82);
            this.cmbProtocol.Name = "cmbProtocol";
            this.cmbProtocol.Size = new System.Drawing.Size(83, 23);
            this.cmbProtocol.TabIndex = 2;
            this.cmbProtocol.SelectedIndexChanged += new System.EventHandler(this.cmbProtocol_SelectedIndexChanged);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(138, 18);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(242, 23);
            this.txtHost.TabIndex = 0;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 147);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 15);
            this.label21.TabIndex = 0;
            this.label21.Text = "PuTTY setting";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Protocol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Host/IP Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabpageAdvancedSession
            // 
            this.tabpageAdvancedSession.Controls.Add(this.groupBox6);
            this.tabpageAdvancedSession.Controls.Add(this.groupPostLoginCommand);
            this.tabpageAdvancedSession.Location = new System.Drawing.Point(4, 24);
            this.tabpageAdvancedSession.Name = "tabpageAdvancedSession";
            this.tabpageAdvancedSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAdvancedSession.Size = new System.Drawing.Size(486, 418);
            this.tabpageAdvancedSession.TabIndex = 1;
            this.tabpageAdvancedSession.Text = "Advanced Session";
            this.tabpageAdvancedSession.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.numPasswordTimeout);
            this.groupBox6.Controls.Add(this.numConnectionTimeout);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.numUsernameTimeout);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.numCommandTimeout);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(39, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(404, 100);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Timeout (ms)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(231, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 15);
            this.label19.TabIndex = 25;
            this.label19.Text = "Password";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Connection";
            // 
            // numPasswordTimeout
            // 
            this.numPasswordTimeout.Location = new System.Drawing.Point(321, 28);
            this.numPasswordTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPasswordTimeout.Name = "numPasswordTimeout";
            this.numPasswordTimeout.Size = new System.Drawing.Size(67, 23);
            this.numPasswordTimeout.TabIndex = 11;
            this.numPasswordTimeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numConnectionTimeout
            // 
            this.numConnectionTimeout.Location = new System.Drawing.Point(107, 28);
            this.numConnectionTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numConnectionTimeout.Name = "numConnectionTimeout";
            this.numConnectionTimeout.Size = new System.Drawing.Size(67, 23);
            this.numConnectionTimeout.TabIndex = 9;
            this.numConnectionTimeout.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 15);
            this.label20.TabIndex = 25;
            this.label20.Text = "User name";
            // 
            // numUsernameTimeout
            // 
            this.numUsernameTimeout.Location = new System.Drawing.Point(107, 61);
            this.numUsernameTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUsernameTimeout.Name = "numUsernameTimeout";
            this.numUsernameTimeout.Size = new System.Drawing.Size(67, 23);
            this.numUsernameTimeout.TabIndex = 10;
            this.numUsernameTimeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 25;
            this.label17.Text = "Command";
            // 
            // numCommandTimeout
            // 
            this.numCommandTimeout.Location = new System.Drawing.Point(321, 63);
            this.numCommandTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCommandTimeout.Name = "numCommandTimeout";
            this.numCommandTimeout.Size = new System.Drawing.Size(67, 23);
            this.numCommandTimeout.TabIndex = 12;
            this.numCommandTimeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupPostLoginCommand
            // 
            this.groupPostLoginCommand.Controls.Add(this.label12);
            this.groupPostLoginCommand.Controls.Add(this.label11);
            this.groupPostLoginCommand.Controls.Add(this.label10);
            this.groupPostLoginCommand.Controls.Add(this.label9);
            this.groupPostLoginCommand.Controls.Add(this.label8);
            this.groupPostLoginCommand.Controls.Add(this.checkPostLogin);
            this.groupPostLoginCommand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPostLoginCommand.Location = new System.Drawing.Point(39, 134);
            this.groupPostLoginCommand.Name = "groupPostLoginCommand";
            this.groupPostLoginCommand.Size = new System.Drawing.Size(404, 204);
            this.groupPostLoginCommand.TabIndex = 13;
            this.groupPostLoginCommand.TabStop = false;
            this.groupPostLoginCommand.Text = "Post-login commands";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Command 5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Command 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Command 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Command 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Command 1";
            // 
            // checkPostLogin
            // 
            this.checkPostLogin.AutoSize = true;
            this.checkPostLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkPostLogin.Location = new System.Drawing.Point(116, 27);
            this.checkPostLogin.Name = "checkPostLogin";
            this.checkPostLogin.Size = new System.Drawing.Size(61, 19);
            this.checkPostLogin.TabIndex = 13;
            this.checkPostLogin.Text = "Enable";
            this.checkPostLogin.UseVisualStyleBackColor = true;
            this.checkPostLogin.CheckedChanged += new System.EventHandler(this.checkPostLogin_CheckedChanged);
            // 
            // tabpageExtraConnect
            // 
            this.tabpageExtraConnect.Controls.Add(this.groupBoxVcXsrv);
            this.tabpageExtraConnect.Controls.Add(this.groupBox5);
            this.tabpageExtraConnect.Controls.Add(this.groupBox4);
            this.tabpageExtraConnect.Location = new System.Drawing.Point(4, 24);
            this.tabpageExtraConnect.Name = "tabpageExtraConnect";
            this.tabpageExtraConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageExtraConnect.Size = new System.Drawing.Size(486, 418);
            this.tabpageExtraConnect.TabIndex = 2;
            this.tabpageExtraConnect.Text = "Extra Connection";
            this.tabpageExtraConnect.UseVisualStyleBackColor = true;
            this.tabpageExtraConnect.Enter += new System.EventHandler(this.tabpageExtraConnect_Enter);
            // 
            // groupBoxVcXsrv
            // 
            this.groupBoxVcXsrv.Controls.Add(this.buttonShowVcXsrvPassword);
            this.groupBoxVcXsrv.Controls.Add(this.textBoxVcXsrvPassword);
            this.groupBoxVcXsrv.Controls.Add(this.label23);
            this.groupBoxVcXsrv.Controls.Add(this.textBoxVcXsrvUserName);
            this.groupBoxVcXsrv.Controls.Add(this.label24);
            this.groupBoxVcXsrv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVcXsrv.Location = new System.Drawing.Point(58, 284);
            this.groupBoxVcXsrv.Name = "groupBoxVcXsrv";
            this.groupBoxVcXsrv.Size = new System.Drawing.Size(370, 109);
            this.groupBoxVcXsrv.TabIndex = 23;
            this.groupBoxVcXsrv.TabStop = false;
            this.groupBoxVcXsrv.Text = "XWindows";
            // 
            // buttonShowVcXsrvPassword
            // 
            this.buttonShowVcXsrvPassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowVcXsrvPassword.Image")));
            this.buttonShowVcXsrvPassword.Location = new System.Drawing.Point(308, 61);
            this.buttonShowVcXsrvPassword.Name = "buttonShowVcXsrvPassword";
            this.buttonShowVcXsrvPassword.Size = new System.Drawing.Size(26, 26);
            this.buttonShowVcXsrvPassword.TabIndex = 22;
            this.buttonShowVcXsrvPassword.UseVisualStyleBackColor = true;
            this.buttonShowVcXsrvPassword.Click += new System.EventHandler(this.buttonShowVcXsrvPassword_Click);
            // 
            // textBoxVcXsrvPassword
            // 
            this.textBoxVcXsrvPassword.Location = new System.Drawing.Point(110, 61);
            this.textBoxVcXsrvPassword.Name = "textBoxVcXsrvPassword";
            this.textBoxVcXsrvPassword.PasswordChar = '*';
            this.textBoxVcXsrvPassword.Size = new System.Drawing.Size(192, 23);
            this.textBoxVcXsrvPassword.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(22, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 15);
            this.label23.TabIndex = 18;
            this.label23.Text = "Password";
            // 
            // textBoxVcXsrvUserName
            // 
            this.textBoxVcXsrvUserName.Location = new System.Drawing.Point(110, 29);
            this.textBoxVcXsrvUserName.Name = "textBoxVcXsrvUserName";
            this.textBoxVcXsrvUserName.Size = new System.Drawing.Size(192, 23);
            this.textBoxVcXsrvUserName.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(22, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 15);
            this.label24.TabIndex = 16;
            this.label24.Text = "User name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btShowSFTPPassword);
            this.groupBox5.Controls.Add(this.txtSFTPPassword);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtSFTPUserName);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(58, 152);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 109);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SFTP";
            // 
            // btShowSFTPPassword
            // 
            this.btShowSFTPPassword.Image = ((System.Drawing.Image)(resources.GetObject("btShowSFTPPassword.Image")));
            this.btShowSFTPPassword.Location = new System.Drawing.Point(308, 61);
            this.btShowSFTPPassword.Name = "btShowSFTPPassword";
            this.btShowSFTPPassword.Size = new System.Drawing.Size(26, 26);
            this.btShowSFTPPassword.TabIndex = 22;
            this.btShowSFTPPassword.UseVisualStyleBackColor = true;
            this.btShowSFTPPassword.Click += new System.EventHandler(this.btShowSFTPPassword_Click);
            // 
            // txtSFTPPassword
            // 
            this.txtSFTPPassword.Location = new System.Drawing.Point(110, 61);
            this.txtSFTPPassword.Name = "txtSFTPPassword";
            this.txtSFTPPassword.PasswordChar = '*';
            this.txtSFTPPassword.Size = new System.Drawing.Size(192, 23);
            this.txtSFTPPassword.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Password";
            // 
            // txtSFTPUserName
            // 
            this.txtSFTPUserName.Location = new System.Drawing.Point(110, 29);
            this.txtSFTPUserName.Name = "txtSFTPUserName";
            this.txtSFTPUserName.Size = new System.Drawing.Size(192, 23);
            this.txtSFTPUserName.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "User name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btShowFTPPassword);
            this.groupBox4.Controls.Add(this.txtFTPPassword);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtFTPUserName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(58, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 109);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FTP";
            // 
            // btShowFTPPassword
            // 
            this.btShowFTPPassword.Image = ((System.Drawing.Image)(resources.GetObject("btShowFTPPassword.Image")));
            this.btShowFTPPassword.Location = new System.Drawing.Point(308, 62);
            this.btShowFTPPassword.Name = "btShowFTPPassword";
            this.btShowFTPPassword.Size = new System.Drawing.Size(26, 26);
            this.btShowFTPPassword.TabIndex = 21;
            this.btShowFTPPassword.UseVisualStyleBackColor = true;
            this.btShowFTPPassword.Click += new System.EventHandler(this.btShowFTPPassword_Click);
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.Location = new System.Drawing.Point(110, 62);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.PasswordChar = '*';
            this.txtFTPPassword.Size = new System.Drawing.Size(192, 23);
            this.txtFTPPassword.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Password";
            // 
            // txtFTPUserName
            // 
            this.txtFTPUserName.Location = new System.Drawing.Point(110, 29);
            this.txtFTPUserName.Name = "txtFTPUserName";
            this.txtFTPUserName.Size = new System.Drawing.Size(192, 23);
            this.txtFTPUserName.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "User name";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(402, 458);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(89, 27);
            this.btCancel.TabIndex = 20;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 497);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session....";
            this.Load += new System.EventHandler(this.frmSession_Load);
            this.tabMain.ResumeLayout(false);
            this.tabpageSession.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.tabpageAdvancedSession.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPasswordTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConnectionTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUsernameTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommandTimeout)).EndInit();
            this.groupPostLoginCommand.ResumeLayout(false);
            this.groupPostLoginCommand.PerformLayout();
            this.tabpageExtraConnect.ResumeLayout(false);
            this.groupBoxVcXsrv.ResumeLayout(false);
            this.groupBoxVcXsrv.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x040000B7 RID: 183
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Button btOK;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.TabControl tabMain;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.TabPage tabpageSession;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.NumericUpDown numPort;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.ComboBox cmbProtocol;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.TextBox txtHost;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.TextBox txtName;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.TabPage tabpageAdvancedSession;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.RichTextBox richDescription;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.GroupBox groupPostLoginCommand;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.CheckBox checkPostLogin;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Button btCancel;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.NumericUpDown numCommandTimeout;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.TabPage tabpageExtraConnect;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.Button btShowSFTPPassword;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.TextBox txtSFTPPassword;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.TextBox txtSFTPUserName;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Button btShowFTPPassword;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.TextBox txtFTPPassword;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.TextBox txtFTPUserName;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.Button btShowSessionPassword;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.TextBox txtSessionPassword;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000E2 RID: 226
		private global::System.Windows.Forms.TextBox txtSessionUserName;

		// Token: 0x040000E3 RID: 227
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000E4 RID: 228
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040000E6 RID: 230
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.NumericUpDown numPasswordTimeout;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.NumericUpDown numConnectionTimeout;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.NumericUpDown numUsernameTimeout;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.ComboBox cmbPuttySession;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBoxVcXsrv;
        private System.Windows.Forms.Button buttonShowVcXsrvPassword;
        private System.Windows.Forms.TextBox textBoxVcXsrvPassword;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxVcXsrvUserName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox checkBoxUsePublicKey;
    }
}
