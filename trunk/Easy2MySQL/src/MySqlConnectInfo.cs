
// MySqlConnectInfo
//

namespace Easy2
{
	/// <summary>
	/// 연결정보를 저장하는 클래스입니다.
	/// </summary>
	public class MySqlConnectInfo
	{
		/// <summary>
		/// 연결명을 나타냅니다.
		/// </summary>
		public string ConnectName
		{
			get { return this.m_connectName; }
			set { this.m_connectName = value; }
		}

		/// <summary>
		/// 호소트명을 나타냅니다.
		/// </summary>
		public string Host
		{
			get { return this.m_host; }
			set { this.m_host = value; }
		}

		/// <summary>
		/// 사용자명을 나타냅니다.
		/// </summary>
		public string Username
		{
			get { return this.m_username; }
			set { this.m_username = value; }
		}

		/// <summary>
		/// 비밀번호를 나타냅니다.
		/// </summary>
		public string Password
		{
			get { return this.m_password; }
			set { this.m_password = value; }
		}

		/// <summary>
		/// 포트번호를 나타냅니다.
		/// </summary>
		public string Port
		{
			get { return this.m_port; }
			set { this.m_port = value; }
		}

		/// <summary>
		/// 사용할 데이터베이스를 나타냅니다.
		/// </summary>
		public string Database
		{
			get { return this.m_database; }
			set { this.m_database = value; }
		}

		/// <summary>
		/// 연결대기시간을 나타냅니다.
		/// </summary>
		public string ConnectTimeout
		{
			get { return this.m_timeout; }
			set { this.m_timeout = value; }
		}

		private string m_connectName = "";
		private string m_host = "localhost";
		private string m_username = "";
		private string m_password = "";
		private string m_port = "3306";
		private string m_database = "";
		private string m_timeout = "15";
	}
}
