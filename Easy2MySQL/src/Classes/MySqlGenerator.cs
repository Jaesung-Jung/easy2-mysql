
// MySqlGenerator.cs
//
using System;
using System.Text;
using System.Collections.Generic;

namespace Easy2.Classes
{
	/// <summary>
	/// MySqlCommunicator 클래스와 통신을 수행하는 명령코드를 만드는 클래스입니다.
	/// </summary>
	public class MySqlGenerator
	{
		/// <summary>
		/// MySqlGenerator 인스턴스를 초기화합니다.
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
				connectInfo.Host,
				connectInfo.Port,
				connectInfo.Username,
				connectInfo.Password,
				connectInfo.Database,
				connectInfo.ConnectTimeout
				);

			return connectionString;
		}

		/// <summary>
		/// 사용할 데이터베이스를 지정하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">사용할 데이터베이스의 이름입니다.</param>
		/// <returns>사용할 데이터베이스를 지정하는 쿼리문입니다.</returns>
		public static string UseDatabase(string databaseName)
		{
			return String.Format("USE `{0}`;", databaseName);
		}

		/// <summary>
		/// 데이터베이스를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>데이터베이를 조회하는 쿼리문입니다.</returns>
		public static string ShowDatabases()
		{
			return "SHOW DATABASES;";
		}

		/// <summary>
		/// 테이블을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">테이블을 소유한 데이터베이스 이름입니다.</param>
		/// <returns>테이블을 조회하는 쿼리문입니다.</returns>
		public static string ShowTables(string databaseName)
		{
			return databaseName == "information_schema"?
				String.Format(
					"SHOW TABLES FROM `{0}`;",
					databaseName
					):
				String.Format(
					"SHOW FULL tables FROM `{0}` WHERE table_type='base table';",
					Program.ActivateCommunicator.UseDatabaseName
					);
		}

		/// <summary>
		/// 뷰를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">뷰를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>뷰를 조회하는 쿼리문입니다.</returns>
		public static string ShowViews(string databaseName)
		{
			return String.Format(
				"SELECT table_name FROM information_schema.tables WHERE table_schema='{0}' AND table_type='VIEW';",
				databaseName
				);
		}

		/// <summary>
		/// 테이블과 뷰를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">테이블을 소유한 데이터베이스 이름입니다.</param>
		/// <returns>테이블과 뷰를 조회하는 쿼리문입니다.</returns>
		public static string ShowTablesViews(string databaseName)
		{
			return String.Format("SHOW TABLES FROM `{0}`", databaseName);
		}

		/// <summary>
		/// 저장 프로시저를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">저장 프로시저를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>저장 프로시저를 조회하는 쿼리문입니다.</returns>
		public static string ShowStoredProcs(string databaseName)
		{
			return String.Format(
				"SELECT * FROM information_schema.routines WHERE routine_schema='{0}' AND routine_type='PROCEDURE';",
				databaseName
				);
		}

		/// <summary>
		/// 함수를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">함수를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>함수를 조회하는 쿼리문입니다.</returns>
		public static string ShowFunctions(string databaseName)
		{
			return String.Format(
				"SELECT * FROM information_schema.routines WHERE routine_schema='{0}' AND routine_type='FUNCTION';",
				databaseName
				);
		}

		/// <summary>
		/// 루틴을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <remarks>
		/// 루틴은 저장프로시저와 함수 모두를 의미합니다.
		/// </remarks>
		/// <param name="databaseName">루틴을 소유한 데이터베이스 이름입니다.</param>
		/// <returns>루틴을 조회하는 쿼리문입니다.</returns>
		public static string ShowRoutine(string databaseName)
		{
			return String.Format(
				"SELECT * FROM information_schema.routines WHERE routine_schema='{0}' AND routine_type='PROCEDURE'|'FUNCTION'",
				databaseName
				);
		}

		/// <summary>
		/// 트리거를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">트리거를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>트리거는 조회하는 쿼리문입니다.</returns>
		public static string ShowTriggers(string databaseName)
		{
			return String.Format(
				"SELECT trigger_name FROM information_schema.triggers WHERE trigger_schema='{0}';",
				databaseName
				);
		}

		/// <summary>
		/// 이벤트를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">이벤트를 소유한 데이터베이스 이름입니다.</param>
		/// <returns>이벤트를 조회하는 쿼리문입니다.</returns>
		public static string ShowEvents(string databaseName)
		{
			return String.Format(
				"SELECT event_name FROM information_schema.events WHERE event_schema='{0}' ORDER BY event_name;",
				databaseName
				);
		}

		/// <summary>
		/// 컬럼을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="tableName">조회할 컬럼의 테이블이름입니다.</param>
		/// <returns>컬럼을 조회하는 쿼리문입니다.</returns>
		public static string ShowColumns(string tableName)
		{
			return String.Format("DESCRIBE `{0}`;", tableName);
		}

		/// <summary>
		/// 컬럼을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="databaseName">조회할 테이블을 소유한 데이터베이스입니다.</param>
		/// <param name="tableName">조회할 컬럼의 테이블이름입니다.</param>
		/// <returns>컬럼을 조회하는 쿼리문입니다.</returns>
		public static string ShowColumns(string databaseName, string tableName)
		{
			return String.Format("DESCRIBE `{0}`.`{1}`;", databaseName, tableName);
		}

		/// <summary>
		/// 인덱스를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="tableName">조회할 인덱스의 테이블이름입니다.</param>
		/// <returns>인덱스를 조회하는 쿼리문입니다.</returns>
		public static string ShowIndexes(string tableName)
		{
			return String.Format("SHOW INDEX FROM `{0}`;", tableName);
		}

		/// <summary>
		/// 모든 문자셋의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>모든 문자셋의 정보를 조회하는 쿼리문입니다.</returns>
		public static string ShowCharset()
		{
			return "SHOW CHARSET;";
		}

		/// <summary>
		/// 문자셋의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="where">조회할 문자셋 또는 콜레이션입니다.</param>
		/// <param name="b">true이면 charset의 정보, false이면 collation에 대한 charset을 조회합니다.</param>
		/// <returns>문자셋의 정보를 조회하는 쿼리문을 생성합니다.</returns>
		public static string ShowCharset(string where, bool b = true)
		{
			return b?
				String.Format("SHOW CHARSET WHERE charset='{0}';", where) :
				String.Format("SELECT character_set_name FROM collations WHERE collation_name='{0}';", where);
		}

		/// <summary>
		/// 모든 콜레이션의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>모든 콜레이션의 정보를 조회하는 쿼리문입니다.</returns>
		public static string ShowCollation()
		{
			return "SHOW COLLATION;";
		}

		/// <summary>
		/// 문자셋에 해당되는 콜레이션의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="charset">조회할 콜레이션의 문자셋입니다.</param>
		/// <returns>문자셋에 해당되는 의 정보를 조회하는 쿼리문을 생성합니다.</returns>
		public static string ShowCollation(string charset)
		{
			return String.Format("SHOW COLLATION WHERE charset='{0}';", charset);
		}

		/// <summary>
		/// 사용중인 데이터베이스의 문자셋을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>사용중인 데이터베이스의 문자셋을 조회하는 쿼리문입니다.</returns>
		public static string ShowCharsetForUseDatabase()
		{
			return "SHOW VARIABLES LIKE 'character_set_database';";
		}

		/// <summary>
		/// 사용중인 데이터베이스의 콜레이션을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>사용중인 데이터베이스의 콜레이션을 조회하는 쿼리문입니다.</returns>
		public static string ShowCollationForUseDatabase()
		{
			return "SHOW VARIABLES LIKE 'collation_database';";
		}

		/// <summary>
		/// 서버의 문자셋을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>서버의 문자셋을 조회하는 쿼리문입니다.</returns>
		public static string ShowCharsetServer()
		{
			return "SHOW VARIABLES LIKE 'character_set_server';";
		}

		/// <summary>
		/// 서버의 콜레이션을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>서버의 콜레이션을 조회하는 쿼리문입니다.</returns>
		public static string ShowCollationServer()
		{
			return "SHOW VARIABLES LIKE 'collation_server';";
		}

		/// <summary>
		/// 테이블의 필드의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="from">조회할 테이블이름입니다.</param>
		/// <param name="isFull">자세한 필드내용을 조회할지의 여부입니다.</param>
		/// <returns>테이블의 필드의 정보를 조회하는 쿼리문입니다.</returns>
		public static string ShowFullFields(string from, bool isFull)
		{
			return isFull ?
				String.Format("SHOW FULL FIELDS FROM {0};", from):
				String.Format("SHOW FIELDS FROM {0};", from);
		}

		/// <summary>
		/// MySQL의 엔진을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>MySQL의 엔진을 조회하는 쿼리문입니다.</returns>
		public static string ShowEngines()
		{
			return "SHOW ENGINES;";
		}

		/// <summary>
		/// MySQL 데이터베이스의 사용자들을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>MySQL 데이터베이스의 사용자들을 조회하는 쿼리문입니다.</returns>
		public static string SelectMysqlUser()
		{
			return "SELECT user, host FROM mysql.user;";
		}

		/// <summary>
		/// MySQL 데이터베이스의 사용자의 정보를 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="username">사용자이름입니다.</param>
		/// <param name="host">호스트명입니다.</param>
		/// <returns>MySQL 데이터베이스의 사용자의 정보를 조회하는 쿼리문입니다.</returns>
		public static string SelectMysqlUser(string username, string host)
		{
			return String.Format(
				"SELECT * FROM mysql.user WHERE user='{0}' AND host='{1}';",
				username,
				host
				);
		}

		/// <summary>
		/// 데이터베이스 권한을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="username">사용자이름입니다.</param>
		/// <param name="host">호스트명입니다.</param>
		/// <returns>데이터베이스 권한을 조회하는 쿼리문입니다.</returns>
		public static string SelectDatabasePrivilege(string username, string host)
		{
			return String.Format(
				"SELECT * FROM mysql.db WHERE user='{0}' AND host='{1}';",
				username,
				host
				);
		}

		/// <summary>
		/// 테이블 권한을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="username">사용자이름입니다.</param>
		/// <param name="host">호스트명입니다.</param>
		/// <param name="databaseName">테이터베이스이름입니다.</param>
		/// <returns>테이블 권한을 조회하는 쿼리문입니다.</returns>
		public static string SelectTablePrivilege(
			string username,
			string host,
			string databaseName
			)
		{
			return String.Format(
				"SELECT * FROM mysql.tables_priv WHERE user='{0}' AND host='{1}' AND db='{2}';",
				username,
				host,
				databaseName
				);
		}

		/// <summary>
		/// 루틴 권한을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="username">사용자이름입니다.</param>
		/// <param name="host">호스트명입니다.</param>
		/// <param name="databaseName">테이터베이스이름입니다.</param>
		/// <returns>테이블 권한을 조회하는 쿼리문입니다.</returns>
		public static string SelectRoutinePrivilege(
			string username,
			string host,
			string databaseName
			)
		{
			return String.Format(
				"SELECT * FROM mysql.procs_priv WHERE user='{0}' AND host='{1}' AND db='{2}';",
				username,
				host,
				databaseName
				);
		}

		/// <summary>
		/// 컬럼 권한을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="username">사용자이름입니다.</param>
		/// <param name="host">호스트명입니다.</param>
		/// <param name="databaseName">데이터베이스이름입니다.</param>
		/// <param name="tableName">테이블이름입니다.</param>
		/// <returns>컬럼 권한을 조회하는 쿼리문입니다.</returns>
		public static string SelectColumnPrivilege(
			string username,
			string host,
			string databaseName,
			string tableName
			)
		{
			return String.Format(
				"SELECT * FROM mysql.columns_priv WHERE user='{0}' AND host='{1}' AND Db='{2}' AND table_name='{3}';",
				username,
				host,
				databaseName,
				tableName
				);
		}

		/// <summary>
		/// 프로시저 권한을 조회하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="username">사용자이름입니다.</param>
		/// <param name="host">호스트명입니다.</param>
		/// <returns>프로시저 권한을 조회하는 쿼리문입니다.</returns>
		public static string SelectProcedurePrivilege(string username, string host)
		{
			return String.Format(
				"SELECT * FROM mysql.procs_priv WHERE USER='{0}' AND HOST='{1}';",
				username,
				host
				);
		}

		/// <summary>
		/// 사용자를 생성하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="userInfo">사용자정보를 가진 객체입니다.</param>
		/// <returns>사용자를 생성하는 쿼리문입니다.</returns>
		public static string CreateUser(User userInfo)
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(
				"INSERT INTO mysql.user(host, user, password, select_priv, insert_priv, update_priv, delete_priv, create_priv, drop_priv, reload_priv, shutdown_priv, process_priv, file_priv, grant_priv, references_priv, index_priv, alter_priv"
				);

			if(Program.ActivateCommunicator.v402 == true)
			{
				builder.Append(
					", show_db_priv, super_priv, create_tmp_table_priv, lock_tables_priv, execute_priv, repl_slave_priv, repl_client_priv"
					);
			}

			if(Program.ActivateCommunicator.v500 == true)
			{
				builder.Append(
					", create_view_priv, show_view_priv, create_routine_priv, alter_routine_priv, create_user_priv, ssl_cipher, x509_issuer, x509_subject"
					);
			}

			if(Program.ActivateCommunicator.v510 == true)
			{
				builder.Append(", event_priv, trigger_priv");
			}

			builder.AppendFormat(
				") VALUES('{0}', '{1}', PASSWORD('{2}'), '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}'",
				userInfo.Host,
				userInfo.Username,
				userInfo.Password,
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
				);

			if(Program.ActivateCommunicator.v402 == true)
			{
				builder.AppendFormat(
					", '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'",
					userInfo.Show_db ? 'Y' : 'N',
					userInfo.Super ? 'Y' : 'N',
					userInfo.Create_tmp_tables ? 'Y' : 'N',
					userInfo.Lock_tables ? 'Y' : 'N',
					userInfo.Execute ? 'Y' : 'N',
					userInfo.Repl_slave ? 'Y' : 'N',
					userInfo.Repl_client ? 'Y' : 'N'
					);
			}

			if(Program.ActivateCommunicator.v500 == true)
			{
				builder.AppendFormat(
					", '{0}', '{1}', '{2}', '{3}', '{4}', '', '', ''",
					userInfo.Create_view ? 'Y' : 'N',
					userInfo.Show_view ? 'Y' : 'N',
					userInfo.Create_routine ? 'Y' : 'N',
					userInfo.Alter_routine ? 'Y' : 'N',
					userInfo.Create_user ? 'Y' : 'N'
					);
			}

			if(Program.ActivateCommunicator.v510 == true)
			{
				builder.AppendFormat(", '{0}', '{1}'",
					userInfo.Event ? 'Y' : 'N',
					userInfo.Trigger ? 'Y' : 'N'
					);
			}

			builder.Append(");");

			return builder.ToString();
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
			StringBuilder builder = new StringBuilder();

			builder.Append(
				"UPDATE mysql.user SET "
				);

			if(userInfo.Password.CompareTo("\n\n\n\n") != 0)
			{
				builder.Append(String.Format(
					"password=PASSWORD('{0}'), ",
					userInfo.Password
					));
			}

			builder.Append(String.Format(
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
				builder.Append(String.Format(
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
				builder.Append(String.Format(
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
				builder.Append(String.Format(
					", event_priv='{0}', trigger_priv='{1}'",
					userInfo.Event ? 'Y' : 'N',
					userInfo.Trigger ? 'Y' : 'N'
					));
			}

			builder.Append(String.Format(
				" WHERE user='{0}' AND host='{1}';",
				targetUsername,
				targetHost
				));

			return builder.ToString();
		}

		/// <summary>
		/// 사용자를 제거하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="targetUsername">제거대상의 사용자이름입니다.</param>
		/// <param name="targetHost">제거대상의 호스트명입니다.</param>
		/// <returns>사용자를 제거하는 쿼리문입니다.</returns>
		public static string DeleteUser(string targetUsername, string targetHost)
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(String.Format(
				"DELETE FROM mysql.user WHERE USER='{0}' AND HOST='{1}';",
				targetUsername,
				targetHost
				));

			builder.Append(String.Format(
				"DELETE FROM mysql.db WHERE USER='{0}' AND HOST='{1}';",
				targetUsername,
				targetHost
				));

			builder.Append(String.Format(
				"DELETE FROM mysql.tables_priv WHERE USER='{0}' AND HOST='{1}';",
				targetUsername,
				targetHost
				));

			builder.Append(String.Format(
				"DELETE FROM mysql.columns_priv WHERE USER='{0}' AND HOST='{1}';",
				targetUsername,
				targetHost
				));

			if(Program.ActivateCommunicator.v500)
			{
				builder.Append(String.Format(
					"DELETE FROM mysql.procs_priv WHERE USER='{0}' AND HOST='{1}';",
					targetUsername,
					targetHost
					));
			}

			return builder.ToString();
		}

		/// <summary>
		/// 데이터베이스를 생성하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="dbname">데이터베이스 이름입니다.</param>
		/// <return>데이터베이스를 생성하는 쿼리문입니다.</return>
		public static string CreateDatabase(string dbname)
		{
			return String.Format("CREATE DATABASE `{0}`;", dbname);
		}

		/// <summary>
		/// 데이터베이스를 생성하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="dbname">데이터베이스 이름입니다.</param>
		/// <param name="charset">문자셋입니다.</param>
		/// <param name="collation">콜레이션입니다.</param>
		/// <return>데이터베이스를 생성하는 쿼리문입니다.</return>
		public static string CreateDatabase(string dbname, string charset, string collation)
		{
			return String.Format("CREATE DATABASE `{0}` CHARACTER SET {1} COLLATE {2};",
				dbname,
				charset,
				collation
				);
		}

		/// <summary>
		/// 데이터베이스를 수정하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="dbname">데이터베이스 이름입니다.</param>
		/// <param name="charset">문자셋입니다.</param>
		/// <param name="collation">콜레이션입니다.</param>
		/// <return>데이터베이스를 수정하는 쿼리문입니다.</return>
		public static string AlterDatabase(string dbname, string charset, string collation)
		{
			return String.Format("ALTER DATABASE `{0}` CHARACTER SET {1} COLLATE {2};",
				dbname,
				charset,
				collation
				);
		}

		/// <summary>
		/// 데이터베이스를 제거하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="dbname">데이터베이스 이름입니다.</param>
		/// <returns>데이터베이스를 제거하는 쿼리문입니다.</returns>
		public static string DropDatabase(string dbname)
		{
			return String.Format("DROP DATABASE `{0}`;", dbname);
		}

		/// <summary>
		/// 데이터베이스를 비우는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="dbname">데이터베이스 이름입니다.</param>
		/// <param name="tables">테이블 배열 객체입니다.</param>
		/// <param name="views">뷰 배열 객체입니다.</param>
		/// <param name="procs">저장프로시저 배열 객체입니다.</param>
		/// <param name="funcs">함수 배열 객체입니다.</param>
		/// <param name="events">이벤트 배열 객체입니다.</param>
		/// <param name="triggers">트리거 배열 객체입니다.</param>
		/// <returns>데이터베이스를 비우는 쿼리문입니다.</returns>
		public static string TrucateDatabase(
			string dbname,
			string[] tables,
			string[] views,
			string[] procs,
			string[] funcs,
			string[] events,
			string[] triggers)
		{
			StringBuilder builder = new StringBuilder();

			foreach(string table in tables)
				builder.Append(String.Format("DROP TABLE `{0}`.`{1}`;", dbname, table));

			foreach(string view in views)
				builder.Append(String.Format("DROP VIEW `{0}`.`{1}`;", dbname, view));

			foreach(string proc in procs)
				builder.Append(String.Format("DROP PROCEDURE `{0}`.`{1}`;", dbname, proc));

			foreach(string func in funcs)
				builder.Append(String.Format("DROP FUNCTION `{0}`.`{1}`;", dbname, func));

			foreach(string evt in events)
				builder.Append(String.Format("DROP EVENT `{0}`.`{1}`;", dbname, evt));

			foreach(string trigger in triggers)
				builder.Append(String.Format("DROP TRIGGER `{0}`.`{1}`;", dbname, trigger));

			return builder.ToString();
		}

		/// <summary>
		/// 데이터베이스 권한정보를 갱신하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="host">호스트입니다.</param>
		/// <param name="user">사용자입니다.</param>
		/// <param name="db_privileges">데이터베이스 권한정보 객체입니다.</param>
		/// <returns>데이터베이스 권한정보를 갱신하는 쿼리문입니다.</returns>
		public static string UpdateDatabasePrivilege(
			string host,
			string user,
			DatabasePrivilege db_priv
			)
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(
				"INSERT INTO mysql.db(host, db, user, "
				);

			for(int i = 0; i < db_priv.Privileges.Count; i++)
			{
				if(i == db_priv.Privileges.Count - 1)
				{
					builder.Append(
						String.Format("{0}) ", db_priv.Privileges[i])
						);
				}

				else
				{
					builder.Append(
						String.Format("{0}, ", db_priv.Privileges[i])
						);
				}
			}

			builder.Append(
				String.Format("VALUES('{0}', '{1}', '{2}', ", host, db_priv.Db, user)
				);

			for(int i = 0; i < db_priv.Privileges.Count; i++)
			{
				if(i == db_priv.Privileges.Count - 1)
				{
					builder.Append("'Y');");
				}
				else
				{
					builder.Append("'Y', ");
				}
			}

			return builder.ToString();
		}

		/// <summary>
		/// 테이블 권한정보를 갱신하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="host">호스트입니다.</param>
		/// <param name="user">사용자입니다.</param>
		/// <param name="db_privileges">테이블 권한정보 객체입니다.</param>
		/// <returns>테이블 권한정보를 갱신하는 쿼리문입니다.</returns>
		public static string UpdateTablePrivilege(
			string host,
			string user,
			TablePrivilege table_priv)
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(String.Format(
				"INSERT INTO mysql.tables_priv(host, db, user, table_name, grantor, table_priv) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '",
				host,
				table_priv.Db,
				user,
				table_priv.TableName,
				String.Format("{0}@{1}", user, host)
				));

			for(int i = 0; i < table_priv.Privileges.Count; i++)
			{
				if(i == table_priv.Privileges.Count - 1)
				{
					builder.Append(
						String.Format("{0}');", table_priv.Privileges[i])
						);
				}
				else
				{
					builder.Append(
						String.Format("{0},", table_priv.Privileges[i])
						);
				}
			}

			return builder.ToString();
		}

		/// <summary>
		/// 컬럼 권한정보를 갱신하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="host">호스트입니다.</param>
		/// <param name="user">사용자입니다.</param>
		/// <param name="db_privileges">컬럼 권한정보 객체입니다.</param>
		/// <returns>컬럼 권한정보를 갱신하는 쿼리문입니다.</returns>
		public static string UpdateColumnPrivilege(
			string host,
			string user,
			ColumnPrivilege column_priv
			)
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(String.Format(
				"INSERT INTO mysql.columns_priv(host, db, user, table_name, column_name, column_priv) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '",
				host,
				column_priv.Db,
				user,
				column_priv.TableName,
				column_priv.ColumnName
				));

			for(int i = 0; i < column_priv.Privileges.Count; i++)
			{
				if(i == column_priv.Privileges.Count - 1)
				{
					builder.Append(
						String.Format("{0}');", column_priv.Privileges[i])
						);
				}
				else
				{
					builder.Append(
						String.Format("{0},", column_priv.Privileges[i])
						);
				}
			}

			return builder.ToString();
		}

		/// <summary>
		/// 루틴 권한정보를 갱신하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="host">호스트입니다.</param>
		/// <param name="user">사용자입니다.</param>
		/// <param name="db_privileges">루틴 권한정보 객체입니다.</param>
		/// <returns>루틴 권한정보를 갱신하는 쿼리문입니다.</returns>
		public static string UpdateRoutinePrivilege(
			string host,
			string user,
			RoutinePrivilege routine_priv
			)
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(String.Format(
				"INSERT INTO mysql.procs_priv(host, db, user, routine_name, routine_type, grantor, proc_priv) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '",
				host,
				routine_priv.Db,
				user,
				routine_priv.RoutineName,
				routine_priv.Type.ToString(),
				String.Format("{0}@{1}", user, host)
				));

			for(int i = 0; i < routine_priv.Privileges.Count; i++)
			{
				if(i == routine_priv.Privileges.Count - 1)
				{
					builder.Append(
						String.Format("{0}');", routine_priv.Privileges[i])
						);
				}
				else
				{
					builder.Append(
						String.Format("{0},", routine_priv.Privileges[i])
						);
				}
			}

			return builder.ToString();
		}

		/// <summary>
		/// tables_priv 테이블의 column_priv 컬럼 값을 갱신하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="host">호스트입니다.</param>
		/// <param name="user">사용자입니다.</param>
		/// <param name="column_privileges">컬럼의 권한정보를 가진 객체 배열입니다.</param>
		/// <returns>tables_priv 테이블의 column_priv 컬럼 값을 갱신하는 쿼리문입니다.</returns>
		public static string UpdateColumnPrivilegeInTablesPriv(
			string host,
			string user,
			ColumnPrivilege[] column_privileges
			)
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(
				"UPDATE mysql.tables_priv SET column_priv='"
				);

			HashSet<string> priv_set = new HashSet<string>();
			foreach(ColumnPrivilege column_priv in column_privileges)
			{
				foreach(string priv in column_priv.Privileges)
				{
					priv_set.Add(priv);
				}
			}

			foreach(string priv in priv_set)
			{
				builder.Append(
					String.Format("{0},", priv)
					);
			}

			// 위 foreach문에서 완성된 문자열 '권한1,권한2,권한3, 형태를 '권한1,권한2,권한3'으로 변경
			// 즉 마지막에 들어있는 ,문자를 '로 치환
			builder.Replace(",", "'", builder.Length - 1, 1);

			builder.Append(String.Format(
				" WHERE host='{0}' AND db='{1}' AND user='{2}' AND table_name='{3}';",
				host,
				column_privileges[0].Db,
				user,
				column_privileges[0].TableName
				));

			return builder.ToString();
		}

		/// <summary>
		/// 모든 객체에 관한 권한을 제거하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="host">호스트입니다.</param>
		/// <param name="user">사용자입니다.</param>
		/// <returns>모든 객체에 관한 권한을 제거하는 쿼리문입니다.</returns>
		public static string DeletePrivileges(string host, string user)
		{
			StringBuilder builder = new StringBuilder();

			builder.Append(String.Format(
				"DELETE FROM mysql.db WHERE host='{0}' AND user='{1}';",
				host,
				user
				));
			builder.Append(String.Format(
				"DELETE FROM mysql.tables_priv WHERE host='{0}' AND user='{1}';",
				host,
				user
				));
			builder.Append(String.Format(
				"DELETE FROM mysql.columns_priv WHERE host='{0}' AND user='{1}';",
				host,
				user
				));
			builder.Append(String.Format(
				"DELETE FROM mysql.procs_priv WHERE host='{0}' AND user='{1}';",
				host,
				user
				));

			return builder.ToString();
		}

		/// <summary>
		/// 테이블을 만드는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="database">테이블을 소유할 데이터베이스입니다.</param>
		/// <param name="table">테이블 이름입니다.</param>
		/// <param name="fields">컬럼정보 배열의 객체입니다.</param>
		/// <param name="option">테이블옵션 객체입니다.</param>
		/// <returns></returns>
		public static string CreateTable(string database, string table, FieldInfo[] fields, TableOption option)
		{
			StringBuilder builder = new StringBuilder();
			List<FieldInfo> pkFields = new List<FieldInfo>();

			builder.Append(String.Format(
				"CREATE TABLE {0}.{1}(",
				database,
				table
				));
			
			foreach(FieldInfo field in fields)
			{
				if(field.PK == true)
					pkFields.Add(field);
			}

			foreach(FieldInfo field in fields)
			{
				builder.Append(String.Format("`{0}` {1}", field.FiledName, field.DataType));

				if(field.DataLength != null)
					builder.Append(String.Format("({0})", field.DataLength));
				if(field.Charset != null && field.Charset != "DEFAULT")
					builder.Append(String.Format(" CHARSET {0}", field.Charset));
				if(field.Collation != null && field.Charset != "DEFAULT")
					builder.Append(String.Format(" COLLATE {0}", field.Collation));
				if(field.Unsigned == true)
					builder.Append(" UNSIGNED");
				if(field.Zerofill == true)
					builder.Append(" ZEROFILL");
				if(field.NotNull == true)
					builder.Append(" NOT NULL");
				if(field.AutoIncrement == true)
					builder.Append(" AUTO_INCREMENT");
				if(field.PK == true && pkFields.Count > 1 && field.FiledName == pkFields[0].FiledName)
					builder.Append(" UNIQUE");
				if(field.Comment != null)
					builder.Append(String.Format(" COMMENT '{0}'", field.Comment));
				if(field != fields[fields.Length - 1])
					builder.Append(", ");
			}

			if(pkFields.Count != 0)
				builder.Append(", PRIMARY KEY(");

			foreach(FieldInfo field in pkFields)
			{
				if(field != pkFields[pkFields.Count - 1])
					builder.Append(String.Format("`{0}`,", field.FiledName));
				else
					builder.Append(String.Format("`{0}`)", field.FiledName));
			}

			if(option != null)
			{
				builder.Append(")");
				if(option.Engine.Length != 0)
					builder.Append(String.Format(" ENGINE={0}", option.Engine));
				if(option.Checksum.Length != 0)
					builder.Append(String.Format(" CHECKSUM={0}", option.Checksum));
				if(option.AutoIncrement.Length != 0)
					builder.Append(String.Format(" AUTO_INCREMENT={0}", option.AutoIncrement));
				if(option.AvgRowLength.Length != 0)
					builder.Append(String.Format(" AVG_ROW_LENGTH={0}", option.AvgRowLength));
				if(option.Comment.Length != 0)
					builder.Append(String.Format(" COMMENT='{0}'", option.Comment));
				if(option.MaximumRows.Length != 0)
					builder.Append(String.Format(" MAX_ROWS={0}", option.MaximumRows));
				if(option.MinimumRows.Length != 0)
					builder.Append(String.Format(" MIN_ROWS={0}", option.MinimumRows));
				if(option.Format.Length != 0)
					builder.Append(String.Format(" FORMAT={0}", option.Format));
				if(option.Charset.Length != 0)
					builder.Append(String.Format(" CHARSET={0}", option.Charset));
				if(option.Collation.Length != 0)
					builder.Append(String.Format(" COLLATE={0}", option.Collation));
				builder.Append(";");
			}
			else
			{
				builder.Append(");");
			}

			return builder.ToString();
		}

		/// <summary>
		/// 내부 캐쉬메모리를 비우는 쿼리문을 생성합니다.
		/// </summary>
		/// <returns>내부 캐쉬메모리를 비우는 쿼리문입니다.</returns>
		public static string FlushPrivileges()
		{
			return "FLUSH PRIVILEGES;";
		}

		/// <summary>
		/// 참조 무결성 체크 여부를 설정하는 쿼리문을 생성합니다.
		/// </summary>
		/// <param name="b">체크 여부입니다.</param>
		/// <returns>참조 무결성 체크 여부를 설정하는 쿼리문입니다.</returns>
		public static string SetForeignKeyChecks(bool b)
		{
			// SET FOREIGN_KEY_CHECKS = 0	참조 무결성 체크 안함
			// SET FOREIGN_KEY_CHECKS = 1	참조 무결성 체크 함
			return b ? "SET FOREIGN_KEY_CHECKS = 1;" : "SET FOREIGN_KEY_CHECKS = 0;";
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
	}
}
