
// UserForm.cs
//
using Easy2.Properties;
using System;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace Easy2
{
	public partial class UserBaseForm : BaseForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public UserBaseForm()
		{
			InitializeComponent();
		}

		private void OnTextChanged(object sender, EventArgs e)
		{
			this.m_commitButton.Enabled =
				(this.m_usernameText.TextLength != 0) && (this.m_hostText.TextLength != 0) ? true : false;
		}

		/// <summary>
		/// 닫기 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnCloseButtonClick(object sender, EventArgs e)
		{
			this.Dispose(true);
		}

		/// <summary>
		/// 모두선택 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnSelectAllButtonClick(object sender, System.EventArgs e)
		{
			this.SelectCheckBox(true);
		}

		/// <summary>
		/// 선택해제 버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnDeselectAllButtonClick(object sender, System.EventArgs e)
		{
			this.SelectCheckBox(false);
		}

		/// <summary>
		/// 체크박스 상태를 조정 합니다.
		/// </summary>
		/// <param name="b">true면 체크, false면 언체크</param>
		private void SelectCheckBox(bool b)
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

		/// <summary>
		/// 확인버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected virtual void OnCommitButtonClick(object sender, EventArgs e)
		{
			if(
				this.m_PasswordText1.TextLength != 0 && this.m_PasswordText2.TextLength != 0 &&
				(this.m_PasswordText1.Text.CompareTo(this.m_PasswordText2.Text) != 0)
				)
			{
				MessageBox.Show(
					this, Resources.Easy2Message_DoNotMatchPassword,
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

				this.m_PasswordText1.Focus();
				return;
			}

			if((this.m_PasswordText1.TextLength == 0 || this.m_PasswordText2.TextLength == 0) &&
				this.m_PasswordText1.TextLength != this.m_PasswordText2.TextLength)
			{
				if(this.m_PasswordText1.TextLength == 0)
				{
					MessageBox.Show(
					this, String.Format(
						Resources.Easy2Message_EmptyItem,
						this.m_PasswordLabel.Text.Substring(0, this.m_PasswordLabel.Text.Length - 4)),
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.m_PasswordText1.Focus();
				}
				else
				{
					MessageBox.Show(
					this, String.Format(
						Resources.Easy2Message_EmptyItem,
						this.m_retypePasswordLabel.Text.Substring(0, this.m_retypePasswordLabel.Text.Length - 4)),
					Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.m_PasswordText2.Focus();
				}
				return;
			}

			UpdateData(true);
		}

		/// <summary>
		/// 컨트롤에 값을 쓰거나 읽어옵니다.
		/// </summary>
		/// <param name="b">true이면 컨트롤에서 데이터를 읽어오고, false이면 컨트롤에 데이터를 씁니다.</param>
		protected void UpdateData(bool b)
		{
			if(b)
			{
				this.m_userInfo.Username = this.m_usernameText.Text;
				this.m_userInfo.Host = this.m_hostText.Text;
				this.m_userInfo.Password = this.m_PasswordText1.Text;

				// All version
				this.m_userInfo.Select = this.m_select.Checked;
				this.m_userInfo.Insert = this.m_insert.Checked;
				this.m_userInfo.Update = this.m_update.Checked;
				this.m_userInfo.Delete = this.m_delete.Checked;
				this.m_userInfo.Create = this.m_create.Checked;
				this.m_userInfo.Drop = this.m_drop.Checked;
				this.m_userInfo.Reload = this.m_reload.Checked;
				this.m_userInfo.Shutdown = this.m_shutdown.Checked;
				this.m_userInfo.Process = this.m_process.Checked;
				this.m_userInfo.File = this.m_file.Checked;
				this.m_userInfo.Reference = this.m_reference.Checked;
				this.m_userInfo.Index = this.m_index.Checked;
				this.m_userInfo.Alter = this.m_alter.Checked;
				this.m_userInfo.Grant = this.m_grant.Checked;

				// 402 version
				this.m_userInfo.Execute = this.m_execute.Checked;
				this.m_userInfo.Repl_slave = this.m_repl_slave.Checked;
				this.m_userInfo.Show_db = this.m_show_db.Checked;
				this.m_userInfo.Repl_client = this.m_repl_client.Checked;
				this.m_userInfo.Super = this.m_super.Checked;
				this.m_userInfo.Lock_tables = this.m_lock_tables.Checked;
				this.m_userInfo.Create_tmp_tables = this.m_create_tmp_tables.Checked;

				// 500 version
				this.m_userInfo.Create_view = this.m_create_view.Checked;
				this.m_userInfo.Create_routine = this.m_create_routine.Checked;
				this.m_userInfo.Show_view = this.m_show_view.Checked;
				this.m_userInfo.Alter_routine = this.m_alter_routine.Checked;
				this.m_userInfo.Create_user = this.m_create_user.Checked;

				// 510 version
				this.m_userInfo.Trigger = this.m_trigger.Checked;
				this.m_userInfo.Event = this.m_event.Checked;
			}
			else
			{
				this.m_usernameText.Text = this.m_userInfo.Username;
				this.m_hostText.Text = this.m_userInfo.Host;
				this.m_PasswordText1.Text = this.m_userInfo.Password;
				this.m_PasswordText2.Text = this.m_userInfo.Password;

				// All version
				this.m_select.Checked = this.m_userInfo.Select;
				this.m_insert.Checked = this.m_userInfo.Insert;
				this.m_update.Checked = this.m_userInfo.Update;
				this.m_delete.Checked = this.m_userInfo.Delete;
				this.m_create.Checked = this.m_userInfo.Create;
				this.m_drop.Checked = this.m_userInfo.Drop;
				this.m_reload.Checked = this.m_userInfo.Reload;
				this.m_shutdown.Checked = this.m_userInfo.Shutdown;
				this.m_process.Checked = this.m_userInfo.Process;
				this.m_file.Checked = this.m_userInfo.File;
				this.m_reference.Checked = this.m_userInfo.Reference;
				this.m_index.Checked = this.m_userInfo.Index;
				this.m_alter.Checked = this.m_userInfo.Alter;
				this.m_grant.Checked = this.m_userInfo.Grant;

				// 402 version
				this.m_execute.Checked = this.m_userInfo.Execute;
				this.m_repl_slave.Checked = this.m_userInfo.Repl_slave;
				this.m_show_db.Checked = this.m_userInfo.Show_db;
				this.m_repl_client.Checked = this.m_userInfo.Repl_client;
				this.m_super.Checked = this.m_userInfo.Super;
				this.m_lock_tables.Checked = this.m_userInfo.Lock_tables;
				this.m_create_tmp_tables.Checked = this.m_userInfo.Create_tmp_tables;

				// 500 version
				this.m_create_view.Checked = this.m_userInfo.Create_view;
				this.m_create_routine.Checked = this.m_userInfo.Create_routine;
				this.m_show_view.Checked = this.m_userInfo.Show_view;
				this.m_alter_routine.Checked = this.m_userInfo.Alter_routine;
				this.m_create_user.Checked = this.m_userInfo.Create_user;

				// 510 version
				this.m_trigger.Checked = this.m_userInfo.Trigger;
				this.m_event.Checked = this.m_userInfo.Event;
			}
		}

		/// <summary>
		/// 사용자정보를 나타냅니다.
		/// </summary>
		protected User UserInfo
		{
			get { return this.m_userInfo; }
			set { this.m_userInfo = value; }
		}

		private User m_userInfo = new User();
	}
}
