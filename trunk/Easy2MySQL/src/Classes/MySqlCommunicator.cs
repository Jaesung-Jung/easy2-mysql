
// MySqlCommunicator.cs
//
using Easy2.Properties;
using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace Easy2.Classes
{
	/// <summary>
	/// 데이터베이스와 연결되어 통신을 수행합니다.
	/// </summary>
	public class MySqlCommunicator : IDisposable
	{
		/// <summary>
		/// MySqlCommunicator 클래스의 인스턴스를 초기화합니다.
		/// </summary>
		public MySqlCommunicator() {}

		/// <summary>
		/// 지정된 연결정보를 가지는 클래스의 인스턴스를 초기화합니다.
		/// </summary>
		/// <param name="connectInfo">연결정보 객체입니다.</param>
		public MySqlCommunicator(MySqlConnectInfo connectInfo)
		{
			this.m_connectInfo = connectInfo;
		}

		/// <summary>
		/// 관리되지 않는 리소스의 확보, 해제 또는 다시 설정과 관련된 응용 프로그램 정의 작업을 수행합니다.
		/// </summary>
		public void Dispose()
		{
			if(this.m_connection != null)
				this.m_connection.Dispose();
		}

		/// <summary>
		/// MySQL 데이터베이스에 연결합니다.
		/// </summary>
		/// <exception cref="MySqlException">
		/// 연결에 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public void Connect()
		{
			Connect(MySqlGenerator.ConnectionString(this.m_connectInfo));
		}

		/// <summary>
		/// 지정된 연결정보로 MySQL 데이터베이스에 연결합니다.
		/// </summary>
		/// <param name="connectInfo">연결정보 객체입니다.</param>
		/// <exception cref="MySqlException">
		/// 연결에 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public void Connect(MySqlConnectInfo connectInfo)
		{
			this.m_connectInfo = connectInfo;
			Connect(MySqlGenerator.ConnectionString(connectInfo));
		}

		/// <summary>
		/// 지정된 연결정보 문자열로 MySQL 데이터베이스 연결합니다.
		/// </summary>
		/// <param name="connectionString">연결정보 문자열입니다.</param>
		/// <exception cref="MySqlException">
		/// 연결에 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
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
		/// MySQL 서버에 연결이 가능한지 여부를 테스트합니다.
		/// </summary>
		/// <returns>연결테스트를 한 데이터베이스의 서버이름과 버전정보입니다.</returns>
		/// <exception cref="MySqlException">
		/// 연결에 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public string ConnectTest()
		{
			return ConnectTest(MySqlGenerator.ConnectionString(this.m_connectInfo));
		}

		/// <summary>
		/// 지정된 연결정보로 MySQL 서버에 연결이 가능한지 여부를 테스트합니다.생
		/// </summary>
		/// <param name="connectInfo">연결정보 객체입니다.</param>
		/// <returns>연결테스트를 한 데이터베이스의 서버이름과 버전정보입니다.</returns>
		/// <exception cref="MySqlException">
		/// 연결에 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public string ConnectTest(MySqlConnectInfo connectInfo)
		{
			return ConnectTest(MySqlGenerator.ConnectionString(connectInfo));
		}

		/// <summary>
		/// 지정된 연결문자열로 MySQL 서버에 연결이 가능한지 여부를 테스트합니다.
		/// </summary>
		/// <param name="connectionString">연결정보 문자열입니다.</param>
		/// <returns>연결테스트를 한 데이터베이스의 서버이름과 버전정보입니다.</returns>
		/// <exception cref="MySqlException">
		/// 연결에 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
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
		/// 결과값이 있는 쿼리문을 실행합니다.
		/// </summary>
		/// <param name="query">실행할 쿼리문입니다.</param>
		/// <returns>쿼리문의 실행결과 객체입니다.</returns>
		/// <exception cref="MySqlException">
		/// 쿼리문 실행을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
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
		/// 쿼리문을 실행합니다.
		/// </summary>
		/// <param name="query">쿼리문입니다.</param>
		/// <returns>영향을 받은 행 갯수입니다.</returns>
		/// <exception cref="MySqlException">
		/// 쿼리문 실행을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
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
		/// 사용할 데이터베이스를 지정합니다.
		/// </summary>
		/// <param name="databaseName">사용할 데이터베이스의 이름입니다.</param>
		public void UseDatabase(string databaseName)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.UseDatabase(databaseName));
		}

		/// <summary>
		/// 사용자를 생성합니다.
		/// </summary>
		/// <param name="userInfo">생성할 사용자정보를 가진 객체입니다.</param>
		/// <exception cref="MySqlException">
		/// 사용자생성을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public void CreateUser(User userInfo)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.CreateUser(userInfo));
		}

		/// <summary>
		/// 사용자를 수정합니다.
		/// </summary>
		/// <param name="targetUsername">수정대상의 사용자이름입니다.</param>
		/// <param name="targetHost">수정대상의 호스트명입니다.</param>
		/// <param name="userInfo">새로운 사용자정보를 가진 객체입니다.</param>
		/// <exception cref="MySqlException">
		/// 사용자수정을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public void AlterUser(string targetUsername, string targetHost, User userInfo)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.AlterUser(targetUsername, targetHost, userInfo));
		}

		/// <summary>
		/// 사용자를 제거합니다.
		/// </summary>
		/// <param name="targetUsername">제거대상의 사용자이름입니다.</param>
		/// <param name="targetHost">제거대상의 호스트명입니다.</param>
		/// <exception cref="MySqlException">
		/// 사용자제거에 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public void DeleteUser(string targetUsername, string targetHost)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.DeleteUser(targetUsername, targetHost));
		}

		/// <summary>
		/// 데이터베이스를 생성합니다.
		/// </summary>
		/// <param name="dbname">생성할 데이터베이스 이름입니다.</param>
		/// <exception cref="MySqlException">
		/// 데이터베이스 생성을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public void CreateDatabase(string dbname)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.CreateDatabase(dbname));
		}

		/// <summary>
		/// 데이터베이스를 생성합니다.
		/// </summary>
		/// <param name="dbname">생성할 데이터베이스 이름입니다.</param>
		/// <param name="charset">문자셋입니다.</param>
		/// <param name="collation">컬레이션입니다.</param>
		/// <exception cref="MySqlException">
		/// 데이터베이스 생성을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public void CreateDatabase(string dbname, string charset, string collation)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.CreateDatabase(dbname, charset, collation));
		}

		/// <summary>
		/// 데이터베이스를 수정합니다.
		/// </summary>
		/// <param name="dbname">수정할 데이터베이스 이름입니다.</param>
		/// <param name="charset">문자셋입니다.</param>
		/// <param name="collation">컬레이션입니다.</param>
		/// <exception cref="MySqlException">
		/// 데이터베이스 수정을 실패하였을 경우 MySqlException 예외가 발생됩니다.
		/// </exception>
		public void AlterDatabase(string dbname, string charset, string collation)
		{
			Program.ActivateCommunicator.Execute(MySqlGenerator.AlterDatabase(dbname, charset, collation));
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
