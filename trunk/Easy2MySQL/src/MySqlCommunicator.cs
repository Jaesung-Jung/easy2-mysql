
// MySqlCommunicator.cs
//
using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace Easy2
{
	/// <summary>
	/// MySQL 데이터베이스와 통신을 수행하는 클래스입니다.
	/// </summary>
	public class MySqlCommunicator : IDisposable
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
		/// IDisposable 인터페이스의 구현입니다.
		/// </summary>
		public void Dispose()
		{
			if(this.m_connection != null)
				this.m_connection.Dispose();
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
		/// <param name="connectInfo">연결정보를 담고있는 객체입니다.</param>
		public void Connect(MySqlConnectInfo connectInfo)
		{
			this.m_connectInfo = connectInfo;
			Connect((new MySqlGenerator()).ConnectionString(connectInfo));
		}

		/// <summary>
		/// MySQL 서버에 연결합니다.
		/// </summary>
		/// <param name="connectionString">연결정보를 담고있는 문자열입니다.</param>
		public void Connect(string connectionString)
		{
			try
			{
				this.m_connection = new MySqlConnection(connectionString);
				this.m_connection.Open();
				Program.CoummunicatorList.Add(this);
			}
			catch(MySqlException ex)
			{
				throw ex;
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

			testConnection.Dispose();

			return message;
		}

		/// <summary>
		/// MySQL 서버와의 연결을 종료합니다.
		/// </summary>
		public void Disconnect()
		{
			Program.CoummunicatorList.Remove(this);
			if(this.m_connection != null)
			{
				this.m_connection.Dispose();
				this.m_connection = null;
			}
		}

		/// <summary>
		/// 결과값이 있는 쿼리를 실행합니다.
		/// </summary>
		/// <param name="query">쿼리문입니다.</param>
		/// <returns>쿼리문의 실행결과 객체입니다.</returns>
		public MySqlDataReader ExecuteReader(string query)
		{
			System.Console.WriteLine(query);
			MySqlCommand command = null;
			MySqlDataReader reader = null;
			try
			{
				command = new MySqlCommand(query, this.m_connection);
				reader = command.ExecuteReader();
			}
			finally
			{
				command.Dispose();
			}
			return reader;
		}

		/// <summary>
		/// 쿼리를 실행합니다.
		/// </summary>
		/// <param name="query">쿼리문입니다.</param>
		/// <returns>영향을 받은 행 갯수입니다.</returns>
		public int Execute(string query)
		{
			System.Console.WriteLine(query);
			MySqlCommand command = null;
			int affectedRow = 0;
			try
			{
				command = new MySqlCommand(query, this.m_connection);
				affectedRow = command.ExecuteNonQuery();
			}
			finally
			{
				command.Dispose();
			}
			return affectedRow;
		}

		/// <summary>
		/// 연결정보를 나타냅니다.
		/// </summary>
		public MySqlConnectInfo ConnectInfo
		{
			get { return this.m_connectInfo; }
			set { this.m_connectInfo = value; }
		}

		/// <summary>
		/// 사용중인 데이터베이스 이름을 나타냅니다.
		/// </summary>
		public string UseDatabaseName
		{
			get { return this.m_useDatabaseName; }
			set { this.m_useDatabaseName = value; }
		}

		private MySqlConnection m_connection;
		private MySqlConnectInfo m_connectInfo;
		private string m_useDatabaseName;
	}
}
