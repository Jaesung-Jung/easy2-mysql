
// QueryEditor.cs
//
using System;
using System.Xml;
using System.Windows.Forms;
using ScintillaNet;

namespace Easy2
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
			this.Styles[0].Font = new System.Drawing.Font("Courier New", 11);
			this.Margins[0].Width = 22;
		}
	}
}
