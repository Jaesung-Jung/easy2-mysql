
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

			// 파일에서 연결정보 읽어오기
			try
			{
				FileStream fs = new FileStream(Properties.Resources.ConnectionDataFilePath, FileMode.Open, FileAccess.Read);
				StreamReader sr = new StreamReader(fs);
				string info;
				while((info = sr.ReadLine()) != null)
				{
					string[] connection = info.Split(';');

					MySqlConnectInfo connectInfo = new MySqlConnectInfo();

					connectInfo.ConnectName = connection[0];
					connectInfo.Host = connection[1];
					connectInfo.Username = connection[2];
					connectInfo.Password = connection[3];
					connectInfo.Port = Int32.Parse(connection[4]);
					connectInfo.Database = connection[5];
					connectInfo.ConnectTimeout = Int32.Parse(connection[6]);

					this.m_connectionList.Add(connectInfo);
					this.m_connectionListCombo.Items.Add(connectInfo.ConnectName);
				}
				sr.Close();
				if(this.m_connectionListCombo.Items.Count > 0)
					this.m_connectionListCombo.SelectedIndex = 0;
			}
			catch(Exception ex)
			{
				EasyToMySqlError.Show(this, ex.Message, "파일을 읽는 중 오류가 발생하였습니다.");
			}
		}

		/// <summary>
		/// 각 컨트롤에 입력된 값을 객체에 저장합니다. 
		/// </summary>
		/// <param name="flag">true일 경우 컨트롤->데이터 false일 경우 데이터->컨트롤로 저장합니다.</param>
		private void UpdateData(bool flag)
		{
			if(flag)
			{
				this.m_connectInfo.Host = this.m_mysqlHostText.Text;
				this.m_connectInfo.Port = Int32.Parse(this.m_mysqlPortText.Text);
				this.m_connectInfo.Username = this.m_mysqlUserText.Text;
				this.m_connectInfo.Password = this.m_mysqlPasswordText.Text;
				this.m_connectInfo.Database = this.m_mysqlDatabaseText.Text;
				this.m_connectInfo.ConnectTimeout = Int32.Parse(this.m_mysqlTimeoutText.Text);
			}
			else
			{
				this.m_mysqlHostText.Text = this.m_connectInfo.Host;
				this.m_mysqlPortText.Text = this.m_connectInfo.Port.ToString();
				this.m_mysqlUserText.Text = this.m_connectInfo.Username;
				this.m_mysqlPasswordText.Text = this.m_connectInfo.Password;
				this.m_mysqlDatabaseText.Text = this.m_connectInfo.Database;
				this.m_mysqlTimeoutText.Text = this.m_connectInfo.ConnectTimeout.ToString();
				this.m_savePasswordCheck.Checked = this.m_mysqlPasswordText.TextLength != 0 ? true : false;
			}
		}

		/// <summary>
		/// 연결하기 버튼을 클릭했을 때 발생합니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_connect_Click(object sender, System.EventArgs e)
		{
			UpdateData(true);

			try
			{
				Program.MySqlConnector = new MySqlCommunicator();
				Program.MySqlConnector.Connect(this.m_connectInfo);
				if(Program.CoummunicatorList.Count == 1)	// 신규연결
					this.DialogResult = DialogResult.OK;

				else	// 추가연결
					this.DialogResult = DialogResult.No;

				this.Dispose(true);
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Properties.Resources.MySqlConnectFail, ex.Number);
			}
		}

		/// <summary>
		/// 연결테스트 버튼을 클릭했을 때 발생합니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_connectTest_Click(object sender, EventArgs e)
		{
			UpdateData(true);

			try
			{
				MySqlCommunicator connector = new MySqlCommunicator();

				string message =
					Properties.Resources.MySqlConnectSuccess + "\n" + connector.ConnectTest(this.m_connectInfo);
				MessageBox.Show(this, message, "Connect Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Properties.Resources.MySqlConnectFail, ex.Number);
			}
		}

		/// <summary>
		/// 취소 버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Dispose(true);
		}

		/// <summary>
		/// 저장된 연결콤보 인덱스가 변경될 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_savedConnectionList_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_connectInfo = this.m_connectionList[this.m_connectionListCombo.SelectedIndex];
			this.UpdateData(false);
		}

		/// <summary>
		/// 새 연결 버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_newConnection_Click(object sender, EventArgs e)
		{
			MySqlConnectInfo currentInfo = this.m_connectInfo;
			this.m_connectInfo = new MySqlConnectInfo();
			DialogResult dlgResult = new NewConnectForm(this).ShowDialog(this);
			if(dlgResult == DialogResult.OK)
			{
				this.m_connectionList.Add(this.m_connectInfo);
				this.m_connectionListCombo.Items.Add(this.m_connectInfo.ConnectName);
				this.m_connectionListCombo.SelectedIndex = this.m_connectionListCombo.Items.Count - 1;
			}
		}

		/// <summary>
		/// 저장하기 버튼을 클릭했을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트 정보를 가진 객체입니다.</param>
		private void m_saveConnection_Click(object sender, EventArgs e)
		{
			UpdateData(true);
			FileStream fs = new FileStream(Properties.Resources.ConnectionDataFilePath, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs);
			string dataLine;
			foreach(MySqlConnectInfo info in this.m_connectionList)
			{
				dataLine = info.ConnectName + ";" + info.Host + ";" + info.Username + ";";
				if(this.m_savePasswordCheck.Checked)
					dataLine += info.Password;
				dataLine += ";" + info.Port.ToString() + ";" + info.Database + ";" + info.ConnectTimeout + ";";

				System.Console.WriteLine(dataLine);

				sw.WriteLine(dataLine);
			}
			sw.Close();
		}

		/// <summary>
		/// 연결정보 클래스를 나타냅니다.
		/// </summary>
		public MySqlConnectInfo ConnectInfo
		{
			get { return this.m_connectInfo; }
		}

		private MySqlConnectInfo m_connectInfo = new MySqlConnectInfo();
		private List<MySqlConnectInfo> m_connectionList = new List<MySqlConnectInfo>();
	}
}
