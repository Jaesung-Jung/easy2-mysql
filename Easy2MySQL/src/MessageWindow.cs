
// MessageWindow
//
using System.Windows.Forms;

namespace Easy2
{
	class MessageWindow : DockablePane
	{
		public MessageWindow(string s) : base(s)
		{
			this.m_messageBox = new ReadonlyTextBox();
			this.Control = this.m_messageBox;
			this.Text = s;
		}

		private ReadonlyTextBox m_messageBox;
	}
}
