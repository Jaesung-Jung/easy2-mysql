
// MessageWindow
//
using System.Windows.Forms;

namespace Easy2.Components
{
	/// <summary>
	/// 메세지를 출력하는 윈도우 클래스입니다.
	/// </summary>
	public class MessageWindow : DockablePane
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		/// <param name="s">타이틀바에 표시할 문자열입니다.</param>
		public MessageWindow(string s) : base(s)
		{
			this.m_messageBox = new ReadonlyTextBox();
			this.Control = this.m_messageBox;
			this.Text = s;
		}

		private ReadonlyTextBox m_messageBox;
	}
}
