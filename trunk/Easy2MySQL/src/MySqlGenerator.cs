
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
				query = String.Format("SHOW FULL TABLES FROM {0} WHERE table_type = 'base table'", Program.ActivateCommunicator.UseDatabaseName);
			return query;
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
		/// 컬럼을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="tableName">조회할 컬럼의 테이블이름입니다.</param>
		/// <returns>컬럼을 조회하는 쿼리문입니다.</returns>
		public string ShowColumns(string tableName)
		{
			return String.Format("DESCRIBE {0}", tableName);
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
	}
}
