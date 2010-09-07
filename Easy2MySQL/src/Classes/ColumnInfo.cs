
// ColumnInfo.cs
//

namespace Easy2.Classes
{
	/// <summary>
	/// 한 컬럼의 정보를 나타냅니다.
	/// </summary>
	public class ColumnInfo
	{
		/// <summary>
		/// 필드명을 나타냅니다.
		/// </summary>
		public string FiledName
		{
			get { return this.m_filedName; }
			set { this.m_filedName = value; }
		}

		/// <summary>
		/// 데이터타입을 나타냅니다.
		/// </summary>
		public string DataType
		{
			get { return this.m_dataType; }
			set { this.m_dataType = value; }
		}

		/// <summary>
		/// 데이터길이를 나타냅니다.
		/// </summary>
		public string DataLength
		{
			get { return this.m_dataLength; }
			set { this.m_dataLength = value; }
		}

		/// <summary>
		/// 기본값을 나타냅니다.
		/// </summary>
		public string DefaultValue
		{
			get { return this.m_defaultValue; }
			set { this.m_defaultValue = value; }
		}

		/// <summary>
		/// 프라이머리키 여부를 나타냅니다.
		/// </summary>
		public bool PK
		{
			get { return this.m_pk; }
			set { this.m_pk = value; }
		}

		/// <summary>
		/// 널값 허용 여부를 나태닙니다.
		/// </summary>
		public bool NotNull
		{
			get { return this.m_nn; }
			set { this.m_nn = value; }
		}

		/// <summary>
		/// 정수값의 사인비트 여부를 나타냅니다.
		/// </summary>
		public bool Unsigned
		{
			get { return this.m_unsigned; }
			set { this.m_unsigned = value; }
		}

		/// <summary>
		/// 자동증가값 여부를 나태닙니다.
		/// </summary>
		public bool AutoIncrement
		{
			get { return this.m_autoIncr; }
			set { this.m_autoIncr = value; }
		}

		/// <summary>
		/// 데이터 저장부분을 0으로 채울지 여부입니다.
		/// </summary>
		public bool Zerofill
		{
			get { return this.m_zerofill; }
			set { this.m_zerofill = value; }
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

		private string m_filedName;
		private string m_dataType;
		private string m_dataLength;
		private string m_defaultValue;
		private bool m_pk;
		private bool m_nn;
		private bool m_unsigned;
		private bool m_autoIncr;
		private bool m_zerofill;
		private string m_charset;
		private string m_collation;
		private string m_comment;
	}
}
