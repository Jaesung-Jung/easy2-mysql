
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
			InitializeComponent();
			this.m_tableEditor.SelectionChanged += new EventHandler(this.OnTableEditorSelectionChanged);
			this.m_db = db;
			this.m_table = table;
			base.TableEditorContainer = this.m_tableEditor;

			InitializeTableEditor();
		}

		/// <summary>
		/// 테이블에디터의 값을 초기화합니다.
		/// </summary>
		private void InitializeTableEditor()
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
					string r_Collation = reader["Collation"].GetType().Name == "DBNull" ? null : reader["Collation"].ToString();
					string r_Null = reader["Null"].ToString();
					string r_Key = reader["Key"].ToString();
					string r_Default = reader["Default"].GetType().Name == "DBNull" ? null : reader["Default"].ToString();
					string r_Extra = reader["Extra"].ToString();
					string r_Comment = reader["Comment"].ToString();

 					FieldInfo field = new FieldInfo();
 					field.FiledName = r_Field;
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
				}
				reader.Close();

				this.m_tableEditor.WriteFields(fields.ToArray());
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
		private void OnTableEditorSelectionChanged(object sender, EventArgs e)
		{
			if(this.m_tableEditor.CurrentCell.OwningRow.IsNewRow == false)
			{
				this.m_deleteRowButton.Enabled = true;
			}
			else
			{
				this.m_deleteRowButton.Enabled = false;
			}
		}

		/// <summary>
		/// 확인버튼을 클릭하면 호출됩니다.
		/// </summary>
		/// <param name="sender">이벤트를 발생시킨 객체입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCommitButtonClick(object sender, EventArgs e)
		{
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
			this.m_tableEditor.RemoveRow();
			base.OnDeleteRowButtonClick(sender, e);
		}

		private TableEditor m_tableEditor = new TableEditor();
		private TableOption m_tableOption = null;
		private string m_db = null;
		private string m_table = null;
	}
}
