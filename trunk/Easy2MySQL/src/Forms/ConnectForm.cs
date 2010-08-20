
// ConnectForm.cs
//
using Easy2.Classes;
using Easy2.Properties;
using System;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;

namespace Easy2.Forms
{
	/// <summary>
	/// 데이터베이스 연결을 위한 폼입니다.
	/// </summary>
	public partial class ConnectForm : BaseForm
	{
		/// <summary>
		/// ConnectForm 인스턴스를 초기화합니다.
		/// </summary>
		public ConnectForm()
		{
			InitializeComponent();
			InitializeChangedEvent();
		}

		/// <summary>
		/// 컨트롤러의 이벤트를 초기화합니다.
		/// </summary>
		public void InitializeChangedEvent()
		{
			this.m_mysqlHostText.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_mysqlUsernameText.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_mysqlPasswordText.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_mysqlPortText.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_mysqlDatabaseText.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_mysqlTimeoutText.TextChanged += new EventHandler(this.OnDataChanged);
			this.m_savePasswordCheck.CheckedChanged += new EventHandler(this.OnDataChanged);
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
		/// 콤보박스의 리스트를 초기화합니다.
		/// </summary>
		private void InitializeComboBoxList()
		{
			foreach(MySqlConnectInfo info in this.m_connectInfoList)
				this.m_connectionListCombo.Items.Add(info.ConnectName);

			if(this.m_connectionListCombo.Items.Count > 0)
			{
				this.m_connectionListCombo.SelectedIndex = 0;
				this.m_selectedInfo = this.m_connectInfoList[0];
				UpdateData(false);
			}
		}

		/// <summary>
		/// 데이터가 변화되었을 때 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDataChanged(object sender, EventArgs e)
		{
			if(this.m_saveConnection.Enabled == false)
				this.m_saveConnection.Enabled = true;
		}

		/// <summary>
		/// 폼이 열릴 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.m_connectionListCombo.SelectedIndexChanged += new EventHandler(this.OnConnectionListComboSelectedIndexChanged);
			this.m_tabControl.ColorScheme.TabBackground = this.BackColor;
			this.m_tabControl.ColorScheme.TabBackground2 = this.BackColor;
			this.m_saveConnection.Enabled = false;
			this.m_connect.Enabled = false;
			this.m_connectTest.Enabled = false;
			this.m_renameConnection.Enabled = false;
			this.m_deleteConnection.Enabled = false;

			InitializeTabPanelBackColor();
			InitializeLabelBackColor();
			ReadConnectInfo();
			InitializeComboBoxList();

			Program.MySqlConnector = new MySqlCommunicator(); // 연결을 담당하는 객체생성
		}

		/// <summary>
		/// 폼이 닫힐 때 호출됩니다.
		/// </summary>
		/// <param name="e"></param>
		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			if(Program.MySqlConnector != null)
				Program.MySqlConnector = null;
			this.Dispose();
		}

