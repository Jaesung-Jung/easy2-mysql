
// CommunicatorCollection.cs
//
using System;
using System.Collections.Generic;

namespace Easy2.Classes
{
	/// <summary>
	/// 인덱스로 액세스할 수 있는 MySqlCommunicator 목록을 나타냅니다.
	/// </summary>
	public class CommunicatorCollection : List<MySqlCommunicator>, IDisposable
	{
		/// <summary>
		/// 비어 있는 상태에서 기본 초기 용량을 가지는 CommunicatorCollection 인스턴스를 초기화합니다.
		/// </summary>
		public CommunicatorCollection() {}

		/// <summary>
		/// 관리되지 않는 리소스의 확보, 해제 또는 다시 설정과 관련된 응용 프로그램 정의 작업을 수행합니다.
		/// </summary>
		public void Dispose()
		{
			foreach(MySqlCommunicator c in this)
				c.Dispose();
		}

		/// <summary>
		/// 관리되지 않는 모든 리소스의 확보, 해제 또는 다시 설정과 관련된 응용 프로그램 정의 작업을 수행합니다.
		/// </summary>
		public void DisconnectAll()
		{
			for(int i = 0 ; i < this.Count ; i++)
				this[i].Disconnect();

			this.Clear();
		}
	}
}
