
// MySqlCommunicator.cs
//
using System;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace Easy2
{
	/// <summary>
	/// MySQL 데이터베이스와 통신을 수행하는 클래스입니다.
	/// </summary>
	public class MySqlCommunicator
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public MySqlCommunicator() {}

		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="connectInfo">연결정보 객체입니다.</param>
		public MySqlCommunicator(MySqlConnectInfo connectInfo)
		{
			this.m_connectInfo = connectInfo;
		}

		/// <summary>
		/// 연결정보입니다.
		/// </summary>
		public MySqlConnectInfo ConnectInfo
		{
			get { return this.m_connectInfo; }
			set { this.m_connectInfo = value; }
		}

		/// <summary>
		/// MySQL 서버에 연결합니다.
		/// </summary>
		public void Connect()
		{
			Connect((new MySqlGenerator()).ConnectionString(this.m_connectInfo));
		}

		/// <summary>
		/// MySQL 서버에 연결합니다.
		/// </summary>
		/// <param name="connectInfo"></param>
		public void Connect(MySqlConnectInfo connectInfo)
		{
			Connect((new MySqlGenerator()).ConnectionString(connectInfo));
		}

		/// <summary>
		/// MySQL 서버에 연결합니다.
		/// </summary>
		/// <param name="connectionString">연결정보를 담고있는 문자열입니다.</param>
		public void Connect(string connectionString)
		{
			if(m_connection == null)
			{
				try
				{
					m_connection = new MySqlConnection(connectionString);
					m_connection.Open();
					m_connection.Close();	// 임시코드
					m_connection = null;	// 임시코드
				}
				catch(MySqlException ex)
				{
					m_connection = null;
					throw ex;
				}
			}
		}

		/// <summary>
		/// MySQL 서버의 연결상태를 테스트합니다.
		/// </summary>
		/// <returns>연결성공 메세지입니다.</returns>
		public string ConnectTest()
		{
			return ConnectTest((new MySqlGenerator()).ConnectionString(this.m_connectInfo));
		}

		/// <summary>
		/// MySQL 서버의 연결상태를 테스트합니다.
		/// </summary>
		/// <param name="connectInfo">연결 정보를 담고있는 객체입니다.</param>
		/// <returns>연결성공 메세지입니다.</returns>
		public string ConnectTest(MySqlConnectInfo connectInfo)
		{
			this.m_connectInfo = connectInfo;
			return ConnectTest((new MySqlGenerator()).ConnectionString(connectInfo));
		}

		/// <summary>
		/// MySQL 서버의 연결상태를 테스트합니다.
		/// </summary>
		/// <param name="connectionString">연결정보를 담고있는 문자열입니다.</param>
		/// <returns>연결성공 메세지입니다.</returns>
		public string ConnectTest(string connectionString)
		{
			MySqlConnection testConnection = new MySqlConnection(connectionString);
			testConnection.Open();

			string message = String.Format("MySQL Server {0}", testConnection.ServerVersion);

			testConnection.Close();

			return message;
		}

		private MySqlConnection m_connection;
		private MySqlConnectInfo m_connectInfo;
	}
}
