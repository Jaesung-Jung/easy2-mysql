
// TableEditor.cs
//
using Easy2.Properties;
using Easy2.Classes;
using Easy2.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace Easy2.Components
{
	public class TableEditor : DataGridViewX
	{
		public TableEditor()
		{
			InitializeComponents();
			InitializeDataTypes();
			InitializeDataTypeColumn();
		}

		/// <summary>
		/// 셀의 값이 변경되면 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnCellValueChanged(DataGridViewCellEventArgs e)
		{
			DataGridViewCell changedCell = this[e.ColumnIndex, e.RowIndex];
			DataGridViewRow changedRow = this.Rows[e.RowIndex];
			DataGridViewColumn changedColumn = this.Columns[e.ColumnIndex];

			if(changedColumn == this.Columns["Datatype"])
			{
				string type = changedCell.Value.ToString();

				if((this.m_permission[type] & DataTypePermission.AutoIncrement) == DataTypePermission.AutoIncrement)
				{
					ControlCell(changedRow.Cells["AutoIncr"], false);
				}
				else
				{
					ControlCell(changedRow.Cells["AutoIncr"], false, true);
				}
				if((this.m_permission[type] & DataTypePermission.Charset) == DataTypePermission.Charset)
				{
					if(this.m_charset.Count == 0)
						ReadCharset();
					ControlCell(changedRow.Cells["Charset"], "DEFAULT", false);
				}
				else
				{
					ControlCell(changedRow.Cells["Charset"], null, true);
				}
				if((this.m_permission[type] & DataTypePermission.Collation) == DataTypePermission.Collation)
				{
					ControlCell(changedRow.Cells["Collation"], false);
				}
				else
				{
					ControlCell(changedRow.Cells["Collation"], null, true);
				}
				if((this.m_permission[type] & DataTypePermission.Len) == DataTypePermission.Len)
				{
					ControlCell(changedRow.Cells["Length"], false);
				}
				else
				{
					ControlCell(changedRow.Cells["Length"], null, true);
				}
				if((this.m_permission[type] & DataTypePermission.Unsigned) == DataTypePermission.Unsigned)
				{
					ControlCell(changedRow.Cells["Unsigned"], false);
				}
				else
				{
					ControlCell(changedRow.Cells["Unsigned"], false, true);
				}
				if((this.m_permission[type] & DataTypePermission.Zerofill) == DataTypePermission.Zerofill)
				{
					ControlCell(changedRow.Cells["Zerofill"], false);
				}
				else
				{
					ControlCell(changedRow.Cells["Zerofill"], false, true);
				}
			}
			else if(changedColumn == this.Columns["Pk"])
			{
				if(Boolean.Parse(changedCell.Value.ToString()))
				{
					ControlCell(changedRow.Cells["NotNull"], true, true);
				}
				else
				{
					ControlCell(changedRow.Cells["NotNull"], false);
				}
			}
			else if(changedColumn == this.Columns["AutoIncr"])
			{
				if(Boolean.Parse(changedCell.Value.ToString()))
				{
					ControlCell(changedRow.Cells["Default"], null, true);
				}
				else
				{
					ControlCell(changedRow.Cells["Default"], false);
				}
			}
			else if(changedColumn == this.Columns["Charset"])
			{
				DataGridViewComboBoxCell collationCell = (DataGridViewComboBoxCell)(changedRow.Cells["Collation"]);
				collationCell.Items.Clear();
				if(changedCell.Value != null)
				{
					if(changedCell.Value.Equals("DEFAULT") == false)
					{
						collationCell.Items.AddRange(
							Program.ActivateCommunicator.GetCollation(changedCell.Value.ToString())
							);
						collationCell.Value = collationCell.Items[0];
					}
					else
					{
						collationCell.Items.Add("DEFAULT");
						collationCell.Value = collationCell.Items[0];
					}
				}
				else
				{
					collationCell.Items.Clear();
					collationCell.Value = null;
				}
			}

			base.OnCellValueChanged(e);
		}

		/// <summary>
		/// 키가 눌려지면 호출됩니다.
		/// </summary>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Back)
			{
 				DataGridViewColumn selectedColumn;
				if(this.CurrentCell != null)
				{
					selectedColumn = this.CurrentCell.OwningColumn;

					if(selectedColumn is DataGridViewTextBoxColumn)
					{
						this.CurrentCell.Value = null;
					}
				}
			}
			else if(e.KeyCode == Keys.Delete)
			{
				RemoveRow();
			}
			else
			{
				base.OnKeyDown(e);
			}
		}

		/// <summary>
		/// 유효하지 않은 데이터가 입력되었을 때 호출됩니다.
		/// </summary>
		/// <param name="displayErrorDialogIfNoHandler">오류메세지 창을 보여줄지 여부입니다.</param>
		/// <param name="e">이벤트정보를 가진 객체입니다.</param>
		protected override void OnDataError(bool displayErrorDialogIfNoHandler, DataGridViewDataErrorEventArgs e)
		{
			// 예외처리기법 추가예정
		}

		/// <summary>
		/// 컴포넌트들을 초기화합니다.
		/// </summary>
		private void InitializeComponents()
		{
			DataGridViewTextBoxColumn fieldnameColumn = new DataGridViewTextBoxColumn();
			DataGridViewComboBoxColumn datatypeColumn = new DataGridViewComboBoxColumn();
			DataGridViewTextBoxColumn lengthColumn = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn defaultColumn = new DataGridViewTextBoxColumn();
			DataGridViewCheckBoxColumn pkColumn = new DataGridViewCheckBoxColumn();
			DataGridViewCheckBoxColumn nnColumn = new DataGridViewCheckBoxColumn();
			DataGridViewCheckBoxColumn unsignedColumn = new DataGridViewCheckBoxColumn();
			DataGridViewCheckBoxColumn autoIncrementColumn = new DataGridViewCheckBoxColumn();
			DataGridViewCheckBoxColumn zerofillColumn = new DataGridViewCheckBoxColumn();
			DataGridViewComboBoxColumn charsetColumn = new DataGridViewComboBoxColumn();
			DataGridViewComboBoxColumn collationColumn = new DataGridViewComboBoxColumn();
			DataGridViewTextBoxColumn commentColumn = new DataGridViewTextBoxColumn();
			//
			// fieldnameColumn
			//
			fieldnameColumn.Name = "Field";
			fieldnameColumn.HeaderText = "필드 이름";
			fieldnameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			fieldnameColumn.Width = 200;
			//
			// datatypeColumn
			//
			datatypeColumn.Name = "Datatype";
			datatypeColumn.HeaderText = "데이터 타입";
			datatypeColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			datatypeColumn.Resizable = DataGridViewTriState.False;
			datatypeColumn.FlatStyle = FlatStyle.Flat;
			datatypeColumn.Width = 120;
			//
			// lengthColumn
			//
			lengthColumn.Name = "Length";
			lengthColumn.HeaderText = "길이";
			lengthColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			lengthColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			lengthColumn.ReadOnly = true;
			lengthColumn.Width = 50;
			lengthColumn.ValueType = typeof(System.Int32);
			//
			// defaultColumn
			//
			defaultColumn.Name = "Default";
			defaultColumn.HeaderText = "기본값";
			defaultColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			defaultColumn.Width = 120;
			//
			// pkColumn
			//
			pkColumn.Name = "Pk";
			pkColumn.HeaderText = "PK";
			pkColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			pkColumn.Resizable = DataGridViewTriState.False;
			pkColumn.Width = 50;
			//
			// nnColumn
			//
			nnColumn.Name = "NotNull";
			nnColumn.HeaderText = "Not Null";
			nnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			nnColumn.Resizable = DataGridViewTriState.False;
			nnColumn.Width = 80;
			//
			// unsignedColumn
			//
			unsignedColumn.Name = "Unsigned";
			unsignedColumn.HeaderText = "Unsigned";
			unsignedColumn.ReadOnly = true;
			unsignedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			unsignedColumn.Resizable = DataGridViewTriState.False;
			unsignedColumn.Width = 80;
			//
			// autoincrementColumn
			//
			autoIncrementColumn.Name = "AutoIncr";
			autoIncrementColumn.HeaderText = "Auto Incr";
			autoIncrementColumn.ReadOnly = true;
			autoIncrementColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			autoIncrementColumn.Resizable = DataGridViewTriState.False;
			autoIncrementColumn.Width = 80;
			//
			// zerofillColumn
			//
			zerofillColumn.Name = "Zerofill";
			zerofillColumn.HeaderText = "Zerofill";
			zerofillColumn.ReadOnly = true;
			zerofillColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			zerofillColumn.Resizable = DataGridViewTriState.False;
			zerofillColumn.Width = 70;
			//
			// charsetColumn
			//
			charsetColumn.Name = "Charset";
			charsetColumn.HeaderText = "문자셋";
			charsetColumn.ReadOnly = true;
			charsetColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			charsetColumn.FlatStyle = FlatStyle.Flat;
			charsetColumn.DataSource = this.m_charset;
			charsetColumn.Width = 100;
			//
			// collationColumn
			//
			collationColumn.Name = "Collation";
			collationColumn.HeaderText = "콜레이션";
			collationColumn.ReadOnly = true;
			collationColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			collationColumn.FlatStyle = FlatStyle.Flat;
			collationColumn.Width = 140;
			//
			// commentColumn
			//
			commentColumn.Name = "Comment";
			commentColumn.HeaderText = "설명";
			commentColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
			commentColumn.Width = 200;
			// 
			// TableEditor
			// 
			this.AllowUserToResizeRows = false;
			this.BackgroundColor = Color.White;
			this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			this.DefaultCellStyle.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.Dock = DockStyle.Fill;
			this.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
			this.MultiSelect = false;
			this.RowHeadersVisible = false;
			this.Columns.AddRange(
				fieldnameColumn,
				datatypeColumn,
				lengthColumn,
				defaultColumn,
				pkColumn,
				nnColumn,
				unsignedColumn,
				autoIncrementColumn,
				zerofillColumn,
				charsetColumn,
				collationColumn,
				commentColumn
				);
		}

		/// <summary>
		/// 데이터타입을 초기화합니다.
		/// </summary>
		private void InitializeDataTypes()
		{
			if(Program.ActivateCommunicator.v500) this.m_permission.Add("BIT", DataTypePermission.Len);
			this.m_permission.Add("TINYINT",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("SMALLINT",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("MEDIUMINT",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("INT",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("INTEGER",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("BIGINT",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("REAL",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("DOUBLE",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("FLOAT",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("DECIMAL",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("NUMERIC",
				DataTypePermission.Len | DataTypePermission.Unsigned |
				DataTypePermission.AutoIncrement | DataTypePermission.Zerofill);
			this.m_permission.Add("DATE", DataTypePermission.None);
			this.m_permission.Add("TIME", DataTypePermission.None);
			this.m_permission.Add("TIMESTAMP", DataTypePermission.None);
			this.m_permission.Add("DATETIME", DataTypePermission.None);
			this.m_permission.Add("YEAR", DataTypePermission.None);
			this.m_permission.Add("CHAR",
				DataTypePermission.Len | DataTypePermission.Charset | DataTypePermission.Collation);
			this.m_permission.Add("VARCHAR",
				DataTypePermission.Len | DataTypePermission.Charset | DataTypePermission.Collation);
			this.m_permission.Add("BINARY", DataTypePermission.Len);
			this.m_permission.Add("VARBINARY", DataTypePermission.Len);
			this.m_permission.Add("TINYBLOB", DataTypePermission.None);
			this.m_permission.Add("BLOB", DataTypePermission.None);
			this.m_permission.Add("MEDIUMBLOB", DataTypePermission.None);
			this.m_permission.Add("LONGBLOB", DataTypePermission.None);
			this.m_permission.Add("TINYTEXT",
				DataTypePermission.Charset | DataTypePermission.Collation);
			this.m_permission.Add("TEXT",
				DataTypePermission.Charset | DataTypePermission.Collation);
			this.m_permission.Add("MEDIUMTEXT",
				DataTypePermission.Charset | DataTypePermission.Collation);
			this.m_permission.Add("LONGTEXT",
				DataTypePermission.Charset | DataTypePermission.Collation);
			this.m_permission.Add("ENUM",
				DataTypePermission.Charset | DataTypePermission.Collation);
			this.m_permission.Add("SET",
				DataTypePermission.Charset | DataTypePermission.Collation);
		}

		/// <summary>
		/// 데이터타입 컬럼을 초기화합니다.
		/// </summary>
		private void InitializeDataTypeColumn()
		{
			foreach(string s in this.m_permission.Keys)
			{
				((DataGridViewComboBoxColumn)(this.Columns["Datatype"])).Items.Add(s);
			}
			((DataGridViewComboBoxColumn)(this.Columns["Datatype"])).Sorted = true;
			((DataGridViewComboBoxColumn)(this.Columns["Datatype"])).SortMode = DataGridViewColumnSortMode.Automatic;
		}

		/// <summary>
		/// 캐릭터셋을 읽어옵니다.
		/// </summary>
		/// <exception cref="MySqlException">
		/// 쿼리문 실행을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		private void ReadCharset()
		{
			this.m_charset.Add("DEFAULT");
			try
			{
				this.m_charset.AddRange(Program.ActivateCommunicator.GetCharset());
			}
			catch(MySqlException ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// 셀의 값, 읽기전용 속성을 컨트롤합니다.
		/// </summary>
		/// <param name="cell">컨트롤할 셀입니다.</param>
		/// <param name="read">읽기전용 여부입니다.</param>
		private void ControlCell(DataGridViewCell cell, bool read)
		{
			cell.ReadOnly = read;
		}

		/// <summary>
		/// 셀의 값, 읽기전용 속성을 컨트롤합니다.
		/// </summary>
		/// <param name="cell">컨트롤할 셀입니다.</param>
		/// <param name="val">값입니다.</param>
		/// <param name="read">읽기전용 여부입니다.</param>
		private void ControlCell(DataGridViewCell cell, object val, bool read)
		{
			cell.Value = val;
			cell.ReadOnly = read;
		}

		/// <summary>
		/// 현재 셀 위치의 행을 제거합니다.(메세지 박스로 지울지여부 물음)
		/// </summary>
		public void RemoveRow()
		{
			if(this.CurrentCell != null)
			{
				// 커밋되지 않은 열은 제거하지 못함
				if(this.CurrentCell.OwningRow.IsNewRow == false)
				{
					DialogResult result = MessageBoxEx.Show(
						this,
						Resources.Easy2Message_DeleteFieldQuestion,
						Resources.Easy2Message_Title,
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
						);
					if(result == DialogResult.Yes)
					{
						DataGridViewRow selecteRow = this.CurrentCell.OwningRow;
						this.Rows.Remove(selecteRow);
					}
				}
			}
		}

		public FieldInfo ReadField(string filed)
		{
			FieldInfo info = new FieldInfo();

			foreach(DataGridViewRow row in this.Rows)
			{
				if(row.Cells["Field"].Value.ToString() == filed)
				{
					info.FieldName = row.Cells["Field"].Value != null ?
						row.Cells["Field"].Value.ToString() : null;
					info.DataType = row.Cells["Datatype"].Value != null ?
						row.Cells["Datatype"].Value.ToString() : null;
					info.DataLength = row.Cells["Length"].Value != null ?
						row.Cells["Length"].Value.ToString() : null;
					info.DefaultValue = row.Cells["Default"].Value != null ?
						row.Cells["Default"].Value.ToString() : null;
					info.PK = row.Cells["Pk"].Value != null ?
						Boolean.Parse(row.Cells["Pk"].Value.ToString()) : false;
					info.NotNull = row.Cells["NotNull"].Value != null ?
						Boolean.Parse(row.Cells["NotNull"].Value.ToString()) : false;
					info.Unsigned = row.Cells["Unsigned"].Value != null ?
						Boolean.Parse(row.Cells["Unsigned"].Value.ToString()) : false;
					info.AutoIncrement = row.Cells["AutoIncr"].Value != null ?
						Boolean.Parse(row.Cells["AutoIncr"].Value.ToString()) : false;
					info.Zerofill = row.Cells["Zerofill"].Value != null ?
						Boolean.Parse(row.Cells["Zerofill"].Value.ToString()) : false;
					info.Charset = row.Cells["Charset"].Value != null ?
						row.Cells["Charset"].Value.ToString() : null;
					info.Collation = row.Cells["Collation"].Value != null ?
						row.Cells["Collation"].Value.ToString() : null;
					info.Comment = row.Cells["Comment"].Value != null ?
						row.Cells["Comment"].Value.ToString() : null;

					break;
				}
			}

			return info;
		}

		/// <summary>
		/// 컬럼들의 정보를 읽습니다.
		/// </summary>
		/// <returns>읽혀진 컬럼의 배열입니다.</returns>
		public FieldInfo[] ReadFields()
		{
			List<FieldInfo> columnList = new List<FieldInfo>();
			foreach(DataGridViewRow row in this.Rows)
			{
				if(row.IsNewRow != true)
				{
					FieldInfo info = new FieldInfo();
					info.FieldName = row.Cells["Field"].Value != null ?
						row.Cells["Field"].Value.ToString() : null;
					info.DataType = row.Cells["Datatype"].Value != null ?
						row.Cells["Datatype"].Value.ToString() : null;
					info.DataLength = row.Cells["Length"].Value != null ?
						row.Cells["Length"].Value.ToString() : null;
					info.DefaultValue = row.Cells["Default"].Value != null ?
						row.Cells["Default"].Value.ToString() : null;
					info.PK = row.Cells["Pk"].Value != null ?
						Boolean.Parse(row.Cells["Pk"].Value.ToString()) : false;
					info.NotNull = row.Cells["NotNull"].Value != null ?
						Boolean.Parse(row.Cells["NotNull"].Value.ToString()) : false;
					info.Unsigned = row.Cells["Unsigned"].Value != null ?
						Boolean.Parse(row.Cells["Unsigned"].Value.ToString()) : false;
					info.AutoIncrement = row.Cells["AutoIncr"].Value != null ?
						Boolean.Parse(row.Cells["AutoIncr"].Value.ToString()) : false;
					info.Zerofill = row.Cells["Zerofill"].Value != null ?
						Boolean.Parse(row.Cells["Zerofill"].Value.ToString()) : false;
					info.Charset = row.Cells["Charset"].Value != null ?
						row.Cells["Charset"].Value.ToString() : null;
					info.Collation = row.Cells["Collation"].Value != null ?
						row.Cells["Collation"].Value.ToString() : null;
					info.Comment = row.Cells["Comment"].Value != null ?
						row.Cells["Comment"].Value.ToString() : null;
					columnList.Add(info);
				}
			}
			return columnList.ToArray();
		}

		public void WriteFields(FieldInfo[] fields)
		{
			foreach(FieldInfo field in fields)
			{
				if(field.DefaultValue != null && field.DefaultValue.Length == 0)
					field.DefaultValue = "''";

				this.Rows.Add(1);
				this.Rows[this.Rows.Count - 2].Cells["Field"].Value = field.FieldName;
				this.Rows[this.Rows.Count - 2].Cells["Datatype"].Value = field.DataType.ToUpper();
				this.Rows[this.Rows.Count - 2].Cells["Length"].Value = field.DataLength;
				this.Rows[this.Rows.Count - 2].Cells["Default"].Value = field.DefaultValue;
				this.Rows[this.Rows.Count - 2].Cells["Pk"].Value = field.PK.ToString();
				this.Rows[this.Rows.Count - 2].Cells["NotNull"].Value = field.NotNull.ToString();
				this.Rows[this.Rows.Count - 2].Cells["Unsigned"].Value = field.Unsigned.ToString();
				this.Rows[this.Rows.Count - 2].Cells["AutoIncr"].Value = field.AutoIncrement.ToString();
				this.Rows[this.Rows.Count - 2].Cells["Zerofill"].Value = field.Zerofill.ToString();
				this.Rows[this.Rows.Count - 2].Cells["Charset"].Value = field.Charset.Length != 0 ? field.Charset : null;
				this.Rows[this.Rows.Count - 2].Cells["Collation"].Value = field.Collation.Length != 0 ? field.Collation : null;
				this.Rows[this.Rows.Count - 2].Cells["Comment"].Value = field.Comment;
				//this.Rows.Add(field.FieldName, field.DataType, field.DataLength, defaultValue, field.PK, field.NotNull, field.Unsigned, field.AutoIncrement, field.Zerofill, field.Charset, field.Collation, field.Comment);
			}
		}

		private Dictionary<string, DataTypePermission> m_permission = new Dictionary<string, DataTypePermission>();
		private List<string> m_charset = new List<string>();
	}
}
