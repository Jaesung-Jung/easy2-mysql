
// TablePrivilege.cs
//
using System.Collections.Generic;

namespace Easy2.Classes
{
	/// <summary>
	/// 테이블 권한정보 클래스입니다.
	/// </summary>
	public class TablePrivilege : DatabasePrivilege
	{
		/// <summary>
		/// 테이블을 나타냅니다.
		/// </summary>
		public string TableName
		{
			get { return this.m_table; }
			set { this.m_table = value;}
		}

		private string m_table;
	}
}