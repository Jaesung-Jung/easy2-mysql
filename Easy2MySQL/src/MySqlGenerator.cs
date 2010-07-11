
// MySqlGenerator.cs
//
using System;
using System.Text;

namespace Easy2
{
	/// <summary>
	/// MySqlCommunicator 클래스와 통신을 수행하는 명령코드를 만드는 클래스입니다.
	/// </summary>
	public class MySqlGenerator
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
		public static string ConnectionString(MySqlConnectInfo connectInfo)
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
		public static string UseDatabase(string databaseName)
		{
			return String.Format("USE {0}", databaseName);
		}

		/// <summary>
		/// 데이터베이스를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>데이터베이를 조회하는 쿼리문입니다.</returns>
		public static string ShowDatabases()
		{
			return "SHOW DATABASES";
		}

		/// <summary>
		/// 테이블을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>테이블을 조회하는 쿼리문입니다.</returns>
		public static string ShowTables(string databaseName)
		{
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
		public static string ShowViews(string databaseName)
		{
			return String.Format("SELECT table_name FROM information_schema.tables WHERE table_schema='{0}' AND table_type='VIEW'", databaseName);
		}

		/// <summary>
		/// 저장 프로시저를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">저장 프로시저를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>저장 프로시저를 조회하는 쿼리문입니다.</returns>
		public static string ShowStoredProcs(string databaseName)
		{
			return String.Format("SELECT specific_name FROM information_schema.routines WHERE routine_schema='{0}' AND routine_type='PROCEDURE'", databaseName);
		}

		/// <summary>
		/// 함수를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">함수를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>함수를 조회하는 쿼리문입니다.</returns>
		public static string ShowFunctions(string databaseName)
		{
			return String.Format("SELECT specific_name FROM information_schema.routines WHERE routine_schema='{0}' AND routine_type='FUNCTION'", databaseName);
		}

		/// <summary>
		/// 트리거를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">트리거를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>트리거는 조회하는 쿼리문입니다.</returns>
		public static string ShowTriggers(string databaseName)
		{
			return String.Format("SELECT trigger_name FROM information_schema.triggers WHERE trigger_schema='{0}'", databaseName);
		}

		/// <summary>
		/// 이벤트를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">이벤트를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>이벤트를 조회하는 쿼리문입니다.</returns>
		public static string ShowEvents(string databaseName)
		{
			return String.Format("SELECT event_name FROM information_schema.events WHERE event_schema='{0}' ORDER BY event_name", databaseName);
		}

		/// <summary>
		/// 컬럼을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="tableName">조회할 컬럼의 테이블이름입니다.</param>
		/// <returns>컬럼을 조회하는 쿼리문입니다.</returns>
		public static string ShowColumns(string tableName)
		{
			return String.Format("DESCRIBE {0}", tableName);
		}

		/// <summary>
		/// 인덱스를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="tableName">조회할 인덱스의 테이블이름입니다.</param>
		/// <returns>인덱스를 조회하는 쿼리문입니다.</returns>
		public static string ShowIndexes(string tableName)
		{
			return String.Format("SHOW INDEX FROM {0}", tableName);
		}

		/// <summary>
		/// 모든 문자셋의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>모든 문자셋의 정보를 조회하는 쿼리문입니다.</returns>
		public static string ShowCharset()
		{
			return "SHOW CHARSET";
		}

		/// <summary>
		/// 문자셋의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="where">조회할 문자셋입니다.</param>
		/// <returns>문자셋의 정보를 조회하는 쿼리문을 생성합니다.</returns>
		public static string ShowCharset(string where)
		{
			return String.Format("SHOW CHARSET WHERE charset='{0}'", where);
		}

		/// <summary>
		/// 모든 컬레션의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>모든 컬레션의 정보를 조회하는 쿼리문입니다.</returns>
		public static string ShowCollation()
		{
			return "SHOW COLLATION";
		}

		/// <summary>
		/// 문자셋에 해당되는 컬레션의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="charset">조회할 컬레션의 문자셋입니다.</param>
		/// <returns>문자셋에 해당되는 컬레션의 정보를 조회하는 쿼리문을 생성합니다.</returns>
		public static string ShowCollation(string charset)
		{
			return String.Format("SHOW COLLATION WHERE charset='{0}'", charset);
		}

		public static string SelectMysqlUser()
		{
			return "SELECT user, host FROM mysql.user";
		}

		public static string SelectMysqlUser(string username, string host)
		{
			return String.Format("SELECT * FROM mysql.user WHERE user='{0}' AND host='{1}'", username, host);
		}

		/// <summary>
		/// 트리에 표시할 행문자열을 생성합니다.
		/// </summary>
		/// <param name="columnInfo">컬럼정보를 가지는 배열입니다.</param>
		/// <returns>트리에 표시할 행문자열입니다.</returns>
		public static string MakeColumnInfo(string[] columnInfo)
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
		public static string MakeIndexInfo(string keyName, string columnName)
		{
			return String.Format("{0}({1})", keyName, columnName);
		}

		/// <summary>
		/// 사용자를 수정하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="targetUsername">수정대상의 사용자이름입니다.</param>
		/// <param name="targetHost">수정대상의 호스트명입니다.</param>
		/// <param name="userInfo">사용자정보를 가진 객체입니다.</param>
		/// <returns>사용자를 수정하는 쿼리문입니다.</returns>
		public static string AlterUser(string targetUsername, string targetHost, User userInfo)
		{
			StringBuilder queryBuilder = new StringBuilder();

			queryBuilder.Append(
				"UPDATE mysql.user SET "
				);

			if(userInfo.Password.CompareTo("\n\n\n\n") != 0)
			{
				queryBuilder.Append(String.Format(
					"password=PASSWORD('{0}'), ",
					userInfo.Password
					));
			}

			queryBuilder.Append(String.Format(
				"user='{0}', host='{1}', select_priv='{2}', insert_priv='{3}', update_priv='{4}', delete_priv='{5}', create_priv='{6}', drop_priv='{7}', reload_priv='{8}', shutdown_priv='{9}', process_priv='{10}', file_priv='{11}', grant_priv='{12}', references_priv='{13}', index_priv='{14}', alter_priv='{15}'",
				userInfo.Username,
				userInfo.Host,
				userInfo.Select ? 'Y' : 'N',
				userInfo.Insert ? 'Y' : 'N',
				userInfo.Update ? 'Y' : 'N',
				userInfo.Delete ? 'Y' : 'N',
				userInfo.Create ? 'Y' : 'N',
				userInfo.Drop ? 'Y' : 'N',
				userInfo.Reload ? 'Y' : 'N',
				userInfo.Shutdown ? 'Y' : 'N',
				userInfo.Process ? 'Y' : 'N',
				userInfo.File ? 'Y' : 'N',
				userInfo.Grant ? 'Y' : 'N',
				userInfo.Reference ? 'Y' : 'N',
				userInfo.Index ? 'Y' : 'N',
				userInfo.Alter ? 'Y' : 'N'
				));

			if(Program.ActivateCommunicator.v402 == true)
			{
				queryBuilder.Append(String.Format(
					", show_db_priv='{0}', super_priv='{1}', create_tmp_table_priv='{2}', lock_tables_priv='{3}', execute_priv='{4}', repl_slave_priv='{5}', repl_client_priv='{6}'",
					userInfo.Show_db ? 'Y' : 'N',
					userInfo.Super ? 'Y' : 'N',
					userInfo.Create_tmp_tables ? 'Y' : 'N',
					userInfo.Lock_tables ? 'Y' : 'N',
					userInfo.Execute ? 'Y' : 'N',
					userInfo.Repl_slave ? 'Y' : 'N',
					userInfo.Repl_client ? 'Y' : 'N'
					));
			}

			if(Program.ActivateCommunicator.v500 == true)
			{
				queryBuilder.Append(String.Format(
					", create_view_priv='{0}', show_view_priv='{1}', create_routine_priv='{2}', alter_routine_priv='{3}', create_user_priv='{4}', ssl_cipher='', x509_issuer='', x509_subject=''",
					userInfo.Create_view ? 'Y' : 'N',
					userInfo.Show_view ? 'Y' : 'N',
					userInfo.Create_routine ? 'Y' : 'N',
					userInfo.Alter_routine ? 'Y' : 'N',
					userInfo.Create_user ? 'Y' : 'N'
					));
			}

			if(Program.ActivateCommunicator.v510 == true)
			{
				queryBuilder.Append(String.Format(
					", event_priv='{0}', trigger_priv='{1}'",
					userInfo.Event ? 'Y' : 'N',
					userInfo.Trigger ? 'Y' : 'N'
					));
			}

			queryBuilder.Append(String.Format(
				" WHERE user='{0}' AND host='{1}'",
				targetUsername,
				targetHost
				));

			return queryBuilder.ToString();
		}

		/// <summary>
		/// 사용자를 생성하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="userInfo">사용자정보를 가진 객체입니다.</param>
		/// <returns>사용자를 생성하는 쿼리문입니다.</returns>
		public static string CreateUser(User userInfo)
		{
			StringBuilder queryBuilder = new StringBuilder();

			queryBuilder.Append(
				"INSERT INTO mysql.user(host, user, password, select_priv, insert_priv, update_priv, delete_priv, create_priv, drop_priv, reload_priv, shutdown_priv, process_priv, file_priv, grant_priv, references_priv, index_priv, alter_priv");

			if(Program.ActivateCommunicator.v402 == true)
			{
				queryBuilder.Append(
					", show_db_priv, super_priv, create_tmp_table_priv, lock_tables_priv, execute_priv, repl_slave_priv, repl_client_priv");
			}

			if(Program.ActivateCommunicator.v500 == true)
			{
				queryBuilder.Append(
					", create_view_priv, show_view_priv, create_routine_priv, alter_routine_priv, create_user_priv, ssl_cipher, x509_issuer, x509_subject");
			}

			if(Program.ActivateCommunicator.v510 == true)
			{
				queryBuilder.Append(", event_priv, trigger_priv");
			}

			queryBuilder.AppendFormat(
				") VALUES('{0}', '{1}', PASSWORD('{2}'), '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}'",
				userInfo.Host, userInfo.Username, userInfo.Password,
				userInfo.Select ? 'Y' : 'N', userInfo.Insert ? 'Y' : 'N', userInfo.Update ? 'Y' : 'N',
				userInfo.Delete ? 'Y' : 'N', userInfo.Create ? 'Y' : 'N', userInfo.Drop ? 'Y' : 'N',
				userInfo.Reload ? 'Y' : 'N', userInfo.Shutdown ? 'Y' : 'N', userInfo.Process ? 'Y' : 'N',
				userInfo.File ? 'Y' : 'N', userInfo.Grant ? 'Y' : 'N', userInfo.Reference ? 'Y' : 'N',
				userInfo.Index ? 'Y' : 'N', userInfo.Alter ? 'Y' : 'N'
				);

			if(Program.ActivateCommunicator.v402 == true)
			{
				queryBuilder.AppendFormat(
					", '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'",
					userInfo.Show_db ? 'Y' : 'N', userInfo.Super ? 'Y' : 'N', userInfo.Create_tmp_tables ? 'Y' : 'N',
					userInfo.Lock_tables ? 'Y' : 'N', userInfo.Execute ? 'Y' : 'N', userInfo.Repl_slave ? 'Y' : 'N',
					userInfo.Repl_client ? 'Y' : 'N'
					);
			}

			if(Program.ActivateCommunicator.v500 == true)
			{
				queryBuilder.AppendFormat(
					", '{0}', '{1}', '{2}', '{3}', '{4}', '', '', ''",
					userInfo.Create_view ? 'Y' : 'N', userInfo.Show_view ? 'Y' : 'N', userInfo.Create_routine ? 'Y' : 'N',
					userInfo.Alter_routine ? 'Y' : 'N', userInfo.Create_user ? 'Y' : 'N'
					);
			}

			if(Program.ActivateCommunicator.v510 == true)
			{
				queryBuilder.AppendFormat(", '{0}', '{1}'", userInfo.Event ? 'Y' : 'N', userInfo.Trigger ? 'Y' : 'N');
			}

			queryBuilder.Append(")");

			return queryBuilder.ToString();
		}
	}
}
