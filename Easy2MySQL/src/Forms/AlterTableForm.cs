
// CreateTableForm.cs
//
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Easy2.Properties;
using Easy2.Classes;
using Easy2.Components;
using DevComponents.DotNetBar;
using MySql.Data.MySqlClient;

namespace Easy2.Forms
{
	public partial class AlterTableForm : TableBaseForm
	{
		/// <summary>
		/// AlterTableForm 컴포넌트를 초기화합니다.
		/// </summary>
		/// <param name="db">수정할 테이블을 소유한 데이터베이스입니다.</param>
		/// <param name="table">수정할 테이블입니다.</param>
		public AlterTableForm(string db, string table)
		{
			this.m_isInitialize = true;
			InitializeComponent();
			this.m_fieldEditor.SelectionChanged += new EventHandler(OnFieldEditorSelectionChanged);
			this.m_fieldEditor.RowsRemoved += new DataGridViewRowsRemovedEventHandler(OnFieldEditorRowsRemoved);
			this.m_fieldEditor.CellValueChanged += new DataGridViewCellEventHandler(OnFieldEditorCellValueChanged);
			this.m_db = db;
			this.m_table = table;
			base.FieldEditorContainer = this.m_fieldEditor;

			InitializeFieldEditor();
			InitializeAdvTablePropertiesForm();
			this.m_isInitialize = false;
		}

