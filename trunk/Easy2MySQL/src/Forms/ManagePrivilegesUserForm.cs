
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
					values[0] = reader["Database"].ToString(); // 데이터베이스 이름
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
					this.m_routinePrivGrid.Rows.Clear();
					
					if(this.m_selectedDatabaseName != "information_schema")
					{
						MySqlDataReader reader = null;
						try
						{
							// 테이블 목록 추가
							reader = Program.ActivateCommunicator.ExecuteReader(
								MySqlGenerator.ShowTablesViews(this.m_selectedDatabaseName)
								);
							List<string[]> tableList = new List<string[]>();

							while(reader.Read())
							{
								string[] values = new string[this.m_tablePrivGrid.ColumnCount];
								values[0] = reader.GetString(0); // 테이블 이름
								for(int i = 1; i < values.Length; i++)
								{
									values[i] = "false"; // 체크박스 초기값
								}
								tableList.Add(values);
							}
							reader.Close();

							foreach(string[] table in tableList)
							{
								this.m_tablePrivGrid.Rows.Add(table);
							}

							SetTablePrivilege();

							// 루틴 목록 추가
							reader = Program.ActivateCommunicator.ExecuteReader(
								MySqlGenerator.ShowRoutine(this.m_selectedDatabaseName)
								);
							List<string[]> routineList = new List<string[]>();

							while(reader.Read())
							{
								string[] values = new string[this.m_routinePrivGrid.ColumnCount];
								values[0] = reader["Routine_name"].ToString();
								values[1] = reader["Routine_type"].ToString();
								for(int i = 2; i < values.Length; i++)
								{
									values[i] = "false";
								}
								routineList.Add(values);
							}
							reader.Close();

							foreach(string[] routine in routineList)
							{
								this.m_routinePrivGrid.Rows.Add(routine);
							}

							SetRoutinePrivilege();
						}
						catch(MySqlException ex)
						{
							EasyToMySqlError.Show(this,	ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
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
						reader = Program.ActivateCommunicator.ExecuteReader(
							MySqlGenerator.ShowColumns(this.m_selectedDatabaseName, this.m_selectedTableName)
							);
						while(reader.Read())
						{
							string[] rowValue = new string[this.m_columnPrivGrid.ColumnCount];
							rowValue[0] = reader["Field"].ToString(); // 컬럼 이름
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
		/// 적용 버튼이 클릭되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생한 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnApplyButtonClick(object sender, EventArgs e)
		{
			/*
			 * 권한을 관리함에 있어 UPDATE를 이용한 변경이 힘들다.
			 * 이유는 각 오브젝트들에 대해 권한이 있는지 없는지 여부를
			 * 검사하여 권한변경 또는 권한을 추가/제거하여야 해야 하기
			 * 때문에, 많은 양의 쿼리문을 처리하면서 비효율적인 동작과
			 * 함께 조건도 복잡해지게 된다.
			 * 권한 변경이 일어나면 관련된 권한을 모두 제거하고 그리드에
			 * 있는 정보를 토대로 새롭게 권한을 작성하여 값을 넣어주도록
			 * 작성하였다.
			 *
			 */

			// 해당사용자의 권한정보를 모두 제거하는 코드 삽입

			// 데이터베이스 권한정보 읽기
			List<DatabasePrivilege> db_privileges = new List<DatabasePrivilege>();
			foreach(DataGridViewRow row in this.m_databasePrivGrid.Rows)
			{
				DatabasePrivilege db_priv = new DatabasePrivilege();
				db_priv.Db = row.Cells["Db"].Value.ToString();
				foreach(DataGridViewCell cell in row.Cells)
				{
					if(cell is DataGridViewCheckBoxCell)
					{
						if(Boolean.Parse(cell.Value.ToString()) == true)
						{
							db_priv.Privileges.Add(cell.OwningColumn.Name);
						}
					}
				}

				// 권한이 있는것들만 추가
				if(db_priv.Privileges.Count != 0)
					db_privileges.Add(db_priv);
			}

			// 테이블 권한정보 읽기
			List<TablePrivilege> table_privileges = new List<TablePrivilege>();
			foreach(DataGridViewRow row in this.m_tablePrivGrid.Rows)
			{
				TablePrivilege table_priv = new TablePrivilege();
				table_priv.Db = this.m_databasePrivGrid.SelectedCells[0].OwningRow.Cells["Db"].Value.ToString();
				table_priv.TableName = row.Cells["Table_name"].Value.ToString();
				foreach(DataGridViewCell cell in row.Cells)
				{
					if(cell is DataGridViewCheckBoxCell)
					{
						if(Boolean.Parse(cell.Value.ToString()) == true)
						{
							table_priv.Privileges.Add(cell.OwningColumn.Name);
						}
					}
				}
				if(table_priv.Privileges.Count != 0)
					table_privileges.Add(table_priv);
			}

			// 컬럼 권한정보 읽기
			List<ColumnPrivilege> column_privileges = new List<ColumnPrivilege>();
			foreach(DataGridViewRow row in this.m_columnPrivGrid.Rows)
			{
				ColumnPrivilege column_priv = new ColumnPrivilege();
				column_priv.Db = this.m_databasePrivGrid.SelectedCells[0].OwningRow.Cells["Db"].Value.ToString();
				column_priv.TableName = this.m_tablePrivGrid.SelectedCells[0].OwningRow.Cells["Table_name"].Value.ToString();
				column_priv.ColumnName = row.Cells["Column_name"].Value.ToString();
				foreach(DataGridViewCell cell in row.Cells)
				{
					if(cell is DataGridViewCheckBoxCell)
					{
						if(Boolean.Parse(cell.Value.ToString()) == true)
						{
							column_priv.Privileges.Add(cell.OwningColumn.Name);
						}
					}
				}
				if(column_priv.Privileges.Count != 0)
					column_privileges.Add(column_priv);
			}

			// 루틴 권한정보 읽기
			List<RoutinePrivilege> routine_privileges = new List<RoutinePrivilege>();
			foreach(DataGridViewRow row in this.m_routinePrivGrid.Rows)
			{
				RoutinePrivilege routine_priv = new RoutinePrivilege();
				routine_priv.Db = this.m_databasePrivGrid.SelectedCells[0].OwningRow.Cells["Db"].Value.ToString();
				routine_priv.RoutineName = row.Cells["Routine_name"].Value.ToString();
				routine_priv.Type = (RoutinePrivilege.RoutineType)Enum.Parse(
					typeof(RoutinePrivilege.RoutineType),
					row.Cells["Routine_type"].Value.ToString()
					);
				foreach(DataGridViewCell cell in row.Cells)
				{
					if(cell is DataGridViewCheckBoxCell)
					{
						if(Boolean.Parse(cell.Value.ToString()) == true)
						{
							routine_priv.Privileges.Add(cell.OwningColumn.Name);
						}
					}
				}
				if(routine_priv.Privileges.Count != 0)
					routine_privileges.Add(routine_priv);
			}

			try
			{
				Program.ActivateCommunicator.UpdatePrivilege(
					this.m_host,
					this.m_username,
					db_privileges.ToArray(),
					table_privileges.ToArray(),
					column_privileges.ToArray(),
					routine_privileges.ToArray()
					);
				MessageBox.Show(
						this,
						Resources.Easy2Message_UpdatePrivileges,
						Resources.Easy2Message_Title,
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
						);
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
		}

		/// <summary>
		/// 닫기 버튼이 클릭되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생한 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnCloseButtonClick(object sender, EventArgs e)
		{
			this.Dispose(true);
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
				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.ShowFullFields(target, false)
					);
				while(reader.Read())
				{
					string fieldName = reader["Field"].ToString();
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
					else if(target == "mysql.tables_priv" |
							target == "mysql.columns_priv" |
							target == "mysql.procs_priv"
						)
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
							string fieldValue = reader["Type"].ToString();
							Regex regex = new Regex("[A-Za-z ]+", RegexOptions.IgnoreCase);
							MatchCollection matches = regex.Matches(fieldValue);
							if(matches.Count > 0)
							{
								foreach(Match match in matches)
								{
									if(match.ToString() != "set")
									{
										DataGridViewCheckBoxColumn privColumn = new DataGridViewCheckBoxColumn();
										privColumn.Name = match.ToString();
										if(targetGridView == this.m_routinePrivGrid)
											System.Console.WriteLine(privColumn.Name);
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
				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.SelectMysqlUser()
					);

				while(reader.Read())
				{
					userList.Add(String.Format("{0}@{1}", reader["user"].ToString(), reader["host"].ToString()));
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
				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.SelectDatabasePrivilege(m_username, m_host)
					);
				while(reader.Read())
				{
					// Linq 쿼리로 Row 찾기
					DataGridViewRow row =
						(from DataGridViewRow r in m_databasePrivGrid.Rows
						 where r.Cells["Db"].Value.ToString() == reader["Db"].ToString()
						 select r).ToArray()[0];

					for(int i = 0; i < reader.FieldCount; i++)
					{
						string fieldName = reader.GetName(i);
						if(fieldName.IndexOf("priv") != -1)
						{
							row.Cells[reader.GetName(i)].Value = reader[fieldName].ToString() == "Y" ? "True" : "False";
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
				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.SelectTablePrivilege(this.m_username, this.m_host, this.m_selectedDatabaseName));
				while(reader.Read())
				{
					// Linq 쿼리로 Row 찾기
					DataGridViewRow row =
						(from DataGridViewRow r in m_tablePrivGrid.Rows
						 where r.Cells["Table_name"].Value.ToString() == reader["Table_name"].ToString()
						 select r).ToArray()[0];

					for(int i = 0; i < reader.FieldCount; i++)
					{
						string fieldName = reader.GetName(i);
						if(fieldName == "Table_priv")
						{
							string[] privilege = reader[fieldName].ToString().Split(',');
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
		/// 사용자의 루틴에 대한 권한정보를 설정합니다.
		/// </summary>
		private void SetRoutinePrivilege()
		{
			// 테이블 권한정보 로드
			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.SelectRoutinePrivilege(this.m_username, this.m_host, this.m_selectedDatabaseName));
				while(reader.Read())
				{
					// Linq 쿼리로 Row 찾기
					DataGridViewRow row =
						(from DataGridViewRow r in m_routinePrivGrid.Rows
						 where r.Cells["Routine_name"].Value.ToString() == reader["Routine_name"].ToString()
						 select r).ToArray()[0];

					for(int i = 0; i < reader.FieldCount; i++)
					{
						string fieldName = reader.GetName(i);
						if(fieldName == "Proc_priv")
						{
							string[] privilege = reader[fieldName].ToString().Split(',');
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
				reader = Program.ActivateCommunicator.ExecuteReader(
					MySqlGenerator.SelectColumnPrivilege(this.m_username, this.m_host, this.m_selectedDatabaseName, this.m_selectedTableName));
				while(reader.Read())
				{
					// Linq 쿼리로 Row 찾기
					DataGridViewRow row =
						(from DataGridViewRow r in m_columnPrivGrid.Rows
						 where r.Cells["Column_name"].Value.ToString() == reader["Column_name"].ToString()
						 select r).ToArray()[0];

					for(int i = 0; i < reader.FieldCount; i++)
					{
						string filedName = reader.GetName(i);
						if(filedName == "Column_priv")
						{
							string[] privilege = reader[filedName].ToString().Split(',');
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
