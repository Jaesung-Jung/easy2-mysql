
// ColumnPrivilege.cs
//
using System.Collections.Generic;

namespace Easy2.Classes
{
	/// <summary>
	/// 컬럼 권한정보 클래스입니다.
	/// </summary>
	public class ColumnPrivilege : TablePrivilege
	{
		/// <summary>
		/// 컬럼을 나타냅니다.
		/// </summary>
		public string ColumnName
		{
			get { return this.m_column; }
			set { this.m_column = value; }
		}

		private string m_column;
	}
}