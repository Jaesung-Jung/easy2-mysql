
// AlterUserForm.cs
//
using Easy2.Classes;
using Easy2.Properties;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;
using DevComponents.Editors;

namespace Easy2.Forms
{
	/// <summary>
	/// 사용자를 수정을 위한 폼입니다.
	/// </summary>
	public partial class AlterUserForm : UserBaseForm
	{
		/// <summary>
		/// AlterUserForm 인스턴스를 초기화합니다.
		/// </summary>
		public AlterUserForm()
		{
			InitializeComponent();
			InitializeChangedEvent();
		}

		/// <summary>
		/// 컨트롤러의 이벤트를 초기화합니다.
		/// </summary>
		public void InitializeChangedEvent()
		{
			this.m_usernameText.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_hostText.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_PasswordText1.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_PasswordText2.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_select.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_insert.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_update.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_delete.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_create.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_drop.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_shutdown.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_process.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_file.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_reference.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_index.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_alter.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_grant.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_execute.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_repl_slave.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_show_db.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_repl_client.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_super.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_lock_tables.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_create_tmp_tables.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_create_view.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_create_routine.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_show_view.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_alter_routine.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_create_view.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_trigger.CheckedChanged += new EventHandler(this.OnDataChanged);
			this.m_event.CheckedChanged += new EventHandler(this.OnDataChanged);
		}

		/// <summary>
		/// 데이터가 변화되었을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDataChanged(object sender, EventArgs e)
		{
			if(this.m_commitButton.Enabled == false)
				this.m_commitButton.Enabled = true;
		}
		
		/// <summary>
		/// 폼이 보여질 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			if(Program.ActivateCommunicator.v402 == false)
				this.m_402VersionGroupBox.Enabled = false;
			if(Program.ActivateCommunicator.v500 == false)
				this.m_500VersionGroupBox.Enabled = false;
			if(Program.ActivateCommunicator.v510 == false)
				this.m_510VersionGroupBox.Enabled = false;


			this.m_userListCombo.Items.AddRange(this.ReadUsers());
			if(m_userListCombo.Items.Count > 0)
				this.m_userListCombo.SelectedIndex = 0;
			this.m_userListCombo.Focus();
		}

		/// <summary>
		/// 사용자리스트를 데이터베이스로부터 읽어옵니다.
		/// </summary>
		/// <returns>'사용자명@호스트명'의 문자열 배열입니다.</returns>
		private string[] ReadUsers()
		{
			MySqlDataReader reader = null;
			List<string> userList = new List<string>(); 

			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.SelectMysqlUser()
					);

				while(reader.Read())
				{
					userList.Add(String.Format(
						"{0}@{1}",
						reader["User"].ToString(),
						reader["Host"].ToString()
						));
				}

