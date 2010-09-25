
// TableWindow.cs
//
using System.Drawing;
using DevComponents.DotNetBar;

namespace Easy2.Components
{
	/// <summary>
	/// 테이블데이터를 출력하는 윈도우입니다.
	/// </summary>
	public class TableWindow : DockContainerItem
	{
		/// <summary>
		/// TableViewer 객체를 초기화합니다.
		/// </summary>
		/// <param name="s">타이틀바에 표시할 문자열입니다.</param>
		public TableWindow(string s) : base(s)
		{
			this.Text = s;
			this.Control = this.m_tableViewer;
			this.m_tableViewer.BackgroundColor = Color.White;
		}

		private TableViewer m_tableViewer = new TableViewer();
	}
}
