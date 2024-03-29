﻿
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
		/// MySQL 내부캐쉬를 비웁니다.
		/// </summary>
		public void FlushPrivileges()
		{
			Execute(MySqlGenerator.FlushPrivileges());
		}

		/// <summary>
		/// 참조 무결성 체크 여부를 설정합니다.
		/// </summary>
		/// <param name="b">체크 여부입니다.</param>
		public void SetForeignKeyChecks(bool b)
		{
			Execute(MySqlGenerator.SetForeignKeyChecks(b));
		}

		/// <summary>
		/// 문자셋을 가져옵니다.
		/// </summary>
		/// <returns>캐릭터셋의 배열입니다.</returns>
		public string[] GetCharset()
		{
			List<string> charset = new List<string>();
			MySqlDataReader reader = null;
			try
			{
				reader = ExecuteReader(MySqlGenerator.ShowCharset());
				while(reader.Read())
				{
					charset.Add(reader["Charset"].ToString());
				}
				reader.Close();
				charset.Sort();
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}

			return charset.ToArray();
		}

		/// <summary>
		/// 컬레이션에 해당하는 문자셋을 가져옵니다.
		/// </summary>
		/// <param name="collation">컬레이션입니다.</param>
		/// <returns>문자셋입니다.</returns>
		public string GetCharset(string collation)
		{
			MySqlDataReader reader = null;
			string charset = null;
			try
			{
				reader = ExecuteReader(MySqlGenerator.ShowCharset(collation, false));
				reader.Read();

				charset = reader["character_set_name"].ToString();

				reader.Close();
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}

			return charset;
		}

		/// <summary>
		/// 문자셋의 대한 설명을 가져옵니다.
		/// </summary>
		/// <param name="charset">해당하는 문자셋입니다.</param>
		/// <returns>문자셋에 대한 설명입니다.</returns>
		public string GetDescription(string charset)
		{
			string description;
			MySqlDataReader reader = null;
			try
			{
				reader = ExecuteReader(MySqlGenerator.ShowCharset(charset));
				reader.Read();
				description = reader["Description"].ToString();
				reader.Close();
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}

			return description;
		}

		/// <summary>
		/// 콜레이션을 가져옵니다.
		/// </summary>
		/// <param name="charset">해당하는 문자셋입니다.</param>
		/// <returns>문자셋에 대한 콜레이션 배열입니다.</returns>
		public string[] GetCollation(string charset)
		{
			List<string> collation = new List<string>();
			MySqlDataReader reader = null;
			try
			{
				reader = ExecuteReader(MySqlGenerator.ShowCollation(charset));
				while(reader.Read())
				{
					collation.Add(reader["Collation"].ToString());
				}
				reader.Close();
				collation.Sort();
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
			return collation.ToArray();
		}

		/// <summary>
		/// MySQL 데이터베이스의 엔진들을 가져옵니다.
		/// </summary>
		/// <returns>데이터베이스의 엔진들입니다.</returns>
		public string[] GetEngines()
		{
			List<string> engines = new List<string>();
			MySqlDataReader reader = null;
			try
			{
				reader = ExecuteReader(MySqlGenerator.ShowEngines());
				while(reader.Read())
				{
					if(reader["Support"].ToString() != "NO")
					{
						engines.Add(reader["Engine"].ToString());
					}
				}
				reader.Close();
				engines.Sort();
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
			return engines.ToArray();
		}

		/// <summary>
		/// 사용할 데이터베이스를 지정합니다.
		/// </summary>
		/// <param name="databaseName">사용할 데이터베이스의 이름입니다.</param>
		public void UseDatabase(string databaseName)
		{
			Execute(MySqlGenerator.UseDatabase(databaseName));
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
			Execute(MySqlGenerator.CreateUser(userInfo));
			FlushPrivileges();
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
			Execute(MySqlGenerator.AlterUser(targetUsername, targetHost, userInfo));
			FlushPrivileges();
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
			Execute(MySqlGenerator.DeleteUser(targetUsername, targetHost));
			FlushPrivileges();
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
			Execute(MySqlGenerator.CreateDatabase(dbname));
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
			Execute(MySqlGenerator.CreateDatabase(dbname, charset, collation));
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
			Execute(MySqlGenerator.AlterDatabase(dbname, charset, collation));
		}

		/// <summary>
		/// 데이터베이스를 제거합니다.
		/// </summary>
		/// <param name="dbname">제거할 데이터베이스입니다.</param>
		public void DropDatabase(string dbname)
		{
			Execute(MySqlGenerator.DropDatabase(dbname));
		}

		/// <summary>
		/// 데이터베이스 내의 모든 오브젝트를 제거합니다.
		/// </summary>
		/// <param name="dbname">제거할 오브젝트를 소유한 데이터베이스입니다.</param>
		/// <param name="dropTables">테이블 제거여부입니다.</param>
		/// <param name="dropViews">뷰 제거여부입니다.</param>
		/// <param name="dropProcs">프로시저 제거여부입니다.</param>
		/// <param name="dropFuncs">함수 제거여부입니다.</param>
		/// <param name="dropEvents">이벤트 제거여부입니다.</param>
		/// <param name="dropTriggers">트리거 제거여부입니다.</param>
		public void TrucateDatabase(
			string dbname,
			bool dropTables,
			bool dropViews,
			bool dropProcs,
			bool dropFuncs,
			bool dropEvents,
			bool dropTriggers)
		{
			MySqlDataReader reader = null;
			List<string> tables = new List<string>();
			List<string> views = new List<string>();
			List<string> procs = new List<string>();
			List<string> funcs = new List<string>();
			List<string> events = new List<string>();
			List<string> triggers = new List<string>();

			try
			{
				SetForeignKeyChecks(false);

				if(dropTables)
				{
					reader = ExecuteReader(MySqlGenerator.ShowTables(dbname));
					while(reader.Read())
						tables.Add(reader[0].ToString());
					reader.Close();
				}

				if(dropViews)
				{
					reader = ExecuteReader(MySqlGenerator.ShowViews(dbname));
					while(reader.Read())
						views.Add(reader[0].ToString());
					reader.Close();
				}

				if(dropProcs)
				{
					reader = ExecuteReader(MySqlGenerator.ShowStoredProcs(dbname));
					while(reader.Read())
						procs.Add(reader[0].ToString());
					reader.Close();
				}

				if(dropFuncs)
				{
					reader = ExecuteReader(MySqlGenerator.ShowFunctions(dbname));
					while(reader.Read())
						funcs.Add(reader[0].ToString());
					reader.Close();
				}

				if(dropEvents)
				{
					reader = ExecuteReader(MySqlGenerator.ShowEvents(dbname));
					while(reader.Read())
						events.Add(reader[0].ToString());
					reader.Close();
				}

				if(dropTriggers)
				{
					reader = ExecuteReader(MySqlGenerator.ShowTriggers(dbname));
					while(reader.Read())
						triggers.Add(reader[0].ToString());
					reader.Close();
				}

				Execute(MySqlGenerator.TrucateDatabase(
					dbname, tables.ToArray(), views.ToArray(), procs.ToArray(), funcs.ToArray(), events.ToArray(), triggers.ToArray())
					);

				SetForeignKeyChecks(true);
			}
			finally
			{
				if(reader != null)
					reader.Close();
			}
		}

		/// <summary>
		/// 데이터베이스 권한을 갱신합니다.
		/// </summary>
		/// <param name="host">호스트입니다.</param>
		/// <param name="user">사용자입니다.</param>
		/// <param name="db_privileges">터이터베이스 권한정보를 가진 객체 배열입니다.</param>
		/// <param name="table_privileges">테이블 권한정보를 가진 객체 배열입니다.</param>
		/// <param name="column_privileges">컬럼 권한정보를 가진 객체 배열입니다.</param>
		/// <param name="routine_privileges">루틴 퀀한정보를 가진 객체 배열입니다.</param>
		public void UpdatePrivilege(
			string host,
			string user,
			DatabasePrivilege[] db_privileges,
			TablePrivilege[] table_privileges,
			ColumnPrivilege[] column_privileges,
			RoutinePrivilege[] routine_privileges
			)
		{
			Execute(MySqlGenerator.DeletePrivileges(host, user));
			FlushPrivileges();

			foreach(DatabasePrivilege db_priv in db_privileges)
				Execute(MySqlGenerator.UpdateDatabasePrivilege(host, user, db_priv));

			foreach(TablePrivilege table_priv in table_privileges)
				Execute(MySqlGenerator.UpdateTablePrivilege(host, user, table_priv));

			foreach(ColumnPrivilege column_priv in column_privileges)
				Execute(MySqlGenerator.UpdateColumnPrivilege(host, user, column_priv));

			foreach(RoutinePrivilege routine_priv in routine_privileges)
				Execute(MySqlGenerator.UpdateRoutinePrivilege(host, user, routine_priv));

			if(column_privileges.Length != 0)
			{
				Execute(MySqlGenerator.UpdateColumnPrivilegeInTablesPriv(
					host,
					user,
					column_privileges
					));
			}
			FlushPrivileges();
		}

		/// <summary>
		/// 테이블을 생성합니다.
		/// </summary>
		/// <param name="database">테이블을 소유할 데이터베이스입니다.</param>
		/// <param name="table">테이블 이름입니다.</param>
		/// <param name="fields">컬럼정보 배열의 객체입니다.</param>
		/// <param name="option">테이블옵션 객체입니다.</param>
		public void CreateTable(string database, string table, FieldInfo[] fields, TableOption option)
		{
			Execute(MySqlGenerator.CreateTable(database, table, fields, option));
		}

		/// <summary>
		/// 테이블을 수정합니다.
		/// </summary>
		/// <param name="database">수정할 테이블을 소유한 데이터베이스입니다.</param>
		/// <param name="table">수정할 테이블입니다.</param>
		/// <param name="addedFields">추가된 필드들의 정보입니다.</param>
		/// <param name="modifiedFields">수정된 필드들의 정보입니다.</param>
		/// <param name="removedFields">삭제된 필드들의 이름입니다.</param>
		/// <param name="primaryFields">프라이머리키 필드들의 이름입니다.</param>
		/// <param name="isChangePrimaryKey">프라이머리키를 변경할지의 여부입니다.</param>
		/// <param name="isDropPrimaryKey">프라이머리키를 지울지의 여부입니다.</param>
		/// <param name="isChangeTableOption">테이블 옵션을 변경할지의 여부입니다.</param>
		/// <param name="option">테이블 고급옵션 입니다.</param>
		public void AlterTable(string database, string table, FieldInfo[] addedFields, FieldInfo[] modifiedFields, string[] removedFields, string[] primaryFields, bool isChangePrimaryKey, bool isDropPrimaryKey, TableOption option, bool isChangeTableOption)
		{
			Execute(MySqlGenerator.AlterTable(database, table, addedFields, modifiedFields, removedFields, primaryFields, isChangePrimaryKey, isDropPrimaryKey, option, isChangeTableOption));
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
