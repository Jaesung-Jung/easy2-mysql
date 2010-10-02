
// TableViewer.cs
//
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DevComponents.DotNetBar.Controls;

namespace Easy2.Components
{
	/// <summary>
	/// 테이블뷰어 클래스입니다.(보기 전용)
	/// </summary>
	public class TableViewer : DataGridViewX
	{
		public TableViewer()
		{
			this.AllowUserToResizeRows = false;
			this.AllowUserToAddRows = false;
			this.AllowUserToDeleteRows = false;
			this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			this.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.BackgroundColor = Color.White;
			this.Dock = DockStyle.Fill;
			this.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.MultiSelect = false;
			this.RowHeadersVisible = false;
		}

		/// <summary>
		/// 테이블에 데이터를 채웁니다.
		/// </summary>
		/// <param name="reader">데이터리더 객체입니다.</param>
		public void FillTableData(MySqlDataReader reader)
		{
			this.Columns.Clear();
			this.Rows.Clear();

			for(int i = 0; i < reader.FieldCount; i++)
			{
				string field = reader.GetName(i);
				Type fieldType = reader.GetFieldType(i);

				DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
				column.Name = field;
				column.HeaderText = field;

				// 정수형 데이터는 왼쪽정렬
				if(
					fieldType.Equals(typeof(Int16)) ||
					fieldType.Equals(typeof(Int32)) ||
					fieldType.Equals(typeof(Int64)) ||
					fieldType.Equals(typeof(UInt16)) ||
					fieldType.Equals(typeof(UInt32)) ||
					fieldType.Equals(typeof(UInt64))
					)
				{
					column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				}

				this.Columns.Add(column);
			}

			while(reader.Read())
			{
				List<string> row = new List<string>();
				for(int i = 0; i < reader.FieldCount; i++)
				{
					// 널값인 데이터는 (NULL) 문자열로 채움
					if(reader.IsDBNull(i))
						row.Add("(NULL)");
					else
						row.Add(reader.GetString(i));
				}
				this.Rows.Add(row.ToArray());
			}
		}
	}
}
