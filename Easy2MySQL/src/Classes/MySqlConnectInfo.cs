﻿
// MySqlConnectInfo
//

namespace Easy2.Classes
{
	/// <summary>
	/// 연결정보를 저장하는 클래스입니다.
	/// </summary>
	public class MySqlConnectInfo
	{
		/// <summary>
		/// MySqlConnectInfo 인스턴스를 초기화합니다.
		/// </summary>
		public MySqlConnectInfo()
			: this("", "localhost", "", "", "3306", "", "15") {}

		/// <summary>
		/// 지정된 연결이름을 가지는 MySqlConnectInfo 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="connectName"></param>
		public MySqlConnectInfo(string connectName)
			: this(connectName, "localhost", "", "", "3306", "", "15") {}

		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="connectName">연결명입니다.</param>
		/// <param name="host">호스트이름입니다.</param>
		/// <param name="username">사용자이름입니다.</param>
		/// <param name="password">비밀번호입니다.</param>
		/// <param name="port">포트번호입니다.</param>
		/// <param name="database">사용할 데이터베이스이름입니다.</param>
		/// <param name="timeout">연결대기시간입니다.</param>
		public MySqlConnectInfo(
			string connectName,
			string host,
			string username,
			string password,
			string port,
			string database,
			string timeout
			)
		{
			this.m_connectName = connectName;
			this.m_host = host;
			this.m_username = username;
			this.m_password = password;
			this.m_port = port;
			this.m_database = database;
			this.m_timeout = timeout;
		}

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

		private string m_connectName;
		private string m_host;
		private string m_username;
		private string m_password;
		private string m_port;
		private string m_database;
		private string m_timeout;
	}
}
