
// ReadonlyTextBox.cs
//
using System.Drawing;
using System.Windows.Forms;

namespace System.Windows.Forms
{
	public class ReadonlyTextBox : TextBox
	{
		/// <summary>
		/// 생성자입니다.
		/// </summary>
		public ReadonlyTextBox()
		{
			this.Multiline = true;
			this.Font = new Font("맑은 고딕", 10);
		}

		/// <summary>
		/// WndProc의 재정의입니다.
		/// </summary>
		/// <param name="m">윈도우메세지 객체입니다.</param>
		protected override void WndProc(ref Message m)
		{
			switch(m.Msg)
			{
				case 0x0102:	// WM_CHAR
					if(m.WParam.ToInt32() == 0x0003)
						base.WndProc(ref m);
					break;
				default:
					base.WndProc(ref m);
					break;
			}
		}
	}
}