		/// <summary>
		/// 테이블에디터의 값을 초기화합니다.
		/// </summary>
		private void InitializeFieldEditor()
		{
			MySqlDataReader reader = null;
			try
			{
				List<FieldInfo> fields = new List<FieldInfo>();
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowFullFields(this.m_db, this.m_table, true));
				while(reader.Read())
				{
					string r_Field = reader["Field"].ToString();
					string r_Type = reader["Type"].ToString();
					string r_Collation = reader["Collation"].GetType().Name.Equals("DBNull") == true ? null : reader["Collation"].ToString();
					string r_Null = reader["Null"].ToString();
					string r_Key = reader["Key"].ToString();
					string r_Default = reader["Default"].GetType().Name.Equals("DBNull") == true ? null : reader["Default"].ToString();
					string r_Extra = reader["Extra"].ToString();
					string r_Comment = reader["Comment"].ToString();

 					FieldInfo field = new FieldInfo();
 					field.FieldName = r_Field;
 					field.DataType = MySqlGenerator.GetDataType(r_Type);
 					field.DataLength = MySqlGenerator.GetDataLength(r_Type);
 					field.DefaultValue = r_Default;
 					field.PK = r_Key == "PRI" ? true : false;
 					field.NotNull = r_Null == "NO" ? true : false;
 					field.Unsigned = r_Type.IndexOf("unsigned") != -1 ? true : false;
 					field.AutoIncrement = r_Extra.IndexOf("auto_increment") != -1 ? true : false;
 					field.Zerofill = r_Type.IndexOf("zerofill") != -1 ? true : false;
					field.Charset = r_Collation != null ? r_Collation.Substring(0, r_Collation.IndexOf('_')) : "";
					field.Collation = r_Collation != null ? r_Collation : "";
					field.Comment = r_Comment;

					fields.Add(field);

					this.m_fieldList.Add(field.FieldName);
					if(field.PK == true)
						this.m_primaryKeyCount++;
				}
				reader.Close();

				this.m_fieldEditor.WriteFields(fields.ToArray());
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
		/// 테이블 고급설정 폼을 초기화합니다.
		/// </summary>
		private void InitializeAdvTablePropertiesForm()
		{
			MySqlDataReader reader = null;
			try
			{
				reader = Program.ActivateCommunicator.ExecuteReader(MySqlGenerator.ShowTableStatus(this.m_db, this.m_table));
				reader.Read();

				TableOption option = new TableOption();
				option.Engine = reader["Engine"].ToString();
				option.Collation = reader["Collation"].ToString();
				option.Charset = option.Collation.Substring(0, option.Collation.IndexOf('_'));
				option.Comment = reader["Comment"].ToString();
				option.Format = reader["Row_format"].ToString();
				option.Checksum = reader["Checksum"].GetType().Name.Equals("DBNull") == true ? "DEFAULT" : reader["Checksum"].ToString();
				option.AutoIncrement = reader["Auto_increment"].GetType().Name.Equals("DBNull") == true ? "" : reader["Auto_increment"].ToString();
				option.AvgRowLength = reader["Avg_row_length"].ToString().Equals("0") == true ? "" : reader["Avg_row_length"].ToString();

				string[] createOptions = reader["Create_options"].ToString().Split(' ');
				foreach(string createOption in createOptions)
				{
					if(createOption.IndexOf("min_rows=") != -1)
					{
						option.MinimumRows = createOption.Substring(0 + "min_rows=".Length);
					}
					else if(createOption.IndexOf("max_rows=") != -1)
					{
						option.MaximumRows = createOption.Substring(0 + "max_rows=".Length);
					}
				}
				reader.Close();

				this.m_tableOption = option;
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
		/// 선택된 셀이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		private void OnFieldEditorSelectionChanged(object sender, EventArgs e)
		{
			if(this.m_fieldEditor.CurrentCell.OwningRow.IsNewRow == false)
			{
				this.m_deleteRowButton.Enabled = true;
			}
			else
			{
				this.m_deleteRowButton.Enabled = false;
			}
		}

		/// <summary>
		/// 행이 지워지면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		void OnFieldEditorRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			// 기존의 필드가 지워짐
			if(e.RowIndex < this.m_fieldList.Count)
			{
				// 지워진 필드 추가
				this.m_removedFields.Add(this.m_fieldList[e.RowIndex]);
				this.m_fieldList.RemoveAt(e.RowIndex);
			}
		}

		/// <summary>
		/// 필드에디터의 값이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		void OnFieldEditorCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(this.m_isInitialize == false)
			{
				if(this.m_fieldEditor.Columns[e.ColumnIndex].Name == "Pk")
				{
					this.m_isChangedPrimaryKey = true;
					if(this.m_modifiedFields.IndexOf(this.m_fieldList[e.RowIndex]) == -1)
						this.m_modifiedFields.Add(this.m_fieldList[e.RowIndex]);
				}
				else if(e.RowIndex < this.m_fieldList.Count)
				{
					if(this.m_modifiedFields.IndexOf(this.m_fieldList[e.RowIndex]) == -1)
						this.m_modifiedFields.Add(this.m_fieldList[e.RowIndex]);
				}
			}
		}

		/// <summary>
		/// 확인버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, EventArgs e)
		{
			List<FieldInfo> addedFields = new List<FieldInfo>();
			List<FieldInfo> modifiedFields = new List<FieldInfo>();
			List<string> primaryFileds = new List<string>();

			for(int i = this.m_fieldList.Count; i < this.m_fieldEditor.Rows.Count; i++)
			{
				if(this.m_fieldEditor.Rows[i].IsNewRow == false)
				{
					addedFields.Add(this.m_fieldEditor.ReadField(this.m_fieldEditor.Rows[i].Cells["Field"].Value.ToString()));
				}
			}

			for(int i = 0; i < this.m_modifiedFields.Count; i++)
			{
				FieldInfo info = this.m_fieldEditor.ReadField(this.m_fieldList.IndexOf(this.m_modifiedFields[i]));
				info.OldFieldName = this.m_modifiedFields[i];
				modifiedFields.Add(info);
			}

			foreach(DataGridViewRow row in this.m_fieldEditor.Rows)
			{
				if(row.IsNewRow == false)
				{
					if(Boolean.Parse(row.Cells["Pk"].Value.ToString()) == true)
						primaryFileds.Add(row.Cells["Field"].Value.ToString());
				}
			}

			if(this.m_primaryKeyCount > 0)
				this.m_isDropPrimaryKey = true;

			try
			{
				Program.ActivateCommunicator.AlterTable(
					this.m_db,
					this.m_table,
					addedFields.ToArray(),
					modifiedFields.ToArray(),
					this.m_removedFields.ToArray(),
					primaryFileds.ToArray(),
					this.m_isChangedPrimaryKey,
					this.m_isDropPrimaryKey,
					this.m_tableOption,
					this.m_isChangedTableOption
					);
				MessageBoxEx.Show(this, Resources.Easy2Message_TableAlterSuccessfully, Resources.Easy2Message_Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(MySqlException ex)
			{
				EasyToMySqlError.Show(this, ex.Message, Resources.Easy2Exception_ExecuteQuery, ex.Number);
			}
		}

		/// <summary>
		/// 고급 기능버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
 		protected override void OnAdvanceButtonClick(object sender, EventArgs e)
 		{
			AdvTablePropertiesForm advPropertiesForm = new AdvTablePropertiesForm(this.m_tableOption);
			advPropertiesForm.ShowDialog(this);
			if(advPropertiesForm.DialogResult == DialogResult.OK)
			{
				this.m_tableOption = advPropertiesForm.ReadData();
				this.m_isChangedTableOption = true;
			}
			base.OnAdvanceButtonClick(sender, e);
 		}

		/// <summary>
		/// 열 제거버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnDeleteRowButtonClick(object sender, EventArgs e)
		{
			this.m_fieldEditor.RemoveRow();
			base.OnDeleteRowButtonClick(sender, e);
		}

		private FieldEditor m_fieldEditor = new FieldEditor();
		private string m_db = null;
		private string m_table = null;

		private List<string> m_fieldList = new List<string>();	// 원본 필드
		private List<string> m_removedFields = new List<string>();	// 삭제된 필드
		private List<string> m_modifiedFields = new List<string>();	// 수정된 필드
		private bool m_isChangedPrimaryKey = false;	// 프라이머리키가 수정됐는지의 여부
		private bool m_isDropPrimaryKey = false;	// 프라이머리키를 지울지의 여부
		private int m_primaryKeyCount = 0;	// 원래의 프라이머리 키의 갯수
		private TableOption m_tableOption = null;
		private bool m_isChangedTableOption = false;

		private bool m_isInitialize = false;
	}
}
