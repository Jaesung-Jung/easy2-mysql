
// QueryEditor.cs
//
using System.Drawing;
using ScintillaNet;

namespace Easy2.Components
{
	/// <summary>
	/// 쿼리에디터 클래스입니다.
	/// </summary>
	public class QueryEditor : Scintilla
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public QueryEditor()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 컴포넌트를 초기화합니다.
		/// </summary>
		private void InitializeComponent()
		{
			this.ConfigurationManager.CustomLocation = "..\\..\\xml";
			this.ConfigurationManager.Language = "mysql";

			this.Margins.Margin0.Type = MarginType.Symbol;
			this.Margins.Margin0.Width = 10;
			this.Margins.Margin1.Type = MarginType.Number;
			
			this.Styles.LineNumber.BackColor = Color.White;

			this.LineWrap.Mode = WrapMode.Word;
		}
	}
}
