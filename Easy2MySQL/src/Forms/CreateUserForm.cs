
// CreateUserForm.cs
//
using Easy2.Properties;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar.Controls;

namespace Easy2
{
	public partial class CreateUserForm : UserBaseForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public CreateUserForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// OnLoad 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);
			if(Program.ActivateCommunicator.v402 == false)
				this.m_402VersionGroupBox.Enabled = false;
			if(Program.ActivateCommunicator.v500 == false)
				this.m_500VersionGroupBox.Enabled = false;
			if(Program.ActivateCommunicator.v510 == false)
				this.m_510VersionGroupBox.Enabled = false;
		}

		/// <summary>
		/// 만들기 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_createButton_Click(object sender, System.EventArgs e)
		{
			if(this.m_usernameText.Text.Trim().Length == 0)
			{
				MessageBox.Show(
					this, String.Format(Resources.Easy2Message_EmptyItem, m_usernameLabel.Text),
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

				this.m_usernameText.Focus();
				return;
			}

			if(this.m_hostText.Text.Trim().Length == 0)
			{
				MessageBox.Show(
					this, String.Format(Resources.Easy2Message_EmptyItem, m_hostLabel.Text),
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

				this.m_hostText.Focus();
				return;
			}

			if(this.m_PasswordText1.TextLength == 0)
			{
				MessageBox.Show(
					this, String.Format(Resources.Easy2Message_EmptyItem, m_PasswordLabel.Text),
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

				this.m_PasswordText1.Focus();
				return;
			}

			if(this.m_PasswordText2.TextLength == 0)
			{
				MessageBox.Show(
					this, String.Format(Resources.Easy2Message_EmptyItem, m_retypePasswordLabel.Text),
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

				this.m_PasswordText2.Focus();
				return;
			}

			if(this.m_PasswordText1.Text.CompareTo(this.m_PasswordText2.Text) != 0)
			{
				MessageBox.Show(
					this, Resources.Easy2Message_DoNotMatchPassword,
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

				this.m_PasswordText1.Focus();
				return;
			}

			User userInfo = new User();
			userInfo.Username = this.m_usernameText.Text;
			userInfo.Host = this.m_hostText.Text;
			userInfo.Password = this.m_PasswordText1.Text;

			// All version
			userInfo.Select = this.m_select.Checked;
			userInfo.Insert = this.m_insert.Checked;
			userInfo.Update = this.m_update.Checked;
			userInfo.Delete = this.m_delete.Checked;
			userInfo.Create = this.m_create.Checked;
			userInfo.Drop = this.m_drop.Checked;
			userInfo.Reload = this.m_reload.Checked;
			userInfo.Shutdown = this.m_shutdown.Checked;
			userInfo.Process = this.m_process.Checked;
			userInfo.File = this.m_file.Checked;
			userInfo.Reference = this.m_reference.Checked;
			userInfo.Index = this.m_index.Checked;
			userInfo.Alter = this.m_alter.Checked;
			userInfo.Grant = this.m_grant.Checked;

			// 402 version
			userInfo.Execute = this.m_execute.Checked;
			userInfo.Repl_slave = this.m_repl_slave.Checked;
			userInfo.Show_db = this.m_show_db.Checked;
			userInfo.Repl_client = this.m_repl_client.Checked;
			userInfo.Super = this.m_super.Checked;
			userInfo.Lock_tables = this.m_lock_tables.Checked;
			userInfo.Create_tmp_tables = this.m_create_tmp_tables.Checked;

			// 500 version
			userInfo.Create_view = this.m_create_view.Checked;
			userInfo.Create_routine = this.m_create_routine.Checked;
			userInfo.Show_view = this.m_show_view.Checked;
			userInfo.Alter_routine = this.m_alter_routine.Checked;
			userInfo.Create_user = this.m_create_user.Checked;

			// 510 version
			userInfo.Trigger = this.m_trigger.Checked;
			userInfo.Event = this.m_event.Checked;

			try
			{
				Program.ActivateCommunicator.CreateUser(userInfo);

				MessageBox.Show(
					this,
					String.Format(Resources.Easy2Message_UserCreatedSuccessfully, userInfo.Username),
					Resources.Easy2Message_Title,
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
					);

				this.Dispose(true);
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
		}

		/// <summary>
		/// 닫기 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void m_closeButton_Click(object sender, EventArgs e)
		{
			this.Dispose(true);
		}

		/// <summary>
		/// 모두선택 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void m_selectAllButton_Click(object sender, System.EventArgs e)
		{
			this.selectCheckBox(true);
		}

		/// <summary>
		/// 선택해제 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void m_deselectAllButton_Click(object sender, System.EventArgs e)
		{
			this.selectCheckBox(false);
		}

		/// <summary>
		/// 체크박스 상태를 조정 합니다.
		/// </summary>
		/// <param name="b">true면 체크, false면 언체크</param>
		private void selectCheckBox(bool b)
		{
			foreach(CheckBoxX check in this.m_allVersionGroupBox.Controls)
			{
				check.Checked = b;
			}

			if(Program.ActivateCommunicator.v402 == true)
			{
				foreach(CheckBoxX check in this.m_402VersionGroupBox.Controls)
				{
					check.Checked = b;
				}
			}

			if(Program.ActivateCommunicator.v500 == true)
			{
				foreach(CheckBoxX check in this.m_500VersionGroupBox.Controls)
				{
					check.Checked = b;
				}
			}

			if(Program.ActivateCommunicator.v510 == true)
			{
				foreach(CheckBoxX check in this.m_510VersionGroupBox.Controls)
				{
					check.Checked = b;
				}
			}
		}
	}
}
