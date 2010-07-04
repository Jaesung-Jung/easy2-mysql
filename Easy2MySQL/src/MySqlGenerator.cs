
// MySqlGenerator.cs
//
using System;
using System.Text;

namespace Easy2
{
	/// <summary>
	/// MySqlCommunicator 클래스와 통신을 수행하는 명령코드를 만드는 클래스입니다.
	/// </summary>
	class MySqlGenerator
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public MySqlGenerator() { }

		/// <summary>
		/// 연결정보 문자열을 생성합니다.
		/// </summary>
		/// <param name="connectInfo">연결정보 객체입니다.</param>
		/// <returns>연결정보 문자열입니다.</returns>
		public string ConnectionString(MySqlConnectInfo connectInfo)
		{
			string connectionString = String.Format(
				"server={0};port={1};user id={2};password={3};database={4};Connect Timeout={5}",
				connectInfo.Host, connectInfo.Port, connectInfo.Username,
				connectInfo.Password, connectInfo.Database, connectInfo.ConnectTimeout);

			return connectionString;
		}

		/// <summary>
		/// 사용할 데이터베이스를 지정하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">사용할 데이터베이스의 이름입니다.</param>
		/// <returns>사용할 데이터베이스를 지정하는 쿼리문입니다.</returns>
		public string UseDatabase(string databaseName)
		{
			return String.Format("USE {0}", databaseName);
		}

		/// <summary>
		/// 데이터베이스를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>데이터베이를 조회하는 쿼리문입니다.</returns>
		public string ShowDatabases()
		{
			return "SHOW DATABASES";
		}

		/// <summary>
		/// 테이블을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>테이블을 조회하는 쿼리문입니다.</returns>
		public string ShowTables(string databaseName)
		{
			// SHOW FULL TABLES FROM {db_name} WHERE table_type = 'base table'
			string query;
			if(databaseName == "information_schema")
				query = String.Format("SHOW TABLES FROM {0}", databaseName);
			else
				query = String.Format("SHOW FULL tables FROM {0} WHERE table_type='base table'", Program.ActivateCommunicator.UseDatabaseName);
			return query;
		}

		/// <summary>
		/// 뷰를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">뷰를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>뷰를 조회하는 쿼리문입니다.</returns>
		public string ShowViews(string databaseName)
		{
			// SELECT `TABLE_NAME` FROM `INFORMATION_SCHEMA`.`TABLES` WHERE `TABLE_SCHEMA` = 'messenger' AND `TABLE_TYPE` = 'VIEW';
			return String.Format("SELECT table_name FROM information_schema.tables WHERE table_schema='{0}' AND table_type='VIEW'", databaseName);
		}

		/// <summary>
		/// 저장 프로시저를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">저장 프로시저를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>저장 프로시저를 조회하는 쿼리문입니다.</returns>
		public string ShowStoredProcs(string databaseName)
		{
			// SELECT `SPECIFIC_NAME` FROM `INFORMATION_SCHEMA`.`ROUTINES` WHERE `ROUTINE_SCHEMA` = 'messenger' AND ROUTINE_TYPE = 'PROCEDURE';
			return String.Format("SELECT specific_name FROM information_schema.routines WHERE routine_schema='{0}' AND routine_type='PROCEDURE'", databaseName);
		}

		/// <summary>
		/// 함수를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">함수를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>함수를 조회하는 쿼리문입니다.</returns>
		public string ShowFunctions(string databaseName)
		{
			return String.Format("SELECT specific_name FROM information_schema.routines WHERE routine_schema='{0}' AND routine_type='FUNCTION'", databaseName);
		}

		/// <summary>
		/// 트리거를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">트리거를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>트리거는 조회하는 쿼리문입니다.</returns>
		public string ShowTriggers(string databaseName)
		{
			// SELECT `TRIGGER_NAME` FROM `INFORMATION_SCHEMA`.`TRIGGERS` WHERE `TRIGGER_SCHEMA` = 'messenger';
			return String.Format("SELECT trigger_name FROM information_schema.triggers WHERE trigger_schema='{0}'", databaseName);
		}

		/// <summary>
		/// 이벤트를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">이벤트를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>이벤트를 조회하는 쿼리문입니다.</returns>
		public string ShowEvents(string databaseName)
		{
			// SELECT `EVENT_NAME` FROM `INFORMATION_SCHEMA`.`EVENTS` WHERE `EVENT_SCHEMA` = 'messenger' ORDER BY EVENT_NAME;
			return String.Format("SELECT event_name FROM information_schema.events WHERE event_schema='{0}' ORDER BY event_name", databaseName);
		}

		/// <summary>
		/// 컬럼을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="tableName">조회할 컬럼의 테이블이름입니다.</param>
		/// <returns>컬럼을 조회하는 쿼리문입니다.</returns>
		public string ShowColumns(string tableName)
		{
			return String.Format("DESCRIBE {0}", tableName);
		}

		/// <summary>
		/// 인덱스를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="tableName">조회할 인덱스의 테이블이름입니다.</param>
		/// <returns>인덱스를 조회하는 쿼리문입니다.</returns>
		public string ShowIndexes(string tableName)
		{
			return String.Format("SHOW INDEX FROM {0}", tableName);
		}

		/// <summary>
		/// 트리에 표시할 행문자열을 생성합니다.
		/// </summary>
		/// <param name="columnInfo">컬럼정보를 가지는 배열입니다.</param>
		/// <returns>트리에 표시할 행문자열입니다.</returns>
		public string MakeColumnInfo(string[] columnInfo)
		{
			string columnText = String.Format("{0}, {1}", columnInfo[0], columnInfo[1]);
			if(columnInfo[2] == "YES")
				columnText += ", Nullable";

			return columnText;
		}

		/// <summary>
		/// 트리에 표시할 인덱스문자열을 생성합니다.
		/// </summary>
		/// <param name="keyName">인덱스 키 이름입니다.</param>
		/// <param name="columnName">인덱스 컬럼 이름입니다.</param>
		/// <returns>트리에 표시할 인덱스문자열입니다.</returns>
		public string MakeIndexInfo(string keyName, string columnName)
		{
			return String.Format("{0}({1})", keyName, columnName);
		}
	}
}
