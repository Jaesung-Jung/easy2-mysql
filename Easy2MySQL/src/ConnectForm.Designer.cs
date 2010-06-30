namespace Easy2
{
	partial class ConnectForm
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
			if(disposing && (components != null))
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
			this.m_connectionListCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.m_savedConnectionLabel = new DevComponents.DotNetBar.LabelX();
			this.m_deleteConnection = new DevComponents.DotNetBar.ButtonX();
			this.m_renameConnection = new DevComponents.DotNetBar.ButtonX();
			this.m_saveConnection = new DevComponents.DotNetBar.ButtonX();
			this.m_newConnection = new DevComponents.DotNetBar.ButtonX();
			this.m_tabControl = new DevComponents.DotNetBar.TabControl();
			this.m_mysqlTabPanel = new DevComponents.DotNetBar.TabControlPanel();
			this.m_secondLabel = new DevComponents.DotNetBar.LabelX();
			this.m_mysqlTimeoutText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_mysqlTimeoutLabel = new DevComponents.DotNetBar.LabelX();
			this.m_savePasswordCheck = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_mysqlDatabaseText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_mysqlDatabaseLabel = new DevComponents.DotNetBar.LabelX();
			this.m_mysqlPortText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_mysqlPortLabel = new DevComponents.DotNetBar.LabelX();
			this.m_mysqlPasswordText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_mysqlPasswordLabel = new DevComponents.DotNetBar.LabelX();
			this.m_mysqlUsernameText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_mysqlUserLabel = new DevComponents.DotNetBar.LabelX();
			this.m_mysqlHostText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_mysqlHostLabel = new DevComponents.DotNetBar.LabelX();
			this.m_mysqlTab = new DevComponents.DotNetBar.TabItem(this.components);
			this.m_httpTabPanel = new DevComponents.DotNetBar.TabControlPanel();
			this.m_httpTab = new DevComponents.DotNetBar.TabItem(this.components);
			this.m_sslTabPanel = new DevComponents.DotNetBar.TabControlPanel();
			this.m_sslTab = new DevComponents.DotNetBar.TabItem(this.components);
			this.m_sshTabPanel = new DevComponents.DotNetBar.TabControlPanel();
			this.m_sshTab = new DevComponents.DotNetBar.TabItem(this.components);
			this.m_connect = new DevComponents.DotNetBar.ButtonX();
			this.m_close = new DevComponents.DotNetBar.ButtonX();
			this.m_connectTest = new DevComponents.DotNetBar.ButtonX();
			this.m_titleLabel = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.m_titleImgLabel = new DevComponents.DotNetBar.LabelX();
			((System.ComponentModel.ISupportInitialize)(this.m_tabControl)).BeginInit();
			this.m_tabControl.SuspendLayout();
			this.m_mysqlTabPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_connectionListCombo
			// 
			this.m_connectionListCombo.DisplayMember = "Text";
			this.m_connectionListCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.m_connectionListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_connectionListCombo.FormattingEnabled = true;
			this.m_connectionListCombo.ItemHeight = 19;
			this.m_connectionListCombo.Location = new System.Drawing.Point(134, 61);
			this.m_connectionListCombo.Name = "m_connectionListCombo";
			this.m_connectionListCombo.Size = new System.Drawing.Size(336, 25);
			this.m_connectionListCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_connectionListCombo.TabIndex = 1;
			// 
			// m_savedConnectionLabel
			// 
			this.m_savedConnectionLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_savedConnectionLabel.BackgroundStyle.Class = "";
			this.m_savedConnectionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_savedConnectionLabel.Location = new System.Drawing.Point(21, 62);
			this.m_savedConnectionLabel.Name = "m_savedConnectionLabel";
			this.m_savedConnectionLabel.Size = new System.Drawing.Size(105, 21);
			this.m_savedConnectionLabel.TabIndex = 0;
			this.m_savedConnectionLabel.Text = "저장된 연결정보";
			// 
			// m_deleteConnection
			// 
			this.m_deleteConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_deleteConnection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_deleteConnection.Location = new System.Drawing.Point(359, 93);
			this.m_deleteConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_deleteConnection.Name = "m_deleteConnection";
			this.m_deleteConnection.Size = new System.Drawing.Size(111, 25);
			this.m_deleteConnection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_deleteConnection.TabIndex = 22;
			this.m_deleteConnection.Text = "지우기(&D)...";
			this.m_deleteConnection.Click += new System.EventHandler(this.m_deleteConnection_Click);
			// 
			// m_renameConnection
			// 
			this.m_renameConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_renameConnection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_renameConnection.Location = new System.Drawing.Point(242, 93);
			this.m_renameConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_renameConnection.Name = "m_renameConnection";
			this.m_renameConnection.Size = new System.Drawing.Size(111, 25);
			this.m_renameConnection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_renameConnection.TabIndex = 21;
			this.m_renameConnection.Text = "바꾸기(&R)...";
			this.m_renameConnection.Click += new System.EventHandler(this.m_renameConnection_Click);
			// 
			// m_saveConnection
			// 
			this.m_saveConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_saveConnection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_saveConnection.Location = new System.Drawing.Point(125, 93);
			this.m_saveConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_saveConnection.Name = "m_saveConnection";
			this.m_saveConnection.Size = new System.Drawing.Size(111, 25);
			this.m_saveConnection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_saveConnection.TabIndex = 20;
			this.m_saveConnection.Text = "저장(&S)";
			this.m_saveConnection.Click += new System.EventHandler(this.m_saveConnection_Click);
			// 
			// m_newConnection
			// 
			this.m_newConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_newConnection.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_newConnection.Location = new System.Drawing.Point(8, 93);
			this.m_newConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_newConnection.Name = "m_newConnection";
			this.m_newConnection.Size = new System.Drawing.Size(111, 25);
			this.m_newConnection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_newConnection.TabIndex = 19;
			this.m_newConnection.Text = "새 연결(&N)...";
			this.m_newConnection.Click += new System.EventHandler(this.m_newConnection_Click);
			// 
			// m_tabControl
			// 
			this.m_tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.m_tabControl.CanReorderTabs = true;
			this.m_tabControl.Controls.Add(this.m_mysqlTabPanel);
			this.m_tabControl.Controls.Add(this.m_httpTabPanel);
			this.m_tabControl.Controls.Add(this.m_sslTabPanel);
			this.m_tabControl.Controls.Add(this.m_sshTabPanel);
			this.m_tabControl.ForeColor = System.Drawing.SystemColors.ControlText;
			this.m_tabControl.Location = new System.Drawing.Point(8, 125);
			this.m_tabControl.Name = "m_tabControl";
			this.m_tabControl.SelectedTabFont = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
			this.m_tabControl.SelectedTabIndex = 0;
			this.m_tabControl.Size = new System.Drawing.Size(462, 251);
			this.m_tabControl.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock;
			this.m_tabControl.TabIndex = 1;
			this.m_tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
			this.m_tabControl.Tabs.Add(this.m_mysqlTab);
			this.m_tabControl.Tabs.Add(this.m_httpTab);
			this.m_tabControl.Tabs.Add(this.m_sshTab);
			this.m_tabControl.Tabs.Add(this.m_sslTab);
			this.m_tabControl.TabStop = false;
			this.m_tabControl.Text = "tabControl1";
			// 
			// m_mysqlTabPanel
			// 
			this.m_mysqlTabPanel.Controls.Add(this.m_secondLabel);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlTimeoutText);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlTimeoutLabel);
			this.m_mysqlTabPanel.Controls.Add(this.m_savePasswordCheck);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlDatabaseText);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlDatabaseLabel);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlPortText);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlPortLabel);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlPasswordText);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlPasswordLabel);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlUsernameText);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlUserLabel);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlHostText);
			this.m_mysqlTabPanel.Controls.Add(this.m_mysqlHostLabel);
			this.m_mysqlTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_mysqlTabPanel.Location = new System.Drawing.Point(0, 28);
			this.m_mysqlTabPanel.Name = "m_mysqlTabPanel";
			this.m_mysqlTabPanel.Padding = new System.Windows.Forms.Padding(1);
			this.m_mysqlTabPanel.Size = new System.Drawing.Size(462, 223);
			this.m_mysqlTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.m_mysqlTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.m_mysqlTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
			this.m_mysqlTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
						| DevComponents.DotNetBar.eBorderSide.Bottom)));
			this.m_mysqlTabPanel.Style.GradientAngle = 90;
			this.m_mysqlTabPanel.TabIndex = 23;
			this.m_mysqlTabPanel.TabItem = this.m_mysqlTab;
			// 
			// m_secondLabel
			// 
			this.m_secondLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_secondLabel.BackgroundStyle.Class = "";
			this.m_secondLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_secondLabel.Location = new System.Drawing.Point(234, 174);
			this.m_secondLabel.Name = "m_secondLabel";
			this.m_secondLabel.Size = new System.Drawing.Size(20, 21);
			this.m_secondLabel.TabIndex = 15;
			this.m_secondLabel.Text = "초";
			// 
			// m_mysqlTimeoutText
			// 
			// 
			// 
			// 
			this.m_mysqlTimeoutText.Border.Class = "TextBoxBorder";
			this.m_mysqlTimeoutText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlTimeoutText.Location = new System.Drawing.Point(126, 170);
			this.m_mysqlTimeoutText.Name = "m_mysqlTimeoutText";
			this.m_mysqlTimeoutText.Size = new System.Drawing.Size(102, 25);
			this.m_mysqlTimeoutText.TabIndex = 14;
			this.m_mysqlTimeoutText.Text = "15";
			this.m_mysqlTimeoutText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// m_mysqlTimeoutLabel
			// 
			this.m_mysqlTimeoutLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_mysqlTimeoutLabel.BackgroundStyle.Class = "";
			this.m_mysqlTimeoutLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlTimeoutLabel.Location = new System.Drawing.Point(13, 174);
			this.m_mysqlTimeoutLabel.Name = "m_mysqlTimeoutLabel";
			this.m_mysqlTimeoutLabel.Size = new System.Drawing.Size(92, 21);
			this.m_mysqlTimeoutLabel.TabIndex = 13;
			this.m_mysqlTimeoutLabel.Text = "대기시간(&M)";
			// 
			// m_savePasswordCheck
			// 
			this.m_savePasswordCheck.AutoSize = true;
			// 
			// 
			// 
			this.m_savePasswordCheck.BackgroundStyle.Class = "";
			this.m_savePasswordCheck.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_savePasswordCheck.Location = new System.Drawing.Point(347, 78);
			this.m_savePasswordCheck.Name = "m_savePasswordCheck";
			this.m_savePasswordCheck.Size = new System.Drawing.Size(85, 21);
			this.m_savePasswordCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_savePasswordCheck.TabIndex = 8;
			this.m_savePasswordCheck.Text = "저장(&W)";
			// 
			// m_mysqlDatabaseText
			// 
			// 
			// 
			// 
			this.m_mysqlDatabaseText.Border.Class = "TextBoxBorder";
			this.m_mysqlDatabaseText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlDatabaseText.Location = new System.Drawing.Point(126, 138);
			this.m_mysqlDatabaseText.Name = "m_mysqlDatabaseText";
			this.m_mysqlDatabaseText.Size = new System.Drawing.Size(313, 25);
			this.m_mysqlDatabaseText.TabIndex = 12;
			// 
			// m_mysqlDatabaseLabel
			// 
			this.m_mysqlDatabaseLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_mysqlDatabaseLabel.BackgroundStyle.Class = "";
			this.m_mysqlDatabaseLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlDatabaseLabel.Location = new System.Drawing.Point(13, 142);
			this.m_mysqlDatabaseLabel.Name = "m_mysqlDatabaseLabel";
			this.m_mysqlDatabaseLabel.Size = new System.Drawing.Size(114, 21);
			this.m_mysqlDatabaseLabel.TabIndex = 11;
			this.m_mysqlDatabaseLabel.Text = "데이터베이스(&B)";
			// 
			// m_mysqlPortText
			// 
			// 
			// 
			// 
			this.m_mysqlPortText.Border.Class = "TextBoxBorder";
			this.m_mysqlPortText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlPortText.Location = new System.Drawing.Point(126, 107);
			this.m_mysqlPortText.Name = "m_mysqlPortText";
			this.m_mysqlPortText.Size = new System.Drawing.Size(215, 25);
			this.m_mysqlPortText.TabIndex = 10;
			this.m_mysqlPortText.Text = "3306";
			// 
			// m_mysqlPortLabel
			// 
			this.m_mysqlPortLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_mysqlPortLabel.BackgroundStyle.Class = "";
			this.m_mysqlPortLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlPortLabel.Location = new System.Drawing.Point(13, 111);
			this.m_mysqlPortLabel.Name = "m_mysqlPortLabel";
			this.m_mysqlPortLabel.Size = new System.Drawing.Size(63, 21);
			this.m_mysqlPortLabel.TabIndex = 9;
			this.m_mysqlPortLabel.Text = "포트(&O)";
			// 
			// m_mysqlPasswordText
			// 
			// 
			// 
			// 
			this.m_mysqlPasswordText.Border.Class = "TextBoxBorder";
			this.m_mysqlPasswordText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlPasswordText.Location = new System.Drawing.Point(126, 76);
			this.m_mysqlPasswordText.Name = "m_mysqlPasswordText";
			this.m_mysqlPasswordText.Size = new System.Drawing.Size(215, 25);
			this.m_mysqlPasswordText.TabIndex = 7;
			this.m_mysqlPasswordText.UseSystemPasswordChar = true;
			// 
			// m_mysqlPasswordLabel
			// 
			this.m_mysqlPasswordLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_mysqlPasswordLabel.BackgroundStyle.Class = "";
			this.m_mysqlPasswordLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlPasswordLabel.Location = new System.Drawing.Point(13, 80);
			this.m_mysqlPasswordLabel.Name = "m_mysqlPasswordLabel";
			this.m_mysqlPasswordLabel.Size = new System.Drawing.Size(87, 21);
			this.m_mysqlPasswordLabel.TabIndex = 6;
			this.m_mysqlPasswordLabel.Text = "비밀번호(&P)";
			// 
			// m_mysqlUsernameText
			// 
			// 
			// 
			// 
			this.m_mysqlUsernameText.Border.Class = "TextBoxBorder";
			this.m_mysqlUsernameText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlUsernameText.Location = new System.Drawing.Point(126, 45);
			this.m_mysqlUsernameText.Name = "m_mysqlUsernameText";
			this.m_mysqlUsernameText.Size = new System.Drawing.Size(313, 25);
			this.m_mysqlUsernameText.TabIndex = 5;
			// 
			// m_mysqlUserLabel
			// 
			this.m_mysqlUserLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_mysqlUserLabel.BackgroundStyle.Class = "";
			this.m_mysqlUserLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlUserLabel.Location = new System.Drawing.Point(13, 49);
			this.m_mysqlUserLabel.Name = "m_mysqlUserLabel";
			this.m_mysqlUserLabel.Size = new System.Drawing.Size(76, 21);
			this.m_mysqlUserLabel.TabIndex = 4;
			this.m_mysqlUserLabel.Text = "사용자(&U)";
			// 
			// m_mysqlHostText
			// 
			// 
			// 
			// 
			this.m_mysqlHostText.Border.Class = "TextBoxBorder";
			this.m_mysqlHostText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlHostText.Location = new System.Drawing.Point(126, 14);
			this.m_mysqlHostText.Name = "m_mysqlHostText";
			this.m_mysqlHostText.Size = new System.Drawing.Size(313, 25);
			this.m_mysqlHostText.TabIndex = 3;
			this.m_mysqlHostText.Text = "localhost";
			// 
			// m_mysqlHostLabel
			// 
			this.m_mysqlHostLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_mysqlHostLabel.BackgroundStyle.Class = "";
			this.m_mysqlHostLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_mysqlHostLabel.Location = new System.Drawing.Point(13, 18);
			this.m_mysqlHostLabel.Name = "m_mysqlHostLabel";
			this.m_mysqlHostLabel.Size = new System.Drawing.Size(76, 21);
			this.m_mysqlHostLabel.TabIndex = 2;
			this.m_mysqlHostLabel.Text = "호스트(&H)";
			// 
			// m_mysqlTab
			// 
			this.m_mysqlTab.AttachedControl = this.m_mysqlTabPanel;
			this.m_mysqlTab.Name = "m_mysqlTab";
			this.m_mysqlTab.Text = "MySQL";
			// 
			// m_httpTabPanel
			// 
			this.m_httpTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_httpTabPanel.Location = new System.Drawing.Point(0, 28);
			this.m_httpTabPanel.Name = "m_httpTabPanel";
			this.m_httpTabPanel.Padding = new System.Windows.Forms.Padding(1);
			this.m_httpTabPanel.Size = new System.Drawing.Size(462, 223);
			this.m_httpTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.m_httpTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.m_httpTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
			this.m_httpTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
						| DevComponents.DotNetBar.eBorderSide.Bottom)));
			this.m_httpTabPanel.Style.GradientAngle = 90;
			this.m_httpTabPanel.TabIndex = 2;
			this.m_httpTabPanel.TabItem = this.m_httpTab;
			// 
			// m_httpTab
			// 
			this.m_httpTab.AttachedControl = this.m_httpTabPanel;
			this.m_httpTab.Name = "m_httpTab";
			this.m_httpTab.Text = "HTTP";
			// 
			// m_sslTabPanel
			// 
			this.m_sslTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_sslTabPanel.Location = new System.Drawing.Point(0, 28);
			this.m_sslTabPanel.Name = "m_sslTabPanel";
			this.m_sslTabPanel.Padding = new System.Windows.Forms.Padding(1);
			this.m_sslTabPanel.Size = new System.Drawing.Size(462, 223);
			this.m_sslTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.m_sslTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.m_sslTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
			this.m_sslTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
						| DevComponents.DotNetBar.eBorderSide.Bottom)));
			this.m_sslTabPanel.Style.GradientAngle = 90;
			this.m_sslTabPanel.TabIndex = 4;
			this.m_sslTabPanel.TabItem = this.m_sslTab;
			// 
			// m_sslTab
			// 
			this.m_sslTab.AttachedControl = this.m_sslTabPanel;
			this.m_sslTab.Name = "m_sslTab";
			this.m_sslTab.Text = "SSL";
			// 
			// m_sshTabPanel
			// 
			this.m_sshTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_sshTabPanel.Location = new System.Drawing.Point(0, 28);
			this.m_sshTabPanel.Name = "m_sshTabPanel";
			this.m_sshTabPanel.Padding = new System.Windows.Forms.Padding(1);
			this.m_sshTabPanel.Size = new System.Drawing.Size(462, 223);
			this.m_sshTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.m_sshTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.m_sshTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(83)))), ((int)(((byte)(89)))));
			this.m_sshTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
						| DevComponents.DotNetBar.eBorderSide.Bottom)));
			this.m_sshTabPanel.Style.GradientAngle = 90;
			this.m_sshTabPanel.TabIndex = 3;
			this.m_sshTabPanel.TabItem = this.m_sshTab;
			// 
			// m_sshTab
			// 
			this.m_sshTab.AttachedControl = this.m_sshTabPanel;
			this.m_sshTab.Name = "m_sshTab";
			this.m_sshTab.Text = "SSH";
			// 
			// m_connect
			// 
			this.m_connect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_connect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_connect.Location = new System.Drawing.Point(8, 386);
			this.m_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_connect.Name = "m_connect";
			this.m_connect.Size = new System.Drawing.Size(145, 25);
			this.m_connect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_connect.TabIndex = 16;
			this.m_connect.Text = "연결하기(&C)";
			this.m_connect.Click += new System.EventHandler(this.m_connect_Click);
			// 
			// m_close
			// 
			this.m_close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_close.Location = new System.Drawing.Point(167, 386);
			this.m_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_close.Name = "m_close";
			this.m_close.Size = new System.Drawing.Size(145, 25);
			this.m_close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_close.TabIndex = 17;
			this.m_close.Text = "닫기(&L)";
			this.m_close.Click += new System.EventHandler(this.m_close_Click);
			// 
			// m_connectTest
			// 
			this.m_connectTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_connectTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_connectTest.Location = new System.Drawing.Point(325, 386);
			this.m_connectTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_connectTest.Name = "m_connectTest";
			this.m_connectTest.Size = new System.Drawing.Size(145, 25);
			this.m_connectTest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_connectTest.TabIndex = 18;
			this.m_connectTest.Text = "연결테스트(&T)";
			this.m_connectTest.Click += new System.EventHandler(this.m_connectTest_Click);
			// 
			// m_titleLabel
			// 
			// 
			// 
			// 
			this.m_titleLabel.BackgroundStyle.Class = "";
			this.m_titleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleLabel.Location = new System.Drawing.Point(63, 4);
			this.m_titleLabel.Name = "m_titleLabel";
			this.m_titleLabel.Size = new System.Drawing.Size(199, 50);
			this.m_titleLabel.TabIndex = 19;
			this.m_titleLabel.Text = "<b><font size=\"+6\"><font color=\"#015A84\">My</font><font color=\"#E97B00\">SQL</font" +
				"><font color=\"#000000\"> 연결하기</font></font></b>";
			// 
			// m_titleImgLabel
			// 
			// 
			// 
			// 
			this.m_titleImgLabel.BackgroundStyle.Class = "";
			this.m_titleImgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleImgLabel.Image = global::Easy2.Properties.Resources.ConnectDatabaseL;
			this.m_titleImgLabel.Location = new System.Drawing.Point(4, 4);
			this.m_titleImgLabel.Name = "m_titleImgLabel";
			this.m_titleImgLabel.Size = new System.Drawing.Size(48, 48);
			this.m_titleImgLabel.TabIndex = 20;
			// 
			// ConnectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 423);
			this.Controls.Add(this.m_titleLabel);
			this.Controls.Add(this.m_titleImgLabel);
			this.Controls.Add(this.m_connectionListCombo);
			this.Controls.Add(this.m_connect);
			this.Controls.Add(this.m_connectTest);
			this.Controls.Add(this.m_close);
			this.Controls.Add(this.m_newConnection);
			this.Controls.Add(this.m_tabControl);
			this.Controls.Add(this.m_saveConnection);
			this.Controls.Add(this.m_savedConnectionLabel);
			this.Controls.Add(this.m_deleteConnection);
			this.Controls.Add(this.m_renameConnection);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConnectForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to MySQL";
			((System.ComponentModel.ISupportInitialize)(this.m_tabControl)).EndInit();
			this.m_tabControl.ResumeLayout(false);
			this.m_mysqlTabPanel.ResumeLayout(false);
			this.m_mysqlTabPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevComponents.DotNetBar.Controls.ComboBoxEx m_connectionListCombo;
		private DevComponents.DotNetBar.LabelX m_savedConnectionLabel;
		private DevComponents.DotNetBar.ButtonX m_deleteConnection;
		private DevComponents.DotNetBar.ButtonX m_renameConnection;
		private DevComponents.DotNetBar.ButtonX m_saveConnection;
		private DevComponents.DotNetBar.ButtonX m_newConnection;
		private DevComponents.DotNetBar.TabControl m_tabControl;
		private DevComponents.DotNetBar.TabControlPanel m_mysqlTabPanel;
		private DevComponents.DotNetBar.TabItem m_mysqlTab;
		private DevComponents.DotNetBar.TabControlPanel m_httpTabPanel;
		private DevComponents.DotNetBar.TabItem m_httpTab;
		private DevComponents.DotNetBar.TabControlPanel m_sshTabPanel;
		private DevComponents.DotNetBar.TabItem m_sshTab;
		private DevComponents.DotNetBar.TabControlPanel m_sslTabPanel;
		private DevComponents.DotNetBar.TabItem m_sslTab;
		private DevComponents.DotNetBar.LabelX m_mysqlHostLabel;
		private DevComponents.DotNetBar.LabelX m_mysqlPasswordLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_mysqlUsernameText;
		private DevComponents.DotNetBar.LabelX m_mysqlUserLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_mysqlHostText;
		private DevComponents.DotNetBar.Controls.TextBoxX m_mysqlPasswordText;
		private DevComponents.DotNetBar.LabelX m_mysqlPortLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_mysqlPortText;
		private DevComponents.DotNetBar.LabelX m_mysqlDatabaseLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_mysqlDatabaseText;
		private DevComponents.DotNetBar.Controls.CheckBoxX m_savePasswordCheck;
		private DevComponents.DotNetBar.ButtonX m_connect;
		private DevComponents.DotNetBar.ButtonX m_close;
		private DevComponents.DotNetBar.ButtonX m_connectTest;
		private DevComponents.DotNetBar.Controls.ReflectionLabel m_titleLabel;
		private DevComponents.DotNetBar.LabelX m_titleImgLabel;
		private DevComponents.DotNetBar.Controls.TextBoxX m_mysqlTimeoutText;
		private DevComponents.DotNetBar.LabelX m_mysqlTimeoutLabel;
		private DevComponents.DotNetBar.LabelX m_secondLabel;
	}
}