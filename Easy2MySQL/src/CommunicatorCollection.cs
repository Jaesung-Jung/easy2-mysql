
// CommunicatorCollection.cs
//
using System.Collections.Generic;

namespace Easy2
{
	/// <summary>
	/// MySqlCommunicator 컬렉션입니다.
	/// </summary>
	public class CommunicatorCollection : List<MySqlCommunicator>
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public CommunicatorCollection() {}

		/// <summary>
		/// 모든 연결을 종료합니다.
		/// </summary>
		public void DisconnectAll()
		{
			for(int i = 0 ; i < this.Count ; i++)
				this[i].Disconnect();

			this.Clear();
		}
	}
}
