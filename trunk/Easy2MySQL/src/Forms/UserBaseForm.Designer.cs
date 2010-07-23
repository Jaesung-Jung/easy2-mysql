namespace Easy2
{
	partial class UserBaseForm
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
			this.m_titleImgLabel = new DevComponents.DotNetBar.LabelX();
			this.m_titleLabel = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.m_usernameLabel = new DevComponents.DotNetBar.LabelX();
			this.m_usernameText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_hostLabel = new DevComponents.DotNetBar.LabelX();
			this.m_hostText = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_PasswordLabel = new DevComponents.DotNetBar.LabelX();
			this.m_PasswordText1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_retypePasswordLabel = new DevComponents.DotNetBar.LabelX();
			this.m_PasswordText2 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.m_allVersionGroupBox = new System.Windows.Forms.GroupBox();
			this.m_grant = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_alter = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_index = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_reference = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_file = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_process = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_shutdown = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_reload = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_drop = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_create = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_delete = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_update = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_insert = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_select = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_402VersionGroupBox = new System.Windows.Forms.GroupBox();
			this.m_create_tmp_tables = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_lock_tables = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_super = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_repl_client = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_show_db = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_repl_slave = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_execute = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_500VersionGroupBox = new System.Windows.Forms.GroupBox();
			this.m_create_user = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_alter_routine = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_show_view = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_create_routine = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_create_view = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_510VersionGroupBox = new System.Windows.Forms.GroupBox();
			this.m_event = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_trigger = new DevComponents.DotNetBar.Controls.CheckBoxX();
			this.m_closeButton = new DevComponents.DotNetBar.ButtonX();
			this.m_commitButton = new DevComponents.DotNetBar.ButtonX();
			this.m_deselectAllButton = new DevComponents.DotNetBar.ButtonX();
			this.m_selectAllButton = new DevComponents.DotNetBar.ButtonX();
			this.m_allVersionGroupBox.SuspendLayout();
			this.m_402VersionGroupBox.SuspendLayout();
			this.m_500VersionGroupBox.SuspendLayout();
			this.m_510VersionGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_titleImgLabel
			// 
			// 
			// 
			// 
			this.m_titleImgLabel.BackgroundStyle.Class = "";
			this.m_titleImgLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleImgLabel.Location = new System.Drawing.Point(4, 4);
			this.m_titleImgLabel.Name = "m_titleImgLabel";
			this.m_titleImgLabel.Size = new System.Drawing.Size(48, 48);
			this.m_titleImgLabel.TabIndex = 0;
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
			this.m_titleLabel.Size = new System.Drawing.Size(363, 50);
			this.m_titleLabel.TabIndex = 1;
			// 
			// m_usernameLabel
			// 
			this.m_usernameLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_usernameLabel.BackgroundStyle.Class = "";
			this.m_usernameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_usernameLabel.Location = new System.Drawing.Point(12, 69);
			this.m_usernameLabel.Name = "m_usernameLabel";
			this.m_usernameLabel.Size = new System.Drawing.Size(89, 21);
			this.m_usernameLabel.TabIndex = 2;
			this.m_usernameLabel.Text = "사용자명(&U)";
			// 
			// m_usernameText
			// 
			// 
			// 
			// 
			this.m_usernameText.Border.Class = "TextBoxBorder";
			this.m_usernameText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_usernameText.Location = new System.Drawing.Point(96, 68);
			this.m_usernameText.Name = "m_usernameText";
			this.m_usernameText.Size = new System.Drawing.Size(161, 25);
			this.m_usernameText.TabIndex = 3;
			// 
			// m_hostLabel
			// 
			this.m_hostLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_hostLabel.BackgroundStyle.Class = "";
			this.m_hostLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_hostLabel.Location = new System.Drawing.Point(280, 69);
			this.m_hostLabel.Name = "m_hostLabel";
			this.m_hostLabel.Size = new System.Drawing.Size(76, 21);
			this.m_hostLabel.TabIndex = 4;
			this.m_hostLabel.Text = "호스트(&H)";
			// 
			// m_hostText
			// 
			// 
			// 
			// 
			this.m_hostText.Border.Class = "TextBoxBorder";
			this.m_hostText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_hostText.Location = new System.Drawing.Point(351, 68);
			this.m_hostText.Name = "m_hostText";
			this.m_hostText.Size = new System.Drawing.Size(161, 25);
			this.m_hostText.TabIndex = 5;
			this.m_hostText.Text = "%";
			// 
			// m_PasswordLabel
			// 
			this.m_PasswordLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_PasswordLabel.BackgroundStyle.Class = "";
			this.m_PasswordLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_PasswordLabel.Location = new System.Drawing.Point(12, 101);
			this.m_PasswordLabel.Name = "m_PasswordLabel";
			this.m_PasswordLabel.Size = new System.Drawing.Size(87, 21);
			this.m_PasswordLabel.TabIndex = 6;
			this.m_PasswordLabel.Text = "비밀번호(&P)";
			// 
			// m_PasswordText1
			// 
			// 
			// 
			// 
			this.m_PasswordText1.Border.Class = "TextBoxBorder";
			this.m_PasswordText1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_PasswordText1.Location = new System.Drawing.Point(96, 99);
			this.m_PasswordText1.Name = "m_PasswordText1";
			this.m_PasswordText1.Size = new System.Drawing.Size(135, 25);
			this.m_PasswordText1.TabIndex = 7;
			this.m_PasswordText1.UseSystemPasswordChar = true;
			// 
			// m_retypePasswordLabel
			// 
			this.m_retypePasswordLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_retypePasswordLabel.BackgroundStyle.Class = "";
			this.m_retypePasswordLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_retypePasswordLabel.Location = new System.Drawing.Point(249, 101);
			this.m_retypePasswordLabel.Name = "m_retypePasswordLabel";
			this.m_retypePasswordLabel.Size = new System.Drawing.Size(133, 21);
			this.m_retypePasswordLabel.TabIndex = 8;
			this.m_retypePasswordLabel.Text = "비밀번호 재입력(&R)";
			// 
			// m_PasswordText2
			// 
			// 
			// 
			// 
			this.m_PasswordText2.Border.Class = "TextBoxBorder";
			this.m_PasswordText2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_PasswordText2.Location = new System.Drawing.Point(377, 99);
			this.m_PasswordText2.Name = "m_PasswordText2";
			this.m_PasswordText2.Size = new System.Drawing.Size(135, 25);
			this.m_PasswordText2.TabIndex = 9;
			this.m_PasswordText2.UseSystemPasswordChar = true;
			// 
			// m_allVersionGroupBox
			// 
			this.m_allVersionGroupBox.Controls.Add(this.m_grant);
			this.m_allVersionGroupBox.Controls.Add(this.m_alter);
			this.m_allVersionGroupBox.Controls.Add(this.m_index);
			this.m_allVersionGroupBox.Controls.Add(this.m_reference);
			this.m_allVersionGroupBox.Controls.Add(this.m_file);
			this.m_allVersionGroupBox.Controls.Add(this.m_process);
			this.m_allVersionGroupBox.Controls.Add(this.m_shutdown);
			this.m_allVersionGroupBox.Controls.Add(this.m_reload);
			this.m_allVersionGroupBox.Controls.Add(this.m_drop);
			this.m_allVersionGroupBox.Controls.Add(this.m_create);
			this.m_allVersionGroupBox.Controls.Add(this.m_delete);
			this.m_allVersionGroupBox.Controls.Add(this.m_update);
			this.m_allVersionGroupBox.Controls.Add(this.m_insert);
			this.m_allVersionGroupBox.Controls.Add(this.m_select);
			this.m_allVersionGroupBox.Location = new System.Drawing.Point(12, 130);
			this.m_allVersionGroupBox.Name = "m_allVersionGroupBox";
			this.m_allVersionGroupBox.Size = new System.Drawing.Size(500, 110);
			this.m_allVersionGroupBox.TabIndex = 10;
			this.m_allVersionGroupBox.TabStop = false;
			this.m_allVersionGroupBox.Text = "MySQL All Version";
			// 
			// m_grant
			// 
			this.m_grant.AutoSize = true;
			// 
			// 
			// 
			this.m_grant.BackgroundStyle.Class = "";
			this.m_grant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_grant.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_grant.Location = new System.Drawing.Point(314, 76);
			this.m_grant.Name = "m_grant";
			this.m_grant.Size = new System.Drawing.Size(67, 20);
			this.m_grant.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_grant.TabIndex = 13;
			this.m_grant.Text = "GRANT";
			// 
			// m_alter
			// 
			this.m_alter.AutoSize = true;
			// 
			// 
			// 
			this.m_alter.BackgroundStyle.Class = "";
			this.m_alter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_alter.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_alter.Location = new System.Drawing.Point(200, 76);
			this.m_alter.Name = "m_alter";
			this.m_alter.Size = new System.Drawing.Size(61, 20);
			this.m_alter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_alter.TabIndex = 12;
			this.m_alter.Text = "ALTER";
			// 
			// m_index
			// 
			this.m_index.AutoSize = true;
			// 
			// 
			// 
			this.m_index.BackgroundStyle.Class = "";
			this.m_index.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_index.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_index.Location = new System.Drawing.Point(103, 76);
			this.m_index.Name = "m_index";
			this.m_index.Size = new System.Drawing.Size(62, 20);
			this.m_index.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_index.TabIndex = 11;
			this.m_index.Text = "INDEX";
			// 
			// m_reference
			// 
			this.m_reference.AutoSize = true;
			// 
			// 
			// 
			this.m_reference.BackgroundStyle.Class = "";
			this.m_reference.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_reference.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_reference.Location = new System.Drawing.Point(6, 76);
			this.m_reference.Name = "m_reference";
			this.m_reference.Size = new System.Drawing.Size(91, 20);
			this.m_reference.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_reference.TabIndex = 10;
			this.m_reference.Text = "REFERENCE";
			// 
			// m_file
			// 
			this.m_file.AutoSize = true;
			// 
			// 
			// 
			this.m_file.BackgroundStyle.Class = "";
			this.m_file.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_file.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_file.Location = new System.Drawing.Point(420, 50);
			this.m_file.Name = "m_file";
			this.m_file.Size = new System.Drawing.Size(48, 20);
			this.m_file.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_file.TabIndex = 9;
			this.m_file.Text = "FILE";
			// 
			// m_process
			// 
			this.m_process.AutoSize = true;
			// 
			// 
			// 
			this.m_process.BackgroundStyle.Class = "";
			this.m_process.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_process.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_process.Location = new System.Drawing.Point(314, 50);
			this.m_process.Name = "m_process";
			this.m_process.Size = new System.Drawing.Size(78, 20);
			this.m_process.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_process.TabIndex = 8;
			this.m_process.Text = "PROCESS";
			// 
			// m_shutdown
			// 
			this.m_shutdown.AutoSize = true;
			// 
			// 
			// 
			this.m_shutdown.BackgroundStyle.Class = "";
			this.m_shutdown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_shutdown.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_shutdown.Location = new System.Drawing.Point(200, 50);
			this.m_shutdown.Name = "m_shutdown";
			this.m_shutdown.Size = new System.Drawing.Size(97, 20);
			this.m_shutdown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_shutdown.TabIndex = 7;
			this.m_shutdown.Text = "SHUTDOWN";
			// 
			// m_reload
			// 
			this.m_reload.AutoSize = true;
			// 
			// 
			// 
			this.m_reload.BackgroundStyle.Class = "";
			this.m_reload.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_reload.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_reload.Location = new System.Drawing.Point(103, 50);
			this.m_reload.Name = "m_reload";
			this.m_reload.Size = new System.Drawing.Size(73, 20);
			this.m_reload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_reload.TabIndex = 6;
			this.m_reload.Text = "RELOAD";
			// 
			// m_drop
			// 
			this.m_drop.AutoSize = true;
			// 
			// 
			// 
			this.m_drop.BackgroundStyle.Class = "";
			this.m_drop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_drop.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_drop.Location = new System.Drawing.Point(6, 50);
			this.m_drop.Name = "m_drop";
			this.m_drop.Size = new System.Drawing.Size(60, 20);
			this.m_drop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_drop.TabIndex = 5;
			this.m_drop.Text = "DROP";
			// 
			// m_create
			// 
			this.m_create.AutoSize = true;
			// 
			// 
			// 
			this.m_create.BackgroundStyle.Class = "";
			this.m_create.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_create.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_create.Location = new System.Drawing.Point(420, 24);
			this.m_create.Name = "m_create";
			this.m_create.Size = new System.Drawing.Size(69, 20);
			this.m_create.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_create.TabIndex = 4;
			this.m_create.Text = "CREATE";
			// 
			// m_delete
			// 
			this.m_delete.AutoSize = true;
			// 
			// 
			// 
			this.m_delete.BackgroundStyle.Class = "";
			this.m_delete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_delete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_delete.Location = new System.Drawing.Point(314, 24);
			this.m_delete.Name = "m_delete";
			this.m_delete.Size = new System.Drawing.Size(67, 20);
			this.m_delete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_delete.TabIndex = 3;
			this.m_delete.Text = "DELETE";
			// 
			// m_update
			// 
			this.m_update.AutoSize = true;
			// 
			// 
			// 
			this.m_update.BackgroundStyle.Class = "";
			this.m_update.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_update.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_update.Location = new System.Drawing.Point(200, 24);
			this.m_update.Name = "m_update";
			this.m_update.Size = new System.Drawing.Size(72, 20);
			this.m_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_update.TabIndex = 2;
			this.m_update.Text = "UPDATE";
			// 
			// m_insert
			// 
			this.m_insert.AutoSize = true;
			// 
			// 
			// 
			this.m_insert.BackgroundStyle.Class = "";
			this.m_insert.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_insert.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_insert.Location = new System.Drawing.Point(103, 24);
			this.m_insert.Name = "m_insert";
			this.m_insert.Size = new System.Drawing.Size(67, 20);
			this.m_insert.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_insert.TabIndex = 1;
			this.m_insert.Text = "INSERT";
			// 
			// m_select
			// 
			this.m_select.AutoSize = true;
			// 
			// 
			// 
			this.m_select.BackgroundStyle.Class = "";
			this.m_select.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_select.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_select.Location = new System.Drawing.Point(6, 24);
			this.m_select.Name = "m_select";
			this.m_select.Size = new System.Drawing.Size(66, 20);
			this.m_select.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_select.TabIndex = 0;
			this.m_select.Text = "SELECT";
			// 
			// m_402VersionGroupBox
			// 
			this.m_402VersionGroupBox.Controls.Add(this.m_create_tmp_tables);
			this.m_402VersionGroupBox.Controls.Add(this.m_lock_tables);
			this.m_402VersionGroupBox.Controls.Add(this.m_super);
			this.m_402VersionGroupBox.Controls.Add(this.m_repl_client);
			this.m_402VersionGroupBox.Controls.Add(this.m_show_db);
			this.m_402VersionGroupBox.Controls.Add(this.m_repl_slave);
			this.m_402VersionGroupBox.Controls.Add(this.m_execute);
			this.m_402VersionGroupBox.Location = new System.Drawing.Point(12, 246);
			this.m_402VersionGroupBox.Name = "m_402VersionGroupBox";
			this.m_402VersionGroupBox.Size = new System.Drawing.Size(245, 167);
			this.m_402VersionGroupBox.TabIndex = 11;
			this.m_402VersionGroupBox.TabStop = false;
			this.m_402VersionGroupBox.Text = "MySQL 4.0.2 Version";
			// 
			// m_create_tmp_tables
			// 
			this.m_create_tmp_tables.AutoSize = true;
			// 
			// 
			// 
			this.m_create_tmp_tables.BackgroundStyle.Class = "";
			this.m_create_tmp_tables.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_create_tmp_tables.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_create_tmp_tables.Location = new System.Drawing.Point(6, 102);
			this.m_create_tmp_tables.Name = "m_create_tmp_tables";
			this.m_create_tmp_tables.Size = new System.Drawing.Size(146, 20);
			this.m_create_tmp_tables.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_create_tmp_tables.TabIndex = 6;
			this.m_create_tmp_tables.Text = "CREATE_TMP_TABLES";
			// 
			// m_lock_tables
			// 
			this.m_lock_tables.AutoSize = true;
			// 
			// 
			// 
			this.m_lock_tables.BackgroundStyle.Class = "";
			this.m_lock_tables.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_lock_tables.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_lock_tables.Location = new System.Drawing.Point(103, 76);
			this.m_lock_tables.Name = "m_lock_tables";
			this.m_lock_tables.Size = new System.Drawing.Size(103, 20);
			this.m_lock_tables.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_lock_tables.TabIndex = 5;
			this.m_lock_tables.Text = "LOCK_TABLES";
			// 
			// m_super
			// 
			this.m_super.AutoSize = true;
			// 
			// 
			// 
			this.m_super.BackgroundStyle.Class = "";
			this.m_super.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_super.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_super.Location = new System.Drawing.Point(6, 76);
			this.m_super.Name = "m_super";
			this.m_super.Size = new System.Drawing.Size(63, 20);
			this.m_super.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_super.TabIndex = 4;
			this.m_super.Text = "SUPER";
			// 
			// m_repl_client
			// 
			this.m_repl_client.AutoSize = true;
			// 
			// 
			// 
			this.m_repl_client.BackgroundStyle.Class = "";
			this.m_repl_client.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_repl_client.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_repl_client.Location = new System.Drawing.Point(103, 50);
			this.m_repl_client.Name = "m_repl_client";
			this.m_repl_client.Size = new System.Drawing.Size(98, 20);
			this.m_repl_client.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_repl_client.TabIndex = 3;
			this.m_repl_client.Text = "REPL_CLIENT";
			// 
			// m_show_db
			// 
			this.m_show_db.AutoSize = true;
			// 
			// 
			// 
			this.m_show_db.BackgroundStyle.Class = "";
			this.m_show_db.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_show_db.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_show_db.Location = new System.Drawing.Point(6, 50);
			this.m_show_db.Name = "m_show_db";
			this.m_show_db.Size = new System.Drawing.Size(85, 20);
			this.m_show_db.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_show_db.TabIndex = 2;
			this.m_show_db.Text = "SHOW_DB";
			// 
			// m_repl_slave
			// 
			this.m_repl_slave.AutoSize = true;
			// 
			// 
			// 
			this.m_repl_slave.BackgroundStyle.Class = "";
			this.m_repl_slave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_repl_slave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_repl_slave.Location = new System.Drawing.Point(103, 24);
			this.m_repl_slave.Name = "m_repl_slave";
			this.m_repl_slave.Size = new System.Drawing.Size(94, 20);
			this.m_repl_slave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_repl_slave.TabIndex = 1;
			this.m_repl_slave.Text = "REPL_SLAVE";
			// 
			// m_execute
			// 
			this.m_execute.AutoSize = true;
			// 
			// 
			// 
			this.m_execute.BackgroundStyle.Class = "";
			this.m_execute.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_execute.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_execute.Location = new System.Drawing.Point(6, 24);
			this.m_execute.Name = "m_execute";
			this.m_execute.Size = new System.Drawing.Size(76, 20);
			this.m_execute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_execute.TabIndex = 0;
			this.m_execute.Text = "EXECUTE";
			// 
			// m_500VersionGroupBox
			// 
			this.m_500VersionGroupBox.Controls.Add(this.m_create_user);
			this.m_500VersionGroupBox.Controls.Add(this.m_alter_routine);
			this.m_500VersionGroupBox.Controls.Add(this.m_show_view);
			this.m_500VersionGroupBox.Controls.Add(this.m_create_routine);
			this.m_500VersionGroupBox.Controls.Add(this.m_create_view);
			this.m_500VersionGroupBox.Location = new System.Drawing.Point(267, 246);
			this.m_500VersionGroupBox.Name = "m_500VersionGroupBox";
			this.m_500VersionGroupBox.Size = new System.Drawing.Size(245, 106);
			this.m_500VersionGroupBox.TabIndex = 12;
			this.m_500VersionGroupBox.TabStop = false;
			this.m_500VersionGroupBox.Text = "MySQL 5.0 Version";
			// 
			// m_create_user
			// 
			this.m_create_user.AutoSize = true;
			// 
			// 
			// 
			this.m_create_user.BackgroundStyle.Class = "";
			this.m_create_user.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_create_user.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_create_user.Location = new System.Drawing.Point(6, 76);
			this.m_create_user.Name = "m_create_user";
			this.m_create_user.Size = new System.Drawing.Size(104, 20);
			this.m_create_user.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_create_user.TabIndex = 4;
			this.m_create_user.Text = "CREATE_USER";
			// 
			// m_alter_routine
			// 
			this.m_alter_routine.AutoSize = true;
			// 
			// 
			// 
			this.m_alter_routine.BackgroundStyle.Class = "";
			this.m_alter_routine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_alter_routine.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_alter_routine.Location = new System.Drawing.Point(116, 50);
			this.m_alter_routine.Name = "m_alter_routine";
			this.m_alter_routine.Size = new System.Drawing.Size(118, 20);
			this.m_alter_routine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_alter_routine.TabIndex = 3;
			this.m_alter_routine.Text = "ALTER_ROUTINE";
			// 
			// m_show_view
			// 
			this.m_show_view.AutoSize = true;
			// 
			// 
			// 
			this.m_show_view.BackgroundStyle.Class = "";
			this.m_show_view.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_show_view.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_show_view.Location = new System.Drawing.Point(6, 50);
			this.m_show_view.Name = "m_show_view";
			this.m_show_view.Size = new System.Drawing.Size(98, 20);
			this.m_show_view.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_show_view.TabIndex = 2;
			this.m_show_view.Text = "SHOW_VIEW";
			// 
			// m_create_routine
			// 
			this.m_create_routine.AutoSize = true;
			// 
			// 
			// 
			this.m_create_routine.BackgroundStyle.Class = "";
			this.m_create_routine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_create_routine.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_create_routine.Location = new System.Drawing.Point(116, 24);
			this.m_create_routine.Name = "m_create_routine";
			this.m_create_routine.Size = new System.Drawing.Size(126, 20);
			this.m_create_routine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_create_routine.TabIndex = 1;
			this.m_create_routine.Text = "CREATE_ROUTINE";
			// 
			// m_create_view
			// 
			this.m_create_view.AutoSize = true;
			// 
			// 
			// 
			this.m_create_view.BackgroundStyle.Class = "";
			this.m_create_view.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_create_view.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_create_view.Location = new System.Drawing.Point(6, 24);
			this.m_create_view.Name = "m_create_view";
			this.m_create_view.Size = new System.Drawing.Size(104, 20);
			this.m_create_view.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_create_view.TabIndex = 0;
			this.m_create_view.Text = "CREATE_VIEW";
			// 
			// m_510VersionGroupBox
			// 
			this.m_510VersionGroupBox.Controls.Add(this.m_event);
			this.m_510VersionGroupBox.Controls.Add(this.m_trigger);
			this.m_510VersionGroupBox.Location = new System.Drawing.Point(267, 358);
			this.m_510VersionGroupBox.Name = "m_510VersionGroupBox";
			this.m_510VersionGroupBox.Size = new System.Drawing.Size(245, 54);
			this.m_510VersionGroupBox.TabIndex = 13;
			this.m_510VersionGroupBox.TabStop = false;
			this.m_510VersionGroupBox.Text = "MySQL 5.1 Version";
			// 
			// m_event
			// 
			this.m_event.AutoSize = true;
			// 
			// 
			// 
			this.m_event.BackgroundStyle.Class = "";
			this.m_event.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_event.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_event.Location = new System.Drawing.Point(116, 24);
			this.m_event.Name = "m_event";
			this.m_event.Size = new System.Drawing.Size(63, 20);
			this.m_event.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_event.TabIndex = 1;
			this.m_event.Text = "EVENT";
			// 
			// m_trigger
			// 
			this.m_trigger.AutoSize = true;
			// 
			// 
			// 
			this.m_trigger.BackgroundStyle.Class = "";
			this.m_trigger.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_trigger.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.m_trigger.Location = new System.Drawing.Point(6, 24);
			this.m_trigger.Name = "m_trigger";
			this.m_trigger.Size = new System.Drawing.Size(75, 20);
			this.m_trigger.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_trigger.TabIndex = 0;
			this.m_trigger.Text = "TRIGGER";
			// 
			// m_closeButton
			// 
			this.m_closeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_closeButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_closeButton.Location = new System.Drawing.Point(396, 426);
			this.m_closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_closeButton.Name = "m_closeButton";
			this.m_closeButton.Size = new System.Drawing.Size(116, 25);
			this.m_closeButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_closeButton.TabIndex = 24;
			this.m_closeButton.Text = "닫기(&L)";
			this.m_closeButton.Click += new System.EventHandler(this.OnCloseButtonClick);
			// 
			// m_commitButton
			// 
			this.m_commitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_commitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_commitButton.Location = new System.Drawing.Point(267, 426);
			this.m_commitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_commitButton.Name = "m_commitButton";
			this.m_commitButton.Size = new System.Drawing.Size(116, 25);
			this.m_commitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_commitButton.TabIndex = 23;
			this.m_commitButton.Text = "확인(&C)";
			this.m_commitButton.Click += new System.EventHandler(this.OnCommitButtonClick);
			// 
			// m_deselectAllButton
			// 
			this.m_deselectAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_deselectAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_deselectAllButton.Location = new System.Drawing.Point(141, 426);
			this.m_deselectAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_deselectAllButton.Name = "m_deselectAllButton";
			this.m_deselectAllButton.Size = new System.Drawing.Size(116, 25);
			this.m_deselectAllButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_deselectAllButton.TabIndex = 22;
			this.m_deselectAllButton.Text = "선택해제(&D)";
			this.m_deselectAllButton.Click += new System.EventHandler(this.OnDeselectAllButtonClick);
			// 
			// m_selectAllButton
			// 
			this.m_selectAllButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_selectAllButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_selectAllButton.Location = new System.Drawing.Point(12, 426);
			this.m_selectAllButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.m_selectAllButton.Name = "m_selectAllButton";
			this.m_selectAllButton.Size = new System.Drawing.Size(116, 25);
			this.m_selectAllButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_selectAllButton.TabIndex = 21;
			this.m_selectAllButton.Text = "모두선택(&A)";
			this.m_selectAllButton.Click += new System.EventHandler(this.OnSelectAllButtonClick);
			// 
			// UserBaseForm
			// 
			this.AcceptButton = this.m_commitButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_closeButton;
			this.ClientSize = new System.Drawing.Size(525, 464);
			this.Controls.Add(this.m_closeButton);
			this.Controls.Add(this.m_commitButton);
			this.Controls.Add(this.m_deselectAllButton);
			this.Controls.Add(this.m_selectAllButton);
			this.Controls.Add(this.m_510VersionGroupBox);
			this.Controls.Add(this.m_500VersionGroupBox);
			this.Controls.Add(this.m_402VersionGroupBox);
			this.Controls.Add(this.m_allVersionGroupBox);
			this.Controls.Add(this.m_PasswordText2);
			this.Controls.Add(this.m_retypePasswordLabel);
			this.Controls.Add(this.m_PasswordText1);
			this.Controls.Add(this.m_PasswordLabel);
			this.Controls.Add(this.m_hostText);
			this.Controls.Add(this.m_hostLabel);
			this.Controls.Add(this.m_usernameText);
			this.Controls.Add(this.m_usernameLabel);
			this.Controls.Add(this.m_titleLabel);
			this.Controls.Add(this.m_titleImgLabel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserBaseForm";
			this.Text = "UserForm";
			this.m_allVersionGroupBox.ResumeLayout(false);
			this.m_allVersionGroupBox.PerformLayout();
			this.m_402VersionGroupBox.ResumeLayout(false);
			this.m_402VersionGroupBox.PerformLayout();
			this.m_500VersionGroupBox.ResumeLayout(false);
			this.m_500VersionGroupBox.PerformLayout();
			this.m_510VersionGroupBox.ResumeLayout(false);
			this.m_510VersionGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected DevComponents.DotNetBar.LabelX m_titleImgLabel;
		protected DevComponents.DotNetBar.Controls.ReflectionLabel m_titleLabel;
		protected DevComponents.DotNetBar.LabelX m_usernameLabel;
		protected DevComponents.DotNetBar.Controls.TextBoxX m_usernameText;
		protected DevComponents.DotNetBar.LabelX m_hostLabel;
		protected DevComponents.DotNetBar.Controls.TextBoxX m_PasswordText1;
		protected DevComponents.DotNetBar.Controls.TextBoxX m_hostText;
		protected DevComponents.DotNetBar.LabelX m_PasswordLabel;
		protected DevComponents.DotNetBar.LabelX m_retypePasswordLabel;
		protected DevComponents.DotNetBar.Controls.TextBoxX m_PasswordText2;
		protected System.Windows.Forms.GroupBox m_allVersionGroupBox;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_grant;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_trigger;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_alter;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_index;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_reference;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_file;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_process;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_shutdown;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_reload;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_drop;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_create;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_delete;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_update;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_insert;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_select;
		protected System.Windows.Forms.GroupBox m_402VersionGroupBox;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_create_tmp_tables;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_lock_tables;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_super;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_repl_client;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_show_db;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_repl_slave;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_execute;
		protected System.Windows.Forms.GroupBox m_500VersionGroupBox;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_create_user;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_alter_routine;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_show_view;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_create_routine;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_create_view;
		protected System.Windows.Forms.GroupBox m_510VersionGroupBox;
		protected DevComponents.DotNetBar.Controls.CheckBoxX m_event;
		protected DevComponents.DotNetBar.ButtonX m_closeButton;
		protected DevComponents.DotNetBar.ButtonX m_commitButton;
		protected DevComponents.DotNetBar.ButtonX m_deselectAllButton;
		protected DevComponents.DotNetBar.ButtonX m_selectAllButton;
	}
}