				reader.Close();
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}

			return userList.ToArray();
		}

		/// <summary>
		/// 사용자리스트 콤보박스 아이템인덱스가 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void OnUserListComboSelectedIndexChanged(object sender, EventArgs e)
		{
			MySqlDataReader reader = null;
			try
			{
				string username = this.m_userListCombo.SelectedItem.ToString().Split('@')[0];
				string host = this.m_userListCombo.SelectedItem.ToString().Split('@')[1];

				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.SelectMysqlUser(username, host)
					);

				while(reader.Read())
				{
					this.UserInfo.Host = reader["Host"].ToString();
					this.UserInfo.Username = reader["User"].ToString();
					this.UserInfo.Password = "\n\n\n\n";
					this.UserInfo.Select = reader.GetChar(3) == 'Y' ? true : false;
					this.UserInfo.Insert = reader.GetChar(4) == 'Y' ? true : false;
					this.UserInfo.Update = reader.GetChar(5) == 'Y' ? true : false;
					this.UserInfo.Delete = reader.GetChar(6) == 'Y' ? true : false;
					this.UserInfo.Create = reader.GetChar(7) == 'Y' ? true : false;
					this.UserInfo.Drop = reader.GetChar(8) == 'Y' ? true : false;
					this.UserInfo.Reload = reader.GetChar(9) == 'Y' ? true : false;
					this.UserInfo.Shutdown = reader.GetChar(10) == 'Y' ? true : false;
					this.UserInfo.Process = reader.GetChar(11) == 'Y' ? true : false;
					this.UserInfo.File = reader.GetChar(12) == 'Y' ? true : false;
					this.UserInfo.Grant = reader.GetChar(13) == 'Y' ? true : false;
					this.UserInfo.Reference = reader.GetChar(14) == 'Y' ? true : false;
					this.UserInfo.Index = reader.GetChar(15) == 'Y' ? true : false;
					this.UserInfo.Alter = reader.GetChar(16) == 'Y' ? true : false;
					this.UserInfo.Show_db = reader.GetChar(17) == 'Y' ? true : false;
					this.UserInfo.Super = reader.GetChar(18) == 'Y' ? true : false;
					this.UserInfo.Create_tmp_tables = reader.GetChar(19) == 'Y' ? true : false;
					this.UserInfo.Lock_tables = reader.GetChar(20) == 'Y' ? true : false;
					this.UserInfo.Execute = reader.GetChar(21) == 'Y' ? true : false;
					this.UserInfo.Repl_slave = reader.GetChar(22) == 'Y' ? true : false;
					this.UserInfo.Repl_client = reader.GetChar(23) == 'Y' ? true : false;
					this.UserInfo.Create_view = reader.GetChar(24) == 'Y' ? true : false;
					this.UserInfo.Show_view = reader.GetChar(25) == 'Y' ? true : false;
					this.UserInfo.Create_routine = reader.GetChar(26) == 'Y' ? true : false;
					this.UserInfo.Alter_routine = reader.GetChar(27) == 'Y' ? true : false;
					this.UserInfo.Create_user = reader.GetChar(28) == 'Y' ? true : false;
					this.UserInfo.Event = reader.GetChar(29) == 'Y' ? true : false;
					this.UserInfo.Trigger = reader.GetChar(30) == 'Y' ? true : false;
				}
				UpdateData(false);
				this.m_commitButton.Enabled = false;
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		/// <summary>
		/// 확인 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, EventArgs e)
		{
			string targetUsername = this.UserInfo.Username;
			string targetHost = this.UserInfo.Host;

			base.OnCommitButtonClick(sender, e);

			if(this.DataEffectiveness)
			{
				try
				{
					Program.ActivateCommunicator.AlterUser(targetUsername, targetHost, this.UserInfo);
					MessageBoxEx.Show(
						this,
						String.Format(Resources.Easy2Message_UserAlterSuccessfully, this.UserInfo.Username),
						Resources.Easy2Message_Title,
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
						);
				}
				catch(MySqlException ex)
				{
					EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
				}
			}
		}

		/// <summary>
		/// 사용자 제거 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDeleteUserButtonClick(object sender, EventArgs e)
		{
			if(MessageBoxEx.Show(
				this,
				String.Format(Resources.Easy2Message_UserDeleteQuestion, this.m_userListCombo.SelectedItem.ToString()),
				Resources.Easy2Message_Title,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string targetUsername = this.UserInfo.Username;
				string targetHost = this.UserInfo.Host;

				try
				{
					Program.ActivateCommunicator.DeleteUser(targetUsername, targetHost);

					int selectedIndex = this.m_userListCombo.SelectedIndex;
					this.m_userListCombo.Items.Remove(this.m_userListCombo.SelectedItem);
					if(selectedIndex > 0)
						this.m_userListCombo.SelectedIndex = selectedIndex - 1;
					else if(selectedIndex == 0 && this.m_userListCombo.Items.Count > 0)
						this.m_userListCombo.SelectedIndex = 0;
					else
						this.m_userListCombo.SelectedIndex = -1;
				}
				catch(MySqlException ex)
				{
					EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
				}
			}
		}
	}
}
