
// MySqlConnectInfo
//

namespace Easy2
{
	/// <summary>
	/// 연결정보를 저장하는 클래스입니다.
	/// </summary>
	public class MySqlConnectInfo
	{
		public string Host
		{
			get { return this.m_host; }
			set { this.m_host = value; }
		}

		public string Username
		{
			get { return this.m_username; }
			set { this.m_username = value; }
		}

		public string Password
		{
			get { return this.m_password; }
			set { this.m_password = value; }
		}

		public int Port
		{
			get { return this.m_port; }
			set { this.m_port = value; }
		}

		public string Database
		{
			get { return this.m_database; }
			set { this.m_database = value; }
		}

		public int ConnectTimeout
		{
			get { return this.m_timeout; }
			set { this.m_timeout = value; }
		}

		private string m_host;
		private string m_username;
		private string m_password;
		private int m_port;
		private string m_database;
		private int m_timeout;
	}
}
