using System.Text.RegularExpressions;

// DataTypePermission.cs
//

namespace Easy2.Enums
{
	enum DataTypePermission
	{
		None = 0,
		Len = 1,
		Unsigned = 2,
		AutoIncrement = 4,
		Zerofill = 8,
		Charset = 16,
		Collation = 32
	}
}
