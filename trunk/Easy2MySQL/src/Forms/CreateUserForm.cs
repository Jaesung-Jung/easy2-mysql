
// CreateUserForm.cs
//
using Easy2.Classes;
using Easy2.Properties;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;

namespace Easy2.Forms
{
	/// <summary>
	/// 사용자를 생성하기 위한 폼 클래스입니다.
	/// </summary>
	public partial class CreateUserForm : UserBaseForm
	{
		/// <summary>
		/// CreateUserForm 인스턴스를 초기화합니다.
		/// </summary>
		public CreateUserForm()
		{
			InitializeComponent();
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

			this.m_usernameText.Focus();
		}

		/// <summary>
		/// 확인버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, EventArgs e)
		{
			base.OnCommitButtonClick(sender, e);

			if(this.DataEffectiveness)
			{
				try
				{
					Program.ActivateCommunicator.CreateUser(this.UserInfo);
					MessageBoxEx.Show(
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
