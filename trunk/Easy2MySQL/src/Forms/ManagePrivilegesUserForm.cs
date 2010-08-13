
// ManagePrivilegesUserForm.cs
//
using Easy2.Enums;
using Easy2.Classes;
using Easy2.Properties;
using System;
using System.Linq;
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
			try
			{
				InitializeGridColumn("mysql.db");
				InitializeGridColumn("mysql.tables_priv");
				InitializeGridColumn("mysql.columns_priv");
				InitializeGridColumn("mysql.procs_priv");

				this.m_userListCombo.Items.AddRange(ReadUsers());
				if(m_userListCombo.Items.Count > 0)
					this.m_userListCombo.SelectedIndex = 0;
				this.m_userListCombo.Focus();
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
				this.Close();
			}
		}

		/// <summary>
		/// 사용자리스트 콤보박스의 인덱스가 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnUserListComboSelectedIndexChanged(object sender, EventArgs e)
		{
			string[] token = this.m_userListCombo.SelectedItem.ToString().Split('@');
			this.m_username = token[0];
			this.m_host = token[1];

			MySqlDataReader reader = null;
			try
			{
				// 데이터베이스 목록 추가
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowDatabases());

				this.m_databasePrivGrid.Rows.Clear();

				// 값목록 만들기
				List<string[]> valueList = new List<string[]>();
				while(reader.Read())
				{
					string[] values = new string[this.m_databasePrivGrid.ColumnCount];
					values[0] = reader.GetString(0); // 데이터베이스 이름
					for(int i = 1; i < values.Length; i++)
					{
						values[i] = "false"; // 체크박스 초기값
					}
					valueList.Add(values);
				}
				reader.Close();

				// MySqlDataReader 객체가 닫히지 않으면 또 다른 MySqlDataReader 객체가
				// 생성될 수 없기 때문에 값목록을 만들고 MySqlDataReader 객체를 닫음으로서
 				// 다른 이벤트에서 MySqlDataReader를 생성할 수 있게 한다.

				// 그리드에 값 추가
				foreach(string[] v in valueList)
				{
					this.m_databasePrivGrid.Rows.Add(v);
				}
				SetDatabasePrivilege();
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		/// <summary>
		/// 데이터베이스 권한 그리드의 선택된 셀이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnDatabasePrivGridSelectionChanged(object sender, EventArgs e)
		{
			if(this.m_databasePrivGrid.SelectedCells.Count > 0)
			{
				int index = this.m_databasePrivGrid.SelectedCells[0].RowIndex;
				if(this.m_selectedDatabaseName != this.m_databasePrivGrid.Rows[index].Cells["Db"].Value.ToString())
				{
					this.m_selectedDatabaseName = this.m_databasePrivGrid.Rows[index].Cells["Db"].Value.ToString();
					this.m_tablePrivGrid.Rows.Clear();
					
					if(this.m_selectedDatabaseName != "information_schema")
					{
						MySqlDataReader reader = null;
						try
						{
							// 테이블 목록 추가
							reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowTablesViews(this.m_selectedDatabaseName));
							List<string[]> valueList = new List<string[]>();

							while(reader.Read())
							{
								string[] values = new string[this.m_tablePrivGrid.ColumnCount];
								values[0] = reader.GetString(0); // 테이블 이름
								for(int i = 1; i < values.Length; i++)
								{
									values[i] = "false"; // 체크박스 초기값
								}
								valueList.Add(values);
							}
							reader.Close();

							foreach(string[] v in valueList)
							{
								this.m_tablePrivGrid.Rows.Add(v);
							}

							SetTablePrivilege();
						}
						catch(MySqlException ex)
						{
							EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
						}
						finally
						{
							if(reader != null)
								reader.Close();
						}
					}
					else
					{
						this.m_columnPrivGrid.Rows.Clear();
						this.m_selectedTableName = "";
					}
				}
			}
		}

		/// <summary>
		/// 테이블 권한 그리드의 선택된 셀이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnTablePrivGridSelectionChanged(object sender, EventArgs e)
		{
			if(this.m_tablePrivGrid.SelectedCells.Count > 0)
			{
				int index = this.m_tablePrivGrid.SelectedCells[0].RowIndex;
				if(this.m_selectedTableName != this.m_tablePrivGrid.Rows[index].Cells["Table_name"].Value.ToString())
				{
					this.m_selectedTableName = this.m_tablePrivGrid.Rows[index].Cells["Table_name"].Value.ToString();
					this.m_columnPrivGrid.Rows.Clear();

					MySqlDataReader reader = null;
					try
					{
						// 컬럼 목록 추가
						reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowColumns(this.m_selectedDatabaseName, this.m_selectedTableName));
						while(reader.Read())
						{
							string[] rowValue = new string[this.m_columnPrivGrid.ColumnCount];
							rowValue[0] = reader.GetString(0); // 컬럼 이름
							for(int i = 1; i < rowValue.Length; i++)
							{
								rowValue[i] = "false"; // 체크박스 초기값
							}
							this.m_columnPrivGrid.Rows.Add(rowValue);
						}
						reader.Close();

						SetColumnPrivilege();
					}
					catch(MySqlException ex)
					{
						EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
					}
					finally
					{
						if(reader != null)
							reader.Close();
					}
				}
			}
		}

		/// <summary>
		/// 데이터베이스 그리드뷰의 컬럼들을 초기화합니다.
		/// </summary>
		/// <exception cref="MySqlException">
		/// 쿼리문 실행을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
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
							privColumn.Name = fieldName;
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
								targetGridView = this.m_routinePrivGrid;
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
										privColumn.Name = match.ToString();
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
				throw ex;
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
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}

			return userList.ToArray();
		}

		/// <summary>
		/// 사용자의 데이터베이스에 대한 권한정보를 설정합니다.
		/// </summary>
		private void SetDatabasePrivilege()
		{
			// 데이터베이스 권한정보 로드
			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.SelectDatabasePrivilege(m_username, m_host));
				while(reader.Read())
				{
					// Linq 쿼리로 Row 찾기
					DataGridViewRow row =
						(from DataGridViewRow r in m_databasePrivGrid.Rows
						 where r.Cells["Db"].Value.ToString() == reader["Db"].ToString()
						 select r).ToArray()[0];

					for(int i = 0; i < reader.FieldCount; i++)
					{
						if(reader.GetName(i).IndexOf("priv") != -1)
						{
							row.Cells[reader.GetName(i)].Value = reader.GetString(i) == "Y" ? "True" : "False";
						}
					}
				}
				reader.Close();
			}
			catch(MySqlException ex)
			{
				throw ex;
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		/// <summary>
		/// 사용자의 테이블에 대한 권한정보를 설정합니다.
		/// </summary>
		private void SetTablePrivilege()
		{
			// 테이블 권한정보 로드
			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.SelectTablePrivilege(this.m_username, this.m_host, this.m_selectedDatabaseName));
				while(reader.Read())
				{
					// Linq 쿼리로 Row 찾기
					DataGridViewRow row =
						(from DataGridViewRow r in m_tablePrivGrid.Rows
						 where r.Cells["Table_name"].Value.ToString() == reader["Table_name"].ToString()
						 select r).ToArray()[0];

					for(int i = 0; i < reader.FieldCount; i++)
					{
						if(reader.GetName(i) == "Table_priv")
						{
							string[] privilege = reader.GetString(i).Split(',');
							foreach(string s in privilege)
							{
								if(s.Length > 0)
								{
									row.Cells[s].Value = "True";
								}
							}
						}
					}
				}
				reader.Close();
			}
			catch(MySqlException ex)
			{
				throw ex;
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		/// <summary>
		/// 사용자의 컬럼에 대한 권한정보를 설정합니다.
		/// </summary>
		private void SetColumnPrivilege()
		{
			// 테이블 권한정보 로드
			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.SelectColumnPrivilege(this.m_username, this.m_host, this.m_selectedDatabaseName, this.m_selectedTableName));
				while(reader.Read())
				{
					// Linq 쿼리로 Row 찾기
					DataGridViewRow row =
						(from DataGridViewRow r in m_columnPrivGrid.Rows
						 where r.Cells["Column_name"].Value.ToString() == reader["Column_name"].ToString()
						 select r).ToArray()[0];

					for(int i = 0; i < reader.FieldCount; i++)
					{
						if(reader.GetName(i) == "Column_priv")
						{
							string[] privilege = reader.GetString(i).Split(',');
							foreach(string s in privilege)
							{
								if(s.Length > 0)
								{
									row.Cells[s].Value = "True";
								}
							}
						}
					}
				}
				reader.Close();
			}
			catch(MySqlException ex)
			{
				throw ex;
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		private string m_username;
		private string m_host;
		private string m_selectedDatabaseName;
		private string m_selectedTableName;
	}
}
