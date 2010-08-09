
// ManagePrivilegesUserForm.cs
//
using Easy2.Enums;
using Easy2.Classes;
using Easy2.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using DevComponents.Editors;
using DevComponents.DotNetBar.Controls;
using MySql.Data.MySqlClient;

namespace Easy2.Forms
{
	/// <summary>
	/// 사용자권한을 관리하기 위한 폼입니다.
	/// </summary>
	public partial class ManagePrivilegesUserForm : BaseForm
	{
		/// <summary>
		/// ManagePrivilegesUserForm 인스턴스를 초기화합니다.
		/// </summary>
		public ManagePrivilegesUserForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 폼이 보여질 때 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnShown(EventArgs e)
		{
			this.m_isOnShown = true;

			base.OnShown(e);

			this.m_userListCombo.Items.AddRange(ReadUsers());
			if(m_userListCombo.Items.Count > 0)
				this.m_userListCombo.SelectedIndex = 0;
			this.m_userListCombo.Focus();

			InitializeGridColumn("mysql.db");
			InitializeGridColumn("mysql.tables_priv");
			InitializeGridColumn("mysql.columns_priv");
			InitializeGridColumn("mysql.procs_priv");

			this.m_isOnShown = false;
		}

		/// <summary>
		/// 사용자리스트 콤보박스의 인덱스가 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnSelectedIndexChanged(object sender, EventArgs e)
		{
			string[] token = this.m_userListCombo.SelectedItem.ToString().Split('@');
			this.m_username = token[0];
			this.m_host = token[1];

			if(this.m_isOnShown == false)
			{
				// 데이터베이스 목록 불러오기
			}
		}

		/// <summary>
		/// 데이터베이스 그리드뷰의 컬럼들을 초기화합니다.
		/// </summary>
		private void InitializeGridColumn(string target)
		{
			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowFullFields(target, false));
				while(reader.Read())
				{
					string fieldName = reader.GetString(0);
					if(target == "mysql.db")
					{
						if(fieldName.IndexOf("priv") != -1)
						{
							DataGridViewCheckBoxColumn privColumn = new DataGridViewCheckBoxColumn();
							privColumn.HeaderText = fieldName.Substring(0, fieldName.IndexOf("priv") - 1);
							privColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
							privColumn.Resizable = DataGridViewTriState.False;
							privColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

							this.m_databasePrivGrid.Columns.Add(privColumn);
						}
					}
					else if(target == "mysql.tables_priv" | target == "mysql.columns_priv" | target == "mysql.procs_priv")
					{
						string targetField = null;
						DataGridViewX targetGridView = null;
						switch(target)
						{
							case "mysql.tables_priv":
								targetField = "Table_priv";
								targetGridView = this.m_tablePrivGrid;
								break;
							case "mysql.columns_priv":
								targetField = "Column_priv";
								targetGridView = this.m_columnPrivGrid;
								break;
							case "mysql.procs_priv":
								targetField = "Proc_priv";
								targetGridView = this.m_procedurePrivGrid;
								break;
						}
						if(fieldName == targetField)
						{
							string fieldValue = reader.GetString(1);
							Regex regex = new Regex("[A-Za-z]+", RegexOptions.IgnoreCase);
							MatchCollection matches = regex.Matches(fieldValue);
							if(matches.Count > 0)
							{
								foreach(Match match in matches)
								{
									if(match.ToString() != "set")
									{
										DataGridViewCheckBoxColumn privColumn = new DataGridViewCheckBoxColumn();
										privColumn.HeaderText = match.ToString();
										privColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
										privColumn.Resizable = DataGridViewTriState.False;
										privColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
										targetGridView.Columns.Add(privColumn);
									}
								}
							}
						}
					}
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
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.SelectMysqlUser());

				while(reader.Read())
				{
					userList.Add(String.Format("{0}@{1}", reader.GetString(0), reader.GetString(1)));
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

			return userList.ToArray();
		}

		private string m_username;
		private string m_host;
		private bool m_isOnShown;
	}
}
