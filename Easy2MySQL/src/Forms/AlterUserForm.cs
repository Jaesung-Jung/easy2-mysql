
// AlterUserForm.cs
//
using Easy2.Properties;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DevComponents.Editors;

namespace Easy2
{
	/// <summary>
	/// AlterUserForm 클래스입니다.
	/// </summary>
	public partial class AlterUserForm : UserBaseForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public AlterUserForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// OnShown 재정의입니다.
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

			this.m_commitButton.Enabled = false;

			if(this.LoadUserList() > 0)
			{
				this.m_userListCombo.SelectedIndex = 0;
				this.m_userListCombo.Focus();
			}
		}

		/// <summary>
		/// 사용자리스트를 불러옵니다.
		/// </summary>
		/// <returns>읽어진 필드의 갯수 입니다.</returns>
		private int LoadUserList()
		{
			MySqlDataReader reader = null;
			int fieldCount = 0;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.SelectMysqlUser());
				fieldCount = reader.FieldCount;

				while(reader.Read())
				{
					this.m_userListCombo.Items.Add(
						new ComboItem(String.Format("{0}@{1}", reader.GetString(0), reader.GetString(1)))
						);
				}

				reader.Close();
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
				this.Dispose(true);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}

			return fieldCount;
		}

		/// <summary>
		/// 사용자리스트 콤보박스 아이템인덱스가 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_userListCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			MySqlDataReader reader = null;
			try
			{
				string username = this.m_userListCombo.SelectedItem.ToString().Split('@')[0];
				string host = this.m_userListCombo.SelectedItem.ToString().Split('@')[1];

				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.SelectMysqlUser(username, host));

				while(reader.Read())
				{
					this.UserInfo.Host = reader.GetString(0);
					this.UserInfo.Username = reader.GetString(1);
					this.UserInfo.Password = "     ";
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
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
				this.Dispose(true);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}
	}
}
