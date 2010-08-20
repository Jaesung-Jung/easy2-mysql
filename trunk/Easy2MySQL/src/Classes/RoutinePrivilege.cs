
// RoutinePrivilege.cs
//
using System.Collections.Generic;

namespace Easy2.Classes
{
	/// <summary>
	/// 루틴 권한정보 클래스입니다.
	/// </summary>
	public class RoutinePrivilege : DatabasePrivilege
	{
		public enum RoutineType { PROCEDURE, FUNCTION }

		/// <summary>
		/// 루틴을 나타냅니다.
		/// </summary>
		public string RoutineName
		{
			get { return this.m_routine; }
			set { this.m_routine = value; }
		}

		/// <summary>
		/// 루틴의 타입을 나타냅니다.
		/// </summary>
		public RoutineType Type
		{
			get { return this.m_type; }
			set { this.m_type = value; }
		}

		private string m_routine;
		private RoutineType m_type;
	}
}