
// MessageWindow
//
using DevComponents.DotNetBar;

namespace Easy2.Components
{
	/// <summary>
	/// 메세지를 출력하는 윈도우 클래스입니다.
	/// </summary>
	public class MessageWindow : DockContainerItem
	{
		/// <summary>
		/// MessageWindow 객체를 초기화합니다.
		/// </summary>
		/// <param name="s">타이틀바에 표시할 문자열입니다.</param>
		public MessageWindow(string s) : base(s)
		{
			this.Control = this.m_messageBox;
			this.Text = s;
		}

		/// <summary>
		/// 윈도우의 타이틀 문자열을 나타냅니다.
		/// </summary>
		public string Title
		{
			set
			{
				if(value != null)
					this.Text = value;
			}
		}

		/// <summary>
		/// 표시할 메세지를 나타냅니다.
		/// </summary>
		public string Message
		{
			get { return this.m_messageBox.Text; }
			set	{ this.m_messageBox.Text = value; }
		}

		private ReadonlyTextBox m_messageBox = new ReadonlyTextBox();
	}
}
