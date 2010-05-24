
// QueryEditor.cs
//
using System.Windows.Forms;

namespace Easy2
{
	class QueryEditor : SyntaxHighlightTextBox
	{
		public QueryEditor()
		{
			this.Keywords.Add("select");
			this.Keywords.Add("insert");
			this.Keywords.Add("update");
			this.Keywords.Add("delete");
			this.Font = new System.Drawing.Font("Courier New", 11);
			this.CompileHighlightWord();
		}
	}
}
