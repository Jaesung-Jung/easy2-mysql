
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
			return String.Format("SHOW DATABASES");
		}
	}
}
