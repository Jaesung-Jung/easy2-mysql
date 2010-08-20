
// DatabasePrivilege.cs
//
using System.Collections.Generic;

namespace Easy2.Classes
{
	/// <summary>
	/// 데이터베이스 권한정보 클래스입니다.
	/// </summary>
	public class DatabasePrivilege
	{
		/// <summary>
		/// 데이터베이스를 나타냅니다.
		/// </summary>
		public string Db
		{
			get { return this.m_db; }
			set { this.m_db = value; }
		}

		/// <summary>
		/// 권한들을 나타냅니다.
		/// </summary>
		public List<string> Privileges
		{
			get { return this.m_privileges; }
		}

		string m_db;
		List<string> m_privileges = new List<string>();
	}
}