		/// <summary>
		/// 콤보리스트의 선택인덱스가 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		void OnConnectionListComboSelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int selectedIndex = this.m_connectionListCombo.SelectedIndex;
				this.m_selectedInfo = this.m_connectInfoList[selectedIndex];
				UpdateData(false);
				this.m_saveConnection.Enabled = false;
				this.m_connect.Enabled = true;
				this.m_connectTest.Enabled = true;
				this.m_renameConnection.Enabled = true;
				this.m_deleteConnection.Enabled = true;
			}
			catch(Exception ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception);
			}
		}

		/// <summary>
		/// 컨트롤에 값을 쓰거나 읽어옵니다.
		/// </summary>
		/// <param name="b">true이면 컨트롤에서 데이터를 읽어오고, false이면 컨트롤에 데이터를 씁니다.</param>
		void UpdateData(bool b)
		{
			if(b)
			{
				this.m_selectedInfo.Host = this.m_mysqlHostText.Text;
				this.m_selectedInfo.Username = this.m_mysqlUsernameText.Text;
				this.m_selectedInfo.Password = this.m_mysqlPasswordText.Text;
				this.m_selectedInfo.Port = this.m_mysqlPortText.Text;
				this.m_selectedInfo.Database = this.m_mysqlDatabaseText.Text;
				this.m_selectedInfo.ConnectTimeout = this.m_mysqlTimeoutText.Text;
			}
			else
			{
				this.m_mysqlHostText.Text = this.m_selectedInfo.Host;
				this.m_mysqlUsernameText.Text = this.m_selectedInfo.Username;
				this.m_mysqlPasswordText.Text = this.m_selectedInfo.Password;
				this.m_mysqlPortText.Text = this.m_selectedInfo.Port;
				this.m_mysqlDatabaseText.Text = this.m_selectedInfo.Database;
				this.m_mysqlTimeoutText.Text = this.m_selectedInfo.ConnectTimeout;
				this.m_savePasswordCheck.Checked = this.m_selectedInfo.Password.Length != 0 ? true : false;
			}
		}

		/// <summary>
		/// 파일에 저장된 연결정보를 읽어옵니다.
		/// </summary>
		private void ReadConnectInfo()
		{
			FileStream fs = null;
			StreamReader sr = null;
			try
			{
				fs = new FileStream(
					Resources.FilePath_ConnectionData,
					FileMode.Open,
					FileAccess.Read
					);
				sr = new StreamReader(fs);
				
				string line;
				while((line = sr.ReadLine()) != null)
				{
					string[] splitLine = line.Split(';');

					// ConnectName, Host, Username, Password, Port, Database, Timeout
					MySqlConnectInfo connectInfo = new MySqlConnectInfo(
						splitLine[0],
						splitLine[1],
						splitLine[2],
						splitLine[3],
						splitLine[4],
						splitLine[5],
						splitLine[6]
						);
					this.m_connectInfoList.Add(connectInfo);
				}

				sr.Close();
				fs.Close();
			}
 			catch(Exception ex)
 			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_FileRead);
 			}
			finally
			{
				if(sr != null)
					sr.Close();
				if(fs != null)
					fs.Close();
			}
		}

		/// <summary>
		/// 파일에 연결정보를 저장합니다.
		/// </summary>
		private void WriteConnectInfo()
		{
			FileStream fs = null;
			StreamWriter sw = null;
			try
			{
				fs = new FileStream(
					Resources.FilePath_ConnectionData,
					FileMode.Open,
					FileAccess.Write
					);
				sw = new StreamWriter(fs);

				string line;
				UpdateData(true);
				for(int i = 0; i < this.m_connectInfoList.Count; i++)
				{
					if((this.m_connectionListCombo.SelectedIndex == i &&
						this.m_savePasswordCheck.Checked) ||
						(this.m_connectionListCombo.SelectedIndex != i))
					{
						line = String.Format("{0};{1};{2};{3};{4};{5};{6};",
							this.m_connectInfoList[i].ConnectName,
							this.m_connectInfoList[i].Host,
							this.m_connectInfoList[i].Username,
							this.m_connectInfoList[i].Password,
							this.m_connectInfoList[i].Port,
							this.m_connectInfoList[i].Database,
							this.m_connectInfoList[i].ConnectTimeout);
					}
					else
					{
						line = String.Format("{0};{1};{2};;{3};{4};{5};",
							this.m_connectInfoList[i].ConnectName,
							this.m_connectInfoList[i].Host,
							this.m_connectInfoList[i].Username,
							this.m_connectInfoList[i].Port,
							this.m_connectInfoList[i].Database,
							this.m_connectInfoList[i].ConnectTimeout);
					}
					sw.WriteLine(line);
				}

				sw.Close();
				fs.Close();

			}
			catch(Exception ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_FileWrite);
			}
			finally
			{
				if(sw != null)
					sw.Close();
				if(fs != null)
					fs.Close();
			}
		}

		/// <summary>
		/// 새 연결 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnNewConnectionClick(object sender, EventArgs e)
		{
			NewConnectForm frm = new NewConnectForm();
			DialogResult result = frm.ShowDialog(this);
			if(result == DialogResult.OK)
			{
				MySqlConnectInfo info = new MySqlConnectInfo(frm.ConnectionName);
				this.m_connectInfoList.Add(info);
				this.m_connectionListCombo.Items.Add(frm.ConnectionName);
				this.m_connectionListCombo.SelectedIndex = this.m_connectionListCombo.Items.Count - 1;
				this.OnDataChanged(null, null);
			}
		}

		/// <summary>
		/// 저장 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnSaveConnectionClick(object sender, EventArgs e)
		{
			UpdateData(true);
			if(this.m_savePasswordCheck.Checked)
				this.m_selectedInfo.Password = "";
			WriteConnectInfo();
			this.m_saveConnection.Enabled = false;
		}

		/// <summary>
		/// 바꾸기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnRenameConnectionClick(object sender, EventArgs e)
		{
			RenameConnectForm frm = new RenameConnectForm(
				this.m_connectionListCombo.SelectedItem.ToString()
				);
			DialogResult result = frm.ShowDialog(this);
			if(result == DialogResult.OK)
			{
				int index = this.m_connectionListCombo.SelectedIndex;
				this.m_connectionListCombo.Items[index] = frm.ConnectionName;
				this.m_connectInfoList[index].ConnectName = frm.ConnectionName;
				this.OnDataChanged(null, null);
			}
		}

		/// <summary>
		/// 지우기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnDeleteConnectionClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				this, Resources.Easy2Message_DeleteQuestion,
				Resources.Easy2Message_Question,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if(result == DialogResult.Yes)
			{
				this.m_connectionListCombo.Items.Remove(this.m_connectionListCombo.SelectedItem);
				this.m_connectInfoList.Remove(this.m_selectedInfo);
				this.m_mysqlHostText.Text = "";
				this.m_mysqlUsernameText.Text = "";
				this.m_mysqlPasswordText.Text = "";
				this.m_mysqlPortText.Text = "";
				this.m_mysqlDatabaseText.Text = "";
				this.m_mysqlTimeoutText.Text = "";
			}
		}

		/// <summary>
		/// 연결하기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnConnectClick(object sender, EventArgs e)
		{
			UpdateData(true);
			try
			{
				Program.MySqlConnector.Connect(this.m_selectedInfo);
				if(Program.CoummunicatorList.Count == 1) // 신규연결
					this.DialogResult = DialogResult.OK;
				else // 추가연결
					this.DialogResult = DialogResult.No;
				this.Close();
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Properties.Resources.Easy2Exception_Connect, ex.Number);
			}
		}

		/// <summary>
		/// 연결테스트 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnConnectTestClick(object sender, EventArgs e)
		{
			UpdateData(true);
			try
			{
				string message =
					Resources.Easy2Message_ConnectSuccess + "\n" +
					Program.MySqlConnector.ConnectTest(this.m_selectedInfo);
				MessageBox.Show(
					this,
					message,
					Resources.Easy2Message_ConnectTest,
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
					);
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_Connect, ex.Number);
			}
		}

		/// <summary>
		/// 닫기 버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private MySqlConnectInfo m_selectedInfo = null;
		private List<MySqlConnectInfo> m_connectInfoList = new List<MySqlConnectInfo>();
	}
}