
// ConnectForm.cs
//
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
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

		/// <summary>
		/// OnLoad 재정의입니다.
		/// </summary>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);

			this.m_tabControl.ColorScheme.TabBackground = this.BackColor;
			this.m_tabControl.ColorScheme.TabBackground2 = this.BackColor;
			InitializeTabPanelBackColor();
			InitializeLabelBackColor();
		}
	}
}
