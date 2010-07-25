namespace Easy2.Forms
{
	partial class AlterUserForm
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
			this.m_userListLabel = new DevComponents.DotNetBar.LabelX();
			this.m_userListCombo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.m_deleteUserButton = new DevComponents.DotNetBar.ButtonX();
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
			this.m_titleImgLabel.Image = global::Easy2.Properties.Resources.AlterUser;
			// 
			// m_titleLabel
			// 
			// 
			// 
			// 
			this.m_titleLabel.BackgroundStyle.Class = "";
			this.m_titleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_titleLabel.Text = "<b><font size=\"+6\"><font color=\"#015A84\">My</font><font color=\"#E97B00\">SQL</font" +
				"><font color=\"#000000\"> 사용자 수정하기</font></font></b>";
			// 
			// m_usernameLabel
			// 
			// 
			// 
			// 
			this.m_usernameLabel.BackgroundStyle.Class = "";
			this.m_usernameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_usernameLabel.Location = new System.Drawing.Point(12, 100);
			this.m_usernameLabel.Size = new System.Drawing.Size(89, 21);
			this.m_usernameLabel.TabIndex = 5;
			// 
			// m_usernameText
			// 
			// 
			// 
			// 
			this.m_usernameText.Border.Class = "TextBoxBorder";
			this.m_usernameText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_usernameText.Location = new System.Drawing.Point(96, 99);
			this.m_usernameText.TabIndex = 6;
			// 
			// m_hostLabel
			// 
			// 
			// 
			// 
			this.m_hostLabel.BackgroundStyle.Class = "";
			this.m_hostLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_hostLabel.Location = new System.Drawing.Point(280, 100);
			this.m_hostLabel.Size = new System.Drawing.Size(76, 21);
			this.m_hostLabel.TabIndex = 7;
			// 
			// m_PasswordText1
			// 
			// 
			// 
			// 
			this.m_PasswordText1.Border.Class = "TextBoxBorder";
			this.m_PasswordText1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_PasswordText1.Location = new System.Drawing.Point(96, 130);
			this.m_PasswordText1.TabIndex = 10;
			// 
			// m_hostText
			// 
			// 
			// 
			// 
			this.m_hostText.Border.Class = "TextBoxBorder";
			this.m_hostText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_hostText.Location = new System.Drawing.Point(351, 99);
			this.m_hostText.TabIndex = 8;
			// 
			// m_PasswordLabel
			// 
			// 
			// 
			// 
			this.m_PasswordLabel.BackgroundStyle.Class = "";
			this.m_PasswordLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_PasswordLabel.Location = new System.Drawing.Point(12, 132);
			this.m_PasswordLabel.Size = new System.Drawing.Size(87, 21);
			this.m_PasswordLabel.TabIndex = 9;
			// 
			// m_retypePasswordLabel
			// 
			// 
			// 
			// 
			this.m_retypePasswordLabel.BackgroundStyle.Class = "";
			this.m_retypePasswordLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_retypePasswordLabel.Location = new System.Drawing.Point(249, 132);
			this.m_retypePasswordLabel.Size = new System.Drawing.Size(133, 21);
			this.m_retypePasswordLabel.TabIndex = 11;
			// 
			// m_PasswordText2
			// 
			// 
			// 
			// 
			this.m_PasswordText2.Border.Class = "TextBoxBorder";
			this.m_PasswordText2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_PasswordText2.Location = new System.Drawing.Point(377, 130);
			this.m_PasswordText2.TabIndex = 12;
			// 
			// m_allVersionGroupBox
			// 
			this.m_allVersionGroupBox.Location = new System.Drawing.Point(12, 161);
			this.m_allVersionGroupBox.TabIndex = 13;
			// 
			// m_grant
			// 
			// 
			// 
			// 
			this.m_grant.BackgroundStyle.Class = "";
			this.m_grant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_trigger
			// 
			// 
			// 
			// 
			this.m_trigger.BackgroundStyle.Class = "";
			this.m_trigger.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_alter
			// 
			// 
			// 
			// 
			this.m_alter.BackgroundStyle.Class = "";
			this.m_alter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_index
			// 
			// 
			// 
			// 
			this.m_index.BackgroundStyle.Class = "";
			this.m_index.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_reference
			// 
			// 
			// 
			// 
			this.m_reference.BackgroundStyle.Class = "";
			this.m_reference.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_file
			// 
			// 
			// 
			// 
			this.m_file.BackgroundStyle.Class = "";
			this.m_file.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_process
			// 
			// 
			// 
			// 
			this.m_process.BackgroundStyle.Class = "";
			this.m_process.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_shutdown
			// 
			// 
			// 
			// 
			this.m_shutdown.BackgroundStyle.Class = "";
			this.m_shutdown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_reload
			// 
			// 
			// 
			// 
			this.m_reload.BackgroundStyle.Class = "";
			this.m_reload.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_drop
			// 
			// 
			// 
			// 
			this.m_drop.BackgroundStyle.Class = "";
			this.m_drop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_create
			// 
			// 
			// 
			// 
			this.m_create.BackgroundStyle.Class = "";
			this.m_create.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_delete
			// 
			// 
			// 
			// 
			this.m_delete.BackgroundStyle.Class = "";
			this.m_delete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_update
			// 
			// 
			// 
			// 
			this.m_update.BackgroundStyle.Class = "";
			this.m_update.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_insert
			// 
			// 
			// 
			// 
			this.m_insert.BackgroundStyle.Class = "";
			this.m_insert.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_select
			// 
			// 
			// 
			// 
			this.m_select.BackgroundStyle.Class = "";
			this.m_select.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_402VersionGroupBox
			// 
			this.m_402VersionGroupBox.Location = new System.Drawing.Point(12, 277);
			this.m_402VersionGroupBox.TabIndex = 14;
			// 
			// m_create_tmp_tables
			// 
			// 
			// 
			// 
			this.m_create_tmp_tables.BackgroundStyle.Class = "";
			this.m_create_tmp_tables.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_lock_tables
			// 
			// 
			// 
			// 
			this.m_lock_tables.BackgroundStyle.Class = "";
			this.m_lock_tables.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_super
			// 
			// 
			// 
			// 
			this.m_super.BackgroundStyle.Class = "";
			this.m_super.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_repl_client
			// 
			// 
			// 
			// 
			this.m_repl_client.BackgroundStyle.Class = "";
			this.m_repl_client.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_show_db
			// 
			// 
			// 
			// 
			this.m_show_db.BackgroundStyle.Class = "";
			this.m_show_db.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_repl_slave
			// 
			// 
			// 
			// 
			this.m_repl_slave.BackgroundStyle.Class = "";
			this.m_repl_slave.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_execute
			// 
			// 
			// 
			// 
			this.m_execute.BackgroundStyle.Class = "";
			this.m_execute.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_500VersionGroupBox
			// 
			this.m_500VersionGroupBox.Location = new System.Drawing.Point(267, 277);
			this.m_500VersionGroupBox.TabIndex = 15;
			// 
			// m_create_user
			// 
			// 
			// 
			// 
			this.m_create_user.BackgroundStyle.Class = "";
			this.m_create_user.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_alter_routine
			// 
			// 
			// 
			// 
			this.m_alter_routine.BackgroundStyle.Class = "";
			this.m_alter_routine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_show_view
			// 
			// 
			// 
			// 
			this.m_show_view.BackgroundStyle.Class = "";
			this.m_show_view.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_create_routine
			// 
			// 
			// 
			// 
			this.m_create_routine.BackgroundStyle.Class = "";
			this.m_create_routine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_create_view
			// 
			// 
			// 
			// 
			this.m_create_view.BackgroundStyle.Class = "";
			this.m_create_view.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_510VersionGroupBox
			// 
			this.m_510VersionGroupBox.Location = new System.Drawing.Point(267, 389);
			this.m_510VersionGroupBox.TabIndex = 16;
			// 
			// m_event
			// 
			// 
			// 
			// 
			this.m_event.BackgroundStyle.Class = "";
			this.m_event.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// m_closeButton
			// 
			this.m_closeButton.Location = new System.Drawing.Point(396, 457);
			// 
			// m_commitButton
			// 
			this.m_commitButton.Location = new System.Drawing.Point(267, 457);
			// 
			// m_deselectAllButton
			// 
			this.m_deselectAllButton.Location = new System.Drawing.Point(141, 457);
			// 
			// m_selectAllButton
			// 
			this.m_selectAllButton.Location = new System.Drawing.Point(12, 457);
			// 
			// m_userListLabel
			// 
			this.m_userListLabel.AutoSize = true;
			// 
			// 
			// 
			this.m_userListLabel.BackgroundStyle.Class = "";
			this.m_userListLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.m_userListLabel.Location = new System.Drawing.Point(12, 69);
			this.m_userListLabel.Name = "m_userListLabel";
			this.m_userListLabel.Size = new System.Drawing.Size(47, 21);
			this.m_userListLabel.TabIndex = 2;
			this.m_userListLabel.Text = "사용자";
			// 
			// m_userListCombo
			// 
			this.m_userListCombo.DisplayMember = "Text";
			this.m_userListCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.m_userListCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_userListCombo.FormattingEnabled = true;
			this.m_userListCombo.ItemHeight = 19;
			this.m_userListCombo.Location = new System.Drawing.Point(96, 67);
			this.m_userListCombo.Name = "m_userListCombo";
			this.m_userListCombo.Size = new System.Drawing.Size(192, 25);
			this.m_userListCombo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_userListCombo.TabIndex = 3;
			this.m_userListCombo.SelectedIndexChanged += new System.EventHandler(this.OnUserListComboSelectedIndexChanged);
			// 
			// m_deleteUserButton
			// 
			this.m_deleteUserButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.m_deleteUserButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.m_deleteUserButton.Location = new System.Drawing.Point(296, 68);
			this.m_deleteUserButton.Name = "m_deleteUserButton";
			this.m_deleteUserButton.Size = new System.Drawing.Size(97, 23);
			this.m_deleteUserButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.m_deleteUserButton.TabIndex = 4;
			this.m_deleteUserButton.Text = "사용자 제거...";
			// 
			// AlterUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 492);
			this.Controls.Add(this.m_userListLabel);
			this.Controls.Add(this.m_userListCombo);
			this.Controls.Add(this.m_deleteUserButton);
			this.DoubleBuffered = true;
			this.Name = "AlterUserForm";
			this.Text = "사용자 수정하기";
			this.Controls.SetChildIndex(this.m_closeButton, 0);
			this.Controls.SetChildIndex(this.m_commitButton, 0);
			this.Controls.SetChildIndex(this.m_deselectAllButton, 0);
			this.Controls.SetChildIndex(this.m_selectAllButton, 0);
			this.Controls.SetChildIndex(this.m_deleteUserButton, 0);
			this.Controls.SetChildIndex(this.m_userListCombo, 0);
			this.Controls.SetChildIndex(this.m_userListLabel, 0);
			this.Controls.SetChildIndex(this.m_titleImgLabel, 0);
			this.Controls.SetChildIndex(this.m_titleLabel, 0);
			this.Controls.SetChildIndex(this.m_usernameLabel, 0);
			this.Controls.SetChildIndex(this.m_usernameText, 0);
			this.Controls.SetChildIndex(this.m_hostLabel, 0);
			this.Controls.SetChildIndex(this.m_hostText, 0);
			this.Controls.SetChildIndex(this.m_PasswordLabel, 0);
			this.Controls.SetChildIndex(this.m_PasswordText1, 0);
			this.Controls.SetChildIndex(this.m_retypePasswordLabel, 0);
			this.Controls.SetChildIndex(this.m_PasswordText2, 0);
			this.Controls.SetChildIndex(this.m_allVersionGroupBox, 0);
			this.Controls.SetChildIndex(this.m_402VersionGroupBox, 0);
			this.Controls.SetChildIndex(this.m_500VersionGroupBox, 0);
			this.Controls.SetChildIndex(this.m_510VersionGroupBox, 0);
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

		private DevComponents.DotNetBar.LabelX m_userListLabel;
		private DevComponents.DotNetBar.Controls.ComboBoxEx m_userListCombo;
		private DevComponents.DotNetBar.ButtonX m_deleteUserButton;
	}
}