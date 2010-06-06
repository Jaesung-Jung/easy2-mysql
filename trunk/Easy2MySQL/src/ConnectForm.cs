
// ConnectForm.cs
//
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;

namespace Easy2
{
	/// <summary>
	/// 연결폼 클래스입니다.
	/// </summary>
	public partial class ConnectForm : BaseForm
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public ConnectForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 폼이 로드될때 발생합니다.
		/// </summary>
		/// <param name="e">이벤트 객체입니다.</param>
		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);

			this.m_tabControl.ColorScheme.TabBackground = this.BackColor;
			this.m_tabControl.ColorScheme.TabBackground2 = this.BackColor;

			InitializeTabPanelBackColor();
			InitializeLabelBackColor();
		}

		/// <summary>
		/// 탭 패널의 배경색을 초기화합니다.
		/// </summary>
		private void InitializeTabPanelBackColor()
		{
			this.m_mysqlTabPanel.Style.BackColor1.Color = this.BackColor;
			this.m_mysqlTabPanel.Style.BackColor2.Color = this.BackColor;
			this.m_httpTabPanel.Style.BackColor1.Color = this.BackColor;
			this.m_httpTabPanel.Style.BackColor2.Color = this.BackColor;
			this.m_sshTabPanel.Style.BackColor1.Color = this.BackColor;
			this.m_sshTabPanel.Style.BackColor2.Color = this.BackColor;
			this.m_sslTabPanel.Style.BackColor1.Color = this.BackColor;
			this.m_sslTabPanel.Style.BackColor2.Color = this.BackColor;
		}

		/// <summary>
		/// 레이블들의 배경색을 초기화합니다.
		/// </summary>
		private void InitializeLabelBackColor()
		{
			this.m_mysqlHostLabel.BackColor = this.BackColor;
			this.m_mysqlUserLabel.BackColor = this.BackColor;
			this.m_mysqlPasswordLabel.BackColor = this.BackColor;
			this.m_mysqlPortLabel.BackColor = this.BackColor;
			this.m_mysqlDatabaseLabel.BackColor = this.BackColor;
			this.m_savePasswordCheck.BackColor = this.BackColor;
			this.m_mysqlTimeoutLabel.BackColor = this.BackColor;
			this.m_secondLabel.BackColor = this.BackColor;
		}

		#region 이벤트

		/// <summary>
		/// 연결하기 버튼을 클릭했을 때 발생합니다.
		/// </summary>
		/// <param name="sender">이벤트를 호출한 객체입니다.</param>
		/// <param name="e">이벤트 아규먼트 객체입니다.</param>
		private void m_connect_Click(object sender, System.EventArgs e)
		{
			MySqlConnectInfo connectInfo = new MySqlConnectInfo();
			UpdateData(connectInfo);

			try
			{
				Program.MySqlCommunicatorHandle.Connect(connectInfo);
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Properties.Resources.MySqlConnectFail, ex.Number);
			}
//			this.Close();
		}

		/// <summary>
		/// 연결테스트 버튼을 클릭했을 때 발생합니다.
		/// </summary>
		/// <param name="sender">이벤트를 호출한 객체입니다.</param>
		/// <param name="e">이벤트 아규먼트 객체입니다.</param>
		private void m_connectTest_Click(object sender, EventArgs e)
		{
			MySqlConnectInfo connectInfo = new MySqlConnectInfo();
			UpdateData(connectInfo);

			try
			{
				string message =
					Properties.Resources.MySqlConnectSuccess + "\n" + Program.MySqlCommunicatorHandle.ConnectTest(connectInfo);
				MessageBox.Show(this, message, "Connect Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Properties.Resources.MySqlConnectFail, ex.Number);
			}
		}

		/// <summary>
		/// 취소 버튼을 클릭했을 때 발생합니다.
		/// </summary>
		/// <param name="sender">이벤트를 호출한 객체입니다.</param>
		/// <param name="e">이벤트 아규먼트 객체입니다.</param>
		private void m_cancel_Click(object sender, EventArgs e)
		{
			this.Dispose(true);
		}

		#endregion

		/// <summary>
		/// 각 컨트롤에 입력된 값을 객체에 저장합니다. 
		/// </summary>
		/// <param name="connectInfo">값을 저장할 객체입니다.</param>
		private void UpdateData(MySqlConnectInfo connectInfo)
		{
			connectInfo.Host = this.m_mysqlHostText.Text;
			connectInfo.Port = Int32.Parse(this.m_mysqlPortText.Text);
			connectInfo.Username = this.m_mysqlUserText.Text;
			connectInfo.Password = this.m_mysqlPasswordText.Text;
			connectInfo.Database = this.m_mysqlDatabaseText.Text;
			connectInfo.ConnectTimeout = Int32.Parse(this.m_mysqlTimeoutText.Text);
		}
	}
}
