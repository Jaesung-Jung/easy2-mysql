
// MySqlCommunicator.cs
//
using Easy2.Properties;
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
			Connect(MySqlGenerator.ConnectionString(this.m_connectInfo));
		}

		/// <summary>
		/// MySQL 서버에 연결합니다.
		/// </summary>
		/// <param name="connectInfo">연결정보를 담고있는 객체입니다.</param>
		public void Connect(MySqlConnectInfo connectInfo)
		{
			this.m_connectInfo = connectInfo;
			Connect(MySqlGenerator.ConnectionString(connectInfo));
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
				string serverVersion = (this.m_connection.ServerVersion.Split('-'))[0];

				if(!(serverVersion.CompareTo("4.0.2") < 0))
				{
					this.m_402version = true;
				}
				if(!(serverVersion.CompareTo("5.0") < 0))
				{
					this.m_500version = true;
				}
				if(!(serverVersion.CompareTo("5.1") < 0))
				{
					this.m_510version = true;
				}
				Program.CoummunicatorList.Add(this);
				Program.ActivateCommunicator = this;
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
			return ConnectTest(MySqlGenerator.ConnectionString(this.m_connectInfo));
		}

		/// <summary>
		/// MySQL 서버의 연결상태를 테스트합니다.
		/// </summary>
		/// <param name="connectInfo">연결 정보를 담고있는 객체입니다.</param>
		/// <returns>연결성공 메세지입니다.</returns>
		public string ConnectTest(MySqlConnectInfo connectInfo)
		{
			return ConnectTest(MySqlGenerator.ConnectionString(connectInfo));
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
				if(command != null)
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
				if(command != null)
					command.Dispose();
			}
			return affectedRow;
		}

		/// <summary>
		/// 사용자를 생성합니다.
		/// </summary>
		/// <param name="userInfo">생성할 사용자정보를 가진 객체입니다.</param>
		public void CreateUser(User userInfo)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.CreateUser(userInfo));
			this.Execute("FLUSH PRIVILEGES");
		}

		/// <summary>
		/// 사용자를 수정합니다.
		/// </summary>
		/// <param name="targetUsername">수정대상의 사용자이름입니다.</param>
		/// <param name="targetHost">수정대상의 호스트명입니다.</param>
		/// <param name="userInfo">사용자정보를 가진 객체입니다.</param>
		public void AlterUser(string targetUsername, string targetHost, User userInfo)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.AlterUser(targetUsername, targetHost, userInfo));
			this.Execute("FLUSH PRIVILEGES");
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

		/// <summary>
		/// 4.0.2버전 이후의 기능을 지원할지 여부입니다.
		/// </summary>
		public bool v402
		{
			get { return this.m_402version; }
		}

		/// <summary>
		/// 5.0버전 이후의 기능을 지원할지 여부입니다.
		/// </summary>
		public bool v500
		{
			get { return this.m_500version; }
		}

		/// <summary>
		/// 5.1버전 이후의 기능을 지원할지 여부입니다.
		/// </summary>
		public bool v510
		{
			get { return this.m_510version; }
		}

		private MySqlConnection m_connection;
		private MySqlConnectInfo m_connectInfo;
		private string m_useDatabaseName;
		private bool m_402version = false;
		private bool m_500version = false;
		private bool m_510version = false;
	}
}
