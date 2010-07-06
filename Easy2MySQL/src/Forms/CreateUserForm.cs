
// CreateUserForm.cs
//
using Easy2.Properties;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
		}

		/// <summary>
		/// 확인버튼을 눌렀을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, EventArgs e)
		{
			base.OnCommitButtonClick(sender, e);
			if(this.RunNetxJob)
			{
				try
				{
					Program.ActivateCommunicator.CreateUser(this.UserInfo);
					MessageBox.Show(
						this,
						String.Format(Resources.Easy2Message_UserCreatedSuccessfully, this.UserInfo.Username),
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
		}
	}
}
