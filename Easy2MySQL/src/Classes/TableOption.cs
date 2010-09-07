
// TableOption.cs
//

namespace Easy2.Classes
{
	/// <summary>
	/// 테이블의 여러 옵션들을 나타냅니다.
	/// </summary>
	public class TableOption
	{
		/// <summary>
		/// 엔진을 나타냅니다.
		/// </summary>
		public string Engine
		{
			get { return this.m_engine; }
			set { this.m_engine = value; }
		}

		/// <summary>
		/// 문자셋을 나타냅니다.
		/// </summary>
		public string Charset
		{
			get { return this.m_charset; }
			set { this.m_charset = value; }
		}

		/// <summary>
		/// 콜레이션을 나타냅니다.
		/// </summary>
		public string Collation
		{
			get { return this.m_collation; }
			set { this.m_collation = value; }
		}

		/// <summary>
		/// 코멘트를 나타냅니다.
		/// </summary>
		public string Comment
		{
			get { return this.m_comment; }
			set { this.m_comment = value; }
		}

		/// <summary>
		/// 서식을 나타냅니다.
		/// </summary>
		public string Format
		{
			get { return this.m_format; }
			set { this.m_format = value; }
		}

		/// <summary>
		/// 체크섬을 나타냅니다.
		/// </summary>
		public string Checksum
		{
			get { return this.m_checksum; }
			set { this.m_checksum = value; }
		}

		/// <summary>
		/// 자동증가값을 나타냅니다.
		/// </summary>
		public string AutoIncrement
		{
			get { return this.m_autoIncrement; }
			set { this.m_autoIncrement = value; }
		}

		/// <summary>
		/// 평균 열의 길이를 나타냅니다.
		/// </summary>
		public string AvgRowLength
		{
			get { return this.m_avgRowLength; }
			set { this.m_avgRowLength = value; }
		}

		/// <summary>
		/// 최소 열의 길이를 나타냅니다.
		/// </summary>
		public string MinimumRows
		{
			get { return this.m_minimumRows; }
			set { this.m_minimumRows = value; }
		}

		/// <summary>
		/// 최대 열의 길이를 나타냅니다.
		/// </summary>
		public string MaximumRows
		{
			get { return this.m_maximumRows; }
			set { this.m_maximumRows = value; }
		}

		private string m_engine;
		private string m_charset;
		private string m_collation;
		private string m_comment;
		private string m_format;
		private string m_checksum;
		private string m_autoIncrement;
		private string m_avgRowLength;
		private string m_minimumRows;
		private string m_maximumRows;
	}
}
